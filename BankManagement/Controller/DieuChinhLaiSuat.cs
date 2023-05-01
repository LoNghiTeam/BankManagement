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
                case ((int)LoaiLaiSuat.laivay):
                    laiSuat.LaiVay = gtMoi / 100;
                    break;
                case ((int)LoaiLaiSuat.laigui):
                    laiSuat.LaiGui = gtMoi / 100;
                    break;
                case ((int)LoaiLaiSuat.tile):
                    laiSuat.TiLe = gtMoi;
                    break;
                case ((int)LoaiLaiSuat.quydoiTD):
                    laiSuat.QuyDoiTD = gtMoi;
                    break;
            }
            laiSuat.NgayApDung = DateTime.Now;
            return laiSuatDAO.taoLaiSuat(laiSuat);
        }

    }
}
