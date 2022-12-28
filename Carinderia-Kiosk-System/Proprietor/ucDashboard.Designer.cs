
namespace Carinderia_Kiosk_System.Proprietor
{
    partial class ucDashboard
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
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlStoreDesc = new System.Windows.Forms.Panel();
            this.lblClosingTime = new System.Windows.Forms.Label();
            this.lblCT = new System.Windows.Forms.Label();
            this.lblOpeningTime = new System.Windows.Forms.Label();
            this.lblOT = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnEditStoreDesc = new System.Windows.Forms.Button();
            this.lblStoreDesc = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.scTimeCalendar = new System.Windows.Forms.SplitContainer();
            this.lblTime = new System.Windows.Forms.Label();
            this.timerCurrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlStoreDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scTimeCalendar)).BeginInit();
            this.scTimeCalendar.Panel1.SuspendLayout();
            this.scTimeCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(20, 23);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(116, 23);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // pnlStoreDesc
            // 
            this.pnlStoreDesc.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlStoreDesc.Controls.Add(this.lblClosingTime);
            this.pnlStoreDesc.Controls.Add(this.lblCT);
            this.pnlStoreDesc.Controls.Add(this.lblOpeningTime);
            this.pnlStoreDesc.Controls.Add(this.lblOT);
            this.pnlStoreDesc.Controls.Add(this.lblContactNum);
            this.pnlStoreDesc.Controls.Add(this.lblContact);
            this.pnlStoreDesc.Controls.Add(this.lblEmailAddress);
            this.pnlStoreDesc.Controls.Add(this.lblEmail);
            this.pnlStoreDesc.Controls.Add(this.lblLocation);
            this.pnlStoreDesc.Controls.Add(this.lblLoc);
            this.pnlStoreDesc.Controls.Add(this.lblStoreName);
            this.pnlStoreDesc.Controls.Add(this.pictureBox1);
            this.pnlStoreDesc.Controls.Add(this.splitter1);
            this.pnlStoreDesc.Controls.Add(this.btnEditStoreDesc);
            this.pnlStoreDesc.Controls.Add(this.lblStoreDesc);
            this.pnlStoreDesc.Controls.Add(this.lblLine);
            this.pnlStoreDesc.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStoreDesc.Location = new System.Drawing.Point(24, 49);
            this.pnlStoreDesc.Name = "pnlStoreDesc";
            this.pnlStoreDesc.Size = new System.Drawing.Size(953, 236);
            this.pnlStoreDesc.TabIndex = 1;
            // 
            // lblClosingTime
            // 
            this.lblClosingTime.AutoSize = true;
            this.lblClosingTime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosingTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClosingTime.Location = new System.Drawing.Point(746, 179);
            this.lblClosingTime.Name = "lblClosingTime";
            this.lblClosingTime.Size = new System.Drawing.Size(108, 19);
            this.lblClosingTime.TabIndex = 14;
            this.lblClosingTime.Text = "ClosingTime";
            // 
            // lblCT
            // 
            this.lblCT.AutoSize = true;
            this.lblCT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCT.Location = new System.Drawing.Point(629, 177);
            this.lblCT.Name = "lblCT";
            this.lblCT.Size = new System.Drawing.Size(116, 21);
            this.lblCT.TabIndex = 13;
            this.lblCT.Text = "Closing Time:";
            // 
            // lblOpeningTime
            // 
            this.lblOpeningTime.AutoSize = true;
            this.lblOpeningTime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpeningTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOpeningTime.Location = new System.Drawing.Point(233, 179);
            this.lblOpeningTime.Name = "lblOpeningTime";
            this.lblOpeningTime.Size = new System.Drawing.Size(118, 19);
            this.lblOpeningTime.TabIndex = 12;
            this.lblOpeningTime.Text = "OpeningTime";
            // 
            // lblOT
            // 
            this.lblOT.AutoSize = true;
            this.lblOT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOT.Location = new System.Drawing.Point(109, 177);
            this.lblOT.Name = "lblOT";
            this.lblOT.Size = new System.Drawing.Size(129, 21);
            this.lblOT.TabIndex = 11;
            this.lblOT.Text = "Opening Time:";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContactNum.Location = new System.Drawing.Point(746, 107);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(139, 19);
            this.lblContactNum.TabIndex = 10;
            this.lblContactNum.Text = "ContactNumber";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContact.Location = new System.Drawing.Point(629, 107);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(121, 21);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "Contact No.:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmailAddress.Location = new System.Drawing.Point(480, 109);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(53, 19);
            this.lblEmailAddress.TabIndex = 8;
            this.lblEmailAddress.Text = "Email";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(354, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(129, 21);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLocation.Location = new System.Drawing.Point(194, 109);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(78, 19);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoc.Location = new System.Drawing.Point(109, 107);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(88, 21);
            this.lblLoc.TabIndex = 5;
            this.lblLoc.Text = "Location:";
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStoreName.Location = new System.Drawing.Point(114, 84);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(124, 23);
            this.lblStoreName.TabIndex = 4;
            this.lblStoreName.Text = "Store Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carinderia_Kiosk_System.Properties.Resources.store_white_40_x_40;
            this.pictureBox1.Location = new System.Drawing.Point(53, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 154);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(953, 82);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // btnEditStoreDesc
            // 
            this.btnEditStoreDesc.BackColor = System.Drawing.Color.Transparent;
            this.btnEditStoreDesc.Image = global::Carinderia_Kiosk_System.Properties.Resources.edit_20_x_20;
            this.btnEditStoreDesc.Location = new System.Drawing.Point(198, 24);
            this.btnEditStoreDesc.Name = "btnEditStoreDesc";
            this.btnEditStoreDesc.Size = new System.Drawing.Size(34, 33);
            this.btnEditStoreDesc.TabIndex = 1;
            this.btnEditStoreDesc.UseVisualStyleBackColor = false;
            // 
            // lblStoreDesc
            // 
            this.lblStoreDesc.AutoSize = true;
            this.lblStoreDesc.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStoreDesc.Location = new System.Drawing.Point(31, 34);
            this.lblStoreDesc.Name = "lblStoreDesc";
            this.lblStoreDesc.Size = new System.Drawing.Size(164, 23);
            this.lblStoreDesc.TabIndex = 0;
            this.lblStoreDesc.Text = "Store Description";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLine.Location = new System.Drawing.Point(3, 129);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(945, 76);
            this.lblLine.TabIndex = 15;
            this.lblLine.Text = "_________________________________________________________________________________" +
    "_______________________\r\n\r\n\r\n\r\n";
            // 
            // scTimeCalendar
            // 
            this.scTimeCalendar.Location = new System.Drawing.Point(996, 49);
            this.scTimeCalendar.Name = "scTimeCalendar";
            this.scTimeCalendar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scTimeCalendar.Panel1
            // 
            this.scTimeCalendar.Panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.scTimeCalendar.Panel1.Controls.Add(this.lblTime);
            this.scTimeCalendar.Panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // scTimeCalendar.Panel2
            // 
            this.scTimeCalendar.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scTimeCalendar.Size = new System.Drawing.Size(245, 236);
            this.scTimeCalendar.SplitterDistance = 61;
            this.scTimeCalendar.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(79, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 23);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // timerCurrTime
            // 
            this.timerCurrTime.Tick += new System.EventHandler(this.timerCurrTime_Tick);
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scTimeCalendar);
            this.Controls.Add(this.pnlStoreDesc);
            this.Controls.Add(this.lblDashboard);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1264, 965);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.pnlStoreDesc.ResumeLayout(false);
            this.pnlStoreDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.scTimeCalendar.Panel1.ResumeLayout(false);
            this.scTimeCalendar.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTimeCalendar)).EndInit();
            this.scTimeCalendar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStoreDesc;
        private System.Windows.Forms.Button btnEditStoreDesc;
        private System.Windows.Forms.Label lblStoreDesc;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClosingTime;
        private System.Windows.Forms.Label lblCT;
        private System.Windows.Forms.Label lblOpeningTime;
        private System.Windows.Forms.Label lblOT;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.SplitContainer scTimeCalendar;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerCurrTime;
    }
}
