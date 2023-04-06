namespace BankManagement.UI
{
    partial class FSoTietKiem
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
            this.cSoTietKiem2 = new BankManagement.UI.CSoTietKiem();
            this.SuspendLayout();
            // 
            // cSoTietKiem2
            // 
            this.cSoTietKiem2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cSoTietKiem2.Location = new System.Drawing.Point(0, 0);
            this.cSoTietKiem2.Name = "cSoTietKiem2";
            this.cSoTietKiem2.Size = new System.Drawing.Size(1082, 494);
            this.cSoTietKiem2.TabIndex = 1;
            // 
            // FSoTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 494);
            this.Controls.Add(this.cSoTietKiem2);
            this.Name = "FSoTietKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết sổ tiết kiệm";
            this.Load += new System.EventHandler(this.FChiTietGTK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CSoTietKiem cSoTietKiem2;
    }
}