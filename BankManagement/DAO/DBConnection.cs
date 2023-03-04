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
        public string thucthi(string Sql)
        {
            try
            {
                // Ket noi
                conn.Open();

                SqlCommand cmd = new SqlCommand(Sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return "";
            }
            catch (Exception ex)
            {
                return ex + "";
            }
            finally
            {
                conn.Close();
            }
            return "";
        }
        public bool searchDN(string Sql)
        {
            SqlDataReader reader1;
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
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public DataTable Load(string table)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM {0}", table);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }

}
