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

namespace Reserveer_Systeem
{
    public partial class frmNewAccount : Form
    {
        public Account Account { get; private set; }

        public frmNewAccount()
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Account account = GetFromForm();
                try
                {
                    if (DatabaseManager.InsertItem(account))
                    {
                        Account = DatabaseManager.ContainsItem(account, new[] {"Username", "Password"});
                        if (
                            DatabaseManager.InsertItem(new Person(txtFirstname.Text, txtLastname.Text)
                            {
                                Account = Account.ID,
                                MainTenant = "Y"
                            }))
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            if (
                                MessageBox.Show("Kon account niet aanmaken. Probeer het opnieuw", "Account aanmaken",
                                    MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                            {
                                continue;
                            }

                            Close();
                        }
                    }
                    else
                    {
                        if (
                            MessageBox.Show("Kon account niet aanmaken. Probeer het opnieuw", "Account aanmaken",
                                MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                        {
                            continue;
                        }

                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gebruikersnaam is al in gebruik. Probeer een andere");
                    return;
                }
                break;
            }
            Close();
        }

        private Account GetFromForm()
        {
            Account account = new Account();
            foreach (PropertyInfo propInfo in typeof (Account).GetProperties().Where(propInfo => propInfo != null))
            {
                if (!propInfo.CanWrite)
                    continue;

                if (propInfo.Name == "ID")
                {
                    propInfo.SetValue(account, -1);
                    continue;
                }
                foreach (Control c in Controls)
                {
                    if (c.Name != $"txt{propInfo.Name}")
                        continue;

                    dynamic control = null;
                    if (c is TextBox)
                    {
                        control = c as TextBox;
                    }
                    if (c is MaskedTextBox)
                    {
                        control = c as MaskedTextBox;
                    }
                    propInfo.SetValue(account, control.Text);
                }
            }
            return account;
        }
    }
}