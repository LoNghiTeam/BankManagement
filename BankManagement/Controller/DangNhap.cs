using BankManagement.DAO;
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
            if(taiKhoanDAO.KiemtraTK(taikhoan, matkhau) == true)
            {
                return true;
            }
            return false;
        }
    }
}
