
namespace Carinderia_Kiosk_System.Customer
{
    partial class PlacedOrderDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFeedback = new System.Windows.Forms.Button();
            this.btnOrderSummary = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordered Successfully!";
            // 
            // btnAddFeedback
            // 
            this.btnAddFeedback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFeedback.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFeedback.Location = new System.Drawing.Point(131, 234);
            this.btnAddFeedback.Name = "btnAddFeedback";
            this.btnAddFeedback.Size = new System.Drawing.Size(176, 45);
            this.btnAddFeedback.TabIndex = 2;
            this.btnAddFeedback.Text = "Add Feedback";
            this.btnAddFeedback.UseVisualStyleBackColor = false;
            this.btnAddFeedback.Click += new System.EventHandler(this.btnAddFeedback_Click);
            // 
            // btnOrderSummary
            // 
            this.btnOrderSummary.BackColor = System.Drawing.Color.Honeydew;
            this.btnOrderSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderSummary.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderSummary.Location = new System.Drawing.Point(326, 234);
            this.btnOrderSummary.Name = "btnOrderSummary";
            this.btnOrderSummary.Size = new System.Drawing.Size(176, 45);
            this.btnOrderSummary.TabIndex = 3;
            this.btnOrderSummary.Text = "Order Summary";
            this.btnOrderSummary.UseVisualStyleBackColor = false;
            this.btnOrderSummary.Click += new System.EventHandler(this.btnOrderSummary_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carinderia_Kiosk_System.Properties.Resources.check_icon_125x125;
            this.pictureBox1.Location = new System.Drawing.Point(249, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PlacedOrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(626, 323);
            this.Controls.Add(this.btnOrderSummary);
            this.Controls.Add(this.btnAddFeedback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlacedOrderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PlacedOrderDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFeedback;
        private System.Windows.Forms.Button btnOrderSummary;
    }
}