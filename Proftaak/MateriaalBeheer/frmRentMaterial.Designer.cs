namespace MateriaalBeheer
{
    partial class frmRentMaterial
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
            this.listMaterial = new System.Windows.Forms.ListBox();
            this.btHuren = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btInnemen = new System.Windows.Forms.Button();
            this.btOverzichtReserveren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMaterial
            // 
            this.listMaterial.FormattingEnabled = true;
            this.listMaterial.ItemHeight = 16;
            this.listMaterial.Location = new System.Drawing.Point(12, 22);
            this.listMaterial.Name = "listMaterial";
            this.listMaterial.Size = new System.Drawing.Size(228, 356);
            this.listMaterial.TabIndex = 9;
            // 
            // btHuren
            // 
            this.btHuren.Location = new System.Drawing.Point(246, 326);
            this.btHuren.Name = "btHuren";
            this.btHuren.Size = new System.Drawing.Size(75, 23);
            this.btHuren.TabIndex = 10;
            this.btHuren.Text = "Huren";
            this.btHuren.UseVisualStyleBackColor = true;
            this.btHuren.Click += new System.EventHandler(this.btHuren_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(13, -1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(152, 17);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Beschikbaar materiaal:";
            // 
            // btInnemen
            // 
            this.btInnemen.Location = new System.Drawing.Point(246, 355);
            this.btInnemen.Name = "btInnemen";
            this.btInnemen.Size = new System.Drawing.Size(75, 23);
            this.btInnemen.TabIndex = 12;
            this.btInnemen.Text = "Innemen";
            this.btInnemen.UseVisualStyleBackColor = true;
            this.btInnemen.Click += new System.EventHandler(this.btInnemen_Click);
            // 
            // btOverzichtReserveren
            // 
            this.btOverzichtReserveren.Location = new System.Drawing.Point(12, 385);
            this.btOverzichtReserveren.Name = "btOverzichtReserveren";
            this.btOverzichtReserveren.Size = new System.Drawing.Size(228, 23);
            this.btOverzichtReserveren.TabIndex = 14;
            this.btOverzichtReserveren.Text = "Bekijk gereserveerde materialen";
            this.btOverzichtReserveren.UseVisualStyleBackColor = true;
            this.btOverzichtReserveren.Click += new System.EventHandler(this.btOverzichtReserveren_Click);
            // 
            // frmRentMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 420);
            this.Controls.Add(this.btOverzichtReserveren);
            this.Controls.Add(this.btInnemen);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btHuren);
            this.Controls.Add(this.listMaterial);
            this.Name = "frmRentMaterial";
            this.Text = "frmRentMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMaterial;
        private System.Windows.Forms.Button btHuren;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btInnemen;
        private System.Windows.Forms.Button btOverzichtReserveren;
    }
}