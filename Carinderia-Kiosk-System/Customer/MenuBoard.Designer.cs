
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbMenuCategoriesFilter = new Nevron.Nov.WinFormControls.NComboBoxControl();
            this.flpMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlFooditemDetailsContainer = new System.Windows.Forms.Panel();
            this.pnlUserControlFoodItemHolder = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucFoodItemDetails1 = new Carinderia_Kiosk_System.Customer.ucFoodItemDetails();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlFooditemDetailsContainer.SuspendLayout();
            this.pnlUserControlFoodItemHolder.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Location = new System.Drawing.Point(81, 19);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(65, 23);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(109, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(495, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            // 
            // cbMenuCategoriesFilter
            // 
            this.cbMenuCategoriesFilter.AutoSize = false;
            this.cbMenuCategoriesFilter.DesignTimeState = null;
            this.cbMenuCategoriesFilter.Location = new System.Drawing.Point(610, 76);
            this.cbMenuCategoriesFilter.Name = "cbMenuCategoriesFilter";
            this.cbMenuCategoriesFilter.Size = new System.Drawing.Size(173, 30);
            this.cbMenuCategoriesFilter.TabIndex = 5;
            // 
            // flpMenuItems
            // 
            this.flpMenuItems.AutoScroll = true;
            this.flpMenuItems.Location = new System.Drawing.Point(12, 112);
            this.flpMenuItems.Name = "flpMenuItems";
            this.flpMenuItems.Size = new System.Drawing.Size(831, 685);
            this.flpMenuItems.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(36, 81);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 21);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search";
            // 
            // pnlFooditemDetailsContainer
            // 
            this.pnlFooditemDetailsContainer.Controls.Add(this.pnlUserControlFoodItemHolder);
            this.pnlFooditemDetailsContainer.Controls.Add(this.pnlTitle);
            this.pnlFooditemDetailsContainer.Location = new System.Drawing.Point(849, 66);
            this.pnlFooditemDetailsContainer.Name = "pnlFooditemDetailsContainer";
            this.pnlFooditemDetailsContainer.Size = new System.Drawing.Size(539, 310);
            this.pnlFooditemDetailsContainer.TabIndex = 8;
            // 
            // pnlUserControlFoodItemHolder
            // 
            this.pnlUserControlFoodItemHolder.Controls.Add(this.ucFoodItemDetails1);
            this.pnlUserControlFoodItemHolder.Location = new System.Drawing.Point(3, 55);
            this.pnlUserControlFoodItemHolder.Name = "pnlUserControlFoodItemHolder";
            this.pnlUserControlFoodItemHolder.Size = new System.Drawing.Size(533, 252);
            this.pnlUserControlFoodItemHolder.TabIndex = 1;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Location = new System.Drawing.Point(4, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(532, 44);
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
            this.panel3.Location = new System.Drawing.Point(849, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 324);
            this.panel3.TabIndex = 9;
            // 
            // ucFoodItemDetails1
            // 
            this.ucFoodItemDetails1.AutoScroll = true;
            this.ucFoodItemDetails1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucFoodItemDetails1.Location = new System.Drawing.Point(1, 0);
            this.ucFoodItemDetails1.Name = "ucFoodItemDetails1";
            this.ucFoodItemDetails1.Size = new System.Drawing.Size(532, 252);
            this.ucFoodItemDetails1.TabIndex = 0;
            // 
            // MenuBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFooditemDetailsContainer);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.flpMenuItems);
            this.Controls.Add(this.cbMenuCategoriesFilter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlFooditemDetailsContainer.ResumeLayout(false);
            this.pnlUserControlFoodItemHolder.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.TextBox textBox1;
        private Nevron.Nov.WinFormControls.NComboBoxControl cbMenuCategoriesFilter;
        private System.Windows.Forms.FlowLayoutPanel flpMenuItems;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlFooditemDetailsContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlUserControlFoodItemHolder;
        private System.Windows.Forms.Label label1;
        private ucFoodItemDetails ucFoodItemDetails1;
    }
}