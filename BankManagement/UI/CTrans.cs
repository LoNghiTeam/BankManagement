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
        List<GiaoDich> giaoDiches = new List<GiaoDich>();

        public CTrans()
        {
            InitializeComponent();
            this.dtgvTrans.Size = new Size(Width, Height);
            HienThiDanhSach();
        }

        private void CTrans_Load(object sender, EventArgs e)
        {
            cbbLoaiGD.Items.Add("Toàn bộ giao dịch");
            cbbLoaiGD.Items.Add("Khoản vay");
            cbbLoaiGD.Items.Add("Gửi tiết kiệm");
            cbbLoaiGD.Items.Add("Tất toán tiết kiệm");
            cbbLoaiGD.Items.Add("Chuyển tiền");
            cbbLoaiGD.Items.Add("Rút tiền");
            cbbLoaiGD.Items.Add("Nạp tiền");
            cbbLoaiGD.Items.Add("Thanh toán nợ");
            cbbLoaiGD.SelectedItem = "Toàn bộ giao dịch";
            cbDate.Checked = false;
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
            if (string.IsNullOrWhiteSpace(option))
            {
                cbMaGD.Checked = true;
                option += " MaGD > 0 ";
            }
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
                option += " MaGD = " + tbxMaGD.Texts;
            }
            if (!string.IsNullOrWhiteSpace(tbxNgGui.Texts))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " NguoiGui = " + tbxNgGui.Texts;
            }
            if (!string.IsNullOrWhiteSpace(tbxNgNhan.Texts))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " NguoiNhan = " + tbxNgNhan.Texts;
            }
            if (!string.IsNullOrWhiteSpace(dpNgayGD.Value.ToString()) && cbDate.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " NgayGD = '" + dpNgayGD.Value + "'";
            }
            if (!string.IsNullOrWhiteSpace(tbxTienGD.Texts))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " Tien = " + tbxTienGD.Texts;
            }
            if (!string.IsNullOrWhiteSpace(cbbLoaiGD.Texts) && cbbLoaiGD.SelectedIndex != 0)
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                switch (cbbLoaiGD.SelectedIndex)
                {
                    case 1: //Khoan vay
                        option += " NguoiGui = -1 " + " AND NguoiNhan > 0 ";
                        break;
                    case 2: //Gui tiet kiem
                        option += " NguoiGui > 0 " + " AND NguoiNhan = -2 ";
                        break;
                    case 3: //Tat toan tiet kiemm
                        option += " NguoiGui = -2 " + " AND NguoiNhan > 0 ";
                        break;
                    case 4: //Chuyen tien
                        option += " NguoiGui > 0 " + " AND NguoiNhan > 0 ";
                        break;
                    case 5: //Rut tien
                        option += " NguoiGui > 0 " + " AND NguoiNhan = 0 ";
                        break;
                    case 6: //Nap tien
                        option += " NguoiGui = 0 " + " AND NguoiNhan > 0 ";
                        break;
                    case 7: //Thanh toan no
                        option += " NguoiGui > 0 " + " AND NguoiNhan = -1 ";
                        break;
                    default:
                        break;
                }
            }
            return option;
        }

        private void dtgvTrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvTrans.Rows[e.RowIndex];

                lbMaGD.Text = row.Cells[0].Value.ToString();

                flowLayoutPanel2.Enabled = true;
            }
        }
        /*ReportDataSource rs = new ReportDataSource();*/
        private void btnPrintAllGD_Click(object sender, EventArgs e)
        {
            giaoDiches.Clear();
            for (int i = 0; i < dtgvTrans.Rows.Count - 1; i++)
            {
                ThemGDVaoMayIn(i);
            }
            FPrintTrans print = new FPrintTrans(giaoDiches);
            print.ShowDialog();
        }
        private void ThemGDVaoMayIn(int i)
        {
            giaoDiches.Add(new GiaoDich
            {
                MaGD = int.Parse(dtgvTrans.Rows[i].Cells[0].Value.ToString()),
                NguoiGui = int.Parse(dtgvTrans.Rows[i].Cells[1].Value.ToString()),
                NguoiNhan = int.Parse(dtgvTrans.Rows[i].Cells[2].Value.ToString()),
                NgayGD = (DateTime)dtgvTrans.Rows[i].Cells[3].Value,
                Tien = double.Parse(dtgvTrans.Rows[i].Cells[4].Value.ToString())
            });
        }

        private void btnPrintGD_Click(object sender, EventArgs e)
        {
            giaoDiches.Clear();
            ThemGDVaoMayIn(dtgvTrans.CurrentCell.RowIndex);
            FPrintTrans print = new FPrintTrans(giaoDiches);
            print.ShowDialog();
        }

        private void cbbLoaiGD_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiGD.SelectedIndex != 0 && cbbLoaiGD.SelectedIndex <= 2)
            {
                btnDSLoaiGD.Text = btnDSLoaiGD.Tag + cbbLoaiGD.SelectedItem.ToString() + " chi tiết.";
                btnDSLoaiGD.Visible = true;
            }
            else
            {
                btnDSLoaiGD.Visible = false;
            }
        }

        private void btnDetailGD_Click(object sender, EventArgs e)
        {
            int index = dtgvTrans.CurrentCell.RowIndex;
            GiaoDich giaoDich = new GiaoDich(
                    int.Parse(dtgvTrans.Rows[index].Cells[0].Value.ToString()),
                    int.Parse(dtgvTrans.Rows[index].Cells[1].Value.ToString()),
                    int.Parse(dtgvTrans.Rows[index].Cells[2].Value.ToString()),
                    (DateTime)dtgvTrans.Rows[index].Cells[3].Value,
                    double.Parse(dtgvTrans.Rows[index].Cells[4].Value.ToString()),
                    int.Parse(dtgvTrans.Rows[index].Cells[5].Value.ToString())
            );
            FChiTietGD chiTietGD = new FChiTietGD(giaoDich);
            chiTietGD.ShowDialog();
        }

        private void btnDSLoaiGD_Click(object sender, EventArgs e)
        {
            if (cbbLoaiGD.SelectedIndex == 2)
            {
                FSoTietKiem chiTietGTK = new FSoTietKiem();
                chiTietGTK.ShowDialog();
            }
        }
    }
}
