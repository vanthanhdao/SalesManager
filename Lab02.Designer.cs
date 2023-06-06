namespace Quanlyphongtro
{
    partial class Lab02
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.Tinh = new System.Windows.Forms.Label();
            this.txtNhan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(132, 54);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(100, 20);
            this.txtSoA.TabIndex = 0;
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(132, 92);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(100, 20);
            this.txtSoB.TabIndex = 1;
            // 
            // Tinh
            // 
            this.Tinh.AutoSize = true;
            this.Tinh.Location = new System.Drawing.Point(147, 9);
            this.Tinh.Name = "Tinh";
            this.Tinh.Size = new System.Drawing.Size(56, 13);
            this.Tinh.TabIndex = 2;
            this.Tinh.Text = "Nhan 2 so";
            this.Tinh.Click += new System.EventHandler(this.Tinh_Click);
            // 
            // txtNhan
            // 
            this.txtNhan.Location = new System.Drawing.Point(132, 130);
            this.txtNhan.Name = "txtNhan";
            this.txtNhan.Size = new System.Drawing.Size(100, 20);
            this.txtNhan.TabIndex = 3;
            this.txtNhan.TextChanged += new System.EventHandler(this.Multiplication);
            // 
            // Lab02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 288);
            this.Controls.Add(this.txtNhan);
            this.Controls.Add(this.Tinh);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Name = "Lab02";
            this.Text = "Lab02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label Tinh;
        private System.Windows.Forms.TextBox txtNhan;
    }
}