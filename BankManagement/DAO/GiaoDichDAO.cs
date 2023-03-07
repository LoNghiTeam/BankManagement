using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAO
{
    internal class GiaoDichDAO
    {
        DBConnection conn = new DBConnection();
        public GiaoDichDAO() { }
        public bool TaoGD(GiaoDich giaoDich)
        {
            string SQL = string.Format("INSERT INTO GiaoDich(NguoiGui, NguoiNhan, NgayGD, Tien) VALUES ('{0}', '{1}', '{2}', '{3}');",
                giaoDich.NguoiGui, giaoDich.NguoiNhan, giaoDich.NgayGD, giaoDich.Tien);
            if (conn.Execute(SQL))
            {
                return true;
            }
            return false;
        }
    }
}
