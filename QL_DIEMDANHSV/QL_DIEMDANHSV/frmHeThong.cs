using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QL_DIEMDANHSV
{
    public partial class frmHeThong : Form
    {
        public string cn = "Select * from SINHVIEN";

        DBconnect dbcon = new DBconnect();
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public frmHeThong()
        {
            InitializeComponent();
            Load_dta1();
        }

        public void Load_dta1()
        {
            DBconnect.CONNECT(cn,dtgv_hethong);
            dtgv_hethong.Columns[0].HeaderText = "Mã sinh viên"; dtgv_hethong.Columns[0].Width = 120;
            dtgv_hethong.Columns[1].HeaderText = "Tên sinh viên"; dtgv_hethong.Columns[1].Width = 120;
            dtgv_hethong.Columns[2].HeaderText = "Ngày sinh"; dtgv_hethong.Columns[4].Width = 120;
            dtgv_hethong.Columns[3].HeaderText = "Phái"; dtgv_hethong.Columns[3].Width = 120;
            dtgv_hethong.Columns[4].HeaderText = "Địa chỉ"; dtgv_hethong.Columns[2].Width = 120;
            dtgv_hethong.Columns[5].HeaderText = "Mã lớp niên chế"; dtgv_hethong.Columns[2].Width = 120;

        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {
        //    dbcon.openConnection();
        //    string sql = "select * from SINHVIEN";
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter(sql,connect);
        //    da.Fill(ds);
        //    dtgv_hethong.DataSource = ds.Tables[0];
        //    dtgv_hethong.Refresh();
     
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void thongTinSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinSV frm = new frmThongTinSV();
            frm.ShowDialog();
        }

        private void thongTinGiaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiangVien frm = new frmGiangVien();
            frm.ShowDialog();
        }


        private void thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGVDiemDanh frm = new frmGVDiemDanh();
            frm.ShowDialog();
        }

        private void thongTinLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop frm = new frmLop();
            frm.ShowDialog();
        }

        private void thongTinDiemDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGVDiemDanh frm = new frmGVDiemDanh();
            frm.ShowDialog();
        }

        private void thôngTinChiTiếtĐiểmDanhSinhViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmChiTietDiemDanh frm = new frmChiTietDiemDanh();
            frm.ShowDialog();
        }

        private void quanLiNguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiangVien frm = new frmGiangVien();
            frm.ShowDialog();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               Close();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }
    }
}
