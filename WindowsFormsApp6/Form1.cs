﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql = "select * from tblHang ";
            SqlDataAdapter adap = new SqlDataAdapter(sql,DAO.conn);
            DataTable table = new DataTable();
            adap.Fill(table);
            dataGridView1.DataSource = table;

        }
    }
}
