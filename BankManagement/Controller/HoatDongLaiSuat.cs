using BankManagement.DAO;
using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Controller
{

   
    public class HoatDongLaiSuat
    {
        LaiSuat laiSuat = new LaiSuat();
        LaiSuatDAO laiSuatDAO = new LaiSuatDAO();
        public HoatDongLaiSuat() { }
        public LaiSuat GetLaiSuat(LaiSuat laiSuat)
        {
            laiSuat = laiSuatDAO.find(laiSuat);
            return laiSuat;
        }
        public double TinhTienTheoDiemTD(int diemTD)
        {
            laiSuat = GetLaiSuat(laiSuat);
            return diemTD * laiSuat.QuyDoiTD;
        } 
        public double TinhSoDu(double daVay, int diemTD) {
            double soDu = TinhTienTheoDiemTD(diemTD) - daVay;
            if (soDu < 0)
                soDu = 0;
            return soDu;
        }
        
    }
}

