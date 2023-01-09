
namespace Carinderia_Kiosk_System.Customer
{
    partial class DineOption
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnTakeOut = new System.Windows.Forms.Button();
            this.btnDineIn = new System.Windows.Forms.Button();
            this.lblDineIn = new System.Windows.Forms.Label();
            this.lblTakeOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(645, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose a method in taking your order:";
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTakeOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTakeOut.Image = global::Carinderia_Kiosk_System.Properties.Resources.Take_Out_100_x_150;
            this.btnTakeOut.Location = new System.Drawing.Point(752, 368);
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnTakeOut.Size = new System.Drawing.Size(170, 200);
            this.btnTakeOut.TabIndex = 3;
            this.btnTakeOut.Text = "Take Out";
            this.btnTakeOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTakeOut.UseVisualStyleBackColor = false;
            this.btnTakeOut.Click += new System.EventHandler(this.btnTakeOut_Click);
            // 
            // btnDineIn
            // 
            this.btnDineIn.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDineIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDineIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDineIn.Image = global::Carinderia_Kiosk_System.Properties.Resources.Dine_In_100_x_150;
            this.btnDineIn.Location = new System.Drawing.Point(503, 368);
            this.btnDineIn.Name = "btnDineIn";
            this.btnDineIn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnDineIn.Size = new System.Drawing.Size(170, 200);
            this.btnDineIn.TabIndex = 2;
            this.btnDineIn.Text = "Dine In";
            this.btnDineIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDineIn.UseVisualStyleBackColor = false;
            this.btnDineIn.Click += new System.EventHandler(this.btnDineIn_Click);
            // 
            // lblDineIn
            // 
            this.lblDineIn.AutoSize = true;
            this.lblDineIn.Location = new System.Drawing.Point(556, 386);
            this.lblDineIn.Name = "lblDineIn";
            this.lblDineIn.Size = new System.Drawing.Size(56, 19);
            this.lblDineIn.TabIndex = 4;
            this.lblDineIn.Text = "Dine In";
            this.lblDineIn.Visible = false;
            // 
            // lblTakeOut
            // 
            this.lblTakeOut.AutoSize = true;
            this.lblTakeOut.Location = new System.Drawing.Point(808, 386);
            this.lblTakeOut.Name = "lblTakeOut";
            this.lblTakeOut.Size = new System.Drawing.Size(70, 19);
            this.lblTakeOut.TabIndex = 5;
            this.lblTakeOut.Text = "Take Out";
            this.lblTakeOut.Visible = false;
            // 
            // DineOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1382, 800);
            this.Controls.Add(this.btnTakeOut);
            this.Controls.Add(this.btnDineIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDineIn);
            this.Controls.Add(this.lblTakeOut);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DineOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDineIn;
        private System.Windows.Forms.Button btnTakeOut;
        private System.Windows.Forms.Label lblDineIn;
        private System.Windows.Forms.Label lblTakeOut;
    }
}