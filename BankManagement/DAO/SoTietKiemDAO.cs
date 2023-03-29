using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
        public void Sua(SoTietKiem stk)
        {
            string sqlStr = string.Format(
                "UPDATE SoTietKiem SET SoTK = '{0}', TenSo='{1}', NgayVay='{2}', Ngayhan='{3}', Tien='{4}', MaLS='{5}', TinhTrang='{6}' WHERE MaSTK = '{7}'",
                stk.SoTK, stk.TenSo, stk.NgayVay, stk.NgayHan, stk.Tien, stk.MaLS, stk.TinhTrang, stk.MaSTK);
            conn.Execute(sqlStr);
        }
        public DataTable LayDanhSachSTK()
        {
            string sqlStr = string.Format("SELECT * FROM SoTietKiem");
            return conn.LayDanhSach(sqlStr);
        }
    }
}
