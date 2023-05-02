using System;
using BankManagement.Model;
using BankManagement.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagement.Controller;

namespace BankManagement.UI
{
    public partial class FTheTinDung : Form
    {
        TheTinDung theTinDung = new TheTinDung();
        TheTinDungDAO theTinDungDAO = new TheTinDungDAO();
        HoatDongLaiSuat hdLS = new HoatDongLaiSuat();
        TaiKhoan taiKhoan = new TaiKhoan();
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        public FTheTinDung()
        {
            InitializeComponent();
        }

        private void FTheTinDung_Load(object sender, EventArgs e)
        {
            if (logging.Taikhoan.IsAdmin == (int)QuyenTaiKhoan.khachhang)
            {
                tbSTK.Enabled = false;
            }
            else
                tbSTK.Enabled = true;
            tbxSoThe.Enabled = false;
            tbSTK.Texts = logging.Taikhoan.SoTK.ToString();
            theTinDung = theTinDungDAO.TimTTD(logging.Taikhoan.SoTK, theTinDung);
            if(theTinDung != null)
            {
                if (theTinDung.NgayHan == null)
                    dpNgayVay.Visible = true;
                else
                    dpNgayVay.Text = theTinDung.NgayHan.ToString();
                lblVay.Text = theTinDung.DaVay.ToString();
                lblSoDu.Text = hdLS.TinhSoDu(theTinDung.DaVay, logging.Taikhoan.DiemTD).ToString();
                tbxSoThe.Texts = theTinDung.MaTTD.ToString();
                btnMoThe.Visible = false;

            }
            else
            {
                lblSoDu.Text = String.Empty;
                lblVay.Text = String.Empty;
                btnChuyenTien.Enabled = false;
                btnRutTien.Enabled = false;
                btnThanhToan.Enabled = false;
            }
            dpNgayVay.Enabled = false;
            
         
        }

        private void tbSTK__TextChanged(object sender, EventArgs e)
        {
            int soTK = -1;
            int.TryParse(tbSTK.Texts.Trim(), out soTK);
            taiKhoan = taiKhoanDAO.TimSoTK(soTK);
            if (taiKhoan != null)
            {
                
                if (theTinDungDAO.KiemTraThe(taiKhoan.SoTK))
                {
                    theTinDung = theTinDungDAO.TimTTD(taiKhoan.SoTK, theTinDung);
                    if (theTinDung.NgayHan == null)
                        dpNgayVay.Visible = true;
                    else if(theTinDung.NgayHan != null)
                        dpNgayVay.Text = theTinDung.NgayHan.ToString();
                    lblVay.Text = theTinDung.DaVay.ToString();
                    lblSoDu.Text = hdLS.TinhSoDu(theTinDung.DaVay, taiKhoan.DiemTD).ToString();
                    tbxSoThe.Texts = theTinDung.MaTTD.ToString();
                    btnChuyenTien.Enabled = true;
                    btnRutTien.Enabled = true;
                    btnThanhToan.Enabled = true;
                }
                else
                {
                    tbxSoThe.Texts = String.Empty;
                    btnMoThe.Visible = true;
                }
            }
            else
            {
                lblSoDu.Text = String.Empty;
                lblVay.Text = String.Empty;
                btnChuyenTien.Enabled = false;
                btnRutTien.Enabled = false;
                btnThanhToan.Enabled = false;
                btnMoThe.Visible = false;
            }
        }

        private void btnMoThe_Click(object sender, EventArgs e)
        {
            if(theTinDungDAO.TaoThe(taiKhoan.SoTK))
            {
                MessageBox.Show("Tạo thẻ thành công", "Thông báo", MessageBoxButtons.OK);
                int soTK = -1;
                int.TryParse(tbSTK.Texts.Trim(), out soTK);
                tbSTK.Texts = String.Empty;
                tbSTK.Texts = soTK.ToString();
            }    
            else
                MessageBox.Show("Tạo thẻ thất bại", "Thông báo", MessageBoxButtons.OK);


        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(theTinDung.NgayHan, DateTime.Now) < 0)
            {
                if (theTinDung.DaVay > 0)
                {
                    FThanhToanTTD fThanhToanTTD = new FThanhToanTTD(theTinDung);
                    fThanhToanTTD.ShowDialog();
                    refresh();
                }
                else
                    MessageBox.Show("Không có khoản vay cần thanh toán", "Thông báo", MessageBoxButtons.OK);

            }
                
            else
                MessageBox.Show("Chưa đến hạn thanh toán", "Thông báo", MessageBoxButtons.OK);
        }
        private bool CheckThe(TheTinDung theTinDung)
        {
            if(theTinDung.DaVay > 0)
            {
                TimeSpan lech = DateTime.Now - theTinDung.NgayHan;
                if (lech.Days > 0)
                    return false;
            }
            return true;
                
        }
        
        private void btnRutTien_Click(object sender, EventArgs e)
        {
            if(CheckThe(theTinDung))
            {
                double soDu = -1;
                double.TryParse(lblSoDu.Text.Trim(), out soDu);
                FRutTienTTD fRutTienTTD = new FRutTienTTD(theTinDung, soDu);
                fRutTienTTD.ShowDialog();
                refresh();
            }
            else
                MessageBox.Show("Vui lòng thanh toán khoản vay trước đó", "Thông báo", MessageBoxButtons.OK);
        }
        private void refresh()
        {
            int soTK = -1;
            int.TryParse(tbSTK.Texts.Trim(), out soTK);
            tbSTK.Texts = String.Empty;
            tbSTK.Texts = soTK.ToString();
        }
        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            if (CheckThe(theTinDung))
            {
                double soDu = -1;
                double.TryParse(lblSoDu.Text.Trim(), out soDu);
                FChuyenTienTTD fChuyenTienTTD = new FChuyenTienTTD(theTinDung, soDu);
                fChuyenTienTTD.ShowDialog();
                refresh();
            }
            else
                MessageBox.Show("Vui lòng thanh toán khoản vay trước đó", "Thông báo", MessageBoxButtons.OK);
        }
    }

}
