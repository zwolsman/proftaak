namespace Toegangscontrole
{
    partial class frmReserveringen
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
            this.listReservering = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAddPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listReservering
            // 
            this.listReservering.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listReservering.FullRowSelect = true;
            this.listReservering.HideSelection = false;
            this.listReservering.Location = new System.Drawing.Point(13, 13);
            this.listReservering.MultiSelect = false;
            this.listReservering.Name = "listReservering";
            this.listReservering.Size = new System.Drawing.Size(898, 396);
            this.listReservering.TabIndex = 0;
            this.listReservering.UseCompatibleStateImageBehavior = false;
            this.listReservering.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naam";
            this.columnHeader1.Width = 196;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bankrekening";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Plaatsnummer";
            this.columnHeader3.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aankomstdatum";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vertrekdatum";
            this.columnHeader5.Width = 119;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nog te betalen bedrag";
            this.columnHeader6.Width = 178;
            // 
            // btAddPayment
            // 
            this.btAddPayment.Location = new System.Drawing.Point(758, 415);
            this.btAddPayment.Name = "btAddPayment";
            this.btAddPayment.Size = new System.Drawing.Size(153, 23);
            this.btAddPayment.TabIndex = 1;
            this.btAddPayment.Text = "Betaling toevoegen";
            this.btAddPayment.UseVisualStyleBackColor = true;
            this.btAddPayment.Click += new System.EventHandler(this.btAddPayment_Click);
            // 
            // frmReserveringen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.btAddPayment);
            this.Controls.Add(this.listReservering);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmReserveringen";
            this.Text = "frmReserveringen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listReservering;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btAddPayment;
    }
}