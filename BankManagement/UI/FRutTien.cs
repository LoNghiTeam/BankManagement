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

namespace BankManagement.UI
{
    public partial class FRutTien : Form
    {
        RutTien rutTien = new RutTien();
        public FRutTien()
        {
            InitializeComponent();
        }
        TaiKhoan taiKhoan = new TaiKhoan();
        private void FRutTien_Load(object sender, EventArgs e)
        {
            lblRate.Text = string.Empty;
            lblTen.Text = string.Empty;
            btnRut.Enabled = false;
        }

        private void tbSoTK__TextChanged(object sender, EventArgs e)
        {

            int SoTK = -1;
            int.TryParse(tbSoTK.Texts.Trim(), out SoTK);


            taiKhoan = rutTien.TimNguoiNhan(SoTK);
            if (taiKhoan != null)
            {
                lblTen.Text = taiKhoan.HoTen;
                lblRate.Text = taiKhoan.Tien.ToString();
                btnRut.Enabled = true;
            }
            else
            {
                lblRate.Text = string.Empty;
                lblTen.Text = string.Empty;
                btnRut.Enabled = false;
            }
        }

        private void btnRut_Click(object sender, EventArgs e)
        {
            double result;
            if (double.TryParse(tbTienRut.Texts, out result))
            {
                if (result.ToString() != "" && result > 0)
                {

                    if (result <= taiKhoan.Tien)
                    {
                        if (rutTien.TaoGiaoDich(int.Parse(tbSoTK.Texts), 1, DateTime.Now, result,3))
                        {
                            if (rutTien.GiaoDichTien(int.Parse(tbSoTK.Texts), result))
                            {
                                taiKhoan.Tien -= result;
                                lblRate.Text = taiKhoan.Tien.ToString() + " VND";
                                MessageBox.Show("Rút tiền thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                                MessageBox.Show("Rút tiền thất bại!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Rút tiền thất bại!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Số dư trong tài khoản không đủ!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                    MessageBox.Show("Yêu cầu nhập số tiền cần rút (>0)!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
            }
        }

    }
}
