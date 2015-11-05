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
        public frmNewAccount()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Account account = GetFromForm();
            DatabaseManager.InsertItem(account);
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