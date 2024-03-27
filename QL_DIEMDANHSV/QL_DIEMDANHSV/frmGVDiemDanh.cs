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
    public partial class frmGVDiemDanh : Form
    {
        public string cn = "select * from GV_DIEMDANH";

        DBconnect dbcon = new DBconnect();
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public frmGVDiemDanh()
        {
            InitializeComponent();
            DBconnect.CONNECT(cn, dtgv_ttdd);
            Show();
        }
        public void Show()
        {
            dtgv_ttdd.Columns[0].HeaderText = "Mã điểm danh"; dtgv_ttdd.Columns[0].Width = 150;
            dtgv_ttdd.Columns[1].HeaderText = "Mã giảng viên"; dtgv_ttdd.Columns[1].Width = 150;
            dtgv_ttdd.Columns[2].HeaderText = "Mã sinh viên"; dtgv_ttdd.Columns[2].Width = 150;
            dtgv_ttdd.Columns[3].HeaderText = "Mã lớp"; dtgv_ttdd.Columns[3].Width = 150;
            dtgv_ttdd.Columns[4].HeaderText = "Ngày điểm danh"; dtgv_ttdd.Columns[4].Width = 150;
            dtgv_ttdd.Columns[5].HeaderText = "Số tiết vắng"; dtgv_ttdd.Columns[5].Width = 150;
            dtgv_ttdd.Columns[6].HeaderText = "Lý do vắng"; dtgv_ttdd.Columns[6].Width = 150;


            txt_madd.Text = "";
            txt_magv.Text = "";
            txt_masv.Text = "";
            txt_malop.Text = "";
            msk_ngaydd.Text = "";
            txt_sotv.Text = "";
            txt_lydo.Text = "";
            //txt_lydo.Text = "";
      

            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        }
        private void frmThongTinDiemDanh_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_madd.Text == "" || txt_magv.Text == "" || txt_masv.Text == "" || txt_malop.Text == "" || msk_ngaydd.SelectedText == "" || txt_sotv.Text == "" || txt_lydo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "insert into GV_DIEMDANH values('" + txt_madd.Text + "','" + txt_magv.Text + "','" + txt_masv.Text + "','" + txt_malop.Text + "','" + msk_ngaydd.SelectedText + "','" + txt_sotv.Text + "',N'" + txt_lydo.Text + "')";
                DBconnect.them_dl(sql1, dtgv_ttdd);
                DBconnect.CONNECT(cn, dtgv_ttdd);
                Show();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update GV_DIEMDANH set MAGV = '" + txt_magv.Text + "',MASV = '" + txt_masv.Text + "',MALOP = '" + txt_malop.Text + "',NGAYDIEMDANH='" + msk_ngaydd.SelectedText + "',SOTIETVANG='" + txt_sotv.Text + "',LYDOVANG= N'" + txt_lydo.Text + "' where MADD ='" + txt_madd.Text + "'";
            DBconnect.Execute1(sql);
            DBconnect.CONNECT(cn, dtgv_ttdd);
            Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from GV_DIEMDANH where MADD = '" + txt_madd.Text + "'";
            DBconnect.Execute(sql);
            DBconnect.CONNECT(cn, dtgv_ttdd);
            Show();
        }

        private void dtgv_ttdd_Click(object sender, EventArgs e)
        {
            int curow = dtgv_ttdd.CurrentRow.Index;
            txt_madd.Text = dtgv_ttdd.Rows[curow].Cells[0].Value.ToString();
            txt_magv.Text = dtgv_ttdd.Rows[curow].Cells[1].Value.ToString();
            txt_masv.Text = dtgv_ttdd.Rows[curow].Cells[2].Value.ToString();
            txt_malop.Text = dtgv_ttdd.Rows[curow].Cells[3].Value.ToString();
            msk_ngaydd.Text = dtgv_ttdd.Rows[curow].Cells[4].Value.ToString();
            txt_sotv.Text = dtgv_ttdd.Rows[curow].Cells[5].Value.ToString();
            txt_lydo.Text = dtgv_ttdd.Rows[curow].Cells[6].Value.ToString();
  

            txt_madd.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

    }
}
