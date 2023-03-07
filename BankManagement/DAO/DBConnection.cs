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
      
        public Boolean checkDN(string Sql)
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
       
    }

}
