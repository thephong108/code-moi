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
            txtTenCL.Text = gridviewCL.CurrentRow.Cells["TenCL"].Value.ToString();
            txtMaCL.Text = gridviewCL.CurrentRow.Cells["MaCL"].Value.ToString();
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
            string sql = "delete from tblChatlieu where Machatlieu = '"+ txtMaCL.Text + "'";
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
            //xoa du lieu trong text box
            txtMaCL.Text = "";
            txtTenCL.Text = "";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //kiem tra dieu kien
            if(txtMaCL.Text == "")
            {
                MessageBox.Show(" ban chua nhap ma cl");
                txtMaCL.Focus();
                return;
            }
            if(txtTenCL.Text =="")
            {
                MessageBox.Show("ban chua nhap ten chat lieu");
                txtTenCL.Focus();
                return;
            }
            string sqlCheckkey = "Select * from tblChatlieu where machatlieu = '" + txtMaCL.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.checkKeyexit(sqlCheckkey))
            {
                MessageBox.Show("Ma chat lieu da ton tai");
                DAO.CloseConnection();
                txtMaCL.Focus();
                return;
            }
            else
            {
                string sql = "insert into tblChatlieu values('" + txtMaCL.Text.Trim() + "', N' " + txtTenCL.Text.Trim() + "')";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoaddatatoGridview();
            }
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
