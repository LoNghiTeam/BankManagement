using BankManagement.DAO;
using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Controller
{
    internal class GuiTien
    {
        LaiSuat laiSuat = new LaiSuat();
        TinhLai tinhLai = new TinhLai();
        LaiSuatDAO laiSuatDAO = new LaiSuatDAO();
        SoTietKiemDAO soTietKiemDAO = new SoTietKiemDAO();
        public GuiTien() { }
        public void TinhlaichangecbThoiGian(ref int thoigian, string chuoithoigian, ref double lai)
        {
            thoigian = 0;
            lai = -1;
            laiSuat = laiSuatDAO.find();
            switch (chuoithoigian)
            {
                case "1 tháng":
                    double a = laiSuat.LaiVay;
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 0.8);
                    thoigian = 1;
                    break;
                case "3 tháng":
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 0.85);
                    thoigian = 3;
                    break;
                case "6 tháng":
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 0.9);
                    thoigian = 6;
                    break;
                case "12 tháng":
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 1);
                    thoigian = 12;
                    break;
                case "24 tháng":
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 1.1);
                    thoigian = 24;
                    break;
                case "36 tháng":
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 1.2);
                    thoigian = 36;
                    break;
                case "Không thời hạn":
                    lai = tinhLai.TinhLaiSuat(laiSuat.LaiVay, 0.7);
                    thoigian = 12;
                    break;
            }
        }

        public void TinhlaichangeTbGuiTien(string thoigian, ref double tien, ref double lai)
        {

            switch (thoigian)
            {

                case "1 tháng":
                    tien += tinhLai.TinhTienLai(tien, lai / 100, 1);
                    break;
                case "3 tháng":
                    tien += tinhLai.TinhTienLai(tien, lai / 100, 3);
                    break;
                case "6 tháng":
                    tien += tinhLai.TinhTienLai(tien, lai / 100, 6);
                    break;
                case "12 tháng":
                    tien += tinhLai.TinhTienLai(tien, lai / 100, 12);
                    break;
                case "24 tháng":
                    tien += tinhLai.TinhTienLai(tien, lai / 100, 24);
                    break;
                case "36 tháng":
                    tien += tinhLai.TinhTienLai(tien, lai / 100, 36);
                    break;
                case "Không thời hạn":
                    tien += tinhLai.TinhTienLai(tien, lai / 100, 12);
                    break;
            }
        }

        public bool TaoSoTietKiem(int soTK,string tenSo,  DateTime ngayGui, int thoiGian, double tienGui, int maLS)
        {
            DateTime ngayHan = new DateTime();
            if (thoiGian != 0)
                ngayHan = ngayGui.AddMonths(thoiGian);
            SoTietKiem soTietKiem = new SoTietKiem(soTK, tenSo, ngayGui, ngayHan, tienGui, maLS, 0);
            if (soTietKiemDAO.TaoSTK(soTietKiem))
                return true;
            return false;
        }
    }
}

