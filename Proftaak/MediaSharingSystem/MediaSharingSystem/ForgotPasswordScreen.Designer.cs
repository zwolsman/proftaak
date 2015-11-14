namespace MediaSharingSystem
{
    partial class ForgotPasswordScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordScreen));
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.EyeCTEventLogo = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblEmail.Location = new System.Drawing.Point(45, 257);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(48, 292);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 22);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblUsername.Location = new System.Drawing.Point(45, 177);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 17);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(48, 210);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(292, 22);
            this.txtUsername.TabIndex = 16;
            // 
            // EyeCTEventLogo
            // 
            this.EyeCTEventLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EyeCTEventLogo.BackgroundImage")));
            this.EyeCTEventLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EyeCTEventLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EyeCTEventLogo.Location = new System.Drawing.Point(140, 26);
            this.EyeCTEventLogo.Margin = new System.Windows.Forms.Padding(4);
            this.EyeCTEventLogo.Name = "EyeCTEventLogo";
            this.EyeCTEventLogo.Size = new System.Drawing.Size(99, 90);
            this.EyeCTEventLogo.TabIndex = 13;
            this.EyeCTEventLogo.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnBack.Location = new System.Drawing.Point(44, 519);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 42);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnSend.Location = new System.Drawing.Point(221, 519);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(116, 42);
            this.btnSend.TabIndex = 23;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.BackColor = System.Drawing.Color.Red;
            this.lblForgotPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblForgotPassword.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgotPassword.Location = new System.Drawing.Point(48, 127);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(297, 32);
            this.lblForgotPassword.TabIndex = 25;
            this.lblForgotPassword.Text = "Forgot Password";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForgotPasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 619);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.EyeCTEventLogo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgotPasswordScreen";
            this.Text = "ForgotPasswordScreen";
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox EyeCTEventLogo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblForgotPassword;
    }
}