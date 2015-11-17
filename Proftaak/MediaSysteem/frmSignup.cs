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
    public partial class frmSignup : frmBase
    {
        public frmSignup()
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;


            MediaAccount account = new MediaAccount()
            {
                Username = username,
                Password = password,
                Email = email
            };


            if (!DatabaseManager.InsertItem(account))
            {
                MessageBox.Show("Could not create user. Please try again with a different username", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Account created!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                account = DatabaseManager.ContainsItem(new MediaAccount()
                {
                    Username = username,
                    Password = password,
                    Email = email
                }, new [] {"Username", "Password"});
                Globals.Account = account;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}