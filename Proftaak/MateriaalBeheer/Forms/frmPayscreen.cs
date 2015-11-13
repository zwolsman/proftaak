using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaalBeheer.Forms
{
    public partial class frmPayscreen : Form
    {
        private string rfid;

        public frmPayscreen(int days, int price, string rfid)
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
            this.rfid = rfid;
            float f = price;
            f = f / 100;
            lblInfo.Text = "Gehuurd voor " + days.ToString() + " dagen\nvoor de prijs van \u20AC" + f.ToString();
        }

        private void btPayNow_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btAddBill_Click(object sender, EventArgs e)
        {
            //TODO:
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
