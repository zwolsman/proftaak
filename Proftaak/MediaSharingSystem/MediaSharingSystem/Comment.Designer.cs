namespace MediaSharingSystem
{
    partial class Comment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comment));
            this.btnComment = new System.Windows.Forms.Button();
            this.EyeCTEventLogo = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLike = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnComment.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnComment.ForeColor = System.Drawing.Color.White;
            this.btnComment.Location = new System.Drawing.Point(87, 47);
            this.btnComment.Margin = new System.Windows.Forms.Padding(4);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(265, 47);
            this.btnComment.TabIndex = 33;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = false;
            // 
            // EyeCTEventLogo
            // 
            this.EyeCTEventLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EyeCTEventLogo.BackgroundImage")));
            this.EyeCTEventLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EyeCTEventLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyeCTEventLogo.Location = new System.Drawing.Point(29, 47);
            this.EyeCTEventLogo.Margin = new System.Windows.Forms.Padding(4);
            this.EyeCTEventLogo.Name = "EyeCTEventLogo";
            this.EyeCTEventLogo.Size = new System.Drawing.Size(49, 45);
            this.EyeCTEventLogo.TabIndex = 32;
            this.EyeCTEventLogo.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblMessage.Location = new System.Drawing.Point(43, 113);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(289, 183);
            this.lblMessage.TabIndex = 36;
            this.lblMessage.Text = "Media Messages";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.UseWaitCursor = true;
            // 
            // btnLike
            // 
            this.btnLike.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnLike.Location = new System.Drawing.Point(43, 300);
            this.btnLike.Margin = new System.Windows.Forms.Padding(4);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 42);
            this.btnLike.TabIndex = 35;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 420);
            this.label1.TabIndex = 34;
            // 
            // lblComment
            // 
            this.lblComment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComment.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblComment.Location = new System.Drawing.Point(43, 346);
            this.lblComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(289, 158);
            this.lblComment.TabIndex = 37;
            this.lblComment.Text = "Comment";
            this.lblComment.UseWaitCursor = true;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(55, 369);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(264, 22);
            this.txtComment.TabIndex = 38;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnBack.Location = new System.Drawing.Point(29, 534);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 42);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 619);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.EyeCTEventLogo);
            this.Name = "Comment";
            this.Text = "Comment";
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.PictureBox EyeCTEventLogo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnBack;
    }
}