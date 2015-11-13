namespace MediaSharingSystem
{
    partial class PlaceMediaMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceMediaMessage));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenInfo = new System.Windows.Forms.Button();
            this.EyeCTEventLogo = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnBack.Location = new System.Drawing.Point(23, 432);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 34);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnGenInfo
            // 
            this.btnGenInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenInfo.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnGenInfo.ForeColor = System.Drawing.Color.White;
            this.btnGenInfo.Location = new System.Drawing.Point(64, 37);
            this.btnGenInfo.Name = "btnGenInfo";
            this.btnGenInfo.Size = new System.Drawing.Size(199, 38);
            this.btnGenInfo.TabIndex = 31;
            this.btnGenInfo.Text = "Place Media Message";
            this.btnGenInfo.UseVisualStyleBackColor = false;
            // 
            // EyeCTEventLogo
            // 
            this.EyeCTEventLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EyeCTEventLogo.BackgroundImage")));
            this.EyeCTEventLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EyeCTEventLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyeCTEventLogo.Location = new System.Drawing.Point(20, 37);
            this.EyeCTEventLogo.Name = "EyeCTEventLogo";
            this.EyeCTEventLogo.Size = new System.Drawing.Size(37, 37);
            this.EyeCTEventLogo.TabIndex = 30;
            this.EyeCTEventLogo.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnSend.Location = new System.Drawing.Point(171, 432);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 34);
            this.btnSend.TabIndex = 34;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 212);
            this.label1.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button1.Location = new System.Drawing.Point(142, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(20, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 23);
            this.textBox1.TabIndex = 37;
            // 
            // PlaceMediaMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 503);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenInfo);
            this.Controls.Add(this.EyeCTEventLogo);
            this.Name = "PlaceMediaMessage";
            this.Text = "PlaceMediaMessage";
            ((System.ComponentModel.ISupportInitialize)(this.EyeCTEventLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenInfo;
        private System.Windows.Forms.PictureBox EyeCTEventLogo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}