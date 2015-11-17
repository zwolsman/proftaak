namespace Toegangscontrole
{
    partial class frmPortier
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
            this.btBetaling = new System.Windows.Forms.Button();
            this.btReservering = new System.Windows.Forms.Button();
            this.btInschrijven = new System.Windows.Forms.Button();
            this.btAanmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBetaling
            // 
            this.btBetaling.Location = new System.Drawing.Point(12, 12);
            this.btBetaling.Name = "btBetaling";
            this.btBetaling.Size = new System.Drawing.Size(190, 23);
            this.btBetaling.TabIndex = 0;
            this.btBetaling.Text = "Betalingen bekijken";
            this.btBetaling.UseVisualStyleBackColor = true;
            this.btBetaling.Click += new System.EventHandler(this.btBetaling_Click);
            // 
            // btReservering
            // 
            this.btReservering.Location = new System.Drawing.Point(12, 41);
            this.btReservering.Name = "btReservering";
            this.btReservering.Size = new System.Drawing.Size(190, 23);
            this.btReservering.TabIndex = 1;
            this.btReservering.Text = "Reservering bekijken";
            this.btReservering.UseVisualStyleBackColor = true;
            this.btReservering.Click += new System.EventHandler(this.btReservering_Click);
            // 
            // btInschrijven
            // 
            this.btInschrijven.Location = new System.Drawing.Point(12, 70);
            this.btInschrijven.Name = "btInschrijven";
            this.btInschrijven.Size = new System.Drawing.Size(190, 23);
            this.btInschrijven.TabIndex = 2;
            this.btInschrijven.Text = "Nieuwe inschrijving";
            this.btInschrijven.UseVisualStyleBackColor = true;
            this.btInschrijven.Click += new System.EventHandler(this.btInschrijven_Click);
            // 
            // btAanmelden
            // 
            this.btAanmelden.Location = new System.Drawing.Point(12, 99);
            this.btAanmelden.Name = "btAanmelden";
            this.btAanmelden.Size = new System.Drawing.Size(190, 23);
            this.btAanmelden.TabIndex = 3;
            this.btAanmelden.Text = "Aanmelden";
            this.btAanmelden.UseVisualStyleBackColor = true;
            this.btAanmelden.Click += new System.EventHandler(this.btAanmelden_Click);
            // 
            // frmPortier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 133);
            this.Controls.Add(this.btAanmelden);
            this.Controls.Add(this.btInschrijven);
            this.Controls.Add(this.btReservering);
            this.Controls.Add(this.btBetaling);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPortier";
            this.Text = "frmPortier";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBetaling;
        private System.Windows.Forms.Button btReservering;
        private System.Windows.Forms.Button btInschrijven;
        private System.Windows.Forms.Button btAanmelden;
    }
}