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

namespace EvenementBeheerSysteem.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            DisableControls(true);

            Task.Run(() =>
            {
                DatabaseManager.Initialize("sa", "Wachtwoord1", "127.0.0.1", "proftaak");
                try
                {
                    DatabaseManager.Open();

                    Invoke((MethodInvoker) delegate()
                    {
                        lblStatus.Text = "Verbonden!";
                        lblStatus.ForeColor = Color.Green;
                    });
                  
                }
                catch
                {
                    Invoke((MethodInvoker) delegate()
                    {
                        lblStatus.Text = "Er is iets fout gegaan..";
                        lblStatus.ForeColor = Color.Red;
                    });
                }
                DisableControls(false);
            });
           
          
        }



        /// <summary>
        /// Enable/disable controls.
        /// </summary>
        /// <param name="locked">True to lock, False to unlock</param>
        private void DisableControls(bool locked)
        {
            foreach (Control control in Controls)
            {
                if (control.InvokeRequired)
                    control.Invoke((MethodInvoker) (() => control.Enabled = !locked));
                else
                    control.Enabled = !locked;
            }
        }

        private void DisableControls(bool locked, params Type[] target)
        {
            foreach (Control control in Controls.Cast<Control>().Where(control => target.Contains(control.GetType())))
            {
                if (control.InvokeRequired)
                    control.Invoke((MethodInvoker)(() => control.Enabled = !locked));
                else
                    control.Enabled = !locked;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //DisableControls(true, typeof(Button), typeof(TextBox));
            var frm = new frmMain();
            frm.FormClosing += (o, args) => Environment.Exit(0);
            frm.Show();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
