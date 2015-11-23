namespace EvenementBeheerSysteem.Forms
{
    partial class frmMain
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
            this.listEvents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupEvenement = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCampingmap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtEind = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupEvenement.SuspendLayout();
            this.SuspendLayout();
            // 
            // listEvents
            // 
            this.listEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listEvents.FullRowSelect = true;
            this.listEvents.Location = new System.Drawing.Point(14, 12);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(297, 442);
            this.listEvents.TabIndex = 0;
            this.listEvents.UseCompatibleStateImageBehavior = false;
            this.listEvents.View = System.Windows.Forms.View.Details;
            this.listEvents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listEvents_KeyDown);
            this.listEvents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listEvents_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naam";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Locatie";
            this.columnHeader3.Width = 98;
            // 
            // groupEvenement
            // 
            this.groupEvenement.Controls.Add(this.btnCancel);
            this.groupEvenement.Controls.Add(this.btnSave);
            this.groupEvenement.Controls.Add(this.label7);
            this.groupEvenement.Controls.Add(this.txtCampingmap);
            this.groupEvenement.Controls.Add(this.label6);
            this.groupEvenement.Controls.Add(this.txtLogo);
            this.groupEvenement.Controls.Add(this.label5);
            this.groupEvenement.Controls.Add(this.txtDescription);
            this.groupEvenement.Controls.Add(this.dtEind);
            this.groupEvenement.Controls.Add(this.label4);
            this.groupEvenement.Controls.Add(this.dtBegin);
            this.groupEvenement.Controls.Add(this.label3);
            this.groupEvenement.Controls.Add(this.txtLocatie);
            this.groupEvenement.Controls.Add(this.label2);
            this.groupEvenement.Controls.Add(this.txtNaam);
            this.groupEvenement.Controls.Add(this.label1);
            this.groupEvenement.Location = new System.Drawing.Point(318, 12);
            this.groupEvenement.Name = "groupEvenement";
            this.groupEvenement.Size = new System.Drawing.Size(428, 348);
            this.groupEvenement.TabIndex = 1;
            this.groupEvenement.TabStop = false;
            this.groupEvenement.Text = "Nieuw evenement";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(10, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Annuleer";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Aanmaken";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Beschrijving";
            // 
            // txtCampingmap
            // 
            this.txtCampingmap.Location = new System.Drawing.Point(216, 110);
            this.txtCampingmap.Name = "txtCampingmap";
            this.txtCampingmap.Size = new System.Drawing.Size(198, 21);
            this.txtCampingmap.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Campingmap";
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(10, 110);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(198, 21);
            this.txtLogo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Logo";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(10, 149);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(403, 161);
            this.txtDescription.TabIndex = 8;
            // 
            // dtEind
            // 
            this.dtEind.Location = new System.Drawing.Point(216, 71);
            this.dtEind.Name = "dtEind";
            this.dtEind.Size = new System.Drawing.Size(198, 21);
            this.dtEind.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Eind datum";
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(216, 32);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(198, 21);
            this.dtBegin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Begin datum";
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(10, 71);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(198, 21);
            this.txtLocatie.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Locatie";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(10, 32);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(198, 21);
            this.txtNaam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 466);
            this.Controls.Add(this.groupEvenement);
            this.Controls.Add(this.listEvents);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.groupEvenement.ResumeLayout(false);
            this.groupEvenement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listEvents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupEvenement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCampingmap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtEind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}