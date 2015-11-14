namespace MediaSharingSystem
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.btnProfileHome = new System.Windows.Forms.Button();
            this.EyeCTEventLogo = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.picbProfile = new System.Windows.Forms.PictureBox();
            this.tabPageReserved = new System.Windows.Forms.TabPage();
            this.listReserved = new System.Windows.Forms.ListView();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbProfile)).BeginInit();
            this.tabPageReserved.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProfileHome
            // 
            this.btnProfileHome.BackColor = System.Drawing.Color.Red;
            this.btnProfileHome.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnProfileHome.ForeColor = System.Drawing.Color.White;
            this.btnProfileHome.Location = new System.Drawing.Point(88, 46);
            this.btnProfileHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfileHome.Name = "btnProfileHome";
            this.btnProfileHome.Size = new System.Drawing.Size(265, 47);
            this.btnProfileHome.TabIndex = 33;
            this.btnProfileHome.Text = "Profile";
            this.btnProfileHome.UseVisualStyleBackColor = false;
            // 
            // EyeCTEventLogo
            // 
            this.EyeCTEventLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EyeCTEventLogo.BackgroundImage")));
            this.EyeCTEventLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EyeCTEventLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyeCTEventLogo.Location = new System.Drawing.Point(33, 48);
            this.EyeCTEventLogo.Margin = new System.Windows.Forms.Padding(4);
            this.EyeCTEventLogo.Name = "EyeCTEventLogo";
            this.EyeCTEventLogo.Size = new System.Drawing.Size(49, 45);
            this.EyeCTEventLogo.TabIndex = 32;
            this.EyeCTEventLogo.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnBack.Location = new System.Drawing.Point(33, 536);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 42);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnProfile.Location = new System.Drawing.Point(174, 536);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(179, 42);
            this.btnProfile.TabIndex = 34;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Controls.Add(this.tabPageReserved);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(33, 161);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 296);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.label2);
            this.tabPageInfo.Controls.Add(this.txtEmail);
            this.tabPageInfo.Controls.Add(this.lblEmail);
            this.tabPageInfo.Controls.Add(this.txtPassword);
            this.tabPageInfo.Controls.Add(this.lblPassword);
            this.tabPageInfo.Controls.Add(this.txtName);
            this.tabPageInfo.Controls.Add(this.lblName);
            this.tabPageInfo.Controls.Add(this.picbProfile);
            this.tabPageInfo.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 26);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(312, 266);
            this.tabPageInfo.TabIndex = 0;
            this.tabPageInfo.Text = "Information";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(189, 240);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Profile Image";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 24);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblEmail.Location = new System.Drawing.Point(18, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 56);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 24);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblPassword.Location = new System.Drawing.Point(18, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 24);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblName.Location = new System.Drawing.Point(18, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // picbProfile
            // 
            this.picbProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbProfile.BackgroundImage")));
            this.picbProfile.Location = new System.Drawing.Point(189, 136);
            this.picbProfile.Name = "picbProfile";
            this.picbProfile.Size = new System.Drawing.Size(100, 101);
            this.picbProfile.TabIndex = 0;
            this.picbProfile.TabStop = false;
            // 
            // tabPageReserved
            // 
            this.tabPageReserved.Controls.Add(this.listReserved);
            this.tabPageReserved.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.tabPageReserved.Location = new System.Drawing.Point(4, 26);
            this.tabPageReserved.Name = "tabPageReserved";
            this.tabPageReserved.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReserved.Size = new System.Drawing.Size(312, 266);
            this.tabPageReserved.TabIndex = 1;
            this.tabPageReserved.Text = "Reserved";
            this.tabPageReserved.UseVisualStyleBackColor = true;
            // 
            // listReserved
            // 
            this.listReserved.Location = new System.Drawing.Point(7, 7);
            this.listReserved.Margin = new System.Windows.Forms.Padding(4);
            this.listReserved.Name = "listReserved";
            this.listReserved.Size = new System.Drawing.Size(295, 252);
            this.listReserved.TabIndex = 1;
            this.listReserved.UseCompatibleStateImageBehavior = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnLogout.Location = new System.Drawing.Point(226, 100);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(127, 40);
            this.btnLogout.TabIndex = 37;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 619);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnProfileHome);
            this.Controls.Add(this.EyeCTEventLogo);
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbProfile)).EndInit();
            this.tabPageReserved.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfileHome;
        private System.Windows.Forms.PictureBox EyeCTEventLogo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.PictureBox picbProfile;
        private System.Windows.Forms.TabPage tabPageReserved;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListView listReserved;
    }
}