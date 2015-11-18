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
using MediaSysteem.Properties;

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

        private int _likes;

        private int Likes
        {
            get { return _likes; }
            set
            {
                _likes = value;
                lblLikes.Text = Likes == 1 ? "1 like" : $"{Likes.ToString("N0")} likes";
            }
        }

        private bool _didLike;

        private bool DidLike
        {
            get { return _didLike; }
            set
            {
                _didLike = value;
                picAction.Image = DidLike
                    ? global::MediaSysteem.Properties.Resources.thumb_down
                    : global::MediaSysteem.Properties.Resources.thumb_up;
            }
        }

        private void OnIsWritingChanged(bool isWriting)
        {
            if (isWriting)
            {
                Controls.Add(flowLayoutPanel1);
                flowLayoutPanel1.Controls.Add(panelComment);
            }
            else
            {
                flowLayoutPanel1.Controls.Remove(panelComment);
                if(!hasMedia)
                    Controls.Remove(flowLayoutPanel1);
            }
        }


        private MediaAccount user;
        private CategoryInstance category;
        private bool hasMedia = false;
        public MessageInstance Message { get; }

        public MessageControl(MessageInstance message)
        {
            InitializeComponent();
            
            this.Message = message;
            user = new MediaAccount() {ID = message.MediaAccount};
            category = new CategoryInstance() {ID = message.Category};

            if (Message.Media != null)
            {
                Media media = new Media() {ID = Message.Media.Value};
                media = DatabaseManager.ContainsItem(media, new [] {"ID"});
                picMedia.ImageLocation = media.Url;
                hasMedia = true;
            }
            else
            {
                flowLayoutPanel1.Controls.Remove(panelMedia);
                Controls.Remove(flowLayoutPanel1);
            }
            user = DatabaseManager.ContainsItem(user, new[] {"ID"});
            category = DatabaseManager.ContainsItem(category, new[] {"ID"});
            Likes =
                int.Parse(
                    DatabaseManager.QueryFirst("SELECT COUNT(*) FROM Likes WHERE message=" + message.ID)["Column1"]
                        .ToString());
            DidLike =
                DatabaseManager.ContainsItem(new Likes() {Message = message.ID, MediaAccount = Globals.Account.ID},
                    new[] {"Message", "MediaAccount"}) !=
                null;

            picUser.ImageLocation = user.Picture;
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
            user = new MediaAccount() {ID = Message.MediaAccount};
            category = new CategoryInstance() {ID = Message.Category};

            user = DatabaseManager.ContainsItem(user, new[] {"ID"});
            category = DatabaseManager.ContainsItem(category, new[] {"ID"});


            picUser.ImageLocation = user.Picture;
            lblUsername.Text = user.Username;
            lblDate.Text = Message.Datum.ToShortDateString();
            lblMessage.Text = Message.Report;

            lblTitle.Text = string.IsNullOrEmpty(Message.Title) ? category.Name : $"{Message.Title} - {category.Name}";
            IsWriting = false;
            if (Globals.Account.ID != Message.MediaAccount)
                Controls.Remove(lblRemove);
        }

        private void picAction_Click(object sender, EventArgs e)
        {
            Likes like = new Likes() {Message = Message.ID, MediaAccount = Globals.Account.ID};
            if (!DidLike)
            {
                if (DatabaseManager.InsertItem(like))
                {
                    DidLike = true;
                    Likes++;
                }
            }
            else
            {
                if (DatabaseManager.Execute($"DELETE FROM Likes WHERE Message={like.Message} AND MediaAccount={like.MediaAccount}") != -1)
                {
                    DidLike = false;
                    Likes--;
                }
            }
        }

        private void MessageControl_Load(object sender, EventArgs e)
        {

        }

        private void picMedia_Click(object sender, EventArgs e)
        {
            new frmPicture(picMedia.Image).Show(this);
        }
    }
}