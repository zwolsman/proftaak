﻿namespace Reserveer_Systeem
{
    partial class frmKaart
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
            this.picKaart = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPlek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picKaart)).BeginInit();
            this.SuspendLayout();
            // 
            // picKaart
            // 
            this.picKaart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picKaart.Image = global::Reserveer_Systeem.Properties.Resources.Map_Image;
            this.picKaart.Location = new System.Drawing.Point(12, 12);
            this.picKaart.Name = "picKaart";
            this.picKaart.Size = new System.Drawing.Size(478, 235);
            this.picKaart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKaart.TabIndex = 0;
            this.picKaart.TabStop = false;
            this.picKaart.Click += new System.EventHandler(this.picKaart_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(415, 253);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Volgende";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPlek
            // 
            this.lblPlek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlek.AutoSize = true;
            this.lblPlek.Location = new System.Drawing.Point(12, 258);
            this.lblPlek.Name = "lblPlek";
            this.lblPlek.Size = new System.Drawing.Size(122, 13);
            this.lblPlek.TabIndex = 8;
            this.lblPlek.Text = "Gekozen plek: geen";
            // 
            // frmKaart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 284);
            this.Controls.Add(this.lblPlek);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picKaart);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "frmKaart";
            this.Text = "Selecteer een plaats";
            ((System.ComponentModel.ISupportInitialize)(this.picKaart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picKaart;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPlek;
    }
}