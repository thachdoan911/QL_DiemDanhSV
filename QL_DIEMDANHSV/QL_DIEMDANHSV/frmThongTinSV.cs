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
    public partial class frmThongTinSV : Form
    {
        public string cn = "select * from SINHVIEN";


        DBconnect dbcon = new DBconnect();
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public frmThongTinSV()
        {
            InitializeComponent();
            DBconnect.CONNECT(cn, dtgv_sv);
            clear();
        }
        public void clear()
        {
            dtgv_sv.Columns[0].HeaderText = "Mã sinh viên"; dtgv_sv.Columns[0].Width = 150;
            dtgv_sv.Columns[1].HeaderText = "Tên sinh viên"; dtgv_sv.Columns[1].Width = 150;
            dtgv_sv.Columns[2].HeaderText = "Ngày sinh"; dtgv_sv.Columns[2].Width = 150;
            dtgv_sv.Columns[3].HeaderText = "Giới tính"; dtgv_sv.Columns[3].Width = 150;
            dtgv_sv.Columns[4].HeaderText = "Địa chỉ"; dtgv_sv.Columns[4].Width = 150;
            dtgv_sv.Columns[5].HeaderText = "Mã lớp"; dtgv_sv.Columns[5].Width = 150;


            txt_masv.Text = "";
            txt_tensv.Text = "";   
            msk_ngaysinh.Text = "";
            txt_gioitinh.Text = "";
            txt_diachi.Text = "";
            txt_malop.Text = "";
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        }
        private void frmThongTinSV_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_masv.Text == "" || txt_tensv.Text == "" || msk_ngaysinh.Text == "" || txt_gioitinh.Text == "" || txt_diachi.Text == "" || txt_malop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "insert into SINHVIEN values('" + txt_masv.Text + "',N'" + txt_tensv.Text + "','" + msk_ngaysinh.SelectedText+ "',N'" + txt_gioitinh.Text + "',N'" + txt_diachi.Text + "','" + txt_malop.Text + "')";
                DBconnect.them_dl(sql1, dtgv_sv);
                DBconnect.CONNECT(cn, dtgv_sv);
                clear();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update SINHVIEN set HOTENSV = N'" + txt_tensv.Text + "',NGAYSINH = '" + msk_ngaysinh.Text + "',PHAI = N'" + txt_gioitinh.Text + "',DIACHI = N'" + txt_diachi.Text + "',MALOP = '" + txt_malop.Text + "' where MASV='" + txt_masv.Text + "'";
            DBconnect.Execute1(sql);
            DBconnect.CONNECT(cn, dtgv_sv);
            clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from SINHVIEN where MASV = '" + txt_masv.Text + "'";
            DBconnect.Execute(sql);
            DBconnect.CONNECT(cn, dtgv_sv);
            clear();
        }

        private void dtgv_sv_Click(object sender, EventArgs e)
        {
            int curow = dtgv_sv.CurrentRow.Index;
            txt_masv.Text = dtgv_sv.Rows[curow].Cells[0].Value.ToString();
            txt_tensv.Text = dtgv_sv.Rows[curow].Cells[1].Value.ToString();
            msk_ngaysinh.Text = dtgv_sv.Rows[curow].Cells[2].Value.ToString();
            txt_gioitinh.Text = dtgv_sv.Rows[curow].Cells[3].Value.ToString();
            txt_diachi.Text = dtgv_sv.Rows[curow].Cells[4].Value.ToString();
            txt_malop.Text = dtgv_sv.Rows[curow].Cells[5].Value.ToString();


            txt_masv.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }
    }
}
