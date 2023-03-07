using BankManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankManagement.Controller
{
    internal class DangKy
    {
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        public DangKy() { }
        public bool ktTaikhoan (string taikhoan)
        {
            if (taiKhoanDAO.KiemtraTK(taikhoan) == true)
            {
                return false;
            }
            return true;
        }
        public bool ktMatKhau(string matkhau, string matkhaunhaplai)
        {
            if (matkhau == matkhaunhaplai)
            {
                return true;
            }
            return false;
        }
        public bool IsValidPhone(String Sdt)
        {
            string pattern = @"^\d{3}-?\d{3}-?\d{4}$";
            return Regex.IsMatch(Sdt, pattern);
        }
        public String CheckNull(String taikhoan, String matkhau, String matkhaunhaplai, String hoten, String cccd, String diachi, String sdt)
        {
            String result = "Ô đang bị trống: ";
            if (taikhoan.Length == 0 || taikhoan == "Tài khoản") result += "Tài khoản, ";
            if (matkhau.Length == 0 || matkhau == "Mật khẩu") result += "Mật khẩu, ";
            if (matkhaunhaplai.Length == 0 ||  matkhaunhaplai == "Nhập lại mật khẩu") result += "Nhập lại mật khẩu, ";
            if (hoten.Length == 0 || hoten == "Họ và tên") result += "Họ và tên , ";
            if (cccd.Length == 0 || cccd == "CCCD") result += "CCCD, ";
            if (diachi.Length == 0 || diachi == "Địa chỉ") result += "Địa chỉ, ";
            if (sdt.Length == 0 || sdt == "Số điện thoại") result += "Số điện thoại, ";
            return result = result.Substring(0, result.Length - 2);

        }
        public String checkAll(String taikhoan, String matkhau, String matkhaunhaplai, String hoten, String cccd, String diachi, String sdt)
        {
            if (CheckNull(taikhoan, matkhau, matkhaunhaplai, hoten, cccd, diachi, sdt).Length > 15)
                return CheckNull(taikhoan, matkhau, matkhaunhaplai, hoten, cccd, diachi, sdt);
            if (!ktMatKhau(matkhau, matkhaunhaplai))
                return "Mật khẩu không trùng khớp";
            if (!IsValidPhone(sdt))
                return "Số điện thoại không hợp lệ";
            if (!ktTaikhoan(taikhoan))
                return "Tài khoản đã tồn tại vui lòng chọn tên tài khoản khác";
            return null;
        }
        public bool TaoTK (String taikhoan, String matkhau, String hoten, DateTime ngaysinh, String cccd, String diachi, String sdt)
        {
            if (taiKhoanDAO.TaoTK(taikhoan, matkhau, hoten, ngaysinh, cccd, diachi, sdt))
                return true;
            return false;
        }

    }
}
