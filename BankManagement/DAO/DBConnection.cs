using BankManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement.DAO
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public DataTable LayDanhSach(string sqlStr)
        {
            DataTable dtds = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtds);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtds;
        }
        public Boolean checkExist(string Sql)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(Sql, conn);   
               SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public string LayTen(string Sql)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(Sql, conn);
                return (string)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return "";
            }
            finally
            {
                conn.Close();
            }
            
        }
        public Boolean Execute(string Sql)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(Sql, conn);   
              
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public TaiKhoan FindTK(string Sql)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(Sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    taiKhoan.SoTK = (int)reader["SoTK"];
                    taiKhoan.UserName = reader["UserName"].ToString();
                    taiKhoan.Pass = reader["Pass"].ToString();
                    taiKhoan.HoTen = reader["HoTen"].ToString();
                    taiKhoan.NgaySinh = (DateTime)reader["NgaySinh"];
                    taiKhoan.Cccd = (string)reader["Cccd"];
                    taiKhoan.DiaChi = reader["Diachi"].ToString();
                    taiKhoan.SoDienThoai = reader["Sodienthoai"].ToString();
                    taiKhoan.IsAdmin = (int)reader["isAdmin"];
                    taiKhoan.Tien = (double)reader["Tien"];
                    taiKhoan.DiemTD = (int)reader["diemTD"];   
                    return taiKhoan;
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
        public double FindTien(string Sql)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(Sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return (double)reader["Tien"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return -1;
            }
            finally
            {
                conn.Close();
            }
            return -1;
        }
    }

}
