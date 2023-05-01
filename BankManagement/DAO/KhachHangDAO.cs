using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace BankManagement.DAO
{
    internal class KhachHangDAO
    {
        DBConnection dbConn = new DBConnection();
        static Random random = new Random();
        public DataTable LayDanhSachKH()
        {
            string sqlStr = string.Format("SELECT SoTk, HoTen, NgaySinh, Cccd, Diachi, Sodienthoai FROM TaiKhoan WHERE isAdmin = 0");
            return dbConn.LayDanhSach(sqlStr);
        }

        public void Sua(TaiKhoan tk)
        {
            string sqlStr = string.Format(
                "UPDATE TaiKhoan SET HoTen = '{0}', Diachi='{1}', Sodienthoai='{2}', Ngaysinh='{3}', Cccd='{4}' WHERE SoTK = '{5}'",
                tk.HoTen, tk.DiaChi, tk.SoDienThoai, tk.NgaySinh,tk.Cccd, tk.SoTK);
            dbConn.Execute(sqlStr);
        }

        public void Them(TaiKhoan tk)
        {
            string userName = GenerateRandom();
            string pass = GenerateRandom();
            string test = string.Format("Select UserName From TaiKhoan Where UserName='{0}'", userName);
            while (dbConn.LayDanhSach(test).Rows.Count >0)
            {
                userName = GenerateRandom();
            }
            test = string.Format("Select Cccd From TaiKhoan Where Cccd='{0}'", tk.Cccd);
            if(dbConn.LayDanhSach(test).Rows.Count > 0)
            {
                System.Windows.MessageBox.Show("Mã số căn cước công dân không hợp lệ do đang đại diện cho một tài khoản khác, vui lòng kiểm tra lại!");
            }
            else
            {
                string sqlStr = string.Format(
                     "INSERT INTO TaiKhoan(UserName, Pass, HoTen, Ngaysinh, Cccd, Diachi, Sodienthoai, isAdmin, Tien) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}','{8}')",
                 userName,pass, tk.HoTen, tk.NgaySinh, tk.Cccd, tk.DiaChi,tk.SoDienThoai,0,0);
                dbConn.Execute(sqlStr);
            }
        }

        static string GenerateRandom()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
