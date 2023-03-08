using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAO
{
    internal class KhachHangDAO
    {
        DBConnection dbConn = new DBConnection();
        public DataTable LayDanhSachKH()
        {
            string sqlStr = string.Format("SELECT * FROM TaiKhoan");
            return dbConn.LayDanhSach(sqlStr);
        }
    }
}
