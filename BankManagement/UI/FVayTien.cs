using BankManagement.Controller;
using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement.UI
{
    public partial class FVayTien : Form
    {
        TaiKhoan taiKhoan = new TaiKhoan();
        VayTien vayTien = new VayTien();
        int thoigian;
        double tien;
        LaiSuat laiSuat = new LaiSuat();
        ChuyenTien chuyenTien = new ChuyenTien();
        public FVayTien()
        {
            InitializeComponent();
        }


        private void FVayTien_Load(object sender, EventArgs e)
        {
            btnVayTien.Enabled = false;
            cbThoiGian.Items.Add("1 tháng");
            cbThoiGian.Items.Add("3 tháng");
            cbThoiGian.Items.Add("6 tháng");
            cbThoiGian.Items.Add("12 tháng");
            cbThoiGian.Items.Add("24 tháng");
            cbThoiGian.Items.Add("36 tháng");
            if(logging.Taikhoan.IsAdmin < 1)
            {
                tbSoTK.Enabled = false;
            }
            tbSoTK.Texts = logging.Taikhoan.SoTK.ToString();
            lblTen.Text = logging.Taikhoan.HoTen;
            lblTong.Text = string.Empty;
            lblLaiSuat.Text = string.Empty;

        }

        private void tbSoTK__TextChanged(object sender, EventArgs e)
        {
            int soTK = -1;
            int.TryParse(tbSoTK.Texts.Trim(), out soTK);

            btnVayTien.Enabled = false;
            taiKhoan = vayTien.TimNguoiNhan(soTK);
            if (taiKhoan != null)
            {
                if (lblTong.Text != "")
                {
                    btnVayTien.Enabled = true;
                }
                lblTen.Text = taiKhoan.HoTen;
                
            }
            else
            {
                lblTen.Text = string.Empty;
                btnVayTien.Enabled = false;
            }
        }

        private void tbTien__TextChanged(object sender, EventArgs e)
        {
            double lai;
            double.TryParse(tbTien.Texts.Trim(), out tien);
            
            if (cbThoiGian.Texts != "" && tien>0)
            {
                string laiSuat = lblLaiSuat.Text;
                laiSuat = laiSuat.Remove(laiSuat.IndexOf('%'));
                double.TryParse(laiSuat, out lai);
                switch (cbThoiGian.Texts.ToString())
                {
                    case "1 tháng":
                        tien += vayTien.TinhTienLai(tien, lai / 100, 1);
                        break;
                    case "3 tháng":
                        tien += vayTien.TinhTienLai(tien, lai / 100, 3);
                        break;
                    case "6 tháng":
                        tien += vayTien.TinhTienLai(tien, lai / 100, 6);
                        break;
                    case "12 tháng":
                        tien += vayTien.TinhTienLai(tien, lai / 100, 12);
                        break;
                    case "24 tháng":
                        tien += vayTien.TinhTienLai(tien, lai / 100, 24);
                        break;
                    case "36 tháng":
                        tien += vayTien.TinhTienLai(tien, lai / 100, 36);
                        break;
                }
                lblTong.Text = tien.ToString() + "VNĐ";
                btnVayTien.Enabled = true;
            }
            else {
                lblTong.Text = string.Empty;
                btnVayTien.Enabled = false; 
            }
        }

        private void cbThoiGian_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
            laiSuat = vayTien.GetLaiSuat();
            double lai = 0;
            switch (cbThoiGian.Texts.ToString())
            {
                case "1 tháng":
                    lai = laiSuat.MaLS * 0.8 * 100;
                    lblLaiSuat.Text = lai.ToString() + "%";
                    thoigian = 1;
                    break;
                case "3 tháng":
                    lai = laiSuat.LaiVay * 0.85 * 100;
                    lblLaiSuat.Text = lai.ToString() + "%";
                    thoigian = 3;
                    break;
                case "6 tháng":
                    lai = laiSuat.LaiVay * 0.9 * 100;
                    lblLaiSuat.Text = lai.ToString() + "%";
                    thoigian = 6;
                    break;
                case "12 tháng":
                    lai = laiSuat.LaiVay * 1 * 100;
                    lblLaiSuat.Text = lai.ToString() + "%";
                    thoigian = 12;
                    break;
                case "24 tháng":
                    lai = laiSuat.LaiVay * 1.1* 100;
                    lblLaiSuat.Text = lai.ToString() + "%";
                    thoigian = 24;
                    break;                
                case "36 tháng":
                    lai = laiSuat.LaiVay * 1.2 * 100;
                    lblLaiSuat.Text = lai.ToString() + "%";
                    thoigian = 36;
                    break;
            }
            if (lblTong != null)
            {

                double.TryParse(tbTien.Texts.Trim(), out tien);
                tien += vayTien.TinhTienLai(tien, lai / 100, thoigian);
                lblTong.Text = tien.ToString() + "VNĐ";
                btnVayTien.Enabled = true;
            }

        }

        private void btnVayTien_Click(object sender, EventArgs e)
        {
            int soTK = -1;
            int.TryParse(tbSoTK.Texts.Trim(), out soTK);
            if (vayTien.TaoKhoanVay(soTK, DateTime.Now, thoigian, tien, laiSuat.MaLS, 0, 1))
                if(chuyenTien.GiaoDichTien(soTK, tien))
                    if(chuyenTien.TaoGiaoDich(-1, soTK, DateTime.Now, tien))
                        MessageBox.Show("Vay tiền thành công", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
