using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAO
{
    internal class KhoanVayDAO
    {
        DBConnection conn = new DBConnection();
        public KhoanVayDAO() { }
        public bool Tao(KhoanVay khoanVay)
        {
            string SQL = string.Format("INSERT INTO KhoanVay(SoTK, NgayVay, NgayHan, Tien, MaLS, TinhTrang, Loai) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}');",
                khoanVay.SoTK, khoanVay.NgayVay, khoanVay.NgayHan, khoanVay.Tien, khoanVay.MaLS, khoanVay.TinhTrang, khoanVay.Loai);
            if (conn.Execute(SQL))
            {
                return true;
            }
            return false;
        }
    }
}
