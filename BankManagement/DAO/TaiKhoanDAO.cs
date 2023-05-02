using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BankManagement.DAO
{
    internal class TaiKhoanDAO
    {
        DBConnection conn = new DBConnection();
        static Random random = new Random();
        public TaiKhoanDAO()
        {

        }

        public bool KiemtraTK(string taikhoan, string matkhau)
        {
            string SQL = string.Format("select * from TaiKhoan WHERE UserName  = '{0}' and Pass = '{1}'", taikhoan, matkhau);
            return conn.checkExist(SQL);

        }
        public bool KiemtraTK(string taikhoan)
        {
            string SQL = string.Format("select * from TaiKhoan WHERE UserName  = '{0}'", taikhoan);
            return conn.checkExist(SQL);
        }
        public TaiKhoan TimTK(string taikhoan)
        {
            string SQL = string.Format("select * from TaiKhoan WHERE UserName  = '{0}'", taikhoan);
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan = conn.FindTK(SQL);
            return taiKhoan;
        }
        public TaiKhoan TimSoTK(int soTK)
        {
            string SQL = string.Format("select * from TaiKhoan WHERE SoTK  = '{0}'", soTK);
            TaiKhoan tk = conn.FindTK(SQL);
            return tk;
        }
        public bool TaoTK(TaiKhoan taiKhoan, int role)
        {
            string SQL = string.Format("INSERT INTO TaiKhoan(UserName, Pass, HoTen, NgaySinh, Cccd, Diachi, Sodienthoai, isAdmin, Tien, DiemTD) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}', '{7}', '{8}', '{9}');",
                taiKhoan.UserName, taiKhoan.Pass, taiKhoan.HoTen, taiKhoan.NgaySinh, taiKhoan.Cccd, taiKhoan.DiaChi, taiKhoan.SoDienThoai, role, 0, taiKhoan.DiemTD);
            return conn.Execute(SQL);
        }
        public double TimTien(int soTK)
        {
            string SQL = string.Format("select * from TaiKhoan WHERE SoTK  = '{0}'", soTK);
            double tien = conn.FindTien(SQL);
            return tien;
        }
        public bool CapNhatTien(int soTK, double tien)
        {
            string SQL = string.Format("UPDATE TaiKhoan SET Tien = {1} where SoTK ='{0}'", soTK, tien);
            return conn.Execute(SQL);
        }

        public bool CongTien(int soTK, double tien)
        {
            string SQL = string.Format("UPDATE TaiKhoan SET Tien = Tien + {1} where SoTK ='{0}'", soTK, tien);
            return conn.Execute(SQL);
        }
        public bool TruTien(int soTK, double tien)
        {
            string SQL = string.Format("UPDATE TaiKhoan SET Tien = Tien - {1} where SoTK ='{0}'", soTK, tien);
            return conn.Execute(SQL);
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
            return conn.Execute(SQL);
        }

        public DataTable LayDanhSachKH()
        {
            string sqlStr = string.Format("SELECT SoTk, HoTen, NgaySinh, Cccd, Diachi, Sodienthoai FROM TaiKhoan WHERE isAdmin = 0");
            return conn.LayDanhSach(sqlStr);
        }

        public void Sua(TaiKhoan tk)
        {
            string sqlStr = string.Format(
                "UPDATE TaiKhoan SET HoTen = '{0}', Diachi='{1}', Sodienthoai='{2}', Ngaysinh='{3}', Cccd='{4}' WHERE SoTK = '{5}'",
                tk.HoTen, tk.DiaChi, tk.SoDienThoai, tk.NgaySinh, tk.Cccd, tk.SoTK);
            conn.Execute(sqlStr);
        }


        //Tính năng random tài khoản:
        /*public void Them(TaiKhoan tk)
        {
            string userName = GenerateRandom();
            string pass = GenerateRandom();
            string test = string.Format("Select UserName From TaiKhoan Where UserName='{0}'", userName);
            while (conn.LayDanhSach(test).Rows.Count > 0)
            {
                userName = GenerateRandom();
            }
            test = string.Format("Select Cccd From TaiKhoan Where Cccd='{0}'", tk.Cccd);
            if (conn.LayDanhSach(test).Rows.Count > 0)
            {
                System.Windows.MessageBox.Show("Mã số căn cước công dân không hợp lệ do đang đại diện cho một tài khoản khác, vui lòng kiểm tra lại!");
            }
            else
            {
                string sqlStr = string.Format(
                     "INSERT INTO TaiKhoan(UserName, Pass, HoTen, Ngaysinh, Cccd, Diachi, Sodienthoai, isAdmin, Tien) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}','{8}')",
                 userName, pass, tk.HoTen, tk.NgaySinh, tk.Cccd, tk.DiaChi, tk.SoDienThoai, 0, 0);
                conn.Execute(sqlStr);
            }
        }

        static string GenerateRandom()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }*/
    }
}
