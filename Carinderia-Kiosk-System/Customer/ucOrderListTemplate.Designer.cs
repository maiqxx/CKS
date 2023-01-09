
namespace Carinderia_Kiosk_System.Customer
{
    partial class ucOrderListTemplate
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
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.numericTxtQuantity = new System.Windows.Forms.NumericUpDown();
            this.pbRemoveItem = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericTxtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveItem)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(15, 17);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(101, 19);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "FoodName";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(15, 44);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(68, 19);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "UnitPrice";
            // 
            // numericTxtQuantity
            // 
            this.numericTxtQuantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTxtQuantity.Location = new System.Drawing.Point(149, 35);
            this.numericTxtQuantity.Name = "numericTxtQuantity";
            this.numericTxtQuantity.Size = new System.Drawing.Size(113, 28);
            this.numericTxtQuantity.TabIndex = 3;
            this.numericTxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbRemoveItem
            // 
            this.pbRemoveItem.Image = global::Carinderia_Kiosk_System.Properties.Resources.delete_20_x_20;
            this.pbRemoveItem.Location = new System.Drawing.Point(310, 26);
            this.pbRemoveItem.Name = "pbRemoveItem";
            this.pbRemoveItem.Size = new System.Drawing.Size(51, 47);
            this.pbRemoveItem.TabIndex = 4;
            this.pbRemoveItem.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(-65, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(523, 87);
            this.panel4.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(186, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(132, 28);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "UnitPrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "FoodName";
            // 
            // ucOrderListTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pbRemoveItem);
            this.Controls.Add(this.numericTxtQuantity);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblFoodName);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucOrderListTemplate";
            this.Size = new System.Drawing.Size(505, 342);
            ((System.ComponentModel.ISupportInitialize)(this.numericTxtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveItem)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.NumericUpDown numericTxtQuantity;
        private System.Windows.Forms.PictureBox pbRemoveItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
