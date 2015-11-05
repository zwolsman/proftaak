namespace Reserveer_Systeem
{
    partial class frmDatum
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTill = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picErrorVoornaam = new System.Windows.Forms.PictureBox();
            this.picErrorAchternaam = new System.Windows.Forms.PictureBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.listPersons = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorVoornaam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorAchternaam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum van aankomst";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(12, 25);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(233, 21);
            this.dtFrom.TabIndex = 1;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtValueChanged);
            // 
            // dtTill
            // 
            this.dtTill.Location = new System.Drawing.Point(12, 65);
            this.dtTill.Name = "dtTill";
            this.dtTill.Size = new System.Drawing.Size(233, 21);
            this.dtTill.TabIndex = 3;
            this.dtTill.ValueChanged += new System.EventHandler(this.dtValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum van vertrek";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picErrorVoornaam);
            this.groupBox1.Controls.Add(this.picErrorAchternaam);
            this.groupBox1.Controls.Add(this.btnAddPerson);
            this.groupBox1.Controls.Add(this.txtAchternaam);
            this.groupBox1.Controls.Add(this.txtVoornaam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblVoornaam);
            this.groupBox1.Controls.Add(this.listPersons);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personen toevoegen";
            // 
            // picErrorVoornaam
            // 
            this.picErrorVoornaam.Image = global::Reserveer_Systeem.Properties.Resources.error;
            this.picErrorVoornaam.Location = new System.Drawing.Point(196, 33);
            this.picErrorVoornaam.Name = "picErrorVoornaam";
            this.picErrorVoornaam.Size = new System.Drawing.Size(21, 21);
            this.picErrorVoornaam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorVoornaam.TabIndex = 7;
            this.picErrorVoornaam.TabStop = false;
            this.picErrorVoornaam.Visible = false;
            // 
            // picErrorAchternaam
            // 
            this.picErrorAchternaam.Image = global::Reserveer_Systeem.Properties.Resources.error;
            this.picErrorAchternaam.Location = new System.Drawing.Point(196, 73);
            this.picErrorAchternaam.Name = "picErrorAchternaam";
            this.picErrorAchternaam.Size = new System.Drawing.Size(21, 21);
            this.picErrorAchternaam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorAchternaam.TabIndex = 6;
            this.picErrorAchternaam.TabStop = false;
            this.picErrorAchternaam.Visible = false;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(9, 100);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(181, 23);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Text = "Voeg toe";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(9, 73);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(181, 21);
            this.txtAchternaam.TabIndex = 4;
            this.txtAchternaam.TextChanged += new System.EventHandler(this.txtVoornaam_TextChanged);
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(9, 33);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(181, 21);
            this.txtVoornaam.TabIndex = 3;
            this.txtVoornaam.TextChanged += new System.EventHandler(this.txtVoornaam_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Achternaam";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(6, 17);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(65, 13);
            this.lblVoornaam.TabIndex = 1;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // listPersons
            // 
            this.listPersons.FormattingEnabled = true;
            this.listPersons.Location = new System.Drawing.Point(223, 20);
            this.listPersons.Name = "listPersons";
            this.listPersons.Size = new System.Drawing.Size(249, 121);
            this.listPersons.TabIndex = 0;
            this.listPersons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listPersons_KeyDown);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(415, 253);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Volgende";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmDatum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 284);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtTill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "frmDatum";
            this.Text = "Reservering";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorVoornaam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorAchternaam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.ListBox listPersons;
        private System.Windows.Forms.PictureBox picErrorAchternaam;
        private System.Windows.Forms.PictureBox picErrorVoornaam;
    }
}