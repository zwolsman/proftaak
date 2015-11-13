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
    public partial class frmEnterProdCode : Form
    {
        public string productcode;

        public frmEnterProdCode()
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (!txtProdCode.Text.Equals(string.Empty))
            {
                productcode = txtProdCode.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Geef een productcode in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
