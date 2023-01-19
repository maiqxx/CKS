
namespace Carinderia_Kiosk_System.Customer
{
    partial class OrderSummary
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
            this.pnlOrderSummaryContainer = new System.Windows.Forms.Panel();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvOrderList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDineOption = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblOrderNumValue = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblDTValue = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnFeedBack = new System.Windows.Forms.Button();
            this.pnlOrderSummaryContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrderSummaryContainer
            // 
            this.pnlOrderSummaryContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlOrderSummaryContainer.Controls.Add(this.lblTotalPayment);
            this.pnlOrderSummaryContainer.Controls.Add(this.label1);
            this.pnlOrderSummaryContainer.Controls.Add(this.lvOrderList);
            this.pnlOrderSummaryContainer.Controls.Add(this.lblDineOption);
            this.pnlOrderSummaryContainer.Controls.Add(this.lblCustomerName);
            this.pnlOrderSummaryContainer.Controls.Add(this.lblCust);
            this.pnlOrderSummaryContainer.Controls.Add(this.lblOrderNumValue);
            this.pnlOrderSummaryContainer.Controls.Add(this.lblOrderNum);
            this.pnlOrderSummaryContainer.Controls.Add(this.lblDTValue);
            this.pnlOrderSummaryContainer.Controls.Add(this.lblDateTime);
            this.pnlOrderSummaryContainer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlOrderSummaryContainer.Location = new System.Drawing.Point(133, 76);
            this.pnlOrderSummaryContainer.Name = "pnlOrderSummaryContainer";
            this.pnlOrderSummaryContainer.Size = new System.Drawing.Size(595, 558);
            this.pnlOrderSummaryContainer.TabIndex = 0;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(331, 525);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(234, 18);
            this.lblTotalPayment.TabIndex = 9;
            this.lblTotalPayment.Text = "0.00";
            this.lblTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Payment:";
            // 
            // lvOrderList
            // 
            this.lvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvOrderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvOrderList.GridLines = true;
            this.lvOrderList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvOrderList.HideSelection = false;
            this.lvOrderList.Location = new System.Drawing.Point(36, 95);
            this.lvOrderList.Name = "lvOrderList";
            this.lvOrderList.Size = new System.Drawing.Size(525, 417);
            this.lvOrderList.TabIndex = 7;
            this.lvOrderList.UseCompatibleStateImageBehavior = false;
            this.lvOrderList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 96;
            // 
            // lblDineOption
            // 
            this.lblDineOption.AutoSize = true;
            this.lblDineOption.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDineOption.Location = new System.Drawing.Point(414, 46);
            this.lblDineOption.Name = "lblDineOption";
            this.lblDineOption.Size = new System.Drawing.Size(92, 18);
            this.lblDineOption.TabIndex = 6;
            this.lblDineOption.Text = "DineOption";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(163, 46);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(123, 18);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "CustomerName";
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(17, 46);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(140, 20);
            this.lblCust.TabIndex = 4;
            this.lblCust.Text = "Customer\'s Name:";
            // 
            // lblOrderNumValue
            // 
            this.lblOrderNumValue.AutoSize = true;
            this.lblOrderNumValue.Location = new System.Drawing.Point(505, 15);
            this.lblOrderNumValue.Name = "lblOrderNumValue";
            this.lblOrderNumValue.Size = new System.Drawing.Size(85, 20);
            this.lblOrderNumValue.TabIndex = 3;
            this.lblOrderNumValue.Text = "OrderNum";
            this.lblOrderNumValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(414, 15);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(85, 20);
            this.lblOrderNum.TabIndex = 2;
            this.lblOrderNum.Text = "Order No.:";
            this.lblOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDTValue
            // 
            this.lblDTValue.AutoSize = true;
            this.lblDTValue.Location = new System.Drawing.Point(144, 15);
            this.lblDTValue.Name = "lblDTValue";
            this.lblDTValue.Size = new System.Drawing.Size(76, 20);
            this.lblDTValue.TabIndex = 1;
            this.lblDTValue.Text = "DateTime";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(17, 15);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(121, 20);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Date and Time: ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.ForestGreen;
            this.panel6.Controls.Add(this.lblOrderSummary);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(861, 48);
            this.panel6.TabIndex = 11;
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrderSummary.Location = new System.Drawing.Point(14, 13);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(179, 23);
            this.lblOrderSummary.TabIndex = 1;
            this.lblOrderSummary.Text = "ORDER SUMMARY";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(436, 665);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 50);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnFeedBack
            // 
            this.btnFeedBack.BackColor = System.Drawing.Color.LightYellow;
            this.btnFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFeedBack.Location = new System.Drawing.Point(241, 665);
            this.btnFeedBack.Name = "btnFeedBack";
            this.btnFeedBack.Size = new System.Drawing.Size(150, 50);
            this.btnFeedBack.TabIndex = 13;
            this.btnFeedBack.Text = "Feedback";
            this.btnFeedBack.UseVisualStyleBackColor = false;
            this.btnFeedBack.Click += new System.EventHandler(this.btnFeedBack_Click);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 793);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnFeedBack);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnlOrderSummaryContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrderSummary_Load);
            this.pnlOrderSummaryContainer.ResumeLayout(false);
            this.pnlOrderSummaryContainer.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderSummaryContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnFeedBack;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.ListView lvOrderList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblDineOption;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblOrderNumValue;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblDTValue;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label label1;
    }
}