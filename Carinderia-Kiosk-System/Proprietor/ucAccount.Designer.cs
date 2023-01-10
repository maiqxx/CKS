
namespace Carinderia_Kiosk_System.Proprietor
{
    partial class ucAccount
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
            this.lblAccountSettings = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUploadNew = new System.Windows.Forms.Button();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.lblStoreDescription = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpClosingTime = new System.Windows.Forms.DateTimePicker();
            this.dtpOpeningTime = new System.Windows.Forms.DateTimePicker();
            this.lblClosingTime = new System.Windows.Forms.Label();
            this.txtIOpeningTime = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblAccountCreated = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccountSettings
            // 
            this.lblAccountSettings.AutoSize = true;
            this.lblAccountSettings.BackColor = System.Drawing.Color.AliceBlue;
            this.lblAccountSettings.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAccountSettings.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAccountSettings.Location = new System.Drawing.Point(19, 14);
            this.lblAccountSettings.Name = "lblAccountSettings";
            this.lblAccountSettings.Size = new System.Drawing.Size(205, 28);
            this.lblAccountSettings.TabIndex = 0;
            this.lblAccountSettings.Text = "Account Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtContactNum);
            this.panel1.Controls.Add(this.lblContactNum);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.lblLastname);
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.lblFirstname);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUploadNew);
            this.panel1.Controls.Add(this.pbProfile);
            this.panel1.Location = new System.Drawing.Point(132, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 328);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Location = new System.Drawing.Point(446, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(412, 259);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(278, 30);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(310, 268);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(93, 21);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            // 
            // txtContactNum
            // 
            this.txtContactNum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtContactNum.Location = new System.Drawing.Point(412, 212);
            this.txtContactNum.Multiline = true;
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(278, 30);
            this.txtContactNum.TabIndex = 8;
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNum.Location = new System.Drawing.Point(282, 221);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(121, 21);
            this.lblContactNum.TabIndex = 7;
            this.lblContactNum.Text = "Contact No.:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Location = new System.Drawing.Point(412, 170);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(278, 30);
            this.txtLastName.TabIndex = 6;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(303, 179);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(100, 21);
            this.lblLastname.TabIndex = 5;
            this.lblLastname.Text = "LastName:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(412, 129);
            this.txtFirstname.Multiline = true;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(278, 30);
            this.txtFirstname.TabIndex = 4;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(305, 138);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(101, 21);
            this.lblFirstname.TabIndex = 3;
            this.lblFirstname.Text = "First Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(596, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUploadNew
            // 
            this.btnUploadNew.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUploadNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadNew.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadNew.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUploadNew.Location = new System.Drawing.Point(412, 55);
            this.btnUploadNew.Name = "btnUploadNew";
            this.btnUploadNew.Size = new System.Drawing.Size(157, 40);
            this.btnUploadNew.TabIndex = 1;
            this.btnUploadNew.Text = "Upload new photo";
            this.btnUploadNew.UseVisualStyleBackColor = false;
            this.btnUploadNew.Click += new System.EventHandler(this.btnUploadNew_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbProfile.Location = new System.Drawing.Point(286, 31);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(91, 86);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 0;
            this.pbProfile.TabStop = false;
            // 
            // lblStoreDescription
            // 
            this.lblStoreDescription.AutoSize = true;
            this.lblStoreDescription.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreDescription.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblStoreDescription.Location = new System.Drawing.Point(37, 18);
            this.lblStoreDescription.Name = "lblStoreDescription";
            this.lblStoreDescription.Size = new System.Drawing.Size(164, 23);
            this.lblStoreDescription.TabIndex = 2;
            this.lblStoreDescription.Text = "Store Description";
            this.lblStoreDescription.Click += new System.EventHandler(this.lblStoreDescription_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.dtpClosingTime);
            this.panel2.Controls.Add(this.dtpOpeningTime);
            this.panel2.Controls.Add(this.lblClosingTime);
            this.panel2.Controls.Add(this.txtIOpeningTime);
            this.panel2.Controls.Add(this.txtLocation);
            this.panel2.Controls.Add(this.lblLocation);
            this.panel2.Controls.Add(this.txtStoreName);
            this.panel2.Controls.Add(this.lblStoreName);
            this.panel2.Controls.Add(this.lblStoreDescription);
            this.panel2.Location = new System.Drawing.Point(132, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 236);
            this.panel2.TabIndex = 3;
            // 
            // dtpClosingTime
            // 
            this.dtpClosingTime.Location = new System.Drawing.Point(412, 189);
            this.dtpClosingTime.Name = "dtpClosingTime";
            this.dtpClosingTime.Size = new System.Drawing.Size(278, 22);
            this.dtpClosingTime.TabIndex = 18;
            // 
            // dtpOpeningTime
            // 
            this.dtpOpeningTime.Location = new System.Drawing.Point(412, 149);
            this.dtpOpeningTime.Name = "dtpOpeningTime";
            this.dtpOpeningTime.Size = new System.Drawing.Size(278, 22);
            this.dtpOpeningTime.TabIndex = 17;
            // 
            // lblClosingTime
            // 
            this.lblClosingTime.AutoSize = true;
            this.lblClosingTime.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblClosingTime.Location = new System.Drawing.Point(287, 190);
            this.lblClosingTime.Name = "lblClosingTime";
            this.lblClosingTime.Size = new System.Drawing.Size(116, 21);
            this.lblClosingTime.TabIndex = 16;
            this.lblClosingTime.Text = "Closing Time:";
            // 
            // txtIOpeningTime
            // 
            this.txtIOpeningTime.AutoSize = true;
            this.txtIOpeningTime.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtIOpeningTime.Location = new System.Drawing.Point(279, 150);
            this.txtIOpeningTime.Name = "txtIOpeningTime";
            this.txtIOpeningTime.Size = new System.Drawing.Size(129, 21);
            this.txtIOpeningTime.TabIndex = 15;
            this.txtIOpeningTime.Text = "Opening Time:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(412, 97);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(278, 30);
            this.txtLocation.TabIndex = 14;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblLocation.Location = new System.Drawing.Point(318, 106);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(88, 21);
            this.lblLocation.TabIndex = 13;
            this.lblLocation.Text = "Location:";
            // 
            // txtStoreName
            // 
            this.txtStoreName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreName.Location = new System.Drawing.Point(412, 51);
            this.txtStoreName.Multiline = true;
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(278, 30);
            this.txtStoreName.TabIndex = 12;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblStoreName.Location = new System.Drawing.Point(293, 60);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(113, 21);
            this.lblStoreName.TabIndex = 11;
            this.lblStoreName.Text = "Store Name:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSaveChanges.Location = new System.Drawing.Point(439, 671);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(148, 40);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblAccountCreated
            // 
            this.lblAccountCreated.AutoSize = true;
            this.lblAccountCreated.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountCreated.Location = new System.Drawing.Point(392, 805);
            this.lblAccountCreated.Name = "lblAccountCreated";
            this.lblAccountCreated.Size = new System.Drawing.Size(115, 17);
            this.lblAccountCreated.TabIndex = 17;
            this.lblAccountCreated.Text = "Account created:";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedAt.Location = new System.Drawing.Point(501, 805);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(75, 17);
            this.lblCreatedAt.TabIndex = 18;
            this.lblCreatedAt.Text = "Created At";
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.AutoSize = true;
            this.lblUpdatedAt.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatedAt.Location = new System.Drawing.Point(865, 805);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(78, 17);
            this.lblUpdatedAt.TabIndex = 20;
            this.lblUpdatedAt.Text = "Updated At";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdate.Location = new System.Drawing.Point(782, 805);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(90, 17);
            this.lblLastUpdate.TabIndex = 19;
            this.lblLastUpdate.Text = "Last updated:";
            // 
            // ucAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.lblUpdatedAt);
            this.Controls.Add(this.lblLastUpdate);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.lblAccountCreated);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAccountSettings);
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(1264, 965);
            this.Load += new System.EventHandler(this.ucAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStoreDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUploadNew;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.DateTimePicker dtpClosingTime;
        private System.Windows.Forms.DateTimePicker dtpOpeningTime;
        private System.Windows.Forms.Label lblClosingTime;
        private System.Windows.Forms.Label txtIOpeningTime;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblAccountCreated;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblUpdatedAt;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Button btnSave;
    }
}
