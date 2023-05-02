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

    public partial class FThanhToanTTD : Form
    {
        private TheTinDung theTinDung;
        public TheTinDung TheTinDung { get => theTinDung; set => theTinDung = value; }
        LaiSuat laiSuat = new LaiSuat();
        TinhLai tinhLai = new TinhLai();
        HoatDongLaiSuat hdLS = new HoatDongLaiSuat();
        TaiKhoan taiKhoan = new TaiKhoan();
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        ChuyenTien chuyenTien = new ChuyenTien();
        TheTinDungDAO theTinDungDAO = new TheTinDungDAO();
        TimeSpan lech;
        public FThanhToanTTD(TheTinDung theTinDung)
        {
            InitializeComponent();
            this.theTinDung = theTinDung;
        }

        private void FThanhToanTTD_Load(object sender, EventArgs e)
        {
            lblSTK.Text = theTinDung.SoTK.ToString();
            lblMST.Text = theTinDung.MaTTD.ToString();
            lblSoTien.Text = theTinDung.DaVay.ToString();
            lblNgayHan.Text = theTinDung.NgayHan.ToString("MM/dd/yyyy");
            lblNgayThanhToan.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lech = DateTime.Now - theTinDung.NgayHan;
            lblSaiLech.Text = lech.Days.ToString();
            laiSuat = hdLS.GetLaiSuat(laiSuat);
            double lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 1.5);
            lblLS.Text = lai + " %";
            double tienLai = tinhLai.TinhTienLai(theTinDung.DaVay, lai / 100, lech.Days / 30);
            lblPhat.Text = tienLai.ToString();
            lblTong.Text = tienLai + theTinDung.DaVay + "";
        }

        private void btnTatToan_Click(object sender, EventArgs e)
        {
            double tongTien;
            double.TryParse(lblTong.Text, out tongTien);
            taiKhoan = taiKhoanDAO.TimSoTK(theTinDung.SoTK);
            if (taiKhoan.Tien >= tongTien)
            {
                if (chuyenTien.GiaoDichTienGui(taiKhoan.SoTK, tongTien))
                {
                    chuyenTien.TaoGiaoDich(taiKhoan.SoTK, (int)TaiKhoanGD.nganhang, DateTime.Now, tongTien, (int)LoaiGiaoDich.travay);
                    theTinDung.NgayHan = DateTime.Now.AddMonths(1);
                    theTinDung.DaVay = 0;
                    if (lech.Days == 0 && theTinDung.DiemThe <= 100)
                        theTinDung.DiemThe += 1;
                    if (theTinDungDAO.CapNhatThe(theTinDung))
                        MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK);
                }
                  
            }

            else
                MessageBox.Show("Tài khoản không đủ tiền để thanh", "Thông báo", MessageBoxButtons.OK);

            this.Dispose();
        }
    }
}

