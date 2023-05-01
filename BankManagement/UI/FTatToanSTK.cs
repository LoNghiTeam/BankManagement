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
    public partial class FTatToanSTK : Form
    {
        private SoTietKiem stk;
        private SoTietKiemDAO stkDAO = new SoTietKiemDAO();
        private TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        private GiaoDichDAO gdDAO = new GiaoDichDAO();
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
            lblMaSo.Text = stk.MaSTK.ToString();
            lblSTK.Text = stk.SoTK.ToString();
            lblTenSo.Text = stk.TenSo;
            lblNgayGD.Text = stk.NgayVay.ToString();
            lblSoTien.Text = stk.Tien.ToString();
            lblMaLS.Text = stk.MaLS.ToString();
            lblTT.Text = "Chua xu ly";
            lblDaoHan.Text = stk.NgayHan.ToString();
            lblTatToan.Text = DateTime.Now.ToString();
            TimeSpan duration = stk.NgayHan - DateTime.Now;  
            int days = duration.Days;
            lblSai.Text = Math.Abs(days).ToString();

            if(days > 0)
            {
                lblTam.Text = stk.Tien.ToString();
                lblPhat.Text = (stk.Tien * 20 / 100).ToString();
                tienTT = stk.Tien - stk.Tien * 20 / 100;
                lblTien.Text = tienTT.ToString();
            }else if(days < 0)
            {
                lblTam.Text = stk.Tien.ToString();
                lblPhat.Text = "0";
                tienTT = stk.Tien;
                lblTien.Text = tienTT.ToString();
            }
            else
            {
                lblTam.Text = stk.Tien.ToString();
                lblPhat.Text = "0";
                tienTT = stk.Tien;
                lblTien.Text = tienTT.ToString();
            }
        }

        private void btnTatToan_Click(object sender, EventArgs e)
        {
            try
             {
                stkDAO.TatToanGD(stk);
                //Sửa tiền người gửi
                tkDAO.CongTien(stk.SoTK, tienTT);
                //Sửa tiền ngân hàng
                tkDAO.TruTien(1, tienTT);
                //Thêm giao dịch tất toán vào bảng tất toán
                GiaoDich gd = new GiaoDich(1, stk.SoTK, DateTime.Now, tienTT, 7);
                gdDAO.TaoGD(gd); 

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
