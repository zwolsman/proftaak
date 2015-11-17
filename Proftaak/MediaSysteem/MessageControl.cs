using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;

namespace MediaSysteem
{
    public partial class MessageControl : UserControl
    {

        private MediaAccount user;
        private CategoryInstance category;
        public MessageControl(MessageInstance message)
        {
            InitializeComponent();
            user = new MediaAccount() {ID = message.MediaAccount};
            category = new CategoryInstance() {ID = message.Category};

            user = DatabaseManager.ContainsItem(user, new[] {"ID"});
            category = DatabaseManager.ContainsItem(category, new[] {"ID"});


            pictureBox1.ImageLocation = user.Picture;
            lblUsername.Text = user.Username;
            lblDate.Text = message.Datum.ToShortDateString();
            lblMessage.Text = message.Report;

            lblTitle.Text = string.IsNullOrEmpty(message.Title) ? category.Name : $"{message.Title} - {category.Name}";
        }

        private void lblPopout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
