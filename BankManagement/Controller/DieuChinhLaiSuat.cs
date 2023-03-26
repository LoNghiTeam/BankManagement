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
        public bool dieuchinh(int type, LaiSuat laiSuat, double laiMoi)
        {
            if(type == 1)
            {
                laiSuat.LaiVay = laiMoi/100;
            }
            else if(type == 2)
            {
                laiSuat.LaiGui = laiMoi/100;
            }
            laiSuat.NgayApDung = DateTime.Now;
            if(laiSuatDAO.taoLaiSuat(laiSuat))
                return true;
            return false;
        }

    }
}
