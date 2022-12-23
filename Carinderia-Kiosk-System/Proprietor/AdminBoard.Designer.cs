﻿
namespace Carinderia_Kiosk_System.Proprietor
{
    partial class AdminBoard
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUserControlContainer = new System.Windows.Forms.Panel();
            this.ucDashboard1 = new Carinderia_Kiosk_System.Proprietor.ucDashboard();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.ucOrders1 = new Carinderia_Kiosk_System.Proprietor.ucOrders();
            this.ucCategories1 = new Carinderia_Kiosk_System.Proprietor.ucCategories();
            this.ucInventory1 = new Carinderia_Kiosk_System.Proprietor.ucInventory();
            this.ucStaff1 = new Carinderia_Kiosk_System.Proprietor.ucStaff();
            this.ucAccount1 = new Carinderia_Kiosk_System.Proprietor.ucAccount();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlUserControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnDashboard);
            this.flowLayoutPanel1.Controls.Add(this.btnOrders);
            this.flowLayoutPanel1.Controls.Add(this.btnCategories);
            this.flowLayoutPanel1.Controls.Add(this.btnInventory);
            this.flowLayoutPanel1.Controls.Add(this.btnStaff);
            this.flowLayoutPanel1.Controls.Add(this.btnAccount);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(227, 1013);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(227, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 45);
            this.panel1.TabIndex = 1;
            // 
            // pnlUserControlContainer
            // 
            this.pnlUserControlContainer.Controls.Add(this.ucAccount1);
            this.pnlUserControlContainer.Controls.Add(this.ucStaff1);
            this.pnlUserControlContainer.Controls.Add(this.ucInventory1);
            this.pnlUserControlContainer.Controls.Add(this.ucCategories1);
            this.pnlUserControlContainer.Controls.Add(this.ucOrders1);
            this.pnlUserControlContainer.Controls.Add(this.ucDashboard1);
            this.pnlUserControlContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserControlContainer.Location = new System.Drawing.Point(227, 48);
            this.pnlUserControlContainer.Name = "pnlUserControlContainer";
            this.pnlUserControlContainer.Size = new System.Drawing.Size(1264, 965);
            this.pnlUserControlContainer.TabIndex = 2;
            this.pnlUserControlContainer.BackColorChanged += new System.EventHandler(this.button1_Click);
            // 
            // ucDashboard1
            // 
            this.ucDashboard1.Location = new System.Drawing.Point(0, 5);
            this.ucDashboard1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucDashboard1.Name = "ucDashboard1";
            this.ucDashboard1.Size = new System.Drawing.Size(1264, 965);
            this.ucDashboard1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Carinderia_Kiosk_System.Properties.Resources.user_icon_20_x_20;
            this.pictureBox3.Location = new System.Drawing.Point(1190, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Carinderia_Kiosk_System.Properties.Resources.user_icon_20_x_20;
            this.pictureBox2.Location = new System.Drawing.Point(1595, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carinderia_Kiosk_System.Properties.Resources.Dialcosta_Light_200_x_100;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = global::Carinderia_Kiosk_System.Properties.Resources.dashboard_20_x_20;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(4, 114);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(223, 60);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Image = global::Carinderia_Kiosk_System.Properties.Resources.orders_20x20;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(4, 182);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOrders.Size = new System.Drawing.Size(223, 60);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.Image = global::Carinderia_Kiosk_System.Properties.Resources.categories_20x20;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(4, 250);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(223, 60);
            this.btnCategories.TabIndex = 4;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Image = global::Carinderia_Kiosk_System.Properties.Resources.inventory_20_x_20;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(4, 318);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(223, 60);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Image = global::Carinderia_Kiosk_System.Properties.Resources.staff_m__20_x_20;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(4, 386);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(223, 60);
            this.btnStaff.TabIndex = 7;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Image = global::Carinderia_Kiosk_System.Properties.Resources.settings_gear_20_x_20;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(4, 454);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(223, 60);
            this.btnAccount.TabIndex = 8;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // ucOrders1
            // 
            this.ucOrders1.Location = new System.Drawing.Point(0, 5);
            this.ucOrders1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucOrders1.Name = "ucOrders1";
            this.ucOrders1.Size = new System.Drawing.Size(1264, 965);
            this.ucOrders1.TabIndex = 1;
            // 
            // ucCategories1
            // 
            this.ucCategories1.Location = new System.Drawing.Point(0, 0);
            this.ucCategories1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucCategories1.Name = "ucCategories1";
            this.ucCategories1.Size = new System.Drawing.Size(1264, 965);
            this.ucCategories1.TabIndex = 2;
            // 
            // ucInventory1
            // 
            this.ucInventory1.Location = new System.Drawing.Point(0, 0);
            this.ucInventory1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucInventory1.Name = "ucInventory1";
            this.ucInventory1.Size = new System.Drawing.Size(1264, 965);
            this.ucInventory1.TabIndex = 3;
            // 
            // ucStaff1
            // 
            this.ucStaff1.Location = new System.Drawing.Point(0, 0);
            this.ucStaff1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucStaff1.Name = "ucStaff1";
            this.ucStaff1.Size = new System.Drawing.Size(1264, 965);
            this.ucStaff1.TabIndex = 4;
            // 
            // ucAccount1
            // 
            this.ucAccount1.Location = new System.Drawing.Point(0, 0);
            this.ucAccount1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucAccount1.Name = "ucAccount1";
            this.ucAccount1.Size = new System.Drawing.Size(1264, 965);
            this.ucAccount1.TabIndex = 5;
            // 
            // AdminBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1491, 1013);
            this.Controls.Add(this.pnlUserControlContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlUserControlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlUserControlContainer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ucDashboard ucDashboard1;
        private ucAccount ucAccount1;
        private ucStaff ucStaff1;
        private ucInventory ucInventory1;
        private ucCategories ucCategories1;
        private ucOrders ucOrders1;
    }
}