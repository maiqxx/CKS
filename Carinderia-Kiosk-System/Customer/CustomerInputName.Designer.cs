
namespace Carinderia_Kiosk_System.Customer
{
    partial class CustomerInputName
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtCustomerUniqueName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBackIcon = new System.Windows.Forms.PictureBox();
            this.btnProceedToOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Controls.Add(this.txtCustomerUniqueName);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(160, 189);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(469, 155);
            this.panel7.TabIndex = 16;
            // 
            // txtCustomerUniqueName
            // 
            this.txtCustomerUniqueName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerUniqueName.Location = new System.Drawing.Point(72, 78);
            this.txtCustomerUniqueName.Name = "txtCustomerUniqueName";
            this.txtCustomerUniqueName.Size = new System.Drawing.Size(333, 32);
            this.txtCustomerUniqueName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your name*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pbBackIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 60);
            this.panel1.TabIndex = 17;
            // 
            // pbBackIcon
            // 
            this.pbBackIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBackIcon.Image = global::Carinderia_Kiosk_System.Properties.Resources.Back_icon_White_20_x_20;
            this.pbBackIcon.Location = new System.Drawing.Point(3, 3);
            this.pbBackIcon.Name = "pbBackIcon";
            this.pbBackIcon.Size = new System.Drawing.Size(49, 50);
            this.pbBackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBackIcon.TabIndex = 18;
            this.pbBackIcon.TabStop = false;
            this.pbBackIcon.Click += new System.EventHandler(this.pbBackIcon_Click);
            // 
            // btnProceedToOrder
            // 
            this.btnProceedToOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnProceedToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceedToOrder.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedToOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProceedToOrder.Location = new System.Drawing.Point(425, 374);
            this.btnProceedToOrder.Name = "btnProceedToOrder";
            this.btnProceedToOrder.Size = new System.Drawing.Size(140, 56);
            this.btnProceedToOrder.TabIndex = 18;
            this.btnProceedToOrder.Text = "OK";
            this.btnProceedToOrder.UseVisualStyleBackColor = false;
            this.btnProceedToOrder.Click += new System.EventHandler(this.btnProceedToOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(232, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 56);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CustomerInputName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 567);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProceedToOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInputName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomerInputName_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtCustomerUniqueName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBackIcon;
        private System.Windows.Forms.Button btnProceedToOrder;
        private System.Windows.Forms.Button btnCancel;
    }
}