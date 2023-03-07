using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Model
{
    internal class TaiKhoan
    {
        private int soTK;
        private String userName;
        private String pass;
        private String hoTen;
        private DateTime ngaySinh;
        private String cccd;
        private String diaChi;
        private String soDienThoai;
        private int isAdmin;
        private double tien;

        public TaiKhoan()
        {
        }
        public TaiKhoan(int soTK, String userName, String pass, String hoTen, DateTime ngaySinh, String cccd, String diaChi, String soDienThoai, int isAdmin, float tien)
        {
            this.soTK = soTK;
            this.userName = userName;
            this.pass = pass;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.cccd = cccd;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.isAdmin = isAdmin;
            this.tien = tien;
        }


        public int SoTK
        {
            get { return soTK; }
            set
            {
                soTK = value;
            }
        }

        public String UserName
        {
            get { return userName; }
            set
            {
                userName = value;
            }
        }

        public String Pass
        {
            get { return pass; }
            set
            {
                pass = value;
            }
        }

        public String HoTen
        {
            get { return hoTen; }
            set
            {
                hoTen = value;
            }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set
            {
                ngaySinh = value;
            }
        }
        public String Cccd
        {
            get { return cccd; }
            set
            {
                cccd = value;
            }
        }
        public String DiaChi
        {
            get { return diaChi; }
            set
            {
                diaChi = value;
            }
        }
        public String SoDienThoai
        {
            get { return soDienThoai; }
            set
            {
                soDienThoai = value;
            }
        }

        public int IsAdmin
        {
            get { return isAdmin; }
            set
            {
                isAdmin = value;
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
    }
}
