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
            this.tbPricePW = new System.Windows.Forms.TextBox();
            this.tbPricePD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listMaterial = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listEvent
            // 
            this.listEvent.FormattingEnabled = true;
            this.listEvent.ItemHeight = 16;
            this.listEvent.Location = new System.Drawing.Point(23, 32);
            this.listEvent.Margin = new System.Windows.Forms.Padding(4);
            this.listEvent.Name = "listEvent";
            this.listEvent.Size = new System.Drawing.Size(228, 244);
            this.listEvent.TabIndex = 0;
            this.listEvent.SelectedIndexChanged += new System.EventHandler(this.listEvent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Events";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btToevoegen);
            this.groupBox1.Controls.Add(this.btVerwijderen);
            this.groupBox1.Controls.Add(this.btWijzigen);
            this.groupBox1.Controls.Add(this.tbPricePW);
            this.groupBox1.Controls.Add(this.tbPricePD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbProduct);
            this.groupBox1.Location = new System.Drawing.Point(16, 283);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(715, 185);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materiaalgegevens";
            // 
            // btToevoegen
            // 
            this.btToevoegen.Location = new System.Drawing.Point(329, 156);
            this.btToevoegen.Name = "btToevoegen";
            this.btToevoegen.Size = new System.Drawing.Size(157, 26);
            this.btToevoegen.TabIndex = 12;
            this.btToevoegen.Text = "Materiaal toevoegen";
            this.btToevoegen.UseVisualStyleBackColor = true;
            this.btToevoegen.Click += new System.EventHandler(this.btToevoegen_Click);
            // 
            // btVerwijderen
            // 
            this.btVerwijderen.Location = new System.Drawing.Point(551, 152);
            this.btVerwijderen.Name = "btVerwijderen";
            this.btVerwijderen.Size = new System.Drawing.Size(157, 26);
            this.btVerwijderen.TabIndex = 11;
            this.btVerwijderen.Text = "Materiaal verwijderen";
            this.btVerwijderen.UseVisualStyleBackColor = true;
            this.btVerwijderen.Click += new System.EventHandler(this.btVerwijderen_Click);
            // 
            // btWijzigen
            // 
            this.btWijzigen.Location = new System.Drawing.Point(329, 124);
            this.btWijzigen.Name = "btWijzigen";
            this.btWijzigen.Size = new System.Drawing.Size(157, 26);
            this.btWijzigen.TabIndex = 10;
            this.btWijzigen.Text = "Materiaal wijzigen";
            this.btWijzigen.UseVisualStyleBackColor = true;
            this.btWijzigen.Click += new System.EventHandler(this.btWijzigen_Click);
            // 
            // tbPricePW
            // 
            this.tbPricePW.Location = new System.Drawing.Point(448, 44);
            this.tbPricePW.Name = "tbPricePW";
            this.tbPricePW.Size = new System.Drawing.Size(93, 22);
            this.tbPricePW.TabIndex = 7;
            // 
            // tbPricePD
            // 
            this.tbPricePD.Location = new System.Drawing.Point(341, 44);
            this.tbPricePD.Name = "tbPricePD";
            this.tbPricePD.Size = new System.Drawing.Size(85, 22);
            this.tbPricePD.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prijs per week";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prijs per dag";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(7, 89);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(316, 89);
            this.tbDescription.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Beschrijving:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product:";
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(3, 44);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(316, 22);
            this.tbProduct.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Materialen";
            // 
            // listMaterial
            // 
            this.listMaterial.FormattingEnabled = true;
            this.listMaterial.ItemHeight = 16;
            this.listMaterial.Location = new System.Drawing.Point(252, 32);
            this.listMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.listMaterial.Name = "listMaterial";
            this.listMaterial.Size = new System.Drawing.Size(228, 244);
            this.listMaterial.TabIndex = 8;
            this.listMaterial.SelectedIndexChanged += new System.EventHandler(this.listMaterial_SelectedIndexChanged);
            // 
            // frmModifyMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 477);
            this.Controls.Add(this.listMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEvent);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPricePW;
        private System.Windows.Forms.TextBox tbPricePD;
        private System.Windows.Forms.Button btWijzigen;
        private System.Windows.Forms.Button btToevoegen;
        private System.Windows.Forms.Button btVerwijderen;
    }
}

