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

namespace Reserveer_Systeem
{
    public partial class frmLogin : Form
    {
        public Account Account { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Account returnAccount = DatabaseManager.ContainsItem(new Account()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            }, new [] {"Username", "Password"});

            if (returnAccount == null)
            {
                picError.Show();
            }
            else
            {
                if (picError.Visible)
                    picError.Hide();
                DialogResult = DialogResult.OK;
                returnAccount.Password = txtPassword.Text;
                Account = returnAccount;
                Close();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (picError.Visible)
                picError.Hide();
        }
    }
}
