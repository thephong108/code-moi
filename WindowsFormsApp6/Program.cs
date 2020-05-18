using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsFormsApp6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Data Source = MSI; Initial Catalog = quanlybanhang; Integrated Security = True
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = MSI; Initial Catalog = quanlybanhang; Integrated Security = True";
            try
            {
                conn.Open();
              //  MessageBox.Show("mo ket noi thanh cong");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
       
            Application.Run(new FrmChatlieu());
        }
    }
}
