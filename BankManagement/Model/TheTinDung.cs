using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Model
{
    public class TheTinDung
    {
        private int maTTD;
        private int soTK;
        private int diemThe;
        private DateTime ngayHan;
        private double daVay;
        private int khoa;

        public TheTinDung() { }

        public int MaTTD
        {
            get => maTTD;
            set
            {
                maTTD = value;
            }
        }
        public int SoTK
        {
            get => soTK;
            set
            {
                soTK = value;
            }
        }
        public int DiemThe
        {
            get => diemThe;
            set
            {
                diemThe = value;
            }
        }

        public DateTime NgayHan
        {
            get => ngayHan;
            set
            {
                ngayHan = value;
            }
        }
        public double DaVay
        {
            get => daVay;
            set
            {
                daVay = value;
            }
        }
        public int Khoa
        {
            get => khoa;
            set
            {
                khoa = value;
            }
        }


    }
}
