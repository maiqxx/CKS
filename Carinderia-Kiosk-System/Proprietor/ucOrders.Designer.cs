
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnTransacts = new System.Windows.Forms.Button();
            this.pnlManageOrdersContainer = new System.Windows.Forms.Panel();
            this.ucTransactionList1 = new Carinderia_Kiosk_System.Proprietor.ucTransactionList();
            this.ucCancelledOrders1 = new Carinderia_Kiosk_System.Proprietor.ucCancelledOrders();
            this.ucCompletedOrders1 = new Carinderia_Kiosk_System.Proprietor.ucCompletedOrders();
            this.ucOrderList1 = new Carinderia_Kiosk_System.Proprietor.ucOrderList();
            this.btnFeedbacks = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlManageOrdersContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageOrders
            // 
            this.lblManageOrders.AutoSize = true;
            this.lblManageOrders.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblManageOrders.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblManageOrders.Location = new System.Drawing.Point(19, 15);
            this.lblManageOrders.Name = "lblManageOrders";
            this.lblManageOrders.Size = new System.Drawing.Size(196, 28);
            this.lblManageOrders.TabIndex = 0;
            this.lblManageOrders.Text = "Manage Orders";
            this.lblManageOrders.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 559F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.btnFeedbacks, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOrderList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTransacts, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 44);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnOrderList
            // 
            this.btnOrderList.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrderList.Location = new System.Drawing.Point(3, 3);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(144, 38);
            this.btnOrderList.TabIndex = 0;
            this.btnOrderList.Text = "Order List";
            this.btnOrderList.UseVisualStyleBackColor = false;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnTransacts
            // 
            this.btnTransacts.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTransacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransacts.Location = new System.Drawing.Point(153, 3);
            this.btnTransacts.Name = "btnTransacts";
            this.btnTransacts.Size = new System.Drawing.Size(161, 38);
            this.btnTransacts.TabIndex = 4;
            this.btnTransacts.Text = "Transaction List";
            this.btnTransacts.UseVisualStyleBackColor = false;
            this.btnTransacts.Click += new System.EventHandler(this.btnTransacts_Click);
            // 
            // pnlManageOrdersContainer
            // 
            this.pnlManageOrdersContainer.Controls.Add(this.ucTransactionList1);
            this.pnlManageOrdersContainer.Controls.Add(this.ucCancelledOrders1);
            this.pnlManageOrdersContainer.Controls.Add(this.ucCompletedOrders1);
            this.pnlManageOrdersContainer.Controls.Add(this.ucOrderList1);
            this.pnlManageOrdersContainer.Location = new System.Drawing.Point(21, 96);
            this.pnlManageOrdersContainer.Name = "pnlManageOrdersContainer";
            this.pnlManageOrdersContainer.Size = new System.Drawing.Size(1213, 815);
            this.pnlManageOrdersContainer.TabIndex = 3;
            // 
            // ucTransactionList1
            // 
            this.ucTransactionList1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucTransactionList1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTransactionList1.Location = new System.Drawing.Point(0, -3);
            this.ucTransactionList1.Name = "ucTransactionList1";
            this.ucTransactionList1.Size = new System.Drawing.Size(1213, 815);
            this.ucTransactionList1.TabIndex = 3;
            this.ucTransactionList1.Load += new System.EventHandler(this.ucTransactionList1_Load);
            // 
            // ucCancelledOrders1
            // 
            this.ucCancelledOrders1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCancelledOrders1.Location = new System.Drawing.Point(0, 0);
            this.ucCancelledOrders1.Name = "ucCancelledOrders1";
            this.ucCancelledOrders1.Size = new System.Drawing.Size(1213, 815);
            this.ucCancelledOrders1.TabIndex = 2;
            // 
            // ucCompletedOrders1
            // 
            this.ucCompletedOrders1.Location = new System.Drawing.Point(0, -1);
            this.ucCompletedOrders1.Name = "ucCompletedOrders1";
            this.ucCompletedOrders1.Size = new System.Drawing.Size(1213, 815);
            this.ucCompletedOrders1.TabIndex = 1;
            // 
            // ucOrderList1
            // 
            this.ucOrderList1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucOrderList1.Location = new System.Drawing.Point(4, 4);
            this.ucOrderList1.Name = "ucOrderList1";
            this.ucOrderList1.Size = new System.Drawing.Size(1213, 815);
            this.ucOrderList1.TabIndex = 0;
            // 
            // btnFeedbacks
            // 
            this.btnFeedbacks.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFeedbacks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeedbacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedbacks.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbacks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFeedbacks.Location = new System.Drawing.Point(320, 3);
            this.btnFeedbacks.Name = "btnFeedbacks";
            this.btnFeedbacks.Size = new System.Drawing.Size(159, 38);
            this.btnFeedbacks.TabIndex = 5;
            this.btnFeedbacks.Text = "Feedbacks";
            this.btnFeedbacks.UseVisualStyleBackColor = false;
            this.btnFeedbacks.Click += new System.EventHandler(this.btnFeedbacks_Click);
            // 
            // ucOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.pnlManageOrdersContainer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblManageOrders);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucOrders";
            this.Size = new System.Drawing.Size(1264, 1025);
            this.Load += new System.EventHandler(this.ucOrders_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlManageOrdersContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnTransacts;
        private System.Windows.Forms.Panel pnlManageOrdersContainer;
        private ucCompletedOrders ucCompletedOrders1;
        private ucOrderList ucOrderList1;
        private ucTransactionList ucTransactionList1;
        private ucCancelledOrders ucCancelledOrders1;
        private System.Windows.Forms.Button btnFeedbacks;
    }
}
