namespace MateriaalBeheer.Forms
{
    partial class frmMain
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
            this.btModify = new System.Windows.Forms.Button();
            this.btRent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(10, 17);
            this.btModify.Margin = new System.Windows.Forms.Padding(2);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(156, 23);
            this.btModify.TabIndex = 0;
            this.btModify.Text = "Materiaal wijzigen";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // btRent
            // 
            this.btRent.Location = new System.Drawing.Point(10, 62);
            this.btRent.Margin = new System.Windows.Forms.Padding(2);
            this.btRent.Name = "btRent";
            this.btRent.Size = new System.Drawing.Size(156, 23);
            this.btRent.TabIndex = 1;
            this.btRent.Text = "Materiaal verhuur";
            this.btRent.UseVisualStyleBackColor = true;
            this.btRent.Click += new System.EventHandler(this.btRent_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 108);
            this.Controls.Add(this.btRent);
            this.Controls.Add(this.btModify);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btRent;
    }
}