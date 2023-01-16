
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelled = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnTransacts = new System.Windows.Forms.Button();
            this.pnlManageOrdersContainer = new System.Windows.Forms.Panel();
            this.ucTransactionList1 = new Carinderia_Kiosk_System.Proprietor.ucTransactionList();
            this.ucCancelledOrders1 = new Carinderia_Kiosk_System.Proprietor.ucCancelledOrders();
            this.ucCompletedOrders1 = new Carinderia_Kiosk_System.Proprietor.ucCompletedOrders();
            this.ucOrderList1 = new Carinderia_Kiosk_System.Proprietor.ucOrderList();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentNumOrders = new System.Windows.Forms.Label();
            this.lblCompletedOrders = new System.Windows.Forms.Label();
            this.lblCancelledOrders = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlManageOrdersContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblCancelledOrders);
            this.panel1.Controls.Add(this.lblCompletedOrders);
            this.panel1.Controls.Add(this.lblCurrentNumOrders);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(31, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 90);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 591F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancelled, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCompleted, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOrderList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTransacts, 4, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 141);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1216, 44);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnCancelled
            // 
            this.btnCancelled.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelled.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelled.Location = new System.Drawing.Point(303, 3);
            this.btnCancelled.Name = "btnCancelled";
            this.btnCancelled.Size = new System.Drawing.Size(144, 38);
            this.btnCancelled.TabIndex = 2;
            this.btnCancelled.Text = "Cancelled";
            this.btnCancelled.UseVisualStyleBackColor = false;
            this.btnCancelled.Click += new System.EventHandler(this.btnCancelled_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompleted.Location = new System.Drawing.Point(153, 3);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(144, 38);
            this.btnCompleted.TabIndex = 1;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = false;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
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
            this.btnTransacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransacts.Location = new System.Drawing.Point(1044, 3);
            this.btnTransacts.Name = "btnTransacts";
            this.btnTransacts.Size = new System.Drawing.Size(169, 38);
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
            this.pnlManageOrdersContainer.Location = new System.Drawing.Point(27, 192);
            this.pnlManageOrdersContainer.Name = "pnlManageOrdersContainer";
            this.pnlManageOrdersContainer.Size = new System.Drawing.Size(1213, 815);
            this.pnlManageOrdersContainer.TabIndex = 3;
            // 
            // ucTransactionList1
            // 
            this.ucTransactionList1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTransactionList1.Location = new System.Drawing.Point(-3, -3);
            this.ucTransactionList1.Name = "ucTransactionList1";
            this.ucTransactionList1.Size = new System.Drawing.Size(1213, 815);
            this.ucTransactionList1.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(98, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(275, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Completed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(489, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cancelled";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Carinderia_Kiosk_System.Properties.Resources.cancelled_orders;
            this.pictureBox3.Location = new System.Drawing.Point(418, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Carinderia_Kiosk_System.Properties.Resources.completed_orders;
            this.pictureBox2.Location = new System.Drawing.Point(204, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carinderia_Kiosk_System.Properties.Resources.current_orders;
            this.pictureBox1.Location = new System.Drawing.Point(27, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentNumOrders
            // 
            this.lblCurrentNumOrders.AutoSize = true;
            this.lblCurrentNumOrders.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentNumOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentNumOrders.Location = new System.Drawing.Point(98, 51);
            this.lblCurrentNumOrders.Name = "lblCurrentNumOrders";
            this.lblCurrentNumOrders.Size = new System.Drawing.Size(19, 19);
            this.lblCurrentNumOrders.TabIndex = 6;
            this.lblCurrentNumOrders.Text = "0";
            // 
            // lblCompletedOrders
            // 
            this.lblCompletedOrders.AutoSize = true;
            this.lblCompletedOrders.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCompletedOrders.Location = new System.Drawing.Point(275, 51);
            this.lblCompletedOrders.Name = "lblCompletedOrders";
            this.lblCompletedOrders.Size = new System.Drawing.Size(19, 19);
            this.lblCompletedOrders.TabIndex = 7;
            this.lblCompletedOrders.Text = "0";
            // 
            // lblCancelledOrders
            // 
            this.lblCancelledOrders.AutoSize = true;
            this.lblCancelledOrders.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelledOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCancelledOrders.Location = new System.Drawing.Point(489, 51);
            this.lblCancelledOrders.Name = "lblCancelledOrders";
            this.lblCancelledOrders.Size = new System.Drawing.Size(19, 19);
            this.lblCancelledOrders.TabIndex = 8;
            this.lblCancelledOrders.Text = "0";
            // 
            // ucOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.pnlManageOrdersContainer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblManageOrders);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucOrders";
            this.Size = new System.Drawing.Size(1264, 1025);
            this.Load += new System.EventHandler(this.ucOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlManageOrdersContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancelled;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnTransacts;
        private System.Windows.Forms.Panel pnlManageOrdersContainer;
        private ucCompletedOrders ucCompletedOrders1;
        private ucOrderList ucOrderList1;
        private ucTransactionList ucTransactionList1;
        private ucCancelledOrders ucCancelledOrders1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCancelledOrders;
        private System.Windows.Forms.Label lblCompletedOrders;
        private System.Windows.Forms.Label lblCurrentNumOrders;
    }
}
