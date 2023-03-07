using BankManagement.Controller;
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

namespace BankManagement
{
    public partial class GiaoDichForm : Form
    {
        ChuyenTien chuyenTien = new ChuyenTien();

        public GiaoDichForm()
        {
            InitializeComponent();
        }


        private void GiaoDich_Load(object sender, EventArgs e)
        {
            btnChuyenTien.Enabled = false;
            lblNguoiChuyen.Text = logging.Taikhoan.HoTen;
            lblSoDu.Text = logging.Taikhoan.Tien.ToString()+ " VND";
            lblSotaiKhoan.Text = logging.Taikhoan.SoTK.ToString();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            if (tbSoTaiKhoan.Text.ToString() != "")
            {
                if (int.Parse(tbSoTaiKhoan.Text) != logging.Taikhoan.SoTK)
                {
                    taiKhoan = chuyenTien.TimNguoiNhan(int.Parse(tbSoTaiKhoan.Text));
                    if (taiKhoan.HoTen != null)
                    {
                        btnChuyenTien.Enabled = true;
                        lblNguoiNhan.Text = taiKhoan.HoTen;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                    MessageBox.Show("Không thể chuyển tiền cho bản thân!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Yêu cầu nhập số tài khoản!", "Thông báo", MessageBoxButtons.OK);

        }
        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            if (tbSoTien.Text.ToString() != ""){ 
                string check = chuyenTien.checkSoTien(double.Parse(tbSoTien.Text));
                if (check == null)
                {
                    if(chuyenTien.TaoGiaoDich(logging.Taikhoan.SoTK ,int.Parse(tbSoTaiKhoan.Text), DateTime.Now, double.Parse(tbSoTien.Text)))
                    {
                        if(chuyenTien.GiaoDichTien(logging.Taikhoan.SoTK, int.Parse(tbSoTaiKhoan.Text), double.Parse(tbSoTien.Text)))
                        {
                            logging.Taikhoan.Tien -= double.Parse(tbSoTien.Text);
                            lblSoDu.Text = logging.Taikhoan.Tien.ToString() + " VND";
                            MessageBox.Show("Chuyển tiền thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Chuyển tiền thất bại!", "Thông báo", MessageBoxButtons.OK);
                    }   
                    else
                        MessageBox.Show("Chuyển tiền thất bại!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(check, "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Yêu cầu nhập số tiền cần chuyển!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
