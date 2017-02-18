namespace ThucTap_bai1
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thong_ke_thu_nhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.danh_sachdataGridView1 = new System.Windows.Forms.DataGridView();
            this.ho_so_chi_tietgroupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmTheochứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tim_kiem_tenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tim_kiem_que_quanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tim_kiem_dia_chiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmTheoPhòngBanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huong_danToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thong_tinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thong_ke_chuyen_monToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danh_sachdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "&Quản lý";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themToolStripMenuItem,
            this.suaToolStripMenuItem,
            this.xoaToolStripMenuItem});
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.newToolStripMenuItem.Text = "&Nhân viên";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.toolStripSeparator4,
            this.tìmTheochứcVụToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.toolsToolStripMenuItem.Text = "&Tìm kiếm";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tim_kiem_tenToolStripMenuItem,
            this.tim_kiem_que_quanToolStripMenuItem,
            this.tim_kiem_dia_chiToolStripMenuItem});
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customizeToolStripMenuItem.Text = "Theo &cá nhân";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thong_ke_thu_nhapToolStripMenuItem,
            this.toolStripSeparator5,
            this.thong_ke_chuyen_monToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.helpToolStripMenuItem.Text = "&Thống kê";
            // 
            // thong_ke_thu_nhapToolStripMenuItem
            // 
            this.thong_ke_thu_nhapToolStripMenuItem.Name = "thong_ke_thu_nhapToolStripMenuItem";
            this.thong_ke_thu_nhapToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.thong_ke_thu_nhapToolStripMenuItem.Text = "&Theo mức thu nhập";
            this.thong_ke_thu_nhapToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(176, 6);
            // 
            // danh_sachdataGridView1
            // 
            this.danh_sachdataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.danh_sachdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danh_sachdataGridView1.Location = new System.Drawing.Point(12, 272);
            this.danh_sachdataGridView1.Name = "danh_sachdataGridView1";
            this.danh_sachdataGridView1.Size = new System.Drawing.Size(711, 208);
            this.danh_sachdataGridView1.TabIndex = 1;
            this.danh_sachdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ho_so_chi_tietgroupBox1
            // 
            this.ho_so_chi_tietgroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ho_so_chi_tietgroupBox1.Location = new System.Drawing.Point(12, 61);
            this.ho_so_chi_tietgroupBox1.Name = "ho_so_chi_tietgroupBox1";
            this.ho_so_chi_tietgroupBox1.Size = new System.Drawing.Size(711, 187);
            this.ho_so_chi_tietgroupBox1.TabIndex = 2;
            this.ho_so_chi_tietgroupBox1.TabStop = false;
            this.ho_so_chi_tietgroupBox1.Text = "Hồ sơ chi tiết";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngBanToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem1.Text = "&Lương";
            // 
            // tìmTheochứcVụToolStripMenuItem
            // 
            this.tìmTheochứcVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmTheoPhòngBanToolStripMenuItem1,
            this.chứcVụToolStripMenuItem});
            this.tìmTheochứcVụToolStripMenuItem.Name = "tìmTheochứcVụToolStripMenuItem";
            this.tìmTheochứcVụToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tìmTheochứcVụToolStripMenuItem.Text = "Theo &tổ chức";
            // 
            // tim_kiem_tenToolStripMenuItem
            // 
            this.tim_kiem_tenToolStripMenuItem.Name = "tim_kiem_tenToolStripMenuItem";
            this.tim_kiem_tenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tim_kiem_tenToolStripMenuItem.Text = "&Tên";
            // 
            // tim_kiem_que_quanToolStripMenuItem
            // 
            this.tim_kiem_que_quanToolStripMenuItem.Name = "tim_kiem_que_quanToolStripMenuItem";
            this.tim_kiem_que_quanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tim_kiem_que_quanToolStripMenuItem.Text = "&Quê quán";
            // 
            // tim_kiem_dia_chiToolStripMenuItem
            // 
            this.tim_kiem_dia_chiToolStripMenuItem.Name = "tim_kiem_dia_chiToolStripMenuItem";
            this.tim_kiem_dia_chiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tim_kiem_dia_chiToolStripMenuItem.Text = "Địa &chỉ";
            // 
            // tìmTheoPhòngBanToolStripMenuItem1
            // 
            this.tìmTheoPhòngBanToolStripMenuItem1.Name = "tìmTheoPhòngBanToolStripMenuItem1";
            this.tìmTheoPhòngBanToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.tìmTheoPhòngBanToolStripMenuItem1.Text = "&Phòng ban";
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chứcVụToolStripMenuItem.Text = "&Chức vụ";
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huong_danToolStripMenuItem,
            this.toolStripSeparator2,
            this.thong_tinToolStripMenuItem});
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // huong_danToolStripMenuItem
            // 
            this.huong_danToolStripMenuItem.Name = "huong_danToolStripMenuItem";
            this.huong_danToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.huong_danToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // thong_tinToolStripMenuItem
            // 
            this.thong_tinToolStripMenuItem.Name = "thong_tinToolStripMenuItem";
            this.thong_tinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thong_tinToolStripMenuItem.Text = "Thông tin";
            // 
            // themToolStripMenuItem
            // 
            this.themToolStripMenuItem.Name = "themToolStripMenuItem";
            this.themToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.themToolStripMenuItem.Text = "&Thêm";
            // 
            // suaToolStripMenuItem
            // 
            this.suaToolStripMenuItem.Name = "suaToolStripMenuItem";
            this.suaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.suaToolStripMenuItem.Text = "&Sửa";
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xoaToolStripMenuItem.Text = "&Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            // 
            // thong_ke_chuyen_monToolStripMenuItem
            // 
            this.thong_ke_chuyen_monToolStripMenuItem.Name = "thong_ke_chuyen_monToolStripMenuItem";
            this.thong_ke_chuyen_monToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.thong_ke_chuyen_monToolStripMenuItem.Text = "Theo chuyên môn";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 492);
            this.Controls.Add(this.ho_so_chi_tietgroupBox1);
            this.Controls.Add(this.danh_sachdataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danh_sachdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thong_ke_thu_nhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridView danh_sachdataGridView1;
        private System.Windows.Forms.GroupBox ho_so_chi_tietgroupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tim_kiem_tenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tim_kiem_que_quanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tim_kiem_dia_chiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmTheochứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoPhòngBanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huong_danToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thong_tinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem thong_ke_chuyen_monToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

