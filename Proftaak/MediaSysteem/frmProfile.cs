using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;


namespace MediaSysteem
{
    public partial class frmProfile : frmBase
    {
        public frmProfile()
        {
            InitializeComponent();
            lblUsername.Text = Globals.Account.Username;

            txtUsername.Text = Globals.Account.Username;
            txtPassword.Text = Globals.Account.Password;
            txtEmail.Text = Globals.Account.Email;
            if (!string.IsNullOrEmpty(Globals.Account.Picture))
                picProfile.ImageLocation = Globals.Account.Picture;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "";

                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                string sep = string.Empty;

                foreach (var c in codecs)
                {
                    string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                    ofd.Filter = string.Format("{0}{1}{2} ({3})|{3}", ofd.Filter, sep, codecName, c.FilenameExtension);
                    sep = "|";
                }

                ofd.Filter = string.Format("{0}{1}{2} ({3})|{3}", ofd.Filter, sep, "All Files", "*.*");

                ofd.DefaultExt = ".png";
                ofd.Multiselect = false;
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    picProfile.ImageLocation = ofd.FileName;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MediaAccount account = new MediaAccount()
            {
                ID = Globals.Account.ID,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                Picture = picProfile.ImageLocation
            };

            if (!DatabaseManager.UpdateItem(account))
            {
                MessageBox.Show("Something went wrong saving your information", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Globals.Account = account;
            Close();
        }
    }
}
