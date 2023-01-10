
namespace Carinderia_Kiosk_System.Proprietor
{
    partial class ucInventory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInventory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMenuBoard = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.pbFoodImage = new System.Windows.Forms.PictureBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cks_dbDataSet = new Carinderia_Kiosk_System.cks_dbDataSet();
            this.inventoryTableAdapter = new Carinderia_Kiosk_System.cks_dbDataSetTableAdapters.inventoryTableAdapter();
            this.pbSearchIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cks_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblInventory.Location = new System.Drawing.Point(19, 14);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(119, 28);
            this.lblInventory.TabIndex = 0;
            this.lblInventory.Text = "Inventory";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pbSearchIcon);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.flpButtons);
            this.panel1.Controls.Add(this.dgvInventory);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtUnit);
            this.panel1.Controls.Add(this.lblUnit);
            this.panel1.Controls.Add(this.pbFoodImage);
            this.panel1.Controls.Add(this.txtImagePath);
            this.panel1.Controls.Add(this.lblImage);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.lblUnitPrice);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.txtFoodName);
            this.panel1.Controls.Add(this.lblFoodName);
            this.panel1.Controls.Add(this.txtStockCode);
            this.panel1.Controls.Add(this.lblStockCode);
            this.panel1.Location = new System.Drawing.Point(18, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 901);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(858, 347);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 28);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnAdd);
            this.flpButtons.Controls.Add(this.btnEdit);
            this.flpButtons.Controls.Add(this.btnDelete);
            this.flpButtons.Controls.Add(this.btnClear);
            this.flpButtons.Controls.Add(this.btnMenuBoard);
            this.flpButtons.Controls.Add(this.btnRefresh);
            this.flpButtons.Location = new System.Drawing.Point(31, 338);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(671, 42);
            this.flpButtons.TabIndex = 24;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Image = global::Carinderia_Kiosk_System.Properties.Resources.add_20_x_20;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAdd.Size = new System.Drawing.Size(118, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Cornsilk;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.Image = global::Carinderia_Kiosk_System.Properties.Resources.update_20_x_20;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(127, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnEdit.Size = new System.Drawing.Size(111, 34);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Update";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Image = global::Carinderia_Kiosk_System.Properties.Resources.delete_20_x_20;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(244, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnDelete.Size = new System.Drawing.Size(108, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCyan;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Teal;
            this.btnClear.Image = global::Carinderia_Kiosk_System.Properties.Resources.clear_format_20_x_20;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(358, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnClear.Size = new System.Drawing.Size(99, 34);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMenuBoard
            // 
            this.btnMenuBoard.BackColor = System.Drawing.Color.Honeydew;
            this.btnMenuBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBoard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBoard.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnMenuBoard.Image = global::Carinderia_Kiosk_System.Properties.Resources.menu_items_green_20_x_20;
            this.btnMenuBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuBoard.Location = new System.Drawing.Point(463, 3);
            this.btnMenuBoard.Name = "btnMenuBoard";
            this.btnMenuBoard.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnMenuBoard.Size = new System.Drawing.Size(139, 34);
            this.btnMenuBoard.TabIndex = 26;
            this.btnMenuBoard.Text = "Menu Board";
            this.btnMenuBoard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuBoard.UseVisualStyleBackColor = false;
            this.btnMenuBoard.Click += new System.EventHandler(this.btnMenuBoard_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::Carinderia_Kiosk_System.Properties.Resources.refresh_20_x_20;
            this.btnRefresh.Location = new System.Drawing.Point(608, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 34);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Tag = "Reload";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvInventory
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(31, 398);
            this.dgvInventory.Name = "dgvInventory";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(1166, 483);
            this.dgvInventory.TabIndex = 23;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick_1);
            this.dgvInventory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInventory_RowHeaderMouseClick);
            this.dgvInventory.Click += new System.EventHandler(this.dgvInventory_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Azure;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(107, 233);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(211, 46);
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(1037, 144);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(101, 28);
            this.txtUnit.TabIndex = 18;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUnit.Location = new System.Drawing.Point(989, 147);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(42, 19);
            this.lblUnit.TabIndex = 17;
            this.lblUnit.Text = "Unit:";
            // 
            // pbFoodImage
            // 
            this.pbFoodImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbFoodImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoodImage.Location = new System.Drawing.Point(107, 38);
            this.pbFoodImage.Name = "pbFoodImage";
            this.pbFoodImage.Size = new System.Drawing.Size(211, 189);
            this.pbFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodImage.TabIndex = 16;
            this.pbFoodImage.TabStop = false;
            this.pbFoodImage.Click += new System.EventHandler(this.pbFoodImage_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagePath.Location = new System.Drawing.Point(882, 185);
            this.txtImagePath.Multiline = true;
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(256, 25);
            this.txtImagePath.TabIndex = 15;
            this.txtImagePath.Click += new System.EventHandler(this.txtImagePath_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblImage.Location = new System.Drawing.Point(762, 191);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(108, 19);
            this.lblImage.TabIndex = 14;
            this.lblImage.Text = "Image Path:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(882, 144);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(101, 28);
            this.txtQuantity.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuantity.Location = new System.Drawing.Point(789, 147);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(81, 19);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(882, 104);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(257, 28);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUnitPrice.Location = new System.Drawing.Point(784, 111);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(88, 19);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(882, 61);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(257, 29);
            this.cbCategory.TabIndex = 7;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategory.Location = new System.Drawing.Point(782, 69);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 19);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(465, 152);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(257, 102);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescription.Location = new System.Drawing.Point(351, 152);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 19);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.Location = new System.Drawing.Point(465, 106);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(257, 28);
            this.txtFoodName.TabIndex = 3;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFoodName.Location = new System.Drawing.Point(346, 113);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(111, 19);
            this.lblFoodName.TabIndex = 2;
            this.lblFoodName.Text = "Food Name:";
            // 
            // txtStockCode
            // 
            this.txtStockCode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtStockCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockCode.Location = new System.Drawing.Point(465, 64);
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.ReadOnly = true;
            this.txtStockCode.Size = new System.Drawing.Size(257, 28);
            this.txtStockCode.TabIndex = 1;
            // 
            // lblStockCode
            // 
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStockCode.Location = new System.Drawing.Point(345, 71);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(110, 19);
            this.lblStockCode.TabIndex = 0;
            this.lblStockCode.Text = "Stock Code:";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.cks_dbDataSet;
            // 
            // cks_dbDataSet
            // 
            this.cks_dbDataSet.DataSetName = "cks_dbDataSet";
            this.cks_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // pbSearchIcon
            // 
            this.pbSearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSearchIcon.BackColor = System.Drawing.SystemColors.Control;
            this.pbSearchIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSearchIcon.Image = global::Carinderia_Kiosk_System.Properties.Resources.search_blck_20_x_20;
            this.pbSearchIcon.Location = new System.Drawing.Point(1147, 347);
            this.pbSearchIcon.Name = "pbSearchIcon";
            this.pbSearchIcon.Size = new System.Drawing.Size(42, 28);
            this.pbSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSearchIcon.TabIndex = 21;
            this.pbSearchIcon.TabStop = false;
            this.pbSearchIcon.Click += new System.EventHandler(this.pbSearchIcon_Click);
            // 
            // ucInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInventory);
            this.Name = "ucInventory";
            this.Size = new System.Drawing.Size(1264, 965);
            this.Load += new System.EventHandler(this.ucInventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cks_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.TextBox txtStockCode;
        private System.Windows.Forms.Label lblStockCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pbFoodImage;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private cks_dbDataSet cks_dbDataSet;
        private cks_dbDataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnMenuBoard;
        private System.Windows.Forms.PictureBox pbSearchIcon;
    }
}
