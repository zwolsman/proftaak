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
        private readonly Size normalSize = new Size(234, 79);
        private readonly Size writingComment = new Size(234, 131);

        public EventHandler<MessageInstance> CommentPostedHandler;
        public EventHandler<MessageInstance> MessageDeleteHandler;

        private bool _isWriting;

        private bool IsWriting
        {
            get { return _isWriting; }
            set
            {
                _isWriting = value;
                OnIsWritingChanged(IsWriting);
            }
        }

        private void OnIsWritingChanged(bool isWriting)
        {
            //Size = isWriting ? writingComment : normalSize;
            if (isWriting)
            {
                Controls.Add(txtMessage);
                Controls.Add(btnSubmitComment);
                Controls.Add(label1);
            }
            else
            {
                Controls.Remove(txtMessage);
                Controls.Remove(btnSubmitComment);
                Controls.Remove(label1);
            }
        }


        private MediaAccount user;
        private CategoryInstance category;
        public MessageInstance Message { get; }

        public MessageControl(MessageInstance message)
        {
            InitializeComponent();
            this.Message = message;
            user = new MediaAccount() {ID = message.MediaAccount};
            category = new CategoryInstance() {ID = message.Category};

            user = DatabaseManager.ContainsItem(user, new[] {"ID"});
            category = DatabaseManager.ContainsItem(category, new[] {"ID"});


            pictureBox1.ImageLocation = user.Picture;
            lblUsername.Text = user.Username;
            lblDate.Text = message.Datum.ToShortDateString();
            lblMessage.Text = message.Report;

            lblTitle.Text = string.IsNullOrEmpty(message.Title) ? category.Name : $"{message.Title} - {category.Name}";
            IsWriting = false;
            if (Globals.Account.ID != message.MediaAccount)
                Controls.Remove(lblRemove);
        }

        private void lblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DatabaseManager.DeleteItem(Message))
                MessageDeleteHandler?.Invoke(this, Message);
        }


        private void btnSubmitComment_Click(object sender, EventArgs e)
        {
            CommentPostedHandler?.Invoke(this, new MessageInstance()
            {
                Category = category.ID,
                Datum = DateTime.Now,
                MediaAccount = Globals.Account.ID,
                Report = txtMessage.Text,
                Message = Message.ID,
                Title = $"Comment on '{Message.Title}'"
            });
            IsWriting = false;
            txtMessage.Clear();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                e.Handled = true;
                IsWriting = false;
                txtMessage.Clear();
            }
        }

        private void linkAddComment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsWriting = !IsWriting;
        }

        public void Reload()
        {
            user = new MediaAccount() { ID = Message.MediaAccount };
            category = new CategoryInstance() { ID = Message.Category };

            user = DatabaseManager.ContainsItem(user, new[] { "ID" });
            category = DatabaseManager.ContainsItem(category, new[] { "ID" });


            pictureBox1.ImageLocation = user.Picture;
            lblUsername.Text = user.Username;
            lblDate.Text = Message.Datum.ToShortDateString();
            lblMessage.Text = Message.Report;

            lblTitle.Text = string.IsNullOrEmpty(Message.Title) ? category.Name : $"{Message.Title} - {category.Name}";
            IsWriting = false;
            if (Globals.Account.ID != Message.MediaAccount)
                Controls.Remove(lblRemove);
        }
    }
}