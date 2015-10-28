namespace Reserveer_Systeem
{
    partial class frmSelectMaterial
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
            this.listMaterials = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listMaterials
            // 
            this.listMaterials.CheckBoxes = true;
            this.listMaterials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listMaterials.FullRowSelect = true;
            this.listMaterials.Location = new System.Drawing.Point(12, 12);
            this.listMaterials.Name = "listMaterials";
            this.listMaterials.Size = new System.Drawing.Size(478, 260);
            this.listMaterials.TabIndex = 0;
            this.listMaterials.UseCompatibleStateImageBehavior = false;
            this.listMaterials.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Omschrijving";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Prijs per dag";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Prijs per week";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Beschikbaar";
            // 
            // frmSelectMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 284);
            this.Controls.Add(this.listMaterials);
            this.Name = "frmSelectMaterial";
            this.Text = "frmSelectMaterial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listMaterials;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}