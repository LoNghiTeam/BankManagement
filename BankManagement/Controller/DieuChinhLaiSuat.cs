using BankManagement.DAO;
using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Controller
{
    internal class DieuChinhLaiSuat
    {
        LaiSuatDAO laiSuatDAO = new LaiSuatDAO();   
        public DieuChinhLaiSuat(){ }
        public bool dieuchinh(int type, LaiSuat laiSuat, double gtMoi)
        {
            switch (type)
            {
                case (1):
                    laiSuat.LaiVay = gtMoi / 100;
                    break;
                case (2):
                    laiSuat.LaiGui = gtMoi / 100;
                    break;
                case (3):
                    laiSuat.TiLe = gtMoi;
                    break;
                case (4):
                    laiSuat.QuyDoiTD = gtMoi;
                    break;
            }
            laiSuat.NgayApDung = DateTime.Now;
            if(laiSuatDAO.taoLaiSuat(laiSuat))
                return true;
            return false;
        }

    }
}
