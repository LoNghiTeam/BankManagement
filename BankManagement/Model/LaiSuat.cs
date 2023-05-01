using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Model
{
    public class LaiSuat
    {
        private int maLS;
        private double laiGui;
        private double laiVay;
        private double tiLe;
        private double quyDoiTD;
        private DateTime ngayApDung;


        public LaiSuat()
        {
        }

        public int MaLS
        {
            get { return maLS; }
            set
            {
                maLS = value;
            }
        }

        public double LaiGui
        {
            get { return laiGui; }
            set
            {
                laiGui = value;
            }
        }

        public double LaiVay
        {
            get { return laiVay; }
            set
            {
                laiVay = value;
            }
        }
        public double TiLe
        {
            get { return tiLe; }
            set
            {
                tiLe = value;
            }
        }

        public double QuyDoiTD
        {
            get { return quyDoiTD; }
            set
            {
                quyDoiTD = value;
            }
        }

        public DateTime NgayApDung
        {
            get { return ngayApDung; }
            set
            {
                ngayApDung = value;
            }
        }

    }
}
