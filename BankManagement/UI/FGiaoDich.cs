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
    public partial class FGiaoDich : Form
    {
        ChuyenTien chuyenTien = new ChuyenTien();
        public FGiaoDich()
        {
            InitializeComponent();
        }


        private void GiaoDich_Load(object sender, EventArgs e)
        {
            btnChuyenTien.Enabled = false;
            lblNguoiChuyen.Text = logging.Taikhoan.HoTen;
            lblSoDu.Text = logging.Taikhoan.Tien.ToString()+ " VND";
            if(logging.Taikhoan.IsAdmin < 1)
            {
                tbSoTaiKhoanGui.Text = logging.Taikhoan.SoTK.ToString();
                tbSoTaiKhoanGui.Enabled = false;
            }
            
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            if (tbSoTaiKhoanNhan.Text.ToString() != "")
            {
                if (int.Parse(tbSoTaiKhoanNhan.Text) != logging.Taikhoan.SoTK)
                {
                    taiKhoan = chuyenTien.TimNguoiNhan(int.Parse(tbSoTaiKhoanNhan.Text));
                    if (taiKhoan != null)
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
            double result;
            if(double.TryParse(tbSoTien.Text, out result))
            {
                if (result.ToString() != "" && result > 0)
                {
                    string check = chuyenTien.checkSoTien(result);
                    if (check == null)
                    {
                        if (chuyenTien.TaoGiaoDich(logging.Taikhoan.SoTK, int.Parse(tbSoTaiKhoanNhan.Text), DateTime.Now, result))
                        {
                            if (chuyenTien.GiaoDichTien(logging.Taikhoan.SoTK, int.Parse(tbSoTaiKhoanNhan.Text), result))
                            {
                                logging.Taikhoan.Tien -= result;
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
                    MessageBox.Show("Yêu cầu nhập số tiền cần chuyển (>0)!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
