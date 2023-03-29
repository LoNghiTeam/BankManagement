using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Controller
{
    internal class TinhLai
    {
        public TinhLai() { }
        public double TinhTienLai(double tien, double lai, int thoigian)
        {
            return tien * lai / 12 * thoigian;
        }
        public double TinhLaiSuat(double laiSuat, double tiLe)
        {
            return laiSuat * tiLe * 100;
        }
    }
}
