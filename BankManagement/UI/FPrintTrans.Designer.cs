namespace BankManagement.UI
{
    partial class FPrintTrans
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
            this.rpvTrans = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvTrans
            // 
            this.rpvTrans.AutoScroll = true;
            this.rpvTrans.AutoSize = true;
            this.rpvTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvTrans.LocalReport.ReportEmbeddedResource = "BankManagement.RTrans.rdlc";
            this.rpvTrans.Location = new System.Drawing.Point(0, 0);
            this.rpvTrans.Name = "rpvTrans";
            this.rpvTrans.ServerReport.BearerToken = null;
            this.rpvTrans.Size = new System.Drawing.Size(800, 450);
            this.rpvTrans.TabIndex = 0;
            // 
            // FPrintTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvTrans);
            this.Name = "FPrintTrans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPrintTrans";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FPrintTrans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvTrans;
    }
}