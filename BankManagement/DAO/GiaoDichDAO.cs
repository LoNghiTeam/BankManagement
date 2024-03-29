﻿using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.DAO
{
    internal class GiaoDichDAO
    {
        DBConnection conn = new DBConnection();
        public GiaoDichDAO() { }
        public bool TaoGD(GiaoDich giaoDich)
        {
            string SQL = string.Format("INSERT INTO GiaoDich(NguoiGui, NguoiNhan, NgayGD, Tien, LoaiGD) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');",
                giaoDich.NguoiGui, giaoDich.NguoiNhan, giaoDich.NgayGD, giaoDich.Tien, giaoDich.Loai);
            return conn.Execute(SQL);

        }
        public DataTable LayDanhSachGD()
        {
            string sqlStr = string.Format("Select * from GiaoDich where LoaiGD = 1");
            return conn.LayDanhSach(sqlStr);
        }
        public DataTable LayDanhSachGD(int soTK)
        {
            string sqlStr = string.Format("Select * from GiaoDich where (NguoiNhan = {0} or NguoiGui = {1}) and LoaiGD = 1", soTK, soTK);
            return conn.LayDanhSach(sqlStr);
        }
        public DataTable TimKiemGDCB(string text, string option)
        {
            string sqlStr = string.Format("SELECT * FROM GiaoDich WHERE "+option, text);
            return conn.LayDanhSach(sqlStr);
        }
        public string LayTenKH(int maTK)
        {
            string sqlStr = string.Format("Select HoTen from TaiKhoan WHERE SoTk = '{0}'", maTK);
            return conn.LayTen(sqlStr);
        }
        public DataTable TimKiemGDNC(string option)
        {
            string sqlStr = string.Format("SELECT * FROM GiaoDich WHERE " + option);
            return conn.LayDanhSach(sqlStr);
        }
    }
}
