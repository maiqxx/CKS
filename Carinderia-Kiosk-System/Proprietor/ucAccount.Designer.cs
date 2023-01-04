
namespace Carinderia_Kiosk_System.Proprietor
{
    partial class ucAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAccountSettings = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStoreDescription = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblAccountSettings
            // 
            this.lblAccountSettings.AutoSize = true;
            this.lblAccountSettings.BackColor = System.Drawing.SystemColors.Control;
            this.lblAccountSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountSettings.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAccountSettings.Location = new System.Drawing.Point(12, 11);
            this.lblAccountSettings.Name = "lblAccountSettings";
            this.lblAccountSettings.Size = new System.Drawing.Size(174, 23);
            this.lblAccountSettings.TabIndex = 0;
            this.lblAccountSettings.Text = "Account Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(50, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 378);
            this.panel1.TabIndex = 1;
            // 
            // lblStoreDescription
            // 
            this.lblStoreDescription.AutoSize = true;
            this.lblStoreDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreDescription.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblStoreDescription.Location = new System.Drawing.Point(28, 463);
            this.lblStoreDescription.Name = "lblStoreDescription";
            this.lblStoreDescription.Size = new System.Drawing.Size(145, 19);
            this.lblStoreDescription.TabIndex = 2;
            this.lblStoreDescription.Text = "Store Description";
            this.lblStoreDescription.Click += new System.EventHandler(this.lblStoreDescription_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(50, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 428);
            this.panel2.TabIndex = 3;
            // 
            // ucAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblStoreDescription);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAccountSettings);
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(1264, 965);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStoreDescription;
        private System.Windows.Forms.Panel panel2;
    }
}
