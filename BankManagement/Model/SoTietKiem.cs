using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Model
{
    public class SoTietKiem
    {
        public SoTietKiem() { }

        public SoTietKiem( int maSTK,int soTK, string tenSo, DateTime ngayVay, DateTime ngayHan, double tien, int maLS, int tinhTrang) {
            this.maSTK = maSTK;
            this.soTK = soTK;
            this.tenSo = tenSo;
            this.ngayVay = ngayVay;
            this.ngayHan = ngayHan;
            this.tien = tien;
            this.maLS = maLS;
            this.tinhTrang = tinhTrang;
        }
        public SoTietKiem(int soTK, string tenSo, DateTime ngayVay, DateTime ngayHan, double tien, int maLS, int tinhTrang)
        {
            this.soTK = soTK;
            this.tenSo = tenSo;
            this.ngayVay = ngayVay;
            this.ngayHan = ngayHan;
            this.tien = tien;
            this.maLS = maLS;
            this.tinhTrang = tinhTrang;
        }
        private int maSTK;
        private int soTK;
        private string tenSo;
        private DateTime ngayVay;
        private DateTime ngayHan;
        private double tien;
        private int maLS;
        private int tinhTrang;

        public int MaSTK
        {
            get { return maSTK; }
            set
            {
                maSTK = value;
            }
        }
        public int SoTK
        {
            get { return soTK; }
            set
            {
                soTK = value;
            }
        }
        public string TenSo
        {
            get { return tenSo; }
            set
            {
                tenSo = value;
            }
        }
        public DateTime NgayVay
        {
            get { return ngayVay; }
            set
            {
                ngayVay = value;
            }
        }

        public DateTime NgayHan
        {
            get { return ngayHan; }
            set
            {
                ngayHan = value;
            }
        }

        public double Tien
        {
            get { return tien; }
            set
            {
                tien = value;
            }
        }

        public int MaLS
        {
            get { return maLS; }
            set
            {
                maLS = value;
            }
        }
        public int TinhTrang
        {
            get { return tinhTrang; }
            set
            {
                tinhTrang = value;
            }
        }


    }
}
    

    


