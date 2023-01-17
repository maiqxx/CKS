
namespace Carinderia_Kiosk_System.Proprietor
{
    partial class ucFeedback
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
            this.flpFeedbacks = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbReload = new System.Windows.Forms.PictureBox();
            this.cbRating = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbReload)).BeginInit();
            this.SuspendLayout();
            // 
            // flpFeedbacks
            // 
            this.flpFeedbacks.AutoScroll = true;
            this.flpFeedbacks.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpFeedbacks.Location = new System.Drawing.Point(148, 62);
            this.flpFeedbacks.Name = "flpFeedbacks";
            this.flpFeedbacks.Size = new System.Drawing.Size(899, 753);
            this.flpFeedbacks.TabIndex = 0;
            this.flpFeedbacks.Paint += new System.Windows.Forms.PaintEventHandler(this.flpFeedbacks_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers\' Reviews";
            // 
            // pbReload
            // 
            this.pbReload.BackColor = System.Drawing.Color.Transparent;
            this.pbReload.Image = global::Carinderia_Kiosk_System.Properties.Resources.refresh_20_x_20;
            this.pbReload.Location = new System.Drawing.Point(192, 20);
            this.pbReload.Name = "pbReload";
            this.pbReload.Size = new System.Drawing.Size(22, 25);
            this.pbReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbReload.TabIndex = 19;
            this.pbReload.TabStop = false;
            this.pbReload.Click += new System.EventHandler(this.pbReload_Click);
            // 
            // cbRating
            // 
            this.cbRating.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Location = new System.Drawing.Point(881, 16);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(166, 27);
            this.cbRating.TabIndex = 20;
            this.cbRating.SelectedIndexChanged += new System.EventHandler(this.cbRating_SelectedIndexChanged);
            // 
            // ucFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.pbReload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpFeedbacks);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucFeedback";
            this.Size = new System.Drawing.Size(1213, 815);
            this.Load += new System.EventHandler(this.ucFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFeedbacks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbReload;
        private System.Windows.Forms.ComboBox cbRating;
    }
}
