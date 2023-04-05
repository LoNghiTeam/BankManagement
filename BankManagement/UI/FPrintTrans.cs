using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagement.Model;
using Microsoft.Reporting.WinForms;

namespace BankManagement.UI
{
    public partial class FPrintTrans : Form
    {
        private List<GiaoDich> _data;
        public FPrintTrans(List<GiaoDich> data)
        {
            InitializeComponent();
            _data = data;
        }

        private void FPrintTrans_Load(object sender, EventArgs e)
        {
            ReportDataSource datasource = new ReportDataSource("DataSet1", _data);
            rpvTrans.LocalReport.DataSources.Clear();
            rpvTrans.LocalReport.DataSources.Add(datasource);
            rpvTrans.LocalReport.ReportPath = "RTrans.rdlc";
            rpvTrans.LocalReport.ReportEmbeddedResource = "RTrans.rdlc";
            this.rpvTrans.RefreshReport();
        }
    }
}
