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
            if(conn.checkDN(SQL) == true)
            {
                return true;
            }
            return false;
        }
    }
}
