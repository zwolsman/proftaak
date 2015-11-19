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
            this.btVolgende = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMaterials
            // 
            this.listMaterials.CheckBoxes = true;
            this.listMaterials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listMaterials.FullRowSelect = true;
            this.listMaterials.Location = new System.Drawing.Point(14, 12);
            this.listMaterials.Name = "listMaterials";
            this.listMaterials.Size = new System.Drawing.Size(476, 266);
            this.listMaterials.TabIndex = 0;
            this.listMaterials.UseCompatibleStateImageBehavior = false;
            this.listMaterials.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Omschrijving";
            this.columnHeader5.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Prijs per dag";
            this.columnHeader6.Width = 92;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Prijs per week";
            this.columnHeader7.Width = 107;
            // 
            // btVolgende
            // 
            this.btVolgende.Location = new System.Drawing.Point(405, 284);
            this.btVolgende.Name = "btVolgende";
            this.btVolgende.Size = new System.Drawing.Size(85, 23);
            this.btVolgende.TabIndex = 1;
            this.btVolgende.Text = "Volgende";
            this.btVolgende.UseVisualStyleBackColor = true;
            this.btVolgende.Click += new System.EventHandler(this.btVolgende_Click);
            // 
            // frmSelectMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 319);
            this.Controls.Add(this.btVolgende);
            this.Controls.Add(this.listMaterials);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "frmSelectMaterial";
            this.Text = "Materiaal selecteren";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listMaterials;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btVolgende;
    }
}