﻿using BankManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace BankManagement
{
    public partial class CTrans : UserControl
    {
        GiaoDichDAO gdDAO = new GiaoDichDAO();
        public CTrans()
        {
            InitializeComponent();
            this.dtgvTrans.Size = new Size(Width, Height);
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            this.dtgvTrans.DataSource = gdDAO.LayDanhSachGD();
        }
        public void TimKiemGD(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                HienThiDanhSach();
            }
            else
            {
                string option = "";
                option += AddORSql(option);
                if (string.IsNullOrWhiteSpace(option))
                {
                    cbMaGD.Checked = true;
                    option += " MaGD LIKE '{0}' ";
                }
                dtgvTrans.DataSource = gdDAO.TimKiemGDCB(text, option);
            }
        }
        
        public string AddORSql(string option)
        {
            if (cbMaGD.Checked)
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += "OR";
                }
                option += " MaGD LIKE '{0}' ";
            }
            if (cbNgGui.Checked)
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += "OR";
                }
                option += " NguoiGui LIKE '{0}' ";
            }
            if (cbNgNhan.Checked)
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += "OR";
                }
                option += " NguoiNhan LIKE '{0}' ";
            }
            if (cbTien.Checked)
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += "OR";
                }
                option += " Tien LIKE '{0}' ";
            }
            return option;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string option = "";
            option += AddAndSql(option);
            dtgvTrans.DataSource = gdDAO.TimKiemGDNC(option);
        }
        public string AddAndSql(string option)
        {
            if (!string.IsNullOrWhiteSpace(tbxMaGD.Texts))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " MaGD = "+tbxMaGD.Texts;
            }
            if (!string.IsNullOrWhiteSpace(tbxNgGui.Texts))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " NguoiGui = "+tbxNgGui.Texts;
            }
            if (!string.IsNullOrWhiteSpace(tbxNgNhan.Texts))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " NguoiNhan = "+tbxNgNhan.Texts;
            }
            if (!string.IsNullOrWhiteSpace(dpNgayGD.Value.ToString()))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " NgayGD = '"+dpNgayGD.Value+"'";
            }
            if (!string.IsNullOrWhiteSpace(tbxTienGD.Texts))
            {
                if (!string.IsNullOrWhiteSpace(option))
                {
                    option += " AND ";
                }
                option += " Tien = "+tbxTienGD.Texts;
            }
            return option;
        }
    }
}
