﻿using BankManagement.DAO;
using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Controller
{
    internal class ChuyenTien
    {
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        GiaoDichDAO GiaoDichDAO = new GiaoDichDAO();
        public ChuyenTien() { }
        public string TimNguoiNhan(int SoTK)
        {
            string Ten = taiKhoanDAO.TimSoTK(SoTK);
            if(Ten != null)
                return Ten;
            return null;
        }
        public string checkSoTien(double Tien)
        {
            if (Tien <= logging.Taikhoan.Tien)
                return null;
            else
                return "Số dư trong tài khoản không đủ!";
        }
        public bool TaoGiaoDich(int nguoigui, int nguoinhan, DateTime ngayGD, double tien) {
            GiaoDich giaoDich = new GiaoDich(nguoigui, nguoinhan, ngayGD, tien);
            if(GiaoDichDAO.TaoGD(giaoDich))
                return true;
            return false;
        }
        public bool GiaoDichTien(int nguoigui, int nguoinhan, double tiengiaodich)
        {
            double tiengui = taiKhoanDAO.TimTien(nguoigui);
            double tiennhan = taiKhoanDAO.TimTien(nguoinhan);
            if (tiengui != -1 && tiennhan != -1)
            {
                tiengui -= tiengiaodich;
                tiennhan += tiengiaodich;
                if (taiKhoanDAO.CapNhatTien(nguoigui, tiengui) && taiKhoanDAO.CapNhatTien(nguoinhan, tiennhan))
                    return true;
                return false;
            }
            return false;
        }
    }
}
