using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;
using Toegangscontrole.Classes;

namespace Toegangscontrole
{
    public partial class frmPayscreen : Form
    {
        private float price;
        private string rfid;

        public frmPayscreen(int price, string rfid)
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
            this.rfid = rfid;
            this.price = price;
            this.price = this.price / 100;
            lblInfo.Text = "Nog te betalen: " + this.price.ToString("C");
        }

        private void btPayNow_Click(object sender, EventArgs e)
        {
            int? i = DatabaseManager.GetLeasePlaceID(rfid);
            if (!i.HasValue)
            {
                MessageBox.Show("Er is iets fout gegaan. Probeer het opnieuw.", "RFID fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
            }
            Payment p = new Payment()
            {
                LeasePlace = (int)i,
                Amount = (int)(price*100),
                Description = "Betaald bij portier:" + price.ToString("C"),
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
