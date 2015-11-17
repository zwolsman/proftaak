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

namespace MediaSysteem
{
    public partial class frmSignin : frmBase
    {
        public frmSignin()
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            MediaAccount account = DatabaseManager.ContainsItem(new MediaAccount()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            }, new[] {"Username", "Password"});

            if (account == null)
            {
                MessageBox.Show("User and/or password are invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Globals.Account = account;
                MessageBox.Show("User signed in!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
