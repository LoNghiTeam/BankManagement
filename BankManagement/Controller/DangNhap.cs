using BankManagement.DAO;
using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Controller
{
    internal class DangNhap
    {
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        public DangNhap() { }

        public Boolean ktDangNhap(String taikhoan, String matkhau)
        {
            if(taiKhoanDAO.KiemtraTK(taikhoan, matkhau))
            {
                return true;
            }
            return false;
        }
        public TaiKhoan TimTK(String taikhoan)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan = taiKhoanDAO.TimTK(taikhoan);
            if (taiKhoan != null)
            {
                return taiKhoan;
            }
            return null;
        }
    }
}
