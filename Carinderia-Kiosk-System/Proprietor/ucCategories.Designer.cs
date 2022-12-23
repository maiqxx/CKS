
namespace Carinderia_Kiosk_System.Proprietor
{
    partial class ucCategories
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
            this.Categories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Location = new System.Drawing.Point(447, 112);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(76, 17);
            this.Categories.TabIndex = 0;
            this.Categories.Text = "Categories";
            // 
            // ucCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Categories);
            this.Name = "ucCategories";
            this.Size = new System.Drawing.Size(1264, 965);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Categories;
    }
}
