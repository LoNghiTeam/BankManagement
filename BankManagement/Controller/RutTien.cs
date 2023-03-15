using BankManagement.DAO;
using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Controller
{
    internal class RutTien
    {
        GiaoDichDAO giaoDichDAO = new GiaoDichDAO();    
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        public TaiKhoan TimNguoiNhan(int SoTK)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan = taiKhoanDAO.TimSoTK(SoTK);
            if (taiKhoan != null)
                return taiKhoan;
            return null;
        }
        public bool TaoGiaoDich(int nguoigui, int nguoinhan, DateTime ngayGD, double tien)
        {
            GiaoDich giaoDich = new GiaoDich(nguoigui, nguoinhan, ngayGD, tien);
            if (giaoDichDAO.TaoGD(giaoDich))
                return true;
            return false;
        }
        public bool GiaoDichTien(int nguoigui, double tiengiaodich)
        {
            double tiennhan = taiKhoanDAO.TimTien(nguoigui);
            if (tiennhan != -1)
            {
                tiennhan -= tiengiaodich;
                if (taiKhoanDAO.CapNhatTien(nguoigui, tiennhan))
                    return true;
                return false;
            }
            return false;
        }
    }
}
