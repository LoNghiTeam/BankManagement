using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAO
{
    internal class TaiKhoanDAO
    {
        DBConnection conn = new DBConnection();
        public TaiKhoanDAO()
        {

        }

        public bool KiemtraTK(String taikhoan, String matkhau)
        {
            string SQL = string.Format("select * from TaiKhoan WHERE UserName  = '{0}' and Pass = '{1}'", taikhoan, matkhau);
            if(conn.searchDN(SQL))
            {
                return true;
            }
            return false;
        }
    }
}
