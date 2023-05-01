namespace BankManagement.UI
{
    partial class FInGD
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
            this.components = new System.ComponentModel.Container();
            this.giaoDichBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new BankManagement.UI.bankDataSet();
            this.giaoDichTableAdapter = new BankManagement.UI.bankDataSetTableAdapters.GiaoDichTableAdapter();
            this.rpvTrans = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // giaoDichBindingSource
            // 
            this.giaoDichBindingSource.DataMember = "GiaoDich";
            this.giaoDichBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "bankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoDichTableAdapter
            // 
            this.giaoDichTableAdapter.ClearBeforeFill = true;
            // 
            // rpvTrans
            // 
            this.rpvTrans.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.Load += new System.EventHandler(this.FPrintTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private bankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource giaoDichBindingSource;
        private bankDataSetTableAdapters.GiaoDichTableAdapter giaoDichTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTrans;
    }
}