﻿using BankManagement.Controller;
using BankManagement.DAO;
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
    public partial class FVayTienTheChap : Form
    {
        TaiKhoan taiKhoan = new TaiKhoan();
        VayTien vayTien = new VayTien();
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();    
        LaiSuatDAO laiSuatDAO = new LaiSuatDAO();
        int thoigian;
        double tien;
        LaiSuat laiSuat = new LaiSuat();
        TinhLai tinhLai = new TinhLai();
        ChuyenTien chuyenTien = new ChuyenTien();
        public FVayTienTheChap()
        {
            InitializeComponent();
        }


        private void FVayTien_Load(object sender, EventArgs e)
        {
            btnVayTien.Enabled = false;
            if(logging.Taikhoan.IsAdmin < (int)QuyenTaiKhoan.nhanvien)
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
            taiKhoan = taiKhoanDAO.TimSoTK(soTK);
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
                vayTien.TinhlaichangeTbTien(cbThoiGian.Texts.ToString(), ref tien, ref lai);
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
            
            laiSuat = laiSuatDAO.find(laiSuat);
            double lai = 0;
            vayTien.TinhlaichangecbThoiGian(ref thoigian, cbThoiGian.Texts.ToString(), ref lai);
            lblLaiSuat.Text = lai.ToString() + "%";
            if (lblTong != null)
            {
                double.TryParse(tbTien.Texts.Trim(), out tien);
                tien += tinhLai.TinhTienLai(tien, lai / 100, thoigian);
                lblTong.Text = tien.ToString() + "VNĐ";
                btnVayTien.Enabled = true;
            }
        }

        private void btnVayTien_Click(object sender, EventArgs e)
        {
            int soTK = -1;
            double thechap;
            int.TryParse(tbSoTK.Texts.Trim(), out soTK);
            double.TryParse(tbTien.Texts.Trim(), out tien);
            double.TryParse(tbTheChap.Texts.Trim(), out thechap);
            if (tbTheChap.Texts != "")
            {
                if (thechap >= tien)
                {
                    if (vayTien.TaoKhoanVay(soTK, DateTime.Now, thoigian, tien, laiSuat.MaLS, (int)TinhTrang.chuatra, (int)LoaiVay.vaythechap))
                        if (chuyenTien.GiaoDichTienNhan(soTK, tien))
                            if (chuyenTien.TaoGiaoDich((int)TaiKhoanGD.nganhang, soTK, DateTime.Now, tien, (int)LoaiGiaoDich.vaytien))
                                MessageBox.Show("Vay tiền thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Tiền vay cần nhỏ hơn hoặc bằng giá trị thế chấp", "Thông báo", MessageBoxButtons.OK);
            }
                
            else
                MessageBox.Show("Yêu cầu nhập giá trị tài sản thế chấp", "Thông báo", MessageBoxButtons.OK);

            if (soTK == logging.Taikhoan.SoTK)
            {
                logging.Taikhoan.Tien += tien;
            }
        } 

    }
}
