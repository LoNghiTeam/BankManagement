using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BankManagement.DAO
{
    internal class TaiKhoanDAO
    {
        DBConnection conn = new DBConnection();
        public TaiKhoanDAO()
        {

        }

        public bool KiemtraTK(string taikhoan, string matkhau)
        {
            string SQL = string.Format("select * from TaiKhoan WHERE UserName  = '{0}' and Pass = '{1}'", taikhoan, matkhau);
            if(conn.checkExist(SQL))
            {
                return true;
            }
            return false;
        }
        public bool KiemtraTK(string taikhoan)
        {
            string SQL = string.Format("select * from TaiKhoan WHERE UserName  = '{0}'", taikhoan);
            if(conn.checkExist(SQL))
            {
                return true;
            }
            return false;
        }
        public TaiKhoan TimTK(string taikhoan)
        {
            string SQL = string.Format("select * from TaiKhoan WHERE UserName  = '{0}'", taikhoan);
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan = conn.FindTK(SQL);
            if(taiKhoan != null)
            {
                return taiKhoan;
            }
            return null;
        }
        public TaiKhoan TimSoTK(int SoTK)
        {
            string SQL = string.Format("select * from TaiKhoan WHERE SoTK  = '{0}'", SoTK);
            TaiKhoan Ten = conn.FindTK(SQL);
            if (Ten != null)
            {
                return Ten;
            }
            return null;
        }
        public bool TaoTK(TaiKhoan taiKhoan, int role) { 
            string SQL = string.Format("INSERT INTO TaiKhoan(UserName, Pass, HoTen, NgaySinh, Cccd, Diachi, Sodienthoai, isAdmin, Tien, DiemTD) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}', '{7}', '{8}', '{9}');",
                taiKhoan.UserName, taiKhoan.Pass, taiKhoan.HoTen, taiKhoan.NgaySinh, taiKhoan.Cccd, taiKhoan.DiaChi, taiKhoan.SoDienThoai, role, 0, taiKhoan.DiemTD);
            if (conn.Execute(SQL))
            {
                return true;
            }
            return false;
        }
        public double TimTien(int soTK)
        {
            string SQL = string.Format("select * from TaiKhoan WHERE SoTK  = '{0}'", soTK);
            double tien = conn.FindTien(SQL);
            if (tien != -1)
            {
                return tien;
            }
            return -1;
        }
        public bool CapNhatTien(int soTK, double tien)
        {
            string SQL = string.Format("UPDATE TaiKhoan SET Tien = {1} where SoTK ='{0}'", soTK, tien);
            if (conn.Execute(SQL))
            {
                return true;
            }
            return false;
        }
        public void CapNhatDiemTinDung(int diem, int soTK )
        {
            string SQL = string.Format("UPDATE TaiKhoan SET DiemTD = {1} where SoTK ='{0}'", soTK, diem);
            conn.Execute(SQL);
           
        }
        public bool DoiMatKhau(string mk)
        {
            string SQL = string.Format("UPDATE TaiKhoan SET Pass = {1} where SoTK ='{0}'", 
                logging.Taikhoan.SoTK, mk);
            if (conn.Execute(SQL))
            {
                return true;
            }
            return false;
        }
    }
}
