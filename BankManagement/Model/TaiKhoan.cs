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
        private int diemTD;

        public TaiKhoan()
        {
        }
        public TaiKhoan(string soTK,String hoTen, DateTime ngaySinh, String cccd, String diaChi, String soDienThoai, int diemTD)
        {
            this.SoTK = Int32.Parse(soTK);
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.cccd = cccd;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.diemTD = diemTD;
            this.diemTD = diemTD;
        }

        public TaiKhoan(String userName, String pass, String hoTen, DateTime ngaySinh, String cccd, String diaChi, String soDienThoai, int diemTD)
        {
            this.userName = userName;
            this.pass = pass;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.cccd = cccd;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.diemTD = diemTD;
        }

        public TaiKhoan(int soTK, String userName, String pass, String hoTen, DateTime ngaySinh, String cccd, String diaChi, String soDienThoai, int isAdmin, float tien, int diemTD)
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
            this.diemTD = diemTD;
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
        public int DiemTD
        {
            get { return diemTD; }
            set
            {
                diemTD = value;
            }
        }
    }
}
