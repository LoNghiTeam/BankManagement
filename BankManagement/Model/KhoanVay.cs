using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Model
{
    internal class KhoanVay
    {


        public KhoanVay()
        {

        }
        public KhoanVay(int soTK, DateTime ngayVay, DateTime ngayHan, double tien, int maLS, int tinhTrang, int loai)
        {
            this.soTK = soTK;
            this.ngayVay = ngayVay;
            this.tien = tien;
            this.maLS = maLS;
            this.ngayHan = ngayHan;
            this.tinhTrang = tinhTrang;
            this.loai = loai;
        }
        public KhoanVay(int maKV, int soTK, DateTime ngayVay, DateTime ngayHan, double tien, int maLS, int tinhTrang, int loai)
        {
            this.maKV = maKV;
            this.soTK = soTK;
            this.ngayVay = ngayVay;
            this.tien = tien;
            this.maLS = maLS;
            this.ngayHan = ngayHan;
            this.tinhTrang = tinhTrang;
            this.loai = loai;
        }
        private int maKV;
        private int soTK;
        private DateTime ngayVay;
        private DateTime ngayHan;
        private double tien;
        private int maLS;
        private int tinhTrang;
        private int loai;

        public int MaKV
        {
            get => maKV;
            set
            {
                maKV = value;
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

        public DateTime NgayVay
        {
            get => ngayVay;
            set
            {
                ngayVay = value;
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

        public double Tien
        {
            get => tien;
            set
            {
                tien = value;
            }
        }

        public int TinhTrang
        {
            get => tinhTrang;
            set
            {
                tinhTrang = value;
            }
        }

        public int Loai
        {
            get => loai;
            set
            {
                loai = value;
            }
        }

        public int MaLS
        {
            get => maLS;
            set
            {
                maLS = value;
            }
        }
    }
}
