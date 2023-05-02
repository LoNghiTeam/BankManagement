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
    public partial class FNapTien : Form
    {
        ChuyenTien chuyenTien = new ChuyenTien();
        TaiKhoan taiKhoan= new TaiKhoan();
        public FNapTien()
        {
            InitializeComponent();
        }
        private void btnNap_Click(object sender, EventArgs e)
        {
            double result;
            if(double.TryParse(tbSoTien.Text,out result)){
                if (result.ToString() != "" && result>0)
                {
                    if (chuyenTien.TaoGiaoDichNap(int.Parse(tbSoTK.Text), DateTime.Now, result, (int)LoaiGiaoDich.naptien))
                    {
                        if (chuyenTien.GiaoDichTienNhan(int.Parse(tbSoTK.Text), result))
                        {
                            taiKhoan.Tien += result;
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
                    MessageBox.Show("Yêu cầu nhập số tiền nạp! (>0)", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void NapTien_Load(object sender, EventArgs e)
        {
            btnNap.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            if (tbSoTK.Text.ToString() != "")
            {
                int soTK;
                int.TryParse(tbSoTK.Text, out soTK);
                taiKhoan = chuyenTien.TimNguoiNhan(soTK);
                if(taiKhoan != null)
                {
                    lblNguoiNhan.Text = taiKhoan.HoTen;
                    lblSoDu.Text = taiKhoan.Tien.ToString();
                    btnNap.Enabled = true;
                }
                else
                    MessageBox.Show("Số tài khoản không tồn tại, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);

            }
            else
                MessageBox.Show("Yêu cầu nhập số tài khoản!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
