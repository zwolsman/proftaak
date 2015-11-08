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
            this.listMaterial.Location = new System.Drawing.Point(14, 24);
            this.listMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listMaterial.Name = "listMaterial";
            this.listMaterial.Size = new System.Drawing.Size(200, 277);
            this.listMaterial.TabIndex = 9;
            // 
            // btHuren
            // 
            this.btHuren.Location = new System.Drawing.Point(215, 265);
            this.btHuren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btHuren.Name = "btHuren";
            this.btHuren.Size = new System.Drawing.Size(65, 19);
            this.btHuren.TabIndex = 10;
            this.btHuren.Text = "Huren";
            this.btHuren.UseVisualStyleBackColor = true;
            this.btHuren.Click += new System.EventHandler(this.btHuren_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(11, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(140, 13);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Beschikbaar materiaal:";
            // 
            // btInnemen
            // 
            this.btInnemen.Location = new System.Drawing.Point(215, 288);
            this.btInnemen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInnemen.Name = "btInnemen";
            this.btInnemen.Size = new System.Drawing.Size(65, 19);
            this.btInnemen.TabIndex = 12;
            this.btInnemen.Text = "Innemen";
            this.btInnemen.UseVisualStyleBackColor = true;
            this.btInnemen.Click += new System.EventHandler(this.btInnemen_Click);
            // 
            // btOverzichtReserveren
            // 
            this.btOverzichtReserveren.Location = new System.Drawing.Point(10, 313);
            this.btOverzichtReserveren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOverzichtReserveren.Name = "btOverzichtReserveren";
            this.btOverzichtReserveren.Size = new System.Drawing.Size(199, 19);
            this.btOverzichtReserveren.TabIndex = 14;
            this.btOverzichtReserveren.Text = "Bekijk gereserveerde materialen";
            this.btOverzichtReserveren.UseVisualStyleBackColor = true;
            this.btOverzichtReserveren.Click += new System.EventHandler(this.btOverzichtReserveren_Click);
            // 
            // frmRentMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 341);
            this.Controls.Add(this.btOverzichtReserveren);
            this.Controls.Add(this.btInnemen);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btHuren);
            this.Controls.Add(this.listMaterial);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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