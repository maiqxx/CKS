
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnFeedBack = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(151, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 577);
            this.panel1.TabIndex = 0;
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
            this.btnOK.Location = new System.Drawing.Point(426, 688);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 50);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // btnFeedBack
            // 
            this.btnFeedBack.BackColor = System.Drawing.Color.LightYellow;
            this.btnFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFeedBack.Location = new System.Drawing.Point(231, 688);
            this.btnFeedBack.Name = "btnFeedBack";
            this.btnFeedBack.Size = new System.Drawing.Size(150, 50);
            this.btnFeedBack.TabIndex = 13;
            this.btnFeedBack.Text = "Feedback";
            this.btnFeedBack.UseVisualStyleBackColor = false;
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 793);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnFeedBack);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnFeedBack;
    }
}