namespace WindowsFormsApp6
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucChatLieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucToolStripMenuItem,
            this.hoaDonNhapToolStripMenuItem,
            this.hoaDonBanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucChatLieuToolStripMenuItem,
            this.danhMucHangToolStripMenuItem});
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.danhMucToolStripMenuItem.Text = "Danh muc";
            // 
            // danhMucChatLieuToolStripMenuItem
            // 
            this.danhMucChatLieuToolStripMenuItem.Name = "danhMucChatLieuToolStripMenuItem";
            this.danhMucChatLieuToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.danhMucChatLieuToolStripMenuItem.Text = "Danh muc Chat lieu";
            this.danhMucChatLieuToolStripMenuItem.Click += new System.EventHandler(this.danhMucChatLieuToolStripMenuItem_Click);
            // 
            // danhMucHangToolStripMenuItem
            // 
            this.danhMucHangToolStripMenuItem.Name = "danhMucHangToolStripMenuItem";
            this.danhMucHangToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.danhMucHangToolStripMenuItem.Text = "Danh muc hang";
            this.danhMucHangToolStripMenuItem.Click += new System.EventHandler(this.danhMucHangToolStripMenuItem_Click);
            // 
            // hoaDonNhapToolStripMenuItem
            // 
            this.hoaDonNhapToolStripMenuItem.Name = "hoaDonNhapToolStripMenuItem";
            this.hoaDonNhapToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.hoaDonNhapToolStripMenuItem.Text = "Hoa don nhap";
            // 
            // hoaDonBanToolStripMenuItem
            // 
            this.hoaDonBanToolStripMenuItem.Name = "hoaDonBanToolStripMenuItem";
            this.hoaDonBanToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.hoaDonBanToolStripMenuItem.Text = "Hoa don ban";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucChatLieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoaDonNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoaDonBanToolStripMenuItem;
    }
}