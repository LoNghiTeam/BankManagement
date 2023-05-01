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
    public partial class FChuyenTienTTD : Form
    {
        private TheTinDung theTinDung;
        public TheTinDung TheTinDung { get => theTinDung; set => theTinDung = value; }
        private double soDu;
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        TaiKhoan taiKhoan = new TaiKhoan();
        ChuyenTien chuyenTien = new ChuyenTien();
        TheTinDungDAO theTinDungDAO = new TheTinDungDAO();
        bool flag = false;
        public FChuyenTienTTD(TheTinDung theTinDung, double soDu)
        {
            InitializeComponent();
            this.soDu = soDu;
            this.theTinDung = theTinDung;
        }

        private void FChuyenTienTTD_Load(object sender, EventArgs e)
        {
            lblMaSoThe.Text = theTinDung.MaTTD.ToString();
            lblRate.Text = soDu.ToString();
            lblSoTK.Text = theTinDung.SoTK.ToString();
            lblTenNguoiNhan.Text = string.Empty;
            btnChuyen.Visible = false;
        }


        private void tbSoTKNhan__TextChanged(object sender, EventArgs e)
        {
            int soTKNhan = -1;
            if (int.TryParse(tbSoTKNhan.Texts, out soTKNhan))
            {
                taiKhoan = taiKhoanDAO.TimSoTK(soTKNhan);
                if (taiKhoan != null)
                {
                    lblTenNguoiNhan.Text = taiKhoan.UserName;
                    if(flag)
                        btnChuyen.Visible = true;
                }
                else
                {
                    lblTenNguoiNhan.Text = String.Empty;
                    btnChuyen.Visible = false;
                }
            }
            else
            {
                lblTenNguoiNhan.Text = String.Empty;
                btnChuyen.Visible = false;
            }
        }

        private void tbTienChuyen__TextChanged(object sender, EventArgs e)
        {

            double tienGui = -1;
            if (double.TryParse(tbTienChuyen.Texts, out tienGui))
            {
                if (tienGui <= soDu  )
                {
                    flag = true;
                    if (lblTenNguoiNhan.Text != string.Empty)
                        btnChuyen.Visible = true;

                }
                else
                {
                    btnChuyen.Visible = false;
                }
            }
            else
            {
                btnChuyen.Visible = false;
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            double tienChuyen;
            double.TryParse(tbTienChuyen.Texts, out tienChuyen);
            
            if (chuyenTien.GiaoDichTien(theTinDung.SoTK, taiKhoan.SoTK, tienChuyen))
            {
                chuyenTien.TaoGiaoDich(taiKhoan.SoTK, 1, DateTime.Now, tienChuyen, 3);
                theTinDung.DaVay += tienChuyen;
                if (theTinDungDAO.CapNhatThe(theTinDung))
                    MessageBox.Show("Chuyển tiền thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Chuyển tiền không thành công", "Thông báo", MessageBoxButtons.OK);

            this.Dispose();
        }
    }
    
}
