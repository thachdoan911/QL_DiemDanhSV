namespace QL_DIEMDANHSV
{
    partial class frmHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeThong));
            this.label1 = new System.Windows.Forms.Label();
            this.thongTinGiaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinDiemDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiNguoiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dtgv_hethong = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hethong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(433, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // thongTinGiaoVienToolStripMenuItem
            // 
            this.thongTinGiaoVienToolStripMenuItem.Name = "thongTinGiaoVienToolStripMenuItem";
            this.thongTinGiaoVienToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.thongTinGiaoVienToolStripMenuItem.Text = "Thông tin giảng viên";
            this.thongTinGiaoVienToolStripMenuItem.Click += new System.EventHandler(this.thongTinGiaoVienToolStripMenuItem_Click);
            // 
            // thongTinSinhVienToolStripMenuItem
            // 
            this.thongTinSinhVienToolStripMenuItem.Name = "thongTinSinhVienToolStripMenuItem";
            this.thongTinSinhVienToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.thongTinSinhVienToolStripMenuItem.Text = "Thông tin sinh viên";
            this.thongTinSinhVienToolStripMenuItem.Click += new System.EventHandler(this.thongTinSinhVienToolStripMenuItem_Click);
            // 
            // cậpNhậtDữLiệuToolStripMenuItem
            // 
            this.cậpNhậtDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinLopToolStripMenuItem,
            this.thongTinSinhVienToolStripMenuItem,
            this.thongTinGiaoVienToolStripMenuItem,
            this.thongTinDiemDanhToolStripMenuItem,
            this.thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem});
            this.cậpNhậtDữLiệuToolStripMenuItem.Name = "cậpNhậtDữLiệuToolStripMenuItem";
            this.cậpNhậtDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.cậpNhậtDữLiệuToolStripMenuItem.Text = "Cập nhật dữ liệu";
            // 
            // thongTinLopToolStripMenuItem
            // 
            this.thongTinLopToolStripMenuItem.Name = "thongTinLopToolStripMenuItem";
            this.thongTinLopToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.thongTinLopToolStripMenuItem.Text = "Thông tin lớp";
            this.thongTinLopToolStripMenuItem.Click += new System.EventHandler(this.thongTinLopToolStripMenuItem_Click);
            // 
            // thongTinDiemDanhToolStripMenuItem
            // 
            this.thongTinDiemDanhToolStripMenuItem.Name = "thongTinDiemDanhToolStripMenuItem";
            this.thongTinDiemDanhToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.thongTinDiemDanhToolStripMenuItem.Text = "Thông tin điểm danh";
            this.thongTinDiemDanhToolStripMenuItem.Click += new System.EventHandler(this.thongTinDiemDanhToolStripMenuItem_Click);
            // 
            // thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem
            // 
            this.thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem.Name = "thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem";
            this.thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem.Text = "Thông tin chi tiết điểm danh sinh viên";
            this.thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // quanLiNguoiDungToolStripMenuItem
            // 
            this.quanLiNguoiDungToolStripMenuItem.Name = "quanLiNguoiDungToolStripMenuItem";
            this.quanLiNguoiDungToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.quanLiNguoiDungToolStripMenuItem.Text = "Quản lí người dùng";
            this.quanLiNguoiDungToolStripMenuItem.Click += new System.EventHandler(this.quanLiNguoiDungToolStripMenuItem_Click);
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauToolStripMenuItem,
            this.quanLiNguoiDungToolStripMenuItem,
            this.dangXuatToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.heThongToolStripMenuItem.Text = "Hệ thống ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.cậpNhậtDữLiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dtgv_hethong
            // 
            this.dtgv_hethong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hethong.GridColor = System.Drawing.Color.Coral;
            this.dtgv_hethong.Location = new System.Drawing.Point(0, 118);
            this.dtgv_hethong.Name = "dtgv_hethong";
            this.dtgv_hethong.RowHeadersWidth = 51;
            this.dtgv_hethong.RowTemplate.Height = 24;
            this.dtgv_hethong.Size = new System.Drawing.Size(1291, 543);
            this.dtgv_hethong.TabIndex = 15;
            // 
            // frmHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1289, 725);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtgv_hethong);
            this.Name = "frmHeThong";
            this.Text = "Hệ thống";
            this.Load += new System.EventHandler(this.frmHeThong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hethong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem thongTinGiaoVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLiNguoiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dtgv_hethong;
        private System.Windows.Forms.ToolStripMenuItem thongTinLopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinDiemDanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem;
    }
}