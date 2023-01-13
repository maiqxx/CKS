
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
            this.pnlRole = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
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
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblWelcome.Location = new System.Drawing.Point(813, 175);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(172, 37);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "WELCOME!";
            // 
            // pnlRole
            // 
            this.pnlRole.Controls.Add(this.btnCustomer);
            this.pnlRole.Controls.Add(this.btnStaff);
            this.pnlRole.Controls.Add(this.btnAdmin);
            this.pnlRole.Location = new System.Drawing.Point(695, 251);
            this.pnlRole.Name = "pnlRole";
            this.pnlRole.Size = new System.Drawing.Size(422, 305);
            this.pnlRole.TabIndex = 6;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::Carinderia_Kiosk_System.Properties.Resources.customers_icon_40_x_40;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(110, 204);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCustomer.Size = new System.Drawing.Size(220, 80);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "CUSTOMER";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(12)))), ((int)(((byte)(172)))));
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::Carinderia_Kiosk_System.Properties.Resources.staff_icon_40_x_40;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(110, 112);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 40, 0);
            this.btnStaff.Size = new System.Drawing.Size(220, 80);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "STAFF";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::Carinderia_Kiosk_System.Properties.Resources.admin_icon_40_x_40;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(110, 18);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.btnAdmin.Size = new System.Drawing.Size(220, 80);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1164, 706);
            this.Controls.Add(this.pnlRole);
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
        private System.Windows.Forms.Panel pnlRole;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnCustomer;
    }
}

