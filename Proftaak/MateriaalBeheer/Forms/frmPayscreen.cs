using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MateriaalBeheer.Classes;
using DatabaseLibrary;

namespace MateriaalBeheer.Forms
{
    public partial class frmPayscreen : Form
    {
        private int price;
        private string rfid;

        public frmPayscreen(int days, int price, string rfid, string product)
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
            this.rfid = rfid;
            this.price = price;
            float f = price;
            f = f / 100;
            lblInfo.Text = char.ToUpper(product[0]) + product.Substring(1) + " gehuurd voor " + days.ToString() + " dagen.\nVoor de prijs van \u20AC" + f.ToString();
        }

        private void btPayNow_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btAddBill_Click(object sender, EventArgs e)
        {
            int? i = DatabaseManager.GetLeasePlaceID(rfid);
            if (i == null)
            {
                MessageBox.Show("Kan betaling niet verwerken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Payment p = new Payment()
            {
                LeasePlace = (int)i,
                Amount = 0 - price,
                Description = "Huur:" + lblInfo.Text,
            };
            DatabaseManager.InsertItem<Payment>(p);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lblInfo_SizeChanged(object sender, EventArgs e)
        {
            lblInfo.Left = (this.ClientSize.Width - lblInfo.Size.Width) / 2;
        }
    }
}
