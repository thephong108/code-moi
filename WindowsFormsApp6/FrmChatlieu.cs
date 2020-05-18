using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp6
{
    public partial class FrmChatlieu : Form
    {
        public FrmChatlieu()
        {
            InitializeComponent();
        }

        private void gridviewCL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
         
        }

        private void FrmChatlieu_Load(object sender, EventArgs e)
        {
            LoaddatatoGridview();
        }

        private void LoaddatatoGridview()
        {
            try
            { 
            DAO.OpenConnection();
            string sql = "select * from tblChatlieu ";
            SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable tblchatlieu = new DataTable();
            myAdapter.Fill(tblchatlieu);
            gridviewCL.DataSource = tblchatlieu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
            
        }

        private void gridviewCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenCL.Text = gridviewCL.CurrentRow.Cells["Tenchatlieu"].Value.ToString();
            txtMaCL.Text = gridviewCL.CurrentRow.Cells["Machatlieu"].Value.ToString();
            txtMaCL.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblChatlieu set Tenchatlieu = N'" + txtTenCL.Text.Trim() + "' where Machatlieu = '" + txtMaCL.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblChatlieu where Machatlieu = '" + txtMaCL.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaCL.Enabled = true;
            txtTenCL.Enabled = true;
        }
    }
}
