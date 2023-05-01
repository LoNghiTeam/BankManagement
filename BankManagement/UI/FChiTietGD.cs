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
    public partial class FChiTietGD : Form
    {
        enum Loai{
            chuyentien = 1,
            nap = 2,
            rut = 3,
            vay = 4,
            gui = 5,
            travay = 6,
            ruttietkiem = 7,

        }
        private GiaoDich giaoDich;
        private GiaoDichDAO gdDAO = new GiaoDichDAO();
        public GiaoDich GiaoDich { get => giaoDich; set => giaoDich = value; }
        public FChiTietGD()
        {
            InitializeComponent();
        }
        public FChiTietGD(GiaoDich giaoDich)
        {
            InitializeComponent();
            this.GiaoDich = giaoDich;
        }
        private void FChiTietGD_Load(object sender, EventArgs e)
        {
            try
            {
                tbxMaGD.Texts = GiaoDich.MaGD.ToString();
                tbxTien.Texts = GiaoDich.Tien.ToString();
                dpNgayGD.Value = GiaoDich.NgayGD;
                tbxMaNgGui.Texts = GiaoDich.NguoiGui.ToString();
                tbxMaNgNhan.Texts = GiaoDich.NguoiNhan.ToString();
                switch (GiaoDich.Loai)
                {
                    case (int)Loai.ruttietkiem:
                         tbxLoaiGD.Texts = "Tất toán tiết kiệm";
                        tbxTenNgGui.Texts = "Ngân hàng đầu tư và phát triển nhóm 4";
                        tbxTenNgNhan.Texts = gdDAO.LayTenKH(GiaoDich.NguoiNhan);
                        break;
                    case (int)Loai.travay:
                        tbxLoaiGD.Texts = "Tất toán khoản vay";
                        tbxTenNgNhan.Texts = "Ngân hàng đầu tư và phát triển nhóm 4";
                        tbxTenNgGui.Texts = gdDAO.LayTenKH(GiaoDich.NguoiGui);
                        break;
                    case (int)Loai.gui:
                        tbxLoaiGD.Texts = "Gửi tiết kiệm";
                        tbxTenNgNhan.Texts = "Ngân hàng đầu tư và phát triển nhóm 4";
                        tbxTenNgGui.Texts = gdDAO.LayTenKH(GiaoDich.NguoiGui);
                        break;
                    case (int)Loai.vay:
                        tbxLoaiGD.Texts = "Vay tiền";
                        tbxTenNgGui.Texts = "Ngân hàng đầu tư và phát triển nhóm 4";
                        tbxTenNgNhan.Texts = gdDAO.LayTenKH(GiaoDich.NguoiNhan);
                        break;
                    case (int)Loai.rut:
                        tbxLoaiGD.Texts = "Rút tiền";
                        tbxTenNgNhan.Texts = "Chủ thể rút tiền";
                        tbxTenNgGui.Texts = gdDAO.LayTenKH(GiaoDich.NguoiGui);
                        break;
                    case (int)Loai.nap:
                        tbxLoaiGD.Texts = "Nạp tiền";
                        tbxTenNgGui.Texts = "Chủ thể nạp tiền";
                        tbxTenNgNhan.Texts = gdDAO.LayTenKH(GiaoDich.NguoiNhan);
                        break;
                    case (int)Loai.chuyentien:
                        tbxLoaiGD.Texts = "Chuyển tiền";
                        tbxTenNgGui.Texts = gdDAO.LayTenKH(GiaoDich.NguoiGui);
                        tbxTenNgNhan.Texts = gdDAO.LayTenKH(GiaoDich.NguoiNhan);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
