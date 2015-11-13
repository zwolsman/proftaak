namespace MediaSharingSystem
{
    partial class SignInScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInScreen));
            this.EyeCTEventLogo = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.link_SignUp = new System.Windows.Forms.LinkLabel();
            this.link_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnSignIn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // EyeCTEventLogo
            // 
            this.EyeCTEventLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EyeCTEventLogo.BackgroundImage")));
            this.EyeCTEventLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EyeCTEventLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EyeCTEventLogo.Location = new System.Drawing.Point(106, 38);
            this.EyeCTEventLogo.Name = "EyeCTEventLogo";
            this.EyeCTEventLogo.Size = new System.Drawing.Size(75, 74);
            this.EyeCTEventLogo.TabIndex = 0;
            this.EyeCTEventLogo.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(37, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "EyeCT Sign In";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(37, 188);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(220, 20);
            this.txt_Username.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(34, 161);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(220, 24);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Location = new System.Drawing.Point(34, 227);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(220, 24);
            this.lbl_Password.TabIndex = 6;
            this.lbl_Password.Text = "Password:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(34, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 88);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(43, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Don\'t have an account?";
            // 
            // link_SignUp
            // 
            this.link_SignUp.AutoSize = true;
            this.link_SignUp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.link_SignUp.Location = new System.Drawing.Point(163, 443);
            this.link_SignUp.Name = "link_SignUp";
            this.link_SignUp.Size = new System.Drawing.Size(77, 15);
            this.link_SignUp.TabIndex = 10;
            this.link_SignUp.TabStop = true;
            this.link_SignUp.Text = "Sign up here";
            // 
            // link_ForgotPassword
            // 
            this.link_ForgotPassword.AutoSize = true;
            this.link_ForgotPassword.BackColor = System.Drawing.SystemColors.Control;
            this.link_ForgotPassword.Location = new System.Drawing.Point(86, 337);
            this.link_ForgotPassword.Name = "link_ForgotPassword";
            this.link_ForgotPassword.Size = new System.Drawing.Size(106, 15);
            this.link_ForgotPassword.TabIndex = 11;
            this.link_ForgotPassword.TabStop = true;
            this.link_ForgotPassword.Text = "Forgot Password?";
            // 
            // btnSignIn2
            // 
            this.btnSignIn2.Location = new System.Drawing.Point(106, 292);
            this.btnSignIn2.Name = "btnSignIn2";
            this.btnSignIn2.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn2.TabIndex = 12;
            this.btnSignIn2.Text = "Sign In";
            this.btnSignIn2.UseVisualStyleBackColor = true;
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 503);
            this.Controls.Add(this.btnSignIn2);
            this.Controls.Add(this.link_ForgotPassword);
            this.Controls.Add(this.link_SignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EyeCTEventLogo);
            this.Name = "SignInScreen";
            this.Text = "SignInScreen";
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EyeCTEventLogo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel link_SignUp;
        private System.Windows.Forms.LinkLabel link_ForgotPassword;
        private System.Windows.Forms.Button btnSignIn2;
    }
}