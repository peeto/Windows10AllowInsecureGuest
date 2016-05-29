namespace Windows10AllowInsecureGuest
{
    partial class frmAllowGuest
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
            this.radbtnControlStateOn = new System.Windows.Forms.RadioButton();
            this.radbtnControlStateOff = new System.Windows.Forms.RadioButton();
            this.labelState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radbtnControlStateOn
            // 
            this.radbtnControlStateOn.AutoSize = true;
            this.radbtnControlStateOn.Location = new System.Drawing.Point(212, 12);
            this.radbtnControlStateOn.Name = "radbtnControlStateOn";
            this.radbtnControlStateOn.Size = new System.Drawing.Size(39, 17);
            this.radbtnControlStateOn.TabIndex = 0;
            this.radbtnControlStateOn.TabStop = true;
            this.radbtnControlStateOn.Text = "On";
            this.radbtnControlStateOn.UseVisualStyleBackColor = true;
            this.radbtnControlStateOn.CheckedChanged += new System.EventHandler(this.radbtnControlStateOn_CheckedChanged);
            // 
            // radbtnControlStateOff
            // 
            this.radbtnControlStateOff.AutoSize = true;
            this.radbtnControlStateOff.Location = new System.Drawing.Point(212, 35);
            this.radbtnControlStateOff.Name = "radbtnControlStateOff";
            this.radbtnControlStateOff.Size = new System.Drawing.Size(39, 17);
            this.radbtnControlStateOff.TabIndex = 1;
            this.radbtnControlStateOff.TabStop = true;
            this.radbtnControlStateOff.Text = "Off";
            this.radbtnControlStateOff.UseVisualStyleBackColor = true;
            this.radbtnControlStateOff.CheckedChanged += new System.EventHandler(this.radbtnControlStateOff_CheckedChanged);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(4, 12);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(202, 13);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "Allow SMB insecure guest mode access?";
            // 
            // frmAllowGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 65);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.radbtnControlStateOff);
            this.Controls.Add(this.radbtnControlStateOn);
            this.Name = "frmAllowGuest";
            this.Text = "Allow Guest Mode Access";
            this.Load += new System.EventHandler(this.frmAllowGuest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radbtnControlStateOn;
        private System.Windows.Forms.RadioButton radbtnControlStateOff;
        private System.Windows.Forms.Label labelState;
    }
}

