namespace MediaSharingSystem
{
    partial class AddImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddImage));
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnUpload.Location = new System.Drawing.Point(29, 90);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(130, 36);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnBack.Location = new System.Drawing.Point(166, 90);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 36);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 72);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // AddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 150);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpload);
            this.Name = "AddImage";
            this.Text = "AddImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}