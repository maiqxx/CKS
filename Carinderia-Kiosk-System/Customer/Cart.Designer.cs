﻿
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
            this.pbBackToMenu = new System.Windows.Forms.PictureBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.flpOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.gbDineOption = new System.Windows.Forms.GroupBox();
            this.checkBoxTakeOut = new System.Windows.Forms.CheckBox();
            this.checkBoxDineIn = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackToMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flpOrders.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbDineOption.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pbBackToMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 64);
            this.panel1.TabIndex = 1;
            // 
            // pbBackToMenu
            // 
            this.pbBackToMenu.Image = global::Carinderia_Kiosk_System.Properties.Resources.Back_icon_White_20_x_20;
            this.pbBackToMenu.Location = new System.Drawing.Point(24, 20);
            this.pbBackToMenu.Name = "pbBackToMenu";
            this.pbBackToMenu.Size = new System.Drawing.Size(34, 27);
            this.pbBackToMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBackToMenu.TabIndex = 1;
            this.pbBackToMenu.TabStop = false;
            this.pbBackToMenu.Click += new System.EventHandler(this.pbBackToMenu_Click);
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCart.Location = new System.Drawing.Point(14, 13);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(61, 23);
            this.lblCart.TabIndex = 1;
            this.lblCart.Text = "CART";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.LightYellow;
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackToMenu.Location = new System.Drawing.Point(54, 251);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(150, 50);
            this.btnBackToMenu.TabIndex = 11;
            this.btnBackToMenu.Text = "Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlaceOrder.Location = new System.Drawing.Point(249, 251);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(150, 50);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flpOrders);
            this.panel2.Location = new System.Drawing.Point(24, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 671);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lblTotalPrice);
            this.panel3.Controls.Add(this.lblTotalPayment);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 600);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 71);
            this.panel3.TabIndex = 9;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPrice.Location = new System.Drawing.Point(490, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(164, 71);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "0.00";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPayment.Location = new System.Drawing.Point(3, 23);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(153, 23);
            this.lblTotalPayment.TabIndex = 0;
            this.lblTotalPayment.Text = "Total Payment:";
            // 
            // flpOrders
            // 
            this.flpOrders.AutoScroll = true;
            this.flpOrders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpOrders.Controls.Add(this.panel6);
            this.flpOrders.Controls.Add(this.panel4);
            this.flpOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpOrders.Location = new System.Drawing.Point(0, 0);
            this.flpOrders.Name = "flpOrders";
            this.flpOrders.Size = new System.Drawing.Size(654, 597);
            this.flpOrders.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.ForestGreen;
            this.panel6.Controls.Add(this.lblCart);
            this.panel6.Controls.Add(this.pbCart);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(646, 48);
            this.panel6.TabIndex = 8;
            // 
            // pbCart
            // 
            this.pbCart.Image = global::Carinderia_Kiosk_System.Properties.Resources.shopping_cart_white_25_x_25;
            this.pbCart.Location = new System.Drawing.Point(66, 6);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(46, 37);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCart.TabIndex = 2;
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(3, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(646, 92);
            this.panel4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "UnitPrice";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(306, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 30);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "FoodName";
            // 
            // gbDineOption
            // 
            this.gbDineOption.Controls.Add(this.checkBoxTakeOut);
            this.gbDineOption.Controls.Add(this.checkBoxDineIn);
            this.gbDineOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDineOption.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDineOption.Location = new System.Drawing.Point(25, 29);
            this.gbDineOption.Name = "gbDineOption";
            this.gbDineOption.Size = new System.Drawing.Size(412, 164);
            this.gbDineOption.TabIndex = 14;
            this.gbDineOption.TabStop = false;
            this.gbDineOption.Text = "Choose a method in taking your order:";
            // 
            // checkBoxTakeOut
            // 
            this.checkBoxTakeOut.AutoSize = true;
            this.checkBoxTakeOut.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTakeOut.Location = new System.Drawing.Point(154, 101);
            this.checkBoxTakeOut.Name = "checkBoxTakeOut";
            this.checkBoxTakeOut.Size = new System.Drawing.Size(114, 27);
            this.checkBoxTakeOut.TabIndex = 1;
            this.checkBoxTakeOut.Tag = "Take Out";
            this.checkBoxTakeOut.Text = "Take Out";
            this.checkBoxTakeOut.UseVisualStyleBackColor = true;
            // 
            // checkBoxDineIn
            // 
            this.checkBoxDineIn.AutoSize = true;
            this.checkBoxDineIn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDineIn.Location = new System.Drawing.Point(154, 52);
            this.checkBoxDineIn.Name = "checkBoxDineIn";
            this.checkBoxDineIn.Size = new System.Drawing.Size(94, 27);
            this.checkBoxDineIn.TabIndex = 0;
            this.checkBoxDineIn.Tag = "Dine In";
            this.checkBoxDineIn.Text = "Dine In";
            this.checkBoxDineIn.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gbDineOption);
            this.panel5.Controls.Add(this.btnPlaceOrder);
            this.panel5.Controls.Add(this.btnBackToMenu);
            this.panel5.Location = new System.Drawing.Point(699, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(476, 671);
            this.panel5.TabIndex = 15;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cart_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackToMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flpOrders.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbDineOption.ResumeLayout(false);
            this.gbDineOption.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.PictureBox pbBackToMenu;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flpOrders;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.GroupBox gbDineOption;
        private System.Windows.Forms.CheckBox checkBoxTakeOut;
        private System.Windows.Forms.CheckBox checkBoxDineIn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}