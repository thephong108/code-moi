namespace WindowsFormsApp6
{
    partial class frmHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridviewDMhang = new System.Windows.Forms.DataGridView();
            this.Mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChatlieu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDMhang)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewDMhang
            // 
            this.gridviewDMhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewDMhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahang,
            this.Tenhang,
            this.MaCL,
            this.Gianhap,
            this.Giaban,
            this.Soluong});
            this.gridviewDMhang.Location = new System.Drawing.Point(71, 305);
            this.gridviewDMhang.Name = "gridviewDMhang";
            this.gridviewDMhang.RowTemplate.Height = 24;
            this.gridviewDMhang.Size = new System.Drawing.Size(833, 188);
            this.gridviewDMhang.TabIndex = 0;
            this.gridviewDMhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewDMhang_CellClick);
            this.gridviewDMhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewDMhang_CellContentClick);
            // 
            // Mahang
            // 
            this.Mahang.DataPropertyName = "Mahang";
            this.Mahang.HeaderText = "Ma Hang";
            this.Mahang.Name = "Mahang";
            // 
            // Tenhang
            // 
            this.Tenhang.DataPropertyName = "Tenhang";
            this.Tenhang.HeaderText = "Ten hang";
            this.Tenhang.Name = "Tenhang";
            // 
            // MaCL
            // 
            this.MaCL.DataPropertyName = "Machatlieu";
            this.MaCL.HeaderText = "Ma chat lieu";
            this.MaCL.Name = "MaCL";
            // 
            // Gianhap
            // 
            this.Gianhap.DataPropertyName = "Dongianhap";
            this.Gianhap.HeaderText = "Gia nhap";
            this.Gianhap.Name = "Gianhap";
            // 
            // Giaban
            // 
            this.Giaban.DataPropertyName = "Dongiaban";
            this.Giaban.HeaderText = "Gia Ban";
            this.Giaban.Name = "Giaban";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "So luong";
            this.Soluong.Name = "Soluong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma Hang";
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(193, 42);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(207, 22);
            this.txtMahang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ten hang";
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(193, 99);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(207, 22);
            this.txtTenhang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chat lieu";
            // 
            // cmbChatlieu
            // 
            this.cmbChatlieu.FormattingEnabled = true;
            this.cmbChatlieu.Location = new System.Drawing.Point(696, 44);
            this.cmbChatlieu.Name = "cmbChatlieu";
            this.cmbChatlieu.Size = new System.Drawing.Size(208, 24);
            this.cmbChatlieu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gia nhap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gia ban";
            // 
            // txtGianhap
            // 
            this.txtGianhap.Location = new System.Drawing.Point(697, 104);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(207, 22);
            this.txtGianhap.TabIndex = 9;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(697, 168);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(207, 22);
            this.txtGiaban.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "So luong";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(193, 168);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(207, 22);
            this.txtSoluong.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(100, 569);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(306, 569);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(524, 569);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(867, 569);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(675, 569);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 613);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.txtGianhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbChatlieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridviewDMhang);
            this.Name = "frmHang";
            this.Text = "Danh muc hang";
            this.Load += new System.EventHandler(this.FrmHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDMhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewDMhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
    }
}