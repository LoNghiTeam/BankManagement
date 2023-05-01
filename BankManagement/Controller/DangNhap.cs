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
            return taiKhoanDAO.KiemtraTK(taikhoan, matkhau);
          
        }
        public TaiKhoan TimTK(String taikhoan)
        {
            return taiKhoanDAO.TimTK(taikhoan);
        }
    }
}
