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
            this.lblMateriaal = new System.Windows.Forms.Label();
            this.btInnemen = new System.Windows.Forms.Button();
            this.btOverzichtReserveren = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.listItem = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listMaterial
            // 
            this.listMaterial.FormattingEnabled = true;
            this.listMaterial.ItemHeight = 17;
            this.listMaterial.Location = new System.Drawing.Point(14, 24);
            this.listMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.listMaterial.Name = "listMaterial";
            this.listMaterial.Size = new System.Drawing.Size(200, 276);
            this.listMaterial.TabIndex = 9;
            // 
            // btHuren
            // 
            this.btHuren.Location = new System.Drawing.Point(170, 315);
            this.btHuren.Margin = new System.Windows.Forms.Padding(2);
            this.btHuren.Name = "btHuren";
            this.btHuren.Size = new System.Drawing.Size(150, 19);
            this.btHuren.TabIndex = 10;
            this.btHuren.Text = "Huren";
            this.btHuren.UseVisualStyleBackColor = true;
            this.btHuren.Click += new System.EventHandler(this.btHuren_Click);
            // 
            // lblMateriaal
            // 
            this.lblMateriaal.AutoSize = true;
            this.lblMateriaal.Location = new System.Drawing.Point(11, 9);
            this.lblMateriaal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateriaal.Name = "lblMateriaal";
            this.lblMateriaal.Size = new System.Drawing.Size(166, 17);
            this.lblMateriaal.TabIndex = 11;
            this.lblMateriaal.Text = "Beschikbaar materiaal:";
            // 
            // btInnemen
            // 
            this.btInnemen.Location = new System.Drawing.Point(330, 315);
            this.btInnemen.Margin = new System.Windows.Forms.Padding(2);
            this.btInnemen.Name = "btInnemen";
            this.btInnemen.Size = new System.Drawing.Size(150, 19);
            this.btInnemen.TabIndex = 12;
            this.btInnemen.Text = "Innemen";
            this.btInnemen.UseVisualStyleBackColor = true;
            this.btInnemen.Click += new System.EventHandler(this.btInnemen_Click);
            // 
            // btOverzichtReserveren
            // 
            this.btOverzichtReserveren.Location = new System.Drawing.Point(10, 315);
            this.btOverzichtReserveren.Margin = new System.Windows.Forms.Padding(2);
            this.btOverzichtReserveren.Name = "btOverzichtReserveren";
            this.btOverzichtReserveren.Size = new System.Drawing.Size(150, 19);
            this.btOverzichtReserveren.TabIndex = 14;
            this.btOverzichtReserveren.Text = "Bekijk gereserveerde materialen";
            this.btOverzichtReserveren.UseVisualStyleBackColor = true;
            this.btOverzichtReserveren.Click += new System.EventHandler(this.btOverzichtReserveren_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(225, 9);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(166, 17);
            this.lblItem.TabIndex = 11;
            this.lblItem.Text = "Beschikbare items:";
            // 
            // listItem
            // 
            this.listItem.FormattingEnabled = true;
            this.listItem.ItemHeight = 17;
            this.listItem.Location = new System.Drawing.Point(228, 24);
            this.listItem.Margin = new System.Windows.Forms.Padding(2);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(200, 276);
            this.listItem.TabIndex = 9;
            // 
            // frmRentMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 341);
            this.Controls.Add(this.btOverzichtReserveren);
            this.Controls.Add(this.btInnemen);
            this.Controls.Add(this.lblMateriaal);
            this.Controls.Add(this.btHuren);
            this.Controls.Add(this.listMaterial);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.listItem);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRentMaterial";
            this.Text = "frmRentMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMaterial;
        private System.Windows.Forms.Button btHuren;
        private System.Windows.Forms.Label lblMateriaal;
        private System.Windows.Forms.Button btInnemen;
        private System.Windows.Forms.Button btOverzichtReserveren;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ListBox listItem;
    }
}