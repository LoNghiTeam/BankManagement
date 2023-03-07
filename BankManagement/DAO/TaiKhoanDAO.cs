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
        public bool TaoTK(String taikhoan, String matkhau, String hoten, DateTime ngaysinh, String cccd, String diachi, String sdt)
        {
            string SQL = string.Format("INSERT INTO TaiKhoan(UserName, Pass, HoTen, NgaySinh, Cccd, Diachi, Sodienthoai, isAdmin, Tien) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}', {7}, {8});", 
                taikhoan, matkhau, hoten, ngaysinh, cccd, diachi, sdt, 0, 0);
            if (conn.Execute(SQL))
            {
                return true;
            }
            return false;
        }
    }
}
