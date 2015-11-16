namespace Toegangscontrole
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
            this.btPortier = new System.Windows.Forms.Button();
            this.btCheckIn = new System.Windows.Forms.Button();
            this.btAttendence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPortier
            // 
            this.btPortier.Location = new System.Drawing.Point(12, 12);
            this.btPortier.Name = "btPortier";
            this.btPortier.Size = new System.Drawing.Size(160, 23);
            this.btPortier.TabIndex = 0;
            this.btPortier.Text = "Toegangscontrole";
            this.btPortier.UseVisualStyleBackColor = true;
            this.btPortier.Click += new System.EventHandler(this.btPortier_Click);
            // 
            // btCheckIn
            // 
            this.btCheckIn.Location = new System.Drawing.Point(12, 41);
            this.btCheckIn.Name = "btCheckIn";
            this.btCheckIn.Size = new System.Drawing.Size(160, 23);
            this.btCheckIn.TabIndex = 1;
            this.btCheckIn.Text = "Portier";
            this.btCheckIn.UseVisualStyleBackColor = true;
            this.btCheckIn.Click += new System.EventHandler(this.btCheckIn_Click);
            // 
            // btAttendence
            // 
            this.btAttendence.Location = new System.Drawing.Point(12, 70);
            this.btAttendence.Name = "btAttendence";
            this.btAttendence.Size = new System.Drawing.Size(160, 23);
            this.btAttendence.TabIndex = 2;
            this.btAttendence.Text = "Lijst aanwezigen";
            this.btAttendence.UseVisualStyleBackColor = true;
            this.btAttendence.Click += new System.EventHandler(this.btAttendence_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 114);
            this.Controls.Add(this.btAttendence);
            this.Controls.Add(this.btCheckIn);
            this.Controls.Add(this.btPortier);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPortier;
        private System.Windows.Forms.Button btCheckIn;
        private System.Windows.Forms.Button btAttendence;
    }
}