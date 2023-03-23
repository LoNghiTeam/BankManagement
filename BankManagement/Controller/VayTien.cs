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
        LaiSuat laiSuat = new LaiSuat();
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

        public double TinhLaiSuat(double laiSuat, double tiLe)
        {
            return laiSuat * tiLe * 100 ;
        }
        public void TinhlaichangeTbTien(string thoigian, ref double tien, ref double lai) {

            switch (thoigian)
            {

                case "1 tháng":
                    tien += TinhTienLai(tien, lai / 100, 1);
                    break;
                case "3 tháng":
                    tien += TinhTienLai(tien, lai / 100, 3);
                    break;
                case "6 tháng":
                    tien += TinhTienLai(tien, lai / 100, 6);
                    break;
                case "12 tháng":
                    tien += TinhTienLai(tien, lai / 100, 12);
                    break;
                case "24 tháng":
                    tien += TinhTienLai(tien, lai / 100, 24);
                    break;
                case "36 tháng":
                    tien += TinhTienLai(tien, lai / 100, 36);
                    break;
            }
        }
        public void TinhlaichangecbThoiGian(ref int thoigian, string chuoithoigian, ref double lai)
        {
            thoigian = 0;
            lai = -1;
            laiSuat = GetLaiSuat();
            switch (chuoithoigian)
            {
                case "1 tháng":
                    double a = laiSuat.LaiVay;
                    lai = TinhLaiSuat(laiSuat.LaiVay, 0.8);
                    thoigian = 1;
                    break;
                case "3 tháng":
                    lai = TinhLaiSuat(laiSuat.LaiVay, 0.85);
                    thoigian = 3;
                    break;
                case "6 tháng":
                    lai = TinhLaiSuat(laiSuat.LaiVay, 0.9);
                    thoigian = 6;
                    break;
                case "12 tháng":
                    lai = TinhLaiSuat(laiSuat.LaiVay, 1);
                    thoigian = 12;
                    break;
                case "24 tháng":
                    lai = TinhLaiSuat(laiSuat.LaiVay, 1.1);
                    thoigian = 24;
                    break;
                case "36 tháng":
                    lai = TinhLaiSuat(laiSuat.LaiVay, 1.2);
                    thoigian = 36;
                    break;
            }
        }
    }
}
