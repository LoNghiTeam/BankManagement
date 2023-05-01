using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAO
{
    public class TheTinDungDAO
    {
        DBConnection conn = new DBConnection();
        public TheTinDungDAO() { }
        public TheTinDung TimTTD(int soTK, TheTinDung theTinDung)
        {
            string SQL = string.Format("select * from TheTinDung WHERE SoTK  = '{0}'", soTK);
            theTinDung = conn.FindTTD(SQL, theTinDung);
            return theTinDung;
        }
        public bool KiemTraThe(int soTK)
        {
            string SQL = string.Format("select * from TheTinDung WHERE SoTK  = '{0}'", soTK);
            return conn.checkExist(SQL);
        }
        public bool TaoThe(int soTK)
        {
            DateTime ngayHan = DateTime.Now.AddMonths(1);
            string SQL = string.Format("INSERT INTO TheTinDung(SoTK,NgayHan) VALUES ('{0}', '{1}');",
                soTK, ngayHan);
            return conn.Execute(SQL);
        }
        public bool CapNhatThe(TheTinDung theTinDung)
        {
            DateTime ngayHan = DateTime.Now.AddMonths(1);
            string SQL = string.Format("UPDATE TheTinDung SET DaVay = {1} , NgayHan = '{2}' , DiemThe = {3} where MaTTD ={0};",
                theTinDung.MaTTD, theTinDung.DaVay, theTinDung.NgayHan, theTinDung.DiemThe);
            return conn.Execute(SQL);
        }
    }
}
