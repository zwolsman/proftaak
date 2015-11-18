namespace Toegangscontrole
{
    partial class frmBetalingen
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
            this.listBetalingen = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBetalingen
            // 
            this.listBetalingen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listBetalingen.FullRowSelect = true;
            this.listBetalingen.Location = new System.Drawing.Point(13, 13);
            this.listBetalingen.MultiSelect = false;
            this.listBetalingen.Name = "listBetalingen";
            this.listBetalingen.Size = new System.Drawing.Size(782, 424);
            this.listBetalingen.TabIndex = 0;
            this.listBetalingen.UseCompatibleStateImageBehavior = false;
            this.listBetalingen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plaats";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bedrag";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Beschrijving";
            this.columnHeader3.Width = 323;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Betalingsdatum";
            this.columnHeader4.Width = 132;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(633, 443);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(162, 23);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Betaling verwijderen";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(13, 443);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(164, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Betaling toevoegen";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // frmBetalingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 478);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.listBetalingen);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBetalingen";
            this.Text = "frmBetalingen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listBetalingen;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
    }
}