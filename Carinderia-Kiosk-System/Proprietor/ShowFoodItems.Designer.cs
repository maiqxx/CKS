
namespace Carinderia_Kiosk_System.Proprietor
{
    partial class ShowFoodItems
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
            this.cbMenuCategoriesFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchFoodItem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flpMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 60);
            this.panel1.TabIndex = 9;
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
            // 
            // cbMenuCategoriesFilter
            // 
            this.cbMenuCategoriesFilter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenuCategoriesFilter.FormattingEnabled = true;
            this.cbMenuCategoriesFilter.Location = new System.Drawing.Point(1115, 79);
            this.cbMenuCategoriesFilter.Name = "cbMenuCategoriesFilter";
            this.cbMenuCategoriesFilter.Size = new System.Drawing.Size(206, 27);
            this.cbMenuCategoriesFilter.TabIndex = 22;
            this.cbMenuCategoriesFilter.SelectedIndexChanged += new System.EventHandler(this.cbMenuCategoriesFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Search";
            // 
            // txtSearchFoodItem
            // 
            this.txtSearchFoodItem.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchFoodItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFoodItem.Location = new System.Drawing.Point(139, 79);
            this.txtSearchFoodItem.Multiline = true;
            this.txtSearchFoodItem.Name = "txtSearchFoodItem";
            this.txtSearchFoodItem.Size = new System.Drawing.Size(495, 30);
            this.txtSearchFoodItem.TabIndex = 20;
            this.txtSearchFoodItem.WordWrap = false;
            this.txtSearchFoodItem.TextChanged += new System.EventHandler(this.txtSearchFoodItem_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carinderia_Kiosk_System.Properties.Resources.filter_steelblue_20x20;
            this.pictureBox1.Location = new System.Drawing.Point(1079, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1071, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 18;
            // 
            // flpMenuItems
            // 
            this.flpMenuItems.AutoScroll = true;
            this.flpMenuItems.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpMenuItems.Location = new System.Drawing.Point(71, 121);
            this.flpMenuItems.Name = "flpMenuItems";
            this.flpMenuItems.Size = new System.Drawing.Size(1250, 608);
            this.flpMenuItems.TabIndex = 17;
            // 
            // ShowFoodItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.cbMenuCategoriesFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchFoodItem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flpMenuItems);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowFoodItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ShowFoodItems_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cbMenuCategoriesFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchFoodItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpMenuItems;
    }
}