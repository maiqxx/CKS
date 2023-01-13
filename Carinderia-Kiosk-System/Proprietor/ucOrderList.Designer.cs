
namespace Carinderia_Kiosk_System.Proprietor.ManageOrdersControls
{
    partial class ucOrderList
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
            this.lblOrderlist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOrderlist
            // 
            this.lblOrderlist.AutoSize = true;
            this.lblOrderlist.Location = new System.Drawing.Point(457, 143);
            this.lblOrderlist.Name = "lblOrderlist";
            this.lblOrderlist.Size = new System.Drawing.Size(71, 19);
            this.lblOrderlist.TabIndex = 0;
            this.lblOrderlist.Text = "Order List";
            // 
            // ucOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOrderlist);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucOrderList";
            this.Size = new System.Drawing.Size(1213, 815);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderlist;
    }
}
