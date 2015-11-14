namespace MediaSharingSystem
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.EyeCTLogo = new System.Windows.Forms.PictureBox();
            this.lblUpdateInfo_back = new System.Windows.Forms.Label();
            this.lblEventInfo = new System.Windows.Forms.Label();
            this.lblEyeCTEvent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSignIn.FlatAppearance.BorderSize = 2;
            this.btnSignIn.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnSignIn.Location = new System.Drawing.Point(28, 512);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(141, 54);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnSignUp.Location = new System.Drawing.Point(205, 512);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(133, 54);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // EyeCTLogo
            // 
            this.EyeCTLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EyeCTLogo.BackgroundImage")));
            this.EyeCTLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EyeCTLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyeCTLogo.Location = new System.Drawing.Point(89, 31);
            this.EyeCTLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EyeCTLogo.Name = "EyeCTLogo";
            this.EyeCTLogo.Size = new System.Drawing.Size(199, 180);
            this.EyeCTLogo.TabIndex = 3;
            this.EyeCTLogo.TabStop = false;
            // 
            // lblUpdateInfo_back
            // 
            this.lblUpdateInfo_back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblUpdateInfo_back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUpdateInfo_back.Location = new System.Drawing.Point(41, 252);
            this.lblUpdateInfo_back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateInfo_back.Name = "lblUpdateInfo_back";
            this.lblUpdateInfo_back.Size = new System.Drawing.Size(297, 230);
            this.lblUpdateInfo_back.TabIndex = 4;
            this.lblUpdateInfo_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEventInfo
            // 
            this.lblEventInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventInfo.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblEventInfo.Location = new System.Drawing.Point(66, 276);
            this.lblEventInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventInfo.Name = "lblEventInfo";
            this.lblEventInfo.Size = new System.Drawing.Size(244, 177);
            this.lblEventInfo.TabIndex = 5;
            this.lblEventInfo.Text = "Event Info";
            this.lblEventInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEventInfo.UseWaitCursor = true;
            // 
            // lblEyeCTEvent
            // 
            this.lblEyeCTEvent.BackColor = System.Drawing.Color.Red;
            this.lblEyeCTEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEyeCTEvent.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblEyeCTEvent.ForeColor = System.Drawing.Color.White;
            this.lblEyeCTEvent.Location = new System.Drawing.Point(41, 215);
            this.lblEyeCTEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEyeCTEvent.Name = "lblEyeCTEvent";
            this.lblEyeCTEvent.Size = new System.Drawing.Size(297, 32);
            this.lblEyeCTEvent.TabIndex = 14;
            this.lblEyeCTEvent.Text = "EyeCT Event";
            this.lblEyeCTEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 619);
            this.Controls.Add(this.lblEyeCTEvent);
            this.Controls.Add(this.lblEventInfo);
            this.Controls.Add(this.lblUpdateInfo_back);
            this.Controls.Add(this.EyeCTLogo);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox EyeCTLogo;
        private System.Windows.Forms.Label lblUpdateInfo_back;
        private System.Windows.Forms.Label lblEventInfo;
        private System.Windows.Forms.Label lblEyeCTEvent;
    }
}

