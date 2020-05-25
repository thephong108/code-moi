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
using System.Data;

namespace WindowsFormsApp6
{
    public partial class frmHang : Form
    {
        public frmHang()
        {
            InitializeComponent();
        }

        private void FrmHang_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            LoaddatatoGridview();
            filldatatocombo();
            DAO.CloseConnection();

        }


        private void LoaddatatoGridview()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblHang ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblHang = new DataTable();
            
                myAdapter.Fill(tblHang);
                gridviewDMhang.DataSource = tblHang;
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
        public void filldatatocombo()
        {
            string sql = "select * from tblChatlieu";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbChatlieu.DataSource = table;
            cmbChatlieu.ValueMember = "Machatlieu";
            cmbChatlieu.DisplayMember = "Tenchatlieu";


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMahang.Enabled = true;
            //xoa du lieu trong text box
            txtMahang.Text = "";
            txtTenhang.Text = "";
            txtGianhap.Text = "";
            txtGiaban.Text = "";
            txtSoluong.Text = "";
            cmbChatlieu.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
            {
                MessageBox.Show(" ban chua nhap ma hang");
                txtMahang.Focus();
                return;
            }
            if (txtTenhang.Text == "")
            {
                MessageBox.Show("ban chua nhap ten hang");
                txtTenhang.Focus();
                return;
            }
            if (cmbChatlieu.SelectedIndex==-1)
            {
                MessageBox.Show("ban chua chon ma chat lieu");
                return;
            }
            if (txtGianhap.Text == "")
            {
                MessageBox.Show("ban chua nhap gia nhap");
                txtGianhap.Focus();
                return;
            }
            if (txtGiaban.Text == "")
            {
                MessageBox.Show("ban chua nhap gia ban");
                txtGiaban.Focus();
                return;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("ban chua nhap so luong");
                txtSoluong.Focus();
                return;
            }
            string sqlCheckkey = "Select * from tblHang where Mahang = '" + txtMahang.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.checkKeyexit(sqlCheckkey))
            {
                MessageBox.Show("Ma hang da ton tai");
                DAO.CloseConnection();
                txtMahang.Focus();
                return;
            }
            else
            {
                string sql = "insert into tblhang values('"+ txtMahang.Text.Trim()+"', N'" + txtTenhang.Text.Trim()
                    + "','" + cmbChatlieu.SelectedValue.ToString()

                    + "'," + txtSoluong.Text.Trim() +"," + txtGianhap.Text.Trim() + "," + txtGiaban.Text.Trim() + ",null,null)";

                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();   
                LoaddatatoGridview();
                filldatatocombo();
                DAO.CloseConnection();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblhang where Mahang = '" + txtMahang.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void gridviewDMhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblHang set Tenhang = N'" + txtTenhang.Text.Trim() + "' where Mahang = '" + txtMahang.Text.Trim()+"'"; 
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void gridviewDMhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahang.Enabled = false;
            txtTenhang.Text = gridviewDMhang.CurrentRow.Cells["Tenhang"].Value.ToString();
            txtMahang.Text = gridviewDMhang.CurrentRow.Cells["Mahang"].Value.ToString();
            txtSoluong.Text = gridviewDMhang.CurrentRow.Cells["soluong"].Value.ToString();
            txtGianhap.Text = gridviewDMhang.CurrentRow.Cells["Gianhap"].Value.ToString();
            txtGiaban.Text = gridviewDMhang.CurrentRow.Cells["Giaban"].Value.ToString();
            cmbChatlieu.Text = gridviewDMhang.CurrentRow.Cells["Macl"].Value.ToString();
        }
    }
}
