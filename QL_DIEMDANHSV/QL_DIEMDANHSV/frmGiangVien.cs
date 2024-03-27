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
    public partial class frmGiangVien : Form
    {
        public string cn = "select * from GIANGVIEN";


        DBconnect dbcon = new DBconnect();
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public frmGiangVien()
        {
            InitializeComponent();
            DBconnect.CONNECT(cn, dtgv_gv);
            clear();
        }
        public void clear()
        {
            dtgv_gv.Columns[0].HeaderText = "Mã giáo viên"; dtgv_gv.Columns[0].Width = 150;
            dtgv_gv.Columns[1].HeaderText = "Tên giáo viên"; dtgv_gv.Columns[1].Width = 160;
            dtgv_gv.Columns[2].HeaderText = "Ngày sinh"; dtgv_gv.Columns[2].Width = 150;
            dtgv_gv.Columns[3].HeaderText = "Địa chỉ"; dtgv_gv.Columns[3].Width = 150;

            txt_magv.Text = "";
            txt_tengv.Text = "";
            msk_ngaysinh.Text = "";
            txt_diachi.Text = "";
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            if (txt_magv.Text == "" || txt_tengv.Text == "" || msk_ngaysinh.Text =="" || txt_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "insert into GIANGVIEN values('" + txt_magv.Text + "',N'" + txt_tengv.Text + "','" + msk_ngaysinh.Text + "',N'" + txt_diachi.Text + "')";
                DBconnect.them_dl(sql1, dtgv_gv);
                DBconnect.CONNECT(cn, dtgv_gv);
                clear();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update GIANGVIEN set HOTENGV = N'" + txt_tengv.Text + "',NGAYSINH = '" + msk_ngaysinh.Text + "',DIACHI =N'"+txt_diachi.Text+"' where MAGV='" + txt_magv.Text + "'";
            DBconnect.Execute1(sql);
            DBconnect.CONNECT(cn, dtgv_gv);
            clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from GIANGVIEN where MAGV = '" + txt_magv.Text + "'";
            DBconnect.Execute(sql);
            DBconnect.CONNECT(cn, dtgv_gv);
            clear();
        }

        private void dtgv_gv_Click(object sender, EventArgs e)
        {
            int curow = dtgv_gv.CurrentRow.Index;
            txt_magv.Text = dtgv_gv.Rows[curow].Cells[0].Value.ToString();
            txt_tengv.Text = dtgv_gv.Rows[curow].Cells[1].Value.ToString();
            msk_ngaysinh.Text = dtgv_gv.Rows[curow].Cells[2].Value.ToString();
            txt_diachi.Text = dtgv_gv.Rows[curow].Cells[3].Value.ToString();

            txt_magv.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }
    }
}
