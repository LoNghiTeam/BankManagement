using BankManagement.DAO;
using BankManagement.Model;
using BankManagement.UI;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BankManagement
{
    public partial class CTrans : UserControl
    {
        GiaoDichDAO gdDAO = new GiaoDichDAO();
        public CTrans()
        {
            InitializeComponent();
            this.dtgvTrans.Size = new Size(Width, Height);
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            this.dtgvTrans.DataSource = gdDAO.LayDanhSachGD();
        }
        public void TimKiemGD(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                HienThiDanhSach();
            }
            else
            {
                string option = "";
                option += AddORSql(option);
                if (string.IsNullOrWhiteSpace(option))
                {
                    cbMaGD.Checked = true;
                    option += " MaGD LIKE '{0}' ";
                }
                dtgvTrans.DataSource = gdDAO.TimKiemGDCB(text, option);
            }
        }
        
        public string AddORSql(string option)
        {
            if (cbMaGD.Checked)
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += "OR";
                }
                option += " MaGD LIKE '{0}' ";
            }
            if (cbNgGui.Checked)
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += "OR";
                }
                option += " NguoiGui LIKE '{0}' ";
            }
            if (cbNgNhan.Checked)
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += "OR";
                }
                option += " NguoiNhan LIKE '{0}' ";
            }
            if (cbTien.Checked)
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += "OR";
                }
                option += " Tien LIKE '{0}' ";
            }
            return option;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string option = "";
            option += AddAndSql(option);
            dtgvTrans.DataSource = gdDAO.TimKiemGDNC(option);
        }
        public string AddAndSql(string option)
        {
            if (!string.IsNullOrWhiteSpace(tbxMaGD.Texts))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " MaGD = "+tbxMaGD.Texts;
            }
            if (!string.IsNullOrWhiteSpace(tbxNgGui.Texts))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " NguoiGui = "+tbxNgGui.Texts;
            }
            if (!string.IsNullOrWhiteSpace(tbxNgNhan.Texts))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " NguoiNhan = "+tbxNgNhan.Texts;
            }
            if (!string.IsNullOrWhiteSpace(dpNgayGD.Value.ToString()) && cbDate.Checked==true)
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " NgayGD = '"+dpNgayGD.Value+"'";
            }
            if (!string.IsNullOrWhiteSpace(tbxTienGD.Texts))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " Tien = "+tbxTienGD.Texts;
            }
            return option;
        }

        private void dtgvTrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvTrans.Rows[e.RowIndex];

                lbMaGD.Text = row.Cells[0].Value.ToString();

                panel2.Enabled = true;
            }
        }
        ReportDataSource rs = new ReportDataSource();
        private void btnPrintAllGD_Click(object sender, EventArgs e)
        {
            List<GiaoDich> giaoDiches = new List<GiaoDich>();
            giaoDiches.Clear();
            for( int i  = 0; i < dtgvTrans.Rows.Count - 1; i++)
            {
                giaoDiches.Add(new GiaoDich
                {
                    MaGD =int.Parse(dtgvTrans.Rows[i].Cells[0].Value.ToString()),
                    NguoiGui = int.Parse(dtgvTrans.Rows[i].Cells[1].Value.ToString()),
                    NguoiNhan = int.Parse(dtgvTrans.Rows[i].Cells[2].Value.ToString()),
                    NgayGD = (DateTime)dtgvTrans.Rows[i].Cells[3].Value,
                    Tien = double.Parse(dtgvTrans.Rows[i].Cells[4].Value.ToString())
                });
            }
            FPrintTrans print = new FPrintTrans(giaoDiches);
            print.ShowDialog();
        }
    }
}
