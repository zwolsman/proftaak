using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toegangscontrole.Classes;
using DatabaseLibrary;
using System.Text.RegularExpressions;

namespace Toegangscontrole
{
    public partial class frmBetaling : Form
    {
        private string bankaccount;
        private string bedrag;
        private string beschrijving;
        private int leaseplace;

        public frmBetaling(int leaseplace, string bank, string bedrag)
        {
            InitializeComponent();
            bankaccount = bank;
            this.bedrag = bedrag;
            beschrijving = string.Empty;
            this.leaseplace = leaseplace;
            DialogResult = DialogResult.Abort;
            LoadForm();
        }

        public frmBetaling(int leaseplace) :this(leaseplace, string.Empty, string.Empty)
        {
        }

        private void LoadForm()
        {
            txtIban.Text = bankaccount;
            txtBedrag.Text = bedrag;
            txtBeschrijving.Text = beschrijving;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtBedrag.Text, @"^\d+$"))
            {
                MessageBox.Show("Bedrag is geen integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Payment p = new Payment()
            {
                LeasePlace = leaseplace,
                PaymentDate = dateTimePicker1.Value.Date,
                Amount = int.Parse(txtBedrag.Text),
                Description = txtBeschrijving.Text
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
    }
}
