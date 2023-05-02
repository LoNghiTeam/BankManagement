using BankManagement.DAO;
using BankManagement.Model;
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
            return taiKhoanDAO.KiemtraTK(taikhoan);
            
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
        public String CheckNull(TaiKhoan taiKhoan, String matKhauNhapLai)
        {
            String result = "Ô đang bị trống: ";
            if (taiKhoan.UserName.Length == 0 || taiKhoan.UserName == "Tài khoản") result += "Tài khoản, ";
            if (taiKhoan.Pass.Length == 0 || taiKhoan.Pass == "Mật khẩu") result += "Mật khẩu, ";
            if (matKhauNhapLai.Length == 0 || matKhauNhapLai == "Nhập lại mật khẩu") result += "Nhập lại mật khẩu, ";
            if (taiKhoan.HoTen.Length == 0 || taiKhoan.HoTen == "Họ và tên") result += "Họ và tên , ";
            if (taiKhoan.Cccd.Length == 0 || taiKhoan.Cccd == "CCCD") result += "CCCD, ";
            if (taiKhoan.DiaChi.Length == 0 || taiKhoan.DiaChi == "Địa chỉ") result += "Địa chỉ, ";
            if (taiKhoan.SoDienThoai.Length == 0 || taiKhoan.SoDienThoai == "Số điện thoại") result += "Số điện thoại, ";
            return result = result.Substring(0, result.Length - 2);

        }
        public String checkAll(TaiKhoan taiKhoan, String matKhauNhapLai)
        {
            if (CheckNull(taiKhoan, matKhauNhapLai).Length > 15)
                return CheckNull(taiKhoan, matKhauNhapLai);
            if (!ktMatKhau(taiKhoan.Pass, matKhauNhapLai))
                return "Mật khẩu không trùng khớp";
            if (!IsValidPhone(taiKhoan.SoDienThoai))
                return "Số điện thoại không hợp lệ";
            if (!ktTaikhoan(taiKhoan.UserName))
                return "Tài khoản đã tồn tại vui lòng chọn tên tài khoản khác";
            return null;
        }
        public bool TaoTKKH(TaiKhoan taiKhoan)
        {
            return taiKhoanDAO.TaoTK(taiKhoan, (int)QuyenTaiKhoan.khachhang);
        }

    }
}
