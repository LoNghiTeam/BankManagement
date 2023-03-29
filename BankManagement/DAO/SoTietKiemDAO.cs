using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAO
{
    internal class SoTietKiemDAO
    {
        DBConnection conn = new DBConnection();
        public SoTietKiemDAO() { }
        public bool TaoSTK(SoTietKiem soTietKiem)
        {
            string SQL = string.Format("INSERT INTO SoTietKiem(SoTK,TenSo, NgayVay, Ngayhan, Tien, MaLS, TinhTrang) VALUES ('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}');",
                soTietKiem.SoTK, soTietKiem.TenSo, soTietKiem.NgayVay, soTietKiem.NgayHan, soTietKiem.Tien, soTietKiem.MaLS, soTietKiem.TinhTrang);
            if (conn.Execute(SQL))
            {
                return true;
            }
            return false;
        }
    }
}
