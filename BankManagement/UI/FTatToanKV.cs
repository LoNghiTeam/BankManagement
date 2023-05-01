using BankManagement.Controller;
using BankManagement.DAO;
using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement.UI
{
    public partial class FTatToanKV : Form
    {
        LaiSuat laiSuat = new LaiSuat();
        TinhLai tinhLai = new TinhLai();
        LaiSuatDAO laiSuatDAO = new LaiSuatDAO();
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        ChuyenTien chuyenTien = new ChuyenTien();
        KhoanVayDAO khoanVayDAO = new KhoanVayDAO();
        int tinhtrang = 0;

        private KhoanVay khoanVay;

        public FTatToanKV()
        {
            InitializeComponent();
        }

        internal FTatToanKV(KhoanVay khoanVay)
        {
            InitializeComponent();
            this.khoanVay = khoanVay;
        }

        private void FTatToanKV_Load(object sender, EventArgs e)
        {
            lblSoKV.Text = khoanVay.MaKV.ToString();
            lblSTK.Text = khoanVay.SoTK.ToString();
            lblNgayVay.Text = khoanVay.NgayVay.ToString();
            lblDaoHan.Text = khoanVay.NgayHan.ToString();
            lblMaLS.Text = khoanVay.MaLS.ToString();
            lblSoTien.Text = khoanVay.Tien.ToString();
            lblTT.Text = "Chưa tất toán";
            if (khoanVay.Loai == 1)
                lblLoai.Text = "Vay tín dụng";
            else
                lblLoai.Text = "Vay thế chấp";
            lblNgayTT.Text = DateTime.Now.ToString();
            TimeSpan thoiGianLech = DateTime.Now - khoanVay.NgayHan;
            int tongSoNgayLech = thoiGianLech.Days;
            TimeSpan thoiGianLT = khoanVay.NgayHan - khoanVay.NgayVay;
            int tongSoThangLT = (int)(thoiGianLT.TotalDays / 30.4375)-1;
            TimeSpan thoiGiantTT = DateTime.Now - khoanVay.NgayVay;
            int TongSoThangTT = (int)(thoiGiantTT.TotalDays / 30.4375);
            double tienTamTinh = TienTamTinh(tongSoThangLT, khoanVay.Tien, TongSoThangTT);
            lblTamTinh.Text = tienTamTinh.ToString();
            if (tongSoNgayLech > 0)
            {
                lblNgaySai.Text = "Trễ " + tongSoNgayLech + " ngày";
                lblPhat.Text = (tienTamTinh * 0.2).ToString();
                lblTongTien.Text = (tienTamTinh * 1.2).ToString();
            }
            else if (tongSoNgayLech < 0)
            {
                lblNgaySai.Text = "Sớm " + Math.Abs(tongSoNgayLech) + " ngày";
                lblPhat.Text = (tienTamTinh * 0.1).ToString();
                lblTongTien.Text = (tienTamTinh * 1.1).ToString();
                tinhtrang = 1;
            }
            else
            {
                lblNgaySai.Text = "Đúng ngày";
                lblTongTien.Text = lblTamTinh.Text;
                lblPhat.Text = "0";
                tinhtrang = 1;
            }
        }
        private double TienTamTinh(int thoigianLT, double tien, int thoigianTT)
        {
            laiSuat = GetLaiSuat(khoanVay.MaLS);
            double lai = -1;
            switch (thoigianLT)
            {
                case 1:
                    double a = laiSuat.LaiVay;
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 0.8 * laiSuat.TiLe);
                    return tien + tinhLai.TinhTienLai(tien, lai / 100, thoigianTT);
                    
                case 3:
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 0.85 * laiSuat.TiLe);
                    return tien + tinhLai.TinhTienLai(tien, lai / 100, thoigianTT);
                case 6:
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 0.9 * laiSuat.TiLe);
                    return tien + tinhLai.TinhTienLai(tien, lai / 100, thoigianTT);
                case 12:
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 1 * laiSuat.TiLe);
                    return tien + tinhLai.TinhTienLai(tien, lai / 100, thoigianTT);
                case 24:
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 1.1 * laiSuat.TiLe);
                    return tien + tinhLai.TinhTienLai(tien, lai / 100, thoigianTT);
                case 36:
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 1.2 * laiSuat.TiLe);
                    return tien + tinhLai.TinhTienLai(tien, lai / 100, thoigianTT);
            }
            return 0;
        }
        private LaiSuat GetLaiSuat(int maLS)
        {
            LaiSuat laiSuat = new LaiSuat();
            laiSuat = laiSuatDAO.find(maLS);
            if (laiSuat != null)
            { return laiSuat; }
            return null;
        }
        private void btnTatToan_Click(object sender, EventArgs e)
        {
            double tongTien;
            double.TryParse(lblTongTien.Text,out tongTien);
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan = taiKhoanDAO.TimSoTK(khoanVay.SoTK);
            if (taiKhoan.Tien >= tongTien)
            {
                if (chuyenTien.GiaoDichTienGui(taiKhoan.SoTK, tongTien))
                {
                    if (tinhtrang != 0)
                        taiKhoanDAO.CapNhatDiemTinDung(taiKhoan.DiemTD + 1, taiKhoan.SoTK);
                    else
                        taiKhoanDAO.CapNhatDiemTinDung(taiKhoan.DiemTD - 1, taiKhoan.SoTK);
                    khoanVayDAO.CapNhatTinhTrang(khoanVay.MaKV);
                    MessageBox.Show("Tất toán thành công", "Thông báo", MessageBoxButtons.OK);
                }
                    

            }

            else
                MessageBox.Show("Tài khoản không đủ tiền để tất toán", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
