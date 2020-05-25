using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void danhMucChatLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChatlieu f1 = new FrmChatlieu();
            f1.Show();
        }

        private void danhMucHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHang f1 = new frmHang();
            f1.Show();
        }
    }
}
