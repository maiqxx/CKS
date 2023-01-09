
namespace Carinderia_Kiosk_System.Customer
{
    partial class Cart
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
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.pbBackToMenu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackToMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.lblCart);
            this.panel1.Controls.Add(this.pbBackToMenu);
            this.panel1.Controls.Add(this.pbCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 60);
            this.panel1.TabIndex = 1;
            // 
            // pbCart
            // 
            this.pbCart.Image = global::Carinderia_Kiosk_System.Properties.Resources.shopping_cart_white_25_x_25;
            this.pbCart.Location = new System.Drawing.Point(125, 7);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(55, 43);
            this.pbCart.TabIndex = 2;
            this.pbCart.TabStop = false;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCart.Location = new System.Drawing.Point(81, 19);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(61, 23);
            this.lblCart.TabIndex = 1;
            this.lblCart.Text = "CART";
            // 
            // pbBackToMenu
            // 
            this.pbBackToMenu.Image = global::Carinderia_Kiosk_System.Properties.Resources.Back_icon_White_20_x_20;
            this.pbBackToMenu.Location = new System.Drawing.Point(12, 7);
            this.pbBackToMenu.Name = "pbBackToMenu";
            this.pbBackToMenu.Size = new System.Drawing.Size(50, 50);
            this.pbBackToMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBackToMenu.TabIndex = 1;
            this.pbBackToMenu.TabStop = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackToMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.PictureBox pbBackToMenu;
    }
}