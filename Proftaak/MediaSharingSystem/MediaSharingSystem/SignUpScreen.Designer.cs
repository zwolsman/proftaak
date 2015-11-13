namespace MediaSharingSystem
{
    partial class SignUpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpScreen));
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txt_UsernameSignIn = new System.Windows.Forms.TextBox();
            this.EyeCTEventLogo = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btnSignIn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lbl_Password.Location = new System.Drawing.Point(27, 214);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(81, 17);
            this.lbl_Password.TabIndex = 18;
            this.lbl_Password.Text = "Password:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(30, 238);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(220, 20);
            this.txt_Password.TabIndex = 17;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblUsername.Location = new System.Drawing.Point(30, 154);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 17);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username:";
            // 
            // txt_UsernameSignIn
            // 
            this.txt_UsernameSignIn.Location = new System.Drawing.Point(30, 180);
            this.txt_UsernameSignIn.Name = "txt_UsernameSignIn";
            this.txt_UsernameSignIn.Size = new System.Drawing.Size(220, 20);
            this.txt_UsernameSignIn.TabIndex = 16;
            // 
            // EyeCTEventLogo
            // 
            this.EyeCTEventLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EyeCTEventLogo.BackgroundImage")));
            this.EyeCTEventLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EyeCTEventLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyeCTEventLogo.Location = new System.Drawing.Point(106, 38);
            this.EyeCTEventLogo.Name = "EyeCTEventLogo";
            this.EyeCTEventLogo.Size = new System.Drawing.Size(75, 74);
            this.EyeCTEventLogo.TabIndex = 13;
            this.EyeCTEventLogo.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblEmail.Location = new System.Drawing.Point(30, 272);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 17);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "E-mail:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(30, 297);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(220, 20);
            this.txt_Email.TabIndex = 20;
            this.txt_Email.UseSystemPasswordChar = true;
            // 
            // btnSignIn2
            // 
            this.btnSignIn2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnSignIn2.Location = new System.Drawing.Point(106, 336);
            this.btnSignIn2.Name = "btnSignIn2";
            this.btnSignIn2.Size = new System.Drawing.Size(75, 34);
            this.btnSignIn2.TabIndex = 22;
            this.btnSignIn2.Text = "Sign In";
            this.btnSignIn2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "EyeCT Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignIn2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txt_UsernameSignIn);
            this.Controls.Add(this.EyeCTEventLogo);
            this.Name = "SignUpScreen";
            this.Text = "SignUpScreen";
            this.Load += new System.EventHandler(this.SignUpScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txt_UsernameSignIn;
        private System.Windows.Forms.PictureBox EyeCTEventLogo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btnSignIn2;
        private System.Windows.Forms.Label label1;
    }
}