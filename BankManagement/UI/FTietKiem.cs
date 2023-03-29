using BankManagement.Controller;
using BankManagement.DAO;
using BankManagement.Model;
using BankManagement.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class FTietKiem : Form
    {
        TaiKhoan taiKhoan = new TaiKhoan();
        LaiSuatDAO laiSuatDAO = new LaiSuatDAO();
        LaiSuat laiSuat = new LaiSuat();
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        GuiTien guiTien = new GuiTien();
        ChuyenTien chuyenTien = new ChuyenTien();
        
        int thoigian;
        double tien;
        public FTietKiem()
        {
            InitializeComponent();
        }

        private void FTietKiem_Load(object sender, EventArgs e)
        {
            btnGuiTietKiem.Enabled = false;
            cbThoiGian.Items.Add("1 tháng");
            cbThoiGian.Items.Add("3 tháng");
            cbThoiGian.Items.Add("6 tháng");
            cbThoiGian.Items.Add("12 tháng");
            cbThoiGian.Items.Add("24 tháng");
            cbThoiGian.Items.Add("36 tháng");
            cbThoiGian.Items.Add("Không thời hạn");
            lblRate.Text = string.Empty;
            if (logging.Taikhoan.IsAdmin < 1)
            {
                tbSoTK.Enabled = false;
            }
            tbSoTK.Texts = logging.Taikhoan.SoTK.ToString();
            lblTienHienCo.Text = logging.Taikhoan.Tien.ToString();
            lblTamTinh.Text = string.Empty;
        }

        private void tbSoTK__TextChanged(object sender, EventArgs e)
        {
            int soTK ;
            int.TryParse(tbSoTK.Texts.Trim(), out soTK);
            btnGuiTietKiem.Enabled = false;
            taiKhoan = taiKhoanDAO.TimSoTK(soTK);
            if (taiKhoan != null)
            {
                if (lblTamTinh.Text != "")
                {
                    btnGuiTietKiem.Enabled = true;
                }
                lblTienHienCo.Text = taiKhoan.Tien.ToString();

            }
            else
            {
                btnGuiTietKiem.Enabled = false;
                lblTienHienCo.Text = string.Empty;
            }
        }

        private void cbThoiGian_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            TinhLai tinhLai = new TinhLai();
            laiSuat = laiSuatDAO.find();
            double lai = 0;

            guiTien.TinhlaichangecbThoiGian(ref thoigian, cbThoiGian.Texts.ToString(), ref lai);
            lblRate.Text = lai.ToString() + "%";
            if(lblTamTinh.Text != ""){
                double.TryParse(tbTienGui.Texts.Trim(), out tien);
                tien += tinhLai.TinhTienLai(tien, lai / 100, thoigian);
                if (cbThoiGian.Texts == "Không thời hạn")
                    lblTamTinh.Text = tien.ToString() + "VNĐ (12 tháng)";
                else
                    lblTamTinh.Text = tien.ToString() + "VNĐ";
                btnGuiTietKiem.Enabled = true;
            }

        }

        private void tbTienGui__TextChanged(object sender, EventArgs e)
        {
            double lai;
            double.TryParse(tbTienGui.Texts.Trim(), out tien);

            if (cbThoiGian.Texts != "" && tien > 0 && tien <= taiKhoan.Tien)
            {
                string laiSuat = lblRate.Text;
                laiSuat = laiSuat.Remove(laiSuat.IndexOf('%'));
                double.TryParse(laiSuat, out lai);
                guiTien.TinhlaichangeTbGuiTien(cbThoiGian.Texts.ToString(), ref tien, ref lai);
                if (cbThoiGian.Texts == "Không thời hạn") 
                    lblTamTinh.Text = tien.ToString() + "VNĐ (12 tháng)";
                else
                    lblTamTinh.Text = tien.ToString() + "VNĐ";
                btnGuiTietKiem.Enabled = true;
            }
            else
            {
                lblTamTinh.Text = string.Empty;
                btnGuiTietKiem.Enabled = false;
            }
        }

        private void btnGuiTietKiem_Click(object sender, EventArgs e)
        {
            int soTK = -1;
            int.TryParse(tbSoTK.Texts.Trim(), out soTK);
            if (guiTien.TaoSoTietKiem(soTK,tbTenSo.Texts, DateTime.Now, thoigian, tien, laiSuat.MaLS))
                if (chuyenTien.GiaoDichTienGui(soTK, tien))
                    if (chuyenTien.TaoGiaoDich(soTK, -2, DateTime.Now, tien))
                        MessageBox.Show("Gửi tiết kiệm thành công", "Thông báo", MessageBoxButtons.OK);

            if (soTK == logging.Taikhoan.SoTK)
            {
                logging.Taikhoan.Tien -= tien;
            }
        }
    }
}
