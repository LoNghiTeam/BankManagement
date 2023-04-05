using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BankManagement.DAO
{

    internal class LaiSuatDAO
    {
        DBConnection dBConnection = new DBConnection();
        public LaiSuatDAO() { }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public LaiSuat find()
        {
            LaiSuat laiSuat = new LaiSuat();
            string sql = string.Format("select top(1) * from LaiSuat ORDER BY MaLS DESC");
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    laiSuat.MaLS = (int)reader["MaLS"];
                    laiSuat.LaiVay = (double)reader["LaiVay"];
                    laiSuat.LaiGui = (double)reader["LaiGui"];
                    laiSuat.TiLe = (double)reader["TiLe"];
                    laiSuat.QuyDoiTD = (double)reader["QuyDoiTD"];
                    laiSuat.NgayApDung = (DateTime)reader["NgayApDung"];
                    return laiSuat;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return null;
            }
            finally
            {
                conn.Close();
            }


            return null;
        }
        public bool taoLaiSuat(LaiSuat laiSuat)
        {
            string SQL = string.Format("INSERT INTO LaiSuat(LaiGui, LaiVay, NgayApDung)  VALUES ('{0}', '{1}', '{2}');",
                laiSuat.LaiGui, laiSuat.LaiVay, laiSuat.NgayApDung);
            if (dBConnection.Execute(SQL))
            {
                return true;
            }
            return false;
        }
    }
}
