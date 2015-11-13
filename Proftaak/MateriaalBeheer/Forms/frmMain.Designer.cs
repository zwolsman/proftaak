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
            this.btModify.Location = new System.Drawing.Point(12, 21);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(179, 23);
            this.btModify.TabIndex = 0;
            this.btModify.Text = "Materiaal wijzigen";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // btRent
            // 
            this.btRent.Location = new System.Drawing.Point(12, 76);
            this.btRent.Name = "btRent";
            this.btRent.Size = new System.Drawing.Size(179, 23);
            this.btRent.TabIndex = 1;
            this.btRent.Text = "Materiaalverhuur";
            this.btRent.UseVisualStyleBackColor = true;
            this.btRent.Click += new System.EventHandler(this.btRent_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 133);
            this.Controls.Add(this.btRent);
            this.Controls.Add(this.btModify);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btRent;
    }
}