using BankManagement.Controller;
using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Service
{
    internal class TatToanSTK
    {

        LaiSuat laiSuat = new LaiSuat();
        TinhLai tinhLai = new TinhLai();
        public TatToanSTK() { }

        public double TinhTienPhat(int days, double tienLai , TimeSpan thoiHan)
        {
            double tienPhat = tienLai * days/thoiHan.Days + 10;
            return tienPhat;
        }

        internal double TinhTienLai(SoTietKiem stk)
        {
            TimeSpan thoiHan = stk.NgayHan - stk.NgayVay;
            double tienLai = 0;

            switch (thoiHan.Days/30)
            {
                case (int)ThoiHanGiaoDich.OneMonth:
                    tienLai = stk.Tien * 0.008 * 1 / 12;
                    break;
                case (int)ThoiHanGiaoDich.ThreeMonths:
                    tienLai = stk.Tien * 0.0085 * 3 / 12;
                    break;
                case (int)ThoiHanGiaoDich.SixMonths:
                    tienLai = stk.Tien * 0.009 * 6 / 12;
                    break;
                case (int)ThoiHanGiaoDich.TwelveMonths:
                    tienLai = stk.Tien * 0.01 * 12 / 12;
                    break;
                case (int)ThoiHanGiaoDich.TwentyFourMonths:
                    tienLai = stk.Tien * 0.011 * 24 / 12;
                    break;
                case (int)ThoiHanGiaoDich.ThirtySixMonths:
                    tienLai = stk.Tien * 0.012 * 36 / 12;
                    break;
                default:
                    break;
            }
            return tienLai;
        }
    }
}
