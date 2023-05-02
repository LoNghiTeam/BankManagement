using BankManagement.Controller;
using BankManagement.DAO;
using BankManagement.Model;
using BankManagement.Service;
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
    public partial class FTatToanSTK : Form
    {
        private SoTietKiem stk;
        private SoTietKiemDAO stkDAO = new SoTietKiemDAO();
        private TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        private GiaoDichDAO gdDAO = new GiaoDichDAO();
        private TatToanSTK ttSTK = new TatToanSTK();
        private double tienTT=0;
        public SoTietKiem STK { get => stk; set => stk = value; }
        public FTatToanSTK()
        {
            InitializeComponent();
        }
        public FTatToanSTK(SoTietKiem stk)
        {
            InitializeComponent();
            this.STK = stk;
        }

        private void FTatToanSTK_Load(object sender, EventArgs e)
        {
            //Thông tin sổ tiết kiệm
            lblMaSo.Text = stk.MaSTK.ToString();
            lblSTK.Text = stk.SoTK.ToString();
            lblTenSo.Text = stk.TenSo;
            lblNgayGD.Text = stk.NgayVay.ToString();
            lblSoTien.Text = stk.Tien.ToString();
            lblMaLS.Text = stk.MaLS.ToString();
            lblTT.Text = "Chua xu ly";
            lblDaoHan.Text = stk.NgayHan.ToString();
            lblTatToan.Text = DateTime.Now.ToString();

            //Thời hạn sổ tiết kiệm
            TimeSpan thoiHan = stk.NgayHan - stk.NgayVay;

            //Tính tiền lãi
            double tienLai = ttSTK.TinhTienLai(stk);

            //Tính thời gian chênh lệch so với hạn
            TimeSpan duration = stk.NgayHan - DateTime.Now;
            int days = duration.Days;
            lblSai.Text = Math.Abs(days).ToString();

            //Tính tiền phạt 
            double tienPhat = 0;
            if (days > 0)
            {
                tienPhat = ttSTK.TinhTienPhat(days, tienLai, thoiHan);
            }

            //Tính tiền tổng nhận được sau khi xử lý
            tienTT = stk.Tien + tienLai - tienPhat;
            
            //Hiển thị thông tin 3 loại tiền
            lblPhat.Text = tienPhat.ToString();
            lblTien.Text = tienTT.ToString();
            lblTam.Text = tienLai.ToString();
        }

        private void btnTatToan_Click(object sender, EventArgs e)
        {
            try
             {
                //Sửa tiền người gửi
                tkDAO.CongTien(stk.SoTK, tienTT);
                //Sửa tiền ngân hàng
                tkDAO.TruTien((int)TaiKhoanGD.nganhang, tienTT);
                //Thêm giao dịch tất toán vào bảng tất toán
                GiaoDich gd = new GiaoDich((int)TaiKhoanGD.nganhang, stk.SoTK, DateTime.Now, tienTT, (int)LoaiGiaoDich.ruttietkiem);
                gdDAO.TaoGD(gd); 
                //Tất toán
                stkDAO.TatToanGD(stk);

                DialogResult result = MessageBox.Show("Tất toán thành công!", "Thông báo", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Tất toán thất bại! Lỗi: "+ex,"Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
