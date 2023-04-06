using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Model
{
    public class GiaoDich
    {
        private int maGD;
        private int nguoiGui;
        private int nguoiNhan;
        private DateTime ngayGD;
        private double tien;
        private int loai;

        public GiaoDich() { }
        public GiaoDich(int nguoiNhan, DateTime ngayGD, double tien, int loai)
        {
            this.nguoiNhan = nguoiNhan;
            this.tien = tien;
            this.ngayGD = ngayGD;
            this.loai = loai;
        }
        
        public GiaoDich(int maGD, int nguoiGui, int nguoiNhan, DateTime ngayGD, double tien, int loai)
        {
            this.maGD = maGD;
            this.nguoiGui = nguoiGui;
            this.nguoiNhan = nguoiNhan;
            this.ngayGD = ngayGD;
            this.tien = tien;
            this.loai = loai;
        }
        public GiaoDich(int nguoiGui, int nguoiNhan, DateTime ngayGD, double tien, int loai)
        {
            this.nguoiGui = nguoiGui;
            this.nguoiNhan = nguoiNhan;
            this.tien = tien;
            this.ngayGD = ngayGD;
            this.loai = loai;
        }

        public int MaGD
        {
            get { return maGD; }
            set
            {
                maGD = value;
            }
        }

        public int NguoiGui
        {
            get { return nguoiGui; }
            set
            {
                nguoiGui = value;
            }
        }

        public int NguoiNhan
        {
            get { return nguoiNhan; }
            set
            {
                nguoiNhan = value;
            }
        }

        public DateTime NgayGD
        {
            get { return ngayGD; }
            set
            {
                ngayGD = value;
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

        public int Loai
        {
            get { return loai; }
            set
            {
                loai = value;
            }
        }
    }
}
