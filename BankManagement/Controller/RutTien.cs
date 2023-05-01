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
            return taiKhoan;
        }
        public bool TaoGiaoDich(int nguoigui, int nguoinhan, DateTime ngayGD, double tien, int loai)
        {
            GiaoDich giaoDich = new GiaoDich(nguoigui, nguoinhan, ngayGD, tien, loai);
            return giaoDichDAO.TaoGD(giaoDich);

        }
        public bool GiaoDichTien(int nguoigui, double tiengiaodich)
        {
            double tiennhan = taiKhoanDAO.TimTien(nguoigui);
            if (tiennhan != -1)
            {
                tiennhan -= tiengiaodich;
                return taiKhoanDAO.CapNhatTien(nguoigui, tiennhan);
            }
            return false;
        }
    }
}
