using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;
using Reserveer_Systeem.Classes;
using Reserveer_Systeem.Properties;

namespace Reserveer_Systeem
{
    public partial class frmKaart : Form
    {
        private readonly Bitmap maskedKaart = Resources.Map_Mask;

        private readonly PropertyInfo imageRectangleProperty = typeof (PictureBox).GetProperty("ImageRectangle",
            BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Instance);


        public int SpotID { get; private set; } = -1;

        public frmKaart()
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
        }

        private void picKaart_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs) e;

            Bitmap original = (Bitmap) picKaart.Image;

            Color? color = null;
            switch (picKaart.SizeMode)
            {
                case PictureBoxSizeMode.Normal:
                case PictureBoxSizeMode.AutoSize:
                {
                    color = original.GetPixel(me.X, me.Y);
                    break;
                }
                case PictureBoxSizeMode.CenterImage:
                case PictureBoxSizeMode.StretchImage:
                case PictureBoxSizeMode.Zoom:
                {
                    Rectangle rectangle = (Rectangle) imageRectangleProperty.GetValue(picKaart, null);
                    if (rectangle.Contains(me.Location))
                    {
                        using (Bitmap copy = new Bitmap(picKaart.ClientSize.Width, picKaart.ClientSize.Height))
                        {
                            using (Graphics g = Graphics.FromImage(copy))
                            {
                                g.DrawImage(maskedKaart, rectangle);

                                color = copy.GetPixel(me.X, me.Y);
                            }
                        }
                    }
                    break;
                }
            }

            if (color.HasValue)
            {
                string hex = ColorTranslator.ToHtml(color.Value);
                int x = Convert.ToInt32(hex.Substring(1), 16);

                if (x >= 1000 || x == 0)
                {
                    SpotID = -1;
                    lblPlek.Text = $"Gekozen plek: geen";
                    return;
                }

                SpotID = x;
                lblPlek.Text = $"Gekozen plek: {SpotID}";
                Console.WriteLine(x);
            }
            else
            {
                SpotID = -1;
                lblPlek.Text = $"Gekozen plek: geen";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (SpotID == -1)
            {
                DialogResult = DialogResult.Abort;
                Close();
                return;
            }

            DatabaseManager.InsertItem(new LeasePlace()
            {
                Account = frmMain.Account.ID,
                Arrival = frmDatum.From,
                Departure = frmDatum.Till,
                Event = frmMain.SelectedEvenement.ID,
                Place = SpotID
            });
            DialogResult = SpotID == -1 ? DialogResult.Abort : DialogResult.OK;
            Close();
        }
    }
}