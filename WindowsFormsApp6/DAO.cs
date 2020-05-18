using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    class DAO
    {
       public static SqlConnection conn;
      public  static string connectionString = "Data Source = MSI; Initial Catalog = quanlybanhang; Integrated Security = True";
        public static void OpenConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            if (conn.State == System.Data.ConnectionState.Closed)
                try
                {
                    conn.Open();
                    //MessageBox.Show("mo ket noi thanh cong");

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

        }
        public static void CloseConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            if (conn.State == System.Data.ConnectionState.Open)
                try
                {
                    conn.Close();
                    MessageBox.Show("Đóng ket noi thanh cong");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

        }
    }
}
  