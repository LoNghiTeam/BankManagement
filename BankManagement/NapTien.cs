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
    public partial class NapTien : Form
    {
        ChuyenTien chuyenTien = new ChuyenTien();
        public NapTien()
        {
            InitializeComponent();
        }
        TaiKhoan taiKhoan = new TaiKhoan();

        private void btnNap_Click(object sender, EventArgs e)
        {
            if(tbSoTien.Text.ToString() != "")
            {
                if (chuyenTien.TaoGiaoDich(0, int.Parse(tbSoTK.Text), DateTime.Now, double.Parse(tbSoTien.Text)))
                {
                    if (chuyenTien.GiaoDichTien(int.Parse(tbSoTK.Text), double.Parse(tbSoTien.Text)))
                    {
                        taiKhoan.Tien += double.Parse(tbSoTien.Text);
                        lblSoDu.Text = taiKhoan.Tien.ToString() + " VND";
                        MessageBox.Show("Nạp tiền thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Nạp tiền thất bại!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Nạp tiền thất bại!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Yêu cầu nhập số tiền nạp!", "Thông báo", MessageBoxButtons.OK);
        }

        private void NapTien_Load(object sender, EventArgs e)
        {
            btnNap.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            if (tbSoTK.Text.ToString() != "")
            {
                taiKhoan = chuyenTien.TimNguoiNhan(int.Parse(tbSoTK.Text));
                lblNguoiNhan.Text = taiKhoan.HoTen;
                lblSoDu.Text = taiKhoan.Tien.ToString();
                btnNap.Enabled = true;
            }
            else
                MessageBox.Show("Yêu cầu nhập số tài khoản!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
