
namespace Carinderia_Kiosk_System.Proprietor
{
    partial class ucOrders
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
            this.lblManageOrders = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblOrderList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageOrders
            // 
            this.lblManageOrders.AutoSize = true;
            this.lblManageOrders.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblManageOrders.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblManageOrders.Location = new System.Drawing.Point(19, 14);
            this.lblManageOrders.Name = "lblManageOrders";
            this.lblManageOrders.Size = new System.Drawing.Size(196, 28);
            this.lblManageOrders.TabIndex = 0;
            this.lblManageOrders.Text = "Manage Orders";
            this.lblManageOrders.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(73, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 155);
            this.panel1.TabIndex = 1;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(35, 291);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1198, 459);
            this.dgvOrders.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1014, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderList.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblOrderList.Location = new System.Drawing.Point(31, 250);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(95, 23);
            this.lblOrderList.TabIndex = 4;
            this.lblOrderList.Text = "Order List";
            // 
            // ucOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblManageOrders);
            this.Name = "ucOrders";
            this.Size = new System.Drawing.Size(1264, 965);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblOrderList;
    }
}
