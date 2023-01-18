
namespace Carinderia_Kiosk_System.Proprietor
{
    partial class ucTransactionList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnGo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pbReload = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReload)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(53, 86);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactions.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(1109, 698);
            this.dgvTransactions.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.dtpStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(3, 3);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(116, 23);
            this.dtpStartDate.TabIndex = 6;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter by Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.dtpEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(168, 3);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(117, 23);
            this.dtpEndDate.TabIndex = 8;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGo.Location = new System.Drawing.Point(291, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(73, 26);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "Apply";
            this.btnGo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(743, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search by Transaction No.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(950, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 26);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pbReload
            // 
            this.pbReload.BackColor = System.Drawing.Color.Transparent;
            this.pbReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbReload.Image = global::Carinderia_Kiosk_System.Properties.Resources.refresh_20_x_20;
            this.pbReload.Location = new System.Drawing.Point(370, 3);
            this.pbReload.Name = "pbReload";
            this.pbReload.Size = new System.Drawing.Size(23, 26);
            this.pbReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbReload.TabIndex = 13;
            this.pbReload.TabStop = false;
            this.pbReload.Click += new System.EventHandler(this.pbReload_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.9645F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0355F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbReload, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpEndDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpStartDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1109, 32);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ucTransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTransactions);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucTransactionList";
            this.Size = new System.Drawing.Size(1213, 815);
            this.Load += new System.EventHandler(this.ucTransactionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReload)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pbReload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
