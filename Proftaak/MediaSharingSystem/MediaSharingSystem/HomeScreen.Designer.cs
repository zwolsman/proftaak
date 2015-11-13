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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EyeCTLogo = new System.Windows.Forms.PictureBox();
            this.lblUpdateInfo_back = new System.Windows.Forms.Label();
            this.lblUpdateInfo_front = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSignIn.FlatAppearance.BorderSize = 2;
            this.btnSignIn.Location = new System.Drawing.Point(21, 416);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(106, 44);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(34, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "EyeCT Events";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EyeCTLogo
            // 
            this.EyeCTLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EyeCTLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyeCTLogo.Image = ((System.Drawing.Image)(resources.GetObject("EyeCTLogo.Image")));
            this.EyeCTLogo.Location = new System.Drawing.Point(67, 25);
            this.EyeCTLogo.Name = "EyeCTLogo";
            this.EyeCTLogo.Size = new System.Drawing.Size(150, 147);
            this.EyeCTLogo.TabIndex = 3;
            this.EyeCTLogo.TabStop = false;
            // 
            // lblUpdateInfo_back
            // 
            this.lblUpdateInfo_back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblUpdateInfo_back.Location = new System.Drawing.Point(34, 205);
            this.lblUpdateInfo_back.Name = "lblUpdateInfo_back";
            this.lblUpdateInfo_back.Size = new System.Drawing.Size(220, 187);
            this.lblUpdateInfo_back.TabIndex = 4;
            this.lblUpdateInfo_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpdateInfo_front
            // 
            this.lblUpdateInfo_front.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUpdateInfo_front.Location = new System.Drawing.Point(53, 244);
            this.lblUpdateInfo_front.Name = "lblUpdateInfo_front";
            this.lblUpdateInfo_front.Size = new System.Drawing.Size(183, 109);
            this.lblUpdateInfo_front.TabIndex = 5;
            this.lblUpdateInfo_front.Text = "Update Info";
            this.lblUpdateInfo_front.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpdateInfo_front.UseWaitCursor = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 503);
            this.Controls.Add(this.lblUpdateInfo_front);
            this.Controls.Add(this.lblUpdateInfo_back);
            this.Controls.Add(this.EyeCTLogo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSignIn);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox EyeCTLogo;
        private System.Windows.Forms.Label lblUpdateInfo_back;
        private System.Windows.Forms.Label lblUpdateInfo_front;
    }
}

