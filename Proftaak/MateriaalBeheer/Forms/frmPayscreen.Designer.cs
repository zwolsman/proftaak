namespace MateriaalBeheer.Forms
{
    partial class frmPayscreen
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btPayNow = new System.Windows.Forms.Button();
            this.btAddBill = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblInfo.Location = new System.Drawing.Point(12, 27);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(234, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Payscreen";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.SizeChanged += new System.EventHandler(this.lblInfo_SizeChanged);
            // 
            // btPayNow
            // 
            this.btPayNow.Location = new System.Drawing.Point(12, 76);
            this.btPayNow.Name = "btPayNow";
            this.btPayNow.Size = new System.Drawing.Size(234, 23);
            this.btPayNow.TabIndex = 1;
            this.btPayNow.Text = "Nu betalen";
            this.btPayNow.UseVisualStyleBackColor = true;
            this.btPayNow.Click += new System.EventHandler(this.btPayNow_Click);
            // 
            // btAddBill
            // 
            this.btAddBill.Location = new System.Drawing.Point(12, 105);
            this.btAddBill.Name = "btAddBill";
            this.btAddBill.Size = new System.Drawing.Size(234, 23);
            this.btAddBill.TabIndex = 2;
            this.btAddBill.Text = "Toevoegen aan rekening";
            this.btAddBill.UseVisualStyleBackColor = true;
            this.btAddBill.Click += new System.EventHandler(this.btAddBill_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(12, 135);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(234, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Annuleren";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // frmPayscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 164);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAddBill);
            this.Controls.Add(this.btPayNow);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPayscreen";
            this.Text = "frmPayscreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btPayNow;
        private System.Windows.Forms.Button btAddBill;
        private System.Windows.Forms.Button btCancel;
    }
}