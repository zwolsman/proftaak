namespace MediaSysteem
{
    partial class frmStartup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEventInfo = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnSignin = new System.Windows.Forms.Button();
            this.comboEvents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblEventInfo);
            this.panel1.Location = new System.Drawing.Point(14, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 216);
            this.panel1.TabIndex = 2;
            // 
            // lblEventInfo
            // 
            this.lblEventInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventInfo.AutoEllipsis = true;
            this.lblEventInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblEventInfo.Location = new System.Drawing.Point(20, 20);
            this.lblEventInfo.Margin = new System.Windows.Forms.Padding(20);
            this.lblEventInfo.Name = "lblEventInfo";
            this.lblEventInfo.Size = new System.Drawing.Size(219, 176);
            this.lblEventInfo.TabIndex = 0;
            this.lblEventInfo.Text = "<<evenet info>>";
            this.lblEventInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(14, 380);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(125, 23);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.Location = new System.Drawing.Point(148, 380);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(125, 23);
            this.btnSignin.TabIndex = 4;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // comboEvents
            // 
            this.comboEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEvents.FormattingEnabled = true;
            this.comboEvents.Location = new System.Drawing.Point(95, 353);
            this.comboEvents.Name = "comboEvents";
            this.comboEvents.Size = new System.Drawing.Size(178, 21);
            this.comboEvents.TabIndex = 5;
            this.comboEvents.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select event";
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboEvents);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.panel1);
            this.Name = "frmStartup";
            this.Text = "Home";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnSignup, 0);
            this.Controls.SetChildIndex(this.btnSignin, 0);
            this.Controls.SetChildIndex(this.comboEvents, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEventInfo;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.ComboBox comboEvents;
        private System.Windows.Forms.Label label1;
    }
}

