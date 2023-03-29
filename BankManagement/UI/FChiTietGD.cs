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
                switch (GiaoDich.NguoiGui)
                {
                    case -2:
                        if (GiaoDich.NguoiNhan > 0)
                        {
                            tbxLoaiGD.Texts = "Tất toán tiết kiệm";
                        }
                        tbxTenNgGui.Texts = "Ngân hàng đầu tư và phát triển nhóm 4";
                        break;
                    case -1:
                        if (GiaoDich.NguoiNhan > 0)
                        {
                            tbxLoaiGD.Texts = "Vay tiền";
                        }
                        tbxTenNgGui.Texts = "Ngân hàng đầu tư và phát triển nhóm 4";
                        break;
                    case 0:
                        if (GiaoDich.NguoiNhan > 0)
                        {
                            tbxLoaiGD.Texts = "Nạp tiền";
                        }
                        tbxTenNgGui.Texts = "Chủ thể nạp tiền";
                        break;
                    default:
                        switch (GiaoDich.NguoiNhan)
                        {
                            case 0:
                                tbxLoaiGD.Texts = "Rút tiền";
                                break;
                            case -1:
                                tbxLoaiGD.Texts = "Thanh toán nợ";
                                break;
                            case -2:
                                tbxLoaiGD.Texts = "Gửi tiền tiết kiệm";
                                break;
                            default:
                                tbxLoaiGD.Texts = "Chuyển tiền giữa các tài khoản";
                                break;
                        }
                        tbxTenNgGui.Texts = gdDAO.LayTenKH(GiaoDich.NguoiGui);
                        break;
                }
                switch (GiaoDich.NguoiNhan)
                {
                    case 0:
                        tbxTenNgNhan.Texts = "Chủ thể rút tiền";
                        break;
                    case -1:
                        tbxTenNgNhan.Texts = "Ngân hàng đầu tư và phát triển nhóm 4";
                        break;
                    case -2:
                        tbxTenNgNhan.Texts = "Ngân hàng đầu tư và phát triển nhóm 4";
                        break;
                    default:
                        tbxTenNgNhan.Texts = gdDAO.LayTenKH(GiaoDich.NguoiNhan);
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
