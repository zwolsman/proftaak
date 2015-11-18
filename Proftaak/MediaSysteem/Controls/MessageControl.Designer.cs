using MediaSysteem.Controls;

namespace MediaSysteem
{
    partial class MessageControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageControl));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.LinkLabel();
            this.linkAddComment = new System.Windows.Forms.LinkLabel();
            this.txtMessage = new MediaSysteem.Controls.CueTextBox();
            this.btnSubmitComment = new System.Windows.Forms.Button();
            this.lblLikes = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelComment = new System.Windows.Forms.Panel();
            this.panelMedia = new System.Windows.Forms.Panel();
            this.picMedia = new System.Windows.Forms.PictureBox();
            this.picAction = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelComment.SuspendLayout();
            this.panelMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(52, 3);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(52, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "2 hours ago";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(52, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "title - category";
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.Location = new System.Drawing.Point(3, 45);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(242, 15);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Message";
            // 
            // lblRemove
            // 
            this.lblRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemove.AutoSize = true;
            this.lblRemove.Location = new System.Drawing.Point(191, 3);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(54, 13);
            this.lblRemove.TabIndex = 5;
            this.lblRemove.TabStop = true;
            this.lblRemove.Text = "Remove";
            this.lblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRemove_LinkClicked);
            // 
            // linkAddComment
            // 
            this.linkAddComment.AutoSize = true;
            this.linkAddComment.Location = new System.Drawing.Point(3, 60);
            this.linkAddComment.Name = "linkAddComment";
            this.linkAddComment.Size = new System.Drawing.Size(86, 13);
            this.linkAddComment.TabIndex = 6;
            this.linkAddComment.TabStop = true;
            this.linkAddComment.Text = "Add comment";
            this.linkAddComment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddComment_LinkClicked);
            // 
            // txtMessage
            // 
            this.txtMessage.Cue = "Enter comment here";
            this.txtMessage.Location = new System.Drawing.Point(3, 8);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(228, 21);
            this.txtMessage.TabIndex = 7;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // btnSubmitComment
            // 
            this.btnSubmitComment.Location = new System.Drawing.Point(156, 35);
            this.btnSubmitComment.Name = "btnSubmitComment";
            this.btnSubmitComment.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitComment.TabIndex = 9;
            this.btnSubmitComment.Text = "Submit";
            this.btnSubmitComment.UseVisualStyleBackColor = true;
            this.btnSubmitComment.Click += new System.EventHandler(this.btnSubmitComment_Click);
            // 
            // lblLikes
            // 
            this.lblLikes.Location = new System.Drawing.Point(95, 60);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(136, 13);
            this.lblLikes.TabIndex = 10;
            this.lblLikes.Text = "1000 likes";
            this.lblLikes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelComment);
            this.flowLayoutPanel1.Controls.Add(this.panelMedia);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 153);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // panelComment
            // 
            this.panelComment.Controls.Add(this.txtMessage);
            this.panelComment.Controls.Add(this.btnSubmitComment);
            this.panelComment.Location = new System.Drawing.Point(3, 3);
            this.panelComment.Name = "panelComment";
            this.panelComment.Size = new System.Drawing.Size(239, 64);
            this.panelComment.TabIndex = 13;
            // 
            // panelMedia
            // 
            this.panelMedia.Controls.Add(this.picMedia);
            this.panelMedia.Location = new System.Drawing.Point(3, 73);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(239, 77);
            this.panelMedia.TabIndex = 14;
            // 
            // picMedia
            // 
            this.picMedia.Location = new System.Drawing.Point(72, 3);
            this.picMedia.Name = "picMedia";
            this.picMedia.Size = new System.Drawing.Size(92, 71);
            this.picMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMedia.TabIndex = 0;
            this.picMedia.TabStop = false;
            this.picMedia.Click += new System.EventHandler(this.picMedia_Click);
            // 
            // picAction
            // 
            this.picAction.Image = ((System.Drawing.Image)(resources.GetObject("picAction.Image")));
            this.picAction.Location = new System.Drawing.Point(215, 26);
            this.picAction.Name = "picAction";
            this.picAction.Size = new System.Drawing.Size(16, 16);
            this.picAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAction.TabIndex = 11;
            this.picAction.TabStop = false;
            this.picAction.Click += new System.EventHandler(this.picAction_Click);
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(6, 3);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(40, 40);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // MessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.picAction);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.linkAddComment);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picUser);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(248, 241);
            this.Load += new System.EventHandler(this.MessageControl_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelComment.ResumeLayout(false);
            this.panelComment.PerformLayout();
            this.panelMedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.LinkLabel lblRemove;
        private System.Windows.Forms.LinkLabel linkAddComment;
        private CueTextBox txtMessage;
        private System.Windows.Forms.Button btnSubmitComment;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.PictureBox picAction;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelComment;
        private System.Windows.Forms.Panel panelMedia;
        private System.Windows.Forms.PictureBox picMedia;
    }
}
