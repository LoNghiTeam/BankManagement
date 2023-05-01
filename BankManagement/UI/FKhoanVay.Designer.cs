namespace BankManagement.UI
{
    partial class FKhoanVay
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
            this.cKhoanVay1 = new BankManagement.UI.CKhoanVay();
            this.SuspendLayout();
            // 
            // cKhoanVay1
            // 
            this.cKhoanVay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cKhoanVay1.Location = new System.Drawing.Point(0, 0);
            this.cKhoanVay1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cKhoanVay1.Name = "cKhoanVay1";
            this.cKhoanVay1.Size = new System.Drawing.Size(659, 419);
            this.cKhoanVay1.TabIndex = 0;

            // 
            // FKhoanVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 419);
            this.Controls.Add(this.cKhoanVay1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FKhoanVay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FKhoanVay";
            this.Load += new System.EventHandler(this.FKhoanVay_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private CKhoanVay cKhoanVay1;
    }
}