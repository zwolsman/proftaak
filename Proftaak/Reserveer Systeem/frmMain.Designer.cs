namespace Reserveer_Systeem
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
            this.listEvents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioExisting = new System.Windows.Forms.RadioButton();
            this.radioNew = new System.Windows.Forms.RadioButton();
            this.lblEventInfo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDatum = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listEvents
            // 
            this.listEvents.FormattingEnabled = true;
            this.listEvents.Location = new System.Drawing.Point(15, 25);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(139, 225);
            this.listEvents.TabIndex = 0;
            this.listEvents.SelectedIndexChanged += new System.EventHandler(this.listEvents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecteer een eventement";
            // 
            // radioExisting
            // 
            this.radioExisting.AutoSize = true;
            this.radioExisting.Location = new System.Drawing.Point(160, 25);
            this.radioExisting.Name = "radioExisting";
            this.radioExisting.Size = new System.Drawing.Size(126, 17);
            this.radioExisting.TabIndex = 2;
            this.radioExisting.Text = "Bestaand account";
            this.radioExisting.UseVisualStyleBackColor = true;
            // 
            // radioNew
            // 
            this.radioNew.AutoSize = true;
            this.radioNew.Checked = true;
            this.radioNew.Location = new System.Drawing.Point(160, 48);
            this.radioNew.Name = "radioNew";
            this.radioNew.Size = new System.Drawing.Size(107, 17);
            this.radioNew.TabIndex = 3;
            this.radioNew.TabStop = true;
            this.radioNew.Text = "Nieuw account";
            this.radioNew.UseVisualStyleBackColor = true;
            // 
            // lblEventInfo
            // 
            this.lblEventInfo.AutoEllipsis = true;
            this.lblEventInfo.BackColor = System.Drawing.SystemColors.Window;
            this.lblEventInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEventInfo.Location = new System.Drawing.Point(160, 134);
            this.lblEventInfo.Name = "lblEventInfo";
            this.lblEventInfo.Size = new System.Drawing.Size(330, 116);
            this.lblEventInfo.TabIndex = 5;
            this.lblEventInfo.Text = "Evenement informatie";
            this.lblEventInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(415, 253);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Volgende";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDatum
            // 
            this.btnDatum.Enabled = false;
            this.btnDatum.Location = new System.Drawing.Point(311, 253);
            this.btnDatum.Name = "btnDatum";
            this.btnDatum.Size = new System.Drawing.Size(98, 23);
            this.btnDatum.TabIndex = 8;
            this.btnDatum.Text = "Datum test";
            this.btnDatum.UseVisualStyleBackColor = true;
            this.btnDatum.Visible = false;
            this.btnDatum.Click += new System.EventHandler(this.button1_Click);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(160, 71);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(330, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Materialen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kaart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 284);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDatum);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblEventInfo);
            this.Controls.Add(this.radioNew);
            this.Controls.Add(this.radioExisting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEvents);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserveer Systeem";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioExisting;
        private System.Windows.Forms.RadioButton radioNew;
        private System.Windows.Forms.Label lblEventInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnDatum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

