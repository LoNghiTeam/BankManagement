using BankManagement.DAO;
using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Controller
{
    
    internal class VayTien
    {
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();    
        LaiSuatDAO laiSuatDAO = new LaiSuatDAO();  
        KhoanVayDAO khoanVayDAO = new KhoanVayDAO();
        public TaiKhoan TimNguoiNhan(int SoTK)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan = taiKhoanDAO.TimSoTK(SoTK);
            if (taiKhoan != null)
                return taiKhoan;
            return null;
        }

        public LaiSuat GetLaiSuat()
        {
            LaiSuat laiSuat = new LaiSuat();
            laiSuat = laiSuatDAO.find();
            if (laiSuat != null)
            { return laiSuat; }
            return null;
        }
        public double TinhTienLai(double tien, double lai, int thoigian)
        {
            return tien*lai/12*thoigian;
        }

        public bool TaoKhoanVay(int soTK, DateTime ngayVay, int thoigian, double tien, int maLS, int tinhTrang, int loai)
        {

            DateTime ngayHan = ngayVay.AddMonths(thoigian);
            KhoanVay khoanVay = new KhoanVay(soTK, ngayVay, ngayHan, tien, maLS, tinhTrang, loai);
            if (khoanVayDAO.Tao(khoanVay))
            { return true; }
            return false;
        }
    }
}
