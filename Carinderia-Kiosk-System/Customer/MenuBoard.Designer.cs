
namespace Carinderia_Kiosk_System.Customer
{
    partial class MenuBoard
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.flpMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFooditemDetailsContainer = new System.Windows.Forms.Panel();
            this.pnlUserControlFoodItemHolder = new System.Windows.Forms.Panel();
            this.lblPesoSign = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.NUPTxtQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPer = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.pbFoodImage = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpOrderListContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCurentOrder = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnGoToCart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchFoodItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMenuCategoriesFilter = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlFooditemDetailsContainer.SuspendLayout();
            this.pnlUserControlFoodItemHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPTxtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCurentOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pbCart);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 60);
            this.panel1.TabIndex = 0;
            // 
            // pbCart
            // 
            this.pbCart.Image = global::Carinderia_Kiosk_System.Properties.Resources.shopping_cart_white_25_x_25;
            this.pbCart.Location = new System.Drawing.Point(1306, 7);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(55, 43);
            this.pbCart.TabIndex = 2;
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Location = new System.Drawing.Point(81, 19);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(66, 23);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "MENU";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Carinderia_Kiosk_System.Properties.Resources.Diacosta_white_25_x_25;
            this.pbLogo.Location = new System.Drawing.Point(12, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(50, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // flpMenuItems
            // 
            this.flpMenuItems.AutoScroll = true;
            this.flpMenuItems.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpMenuItems.Location = new System.Drawing.Point(12, 112);
            this.flpMenuItems.Name = "flpMenuItems";
            this.flpMenuItems.Size = new System.Drawing.Size(831, 685);
            this.flpMenuItems.TabIndex = 6;
            this.flpMenuItems.Paint += new System.Windows.Forms.PaintEventHandler(this.flpMenuItems_Paint);
            // 
            // pnlFooditemDetailsContainer
            // 
            this.pnlFooditemDetailsContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlFooditemDetailsContainer.Controls.Add(this.pnlUserControlFoodItemHolder);
            this.pnlFooditemDetailsContainer.Controls.Add(this.pnlTitle);
            this.pnlFooditemDetailsContainer.Location = new System.Drawing.Point(849, 66);
            this.pnlFooditemDetailsContainer.Name = "pnlFooditemDetailsContainer";
            this.pnlFooditemDetailsContainer.Size = new System.Drawing.Size(539, 295);
            this.pnlFooditemDetailsContainer.TabIndex = 8;
            // 
            // pnlUserControlFoodItemHolder
            // 
            this.pnlUserControlFoodItemHolder.AutoScroll = true;
            this.pnlUserControlFoodItemHolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlUserControlFoodItemHolder.Controls.Add(this.lblPesoSign);
            this.pnlUserControlFoodItemHolder.Controls.Add(this.btnAddToCart);
            this.pnlUserControlFoodItemHolder.Controls.Add(this.NUPTxtQuantity);
            this.pnlUserControlFoodItemHolder.Controls.Add(this.lblDesc);
            this.pnlUserControlFoodItemHolder.Controls.Add(this.lblDescription);
            this.pnlUserControlFoodItemHolder.Controls.Add(this.lblUnit);
            this.pnlUserControlFoodItemHolder.Controls.Add(this.lblPer);
            this.pnlUserControlFoodItemHolder.Controls.Add(this.lblUnitPrice);
            this.pnlUserControlFoodItemHolder.Controls.Add(this.lblFoodName);
            this.pnlUserControlFoodItemHolder.Controls.Add(this.pbFoodImage);
            this.pnlUserControlFoodItemHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserControlFoodItemHolder.Location = new System.Drawing.Point(0, 44);
            this.pnlUserControlFoodItemHolder.Name = "pnlUserControlFoodItemHolder";
            this.pnlUserControlFoodItemHolder.Size = new System.Drawing.Size(539, 251);
            this.pnlUserControlFoodItemHolder.TabIndex = 1;
            // 
            // lblPesoSign
            // 
            this.lblPesoSign.AutoSize = true;
            this.lblPesoSign.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoSign.Location = new System.Drawing.Point(169, 44);
            this.lblPesoSign.Name = "lblPesoSign";
            this.lblPesoSign.Size = new System.Drawing.Size(21, 22);
            this.lblPesoSign.TabIndex = 18;
            this.lblPesoSign.Text = "₱";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Honeydew;
            this.btnAddToCart.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddToCart.Image = global::Carinderia_Kiosk_System.Properties.Resources.add_to_cart_green_25_x_25;
            this.btnAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.Location = new System.Drawing.Point(370, 99);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAddToCart.Size = new System.Drawing.Size(126, 38);
            this.btnAddToCart.TabIndex = 17;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // NUPTxtQuantity
            // 
            this.NUPTxtQuantity.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUPTxtQuantity.Location = new System.Drawing.Point(173, 103);
            this.NUPTxtQuantity.Name = "NUPTxtQuantity";
            this.NUPTxtQuantity.Size = new System.Drawing.Size(188, 30);
            this.NUPTxtQuantity.TabIndex = 16;
            this.NUPTxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(37, 174);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(280, 17);
            this.lblDesc.TabIndex = 15;
            this.lblDesc.Text = "Some text here that describes the food item...";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(15, 156);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 18);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(366, 44);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 21);
            this.lblUnit.TabIndex = 13;
            this.lblUnit.Text = "unit";
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.Location = new System.Drawing.Point(331, 44);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(38, 21);
            this.lblPer.TabIndex = 12;
            this.lblPer.Text = "per";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(185, 44);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(54, 22);
            this.lblUnitPrice.TabIndex = 11;
            this.lblUnitPrice.Text = "Price";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(169, 15);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(101, 19);
            this.lblFoodName.TabIndex = 10;
            this.lblFoodName.Text = "FoodName";
            // 
            // pbFoodImage
            // 
            this.pbFoodImage.Location = new System.Drawing.Point(18, 15);
            this.pbFoodImage.Name = "pbFoodImage";
            this.pbFoodImage.Size = new System.Drawing.Size(130, 130);
            this.pbFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodImage.TabIndex = 9;
            this.pbFoodImage.TabStop = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(539, 44);
            this.pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Food Item Details";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flpOrderListContainer);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pnlCurentOrder);
            this.panel3.Location = new System.Drawing.Point(849, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 371);
            this.panel3.TabIndex = 9;
            // 
            // flpOrderListContainer
            // 
            this.flpOrderListContainer.AutoScroll = true;
            this.flpOrderListContainer.BackColor = System.Drawing.SystemColors.Control;
            this.flpOrderListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOrderListContainer.Location = new System.Drawing.Point(0, 44);
            this.flpOrderListContainer.Name = "flpOrderListContainer";
            this.flpOrderListContainer.Size = new System.Drawing.Size(539, 289);
            this.flpOrderListContainer.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 38);
            this.panel2.TabIndex = 3;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(370, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(169, 38);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "0.00";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // pnlCurentOrder
            // 
            this.pnlCurentOrder.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlCurentOrder.Controls.Add(this.label2);
            this.pnlCurentOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurentOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlCurentOrder.Name = "pnlCurentOrder";
            this.pnlCurentOrder.Size = new System.Drawing.Size(539, 44);
            this.pnlCurentOrder.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current Orders";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.LightYellow;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheckOut.Location = new System.Drawing.Point(914, 753);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(150, 35);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnGoToCart
            // 
            this.btnGoToCart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGoToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToCart.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoToCart.Location = new System.Drawing.Point(1184, 753);
            this.btnGoToCart.Name = "btnGoToCart";
            this.btnGoToCart.Size = new System.Drawing.Size(150, 35);
            this.btnGoToCart.TabIndex = 11;
            this.btnGoToCart.Text = "Cart";
            this.btnGoToCart.UseVisualStyleBackColor = false;
            this.btnGoToCart.Click += new System.EventHandler(this.btnGoToCart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carinderia_Kiosk_System.Properties.Resources.filter_icon_green_20_x_20;
            this.pictureBox1.Location = new System.Drawing.Point(601, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchFoodItem
            // 
            this.txtSearchFoodItem.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchFoodItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFoodItem.Location = new System.Drawing.Point(85, 76);
            this.txtSearchFoodItem.Multiline = true;
            this.txtSearchFoodItem.Name = "txtSearchFoodItem";
            this.txtSearchFoodItem.Size = new System.Drawing.Size(495, 30);
            this.txtSearchFoodItem.TabIndex = 14;
            this.txtSearchFoodItem.WordWrap = false;
            this.txtSearchFoodItem.TextChanged += new System.EventHandler(this.txtSearchFoodItem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Search";
            // 
            // cbMenuCategoriesFilter
            // 
            this.cbMenuCategoriesFilter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenuCategoriesFilter.FormattingEnabled = true;
            this.cbMenuCategoriesFilter.Location = new System.Drawing.Point(637, 79);
            this.cbMenuCategoriesFilter.Name = "cbMenuCategoriesFilter";
            this.cbMenuCategoriesFilter.Size = new System.Drawing.Size(206, 27);
            this.cbMenuCategoriesFilter.TabIndex = 16;
            this.cbMenuCategoriesFilter.SelectedIndexChanged += new System.EventHandler(this.cbMenuCategoriesFilter_SelectedIndexChanged);
            // 
            // MenuBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.cbMenuCategoriesFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchFoodItem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGoToCart);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFooditemDetailsContainer);
            this.Controls.Add(this.flpMenuItems);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlFooditemDetailsContainer.ResumeLayout(false);
            this.pnlUserControlFoodItemHolder.ResumeLayout(false);
            this.pnlUserControlFoodItemHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPTxtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCurentOrder.ResumeLayout(false);
            this.pnlCurentOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.FlowLayoutPanel flpMenuItems;
        private System.Windows.Forms.Panel pnlFooditemDetailsContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlUserControlFoodItemHolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.NumericUpDown NUPTxtQuantity;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.PictureBox pbFoodImage;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.Panel pnlCurentOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnGoToCart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPesoSign;
        private System.Windows.Forms.FlowLayoutPanel flpOrderListContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchFoodItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMenuCategoriesFilter;
    }
}