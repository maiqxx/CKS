
namespace Carinderia_Kiosk_System
{
    partial class StartUp
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSelectMode = new System.Windows.Forms.Label();
            this.pnlRole = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlLeftLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlRole.SuspendLayout();
            this.pnlLeftLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(816, 121);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(172, 37);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "WELCOME!";
            // 
            // lblSelectMode
            // 
            this.lblSelectMode.AutoSize = true;
            this.lblSelectMode.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectMode.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMode.ForeColor = System.Drawing.Color.Black;
            this.lblSelectMode.Location = new System.Drawing.Point(833, 258);
            this.lblSelectMode.Name = "lblSelectMode";
            this.lblSelectMode.Size = new System.Drawing.Size(126, 23);
            this.lblSelectMode.TabIndex = 5;
            this.lblSelectMode.Text = "SELECT ROLE:";
            // 
            // pnlRole
            // 
            this.pnlRole.Controls.Add(this.button1);
            this.pnlRole.Controls.Add(this.btnStaff);
            this.pnlRole.Controls.Add(this.btnAdmin);
            this.pnlRole.Location = new System.Drawing.Point(698, 284);
            this.pnlRole.Name = "pnlRole";
            this.pnlRole.Size = new System.Drawing.Size(391, 244);
            this.pnlRole.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(110, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "CUSTOMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Black;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Location = new System.Drawing.Point(110, 94);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(180, 50);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "STAFF";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Black;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(110, 26);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(180, 50);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pnlLeftLogo
            // 
            this.pnlLeftLogo.BackgroundImage = global::Carinderia_Kiosk_System.Properties.Resources.blue_wooden_bg;
            this.pnlLeftLogo.Controls.Add(this.pbLogo);
            this.pnlLeftLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftLogo.Name = "pnlLeftLogo";
            this.pnlLeftLogo.Size = new System.Drawing.Size(632, 706);
            this.pnlLeftLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Carinderia_Kiosk_System.Properties.Resources.Blue_Simple_Restaurant_Logo_v1_1;
            this.pbLogo.Location = new System.Drawing.Point(114, 195);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(392, 311);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 706);
            this.Controls.Add(this.pnlRole);
            this.Controls.Add(this.lblSelectMode);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlLeftLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlRole.ResumeLayout(false);
            this.pnlLeftLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSelectMode;
        private System.Windows.Forms.Panel pnlRole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnAdmin;
    }
}

