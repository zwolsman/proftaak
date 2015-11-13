namespace MateriaalBeheer
{
    partial class frmModifyMaterial
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
            this.listEvent = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btToevoegen = new System.Windows.Forms.Button();
            this.btVerwijderen = new System.Windows.Forms.Button();
            this.btWijzigen = new System.Windows.Forms.Button();
            this.txtPricePW = new System.Windows.Forms.TextBox();
            this.txtPricePD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listMaterial = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listEvent
            // 
            this.listEvent.FormattingEnabled = true;
            this.listEvent.Location = new System.Drawing.Point(20, 26);
            this.listEvent.Name = "listEvent";
            this.listEvent.Size = new System.Drawing.Size(228, 199);
            this.listEvent.TabIndex = 0;
            this.listEvent.SelectedIndexChanged += new System.EventHandler(this.listEvent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Events";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btToevoegen);
            this.groupBox1.Controls.Add(this.btVerwijderen);
            this.groupBox1.Controls.Add(this.btWijzigen);
            this.groupBox1.Controls.Add(this.txtPricePW);
            this.groupBox1.Controls.Add(this.txtPricePD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProduct);
            this.groupBox1.Location = new System.Drawing.Point(14, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 145);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materiaalgegevens";
            // 
            // btToevoegen
            // 
            this.btToevoegen.Location = new System.Drawing.Point(299, 111);
            this.btToevoegen.Margin = new System.Windows.Forms.Padding(2);
            this.btToevoegen.Name = "btToevoegen";
            this.btToevoegen.Size = new System.Drawing.Size(175, 23);
            this.btToevoegen.TabIndex = 12;
            this.btToevoegen.Text = "Materiaal toevoegen";
            this.btToevoegen.UseVisualStyleBackColor = true;
            this.btToevoegen.Click += new System.EventHandler(this.btToevoegen_Click);
            // 
            // btVerwijderen
            // 
            this.btVerwijderen.Location = new System.Drawing.Point(299, 57);
            this.btVerwijderen.Margin = new System.Windows.Forms.Padding(2);
            this.btVerwijderen.Name = "btVerwijderen";
            this.btVerwijderen.Size = new System.Drawing.Size(175, 23);
            this.btVerwijderen.TabIndex = 11;
            this.btVerwijderen.Text = "Materiaal verwijderen";
            this.btVerwijderen.UseVisualStyleBackColor = true;
            this.btVerwijderen.Click += new System.EventHandler(this.btVerwijderen_Click);
            // 
            // btWijzigen
            // 
            this.btWijzigen.Location = new System.Drawing.Point(299, 84);
            this.btWijzigen.Margin = new System.Windows.Forms.Padding(2);
            this.btWijzigen.Name = "btWijzigen";
            this.btWijzigen.Size = new System.Drawing.Size(175, 23);
            this.btWijzigen.TabIndex = 10;
            this.btWijzigen.Text = "Materiaal wijzigen";
            this.btWijzigen.UseVisualStyleBackColor = true;
            this.btWijzigen.Click += new System.EventHandler(this.btWijzigen_Click);
            // 
            // txtPricePW
            // 
            this.txtPricePW.Location = new System.Drawing.Point(392, 32);
            this.txtPricePW.Margin = new System.Windows.Forms.Padding(2);
            this.txtPricePW.Name = "txtPricePW";
            this.txtPricePW.Size = new System.Drawing.Size(82, 21);
            this.txtPricePW.TabIndex = 7;
            // 
            // txtPricePD
            // 
            this.txtPricePD.Location = new System.Drawing.Point(299, 32);
            this.txtPricePD.Margin = new System.Windows.Forms.Padding(2);
            this.txtPricePD.Name = "txtPricePD";
            this.txtPricePD.Size = new System.Drawing.Size(75, 21);
            this.txtPricePD.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prijs per week";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prijs per dag";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(5, 70);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(277, 64);
            this.txtDescription.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Beschrijving:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product:";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(6, 32);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(277, 21);
            this.txtProduct.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Materialen";
            // 
            // listMaterial
            // 
            this.listMaterial.FormattingEnabled = true;
            this.listMaterial.Location = new System.Drawing.Point(279, 26);
            this.listMaterial.Name = "listMaterial";
            this.listMaterial.Size = new System.Drawing.Size(228, 199);
            this.listMaterial.TabIndex = 8;
            this.listMaterial.SelectedIndexChanged += new System.EventHandler(this.listMaterial_SelectedIndexChanged);
            // 
            // frmModifyMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 387);
            this.Controls.Add(this.listMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEvent);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "frmModifyMaterial";
            this.Text = "Materiaalbeheer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPricePW;
        private System.Windows.Forms.TextBox txtPricePD;
        private System.Windows.Forms.Button btWijzigen;
        private System.Windows.Forms.Button btToevoegen;
        private System.Windows.Forms.Button btVerwijderen;
    }
}

