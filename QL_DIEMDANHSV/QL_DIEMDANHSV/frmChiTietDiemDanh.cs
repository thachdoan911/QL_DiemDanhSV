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
using System.Data;

namespace QL_DIEMDANHSV
{
    public partial class frmChiTietDiemDanh : Form
    {
        public string cn = "select * from CHITIETDIEMDANH";

        DBconnect dbcon = new DBconnect();
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public frmChiTietDiemDanh()
        {
            InitializeComponent();
            DBconnect.CONNECT(cn, dtgv_ctdd);
            Show();
        }
        public void Show()
        {
            dtgv_ctdd.Columns[0].HeaderText = "Mã sinh viên"; dtgv_ctdd.Columns[0].Width = 150;
            dtgv_ctdd.Columns[1].HeaderText = "Mã lớp"; dtgv_ctdd.Columns[1].Width = 150;
            dtgv_ctdd.Columns[2].HeaderText = "Số tiết có phép"; dtgv_ctdd.Columns[2].Width = 150;
            dtgv_ctdd.Columns[3].HeaderText = "Số tiết không phép"; dtgv_ctdd.Columns[3].Width = 150;



            
            txt_masv.Text = "";
            txt_malop.Text = "";
            txt_sotietcophep.Text = "";
            txt_sotietkophep.Text = "";



            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_masv.Text == "" || txt_malop.Text == "" || txt_sotietcophep.Text == "" || txt_sotietkophep.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "insert into CHITIETDIEMDANH values('" + txt_masv.Text + "','" + txt_malop.Text + "','" + txt_sotietcophep.Text + "','" + txt_sotietkophep.Text + "')";
                DBconnect.them_dl(sql1, dtgv_ctdd);
                DBconnect.CONNECT(cn, dtgv_ctdd);
                Show();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update CHITIETDIEMDANH set MALOP = '" + txt_malop.Text + "',SOTIETCOPHEP = '" + txt_sotietcophep.Text + "',SOTIETKHONGPHEP='" + txt_sotietkophep.Text + "'";
            DBconnect.Execute1(sql);
            DBconnect.CONNECT(cn, dtgv_ctdd);
            Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from CHITIETDIEMDANH where MASV = '" + txt_masv.Text + "'";
            DBconnect.Execute(sql);
            DBconnect.CONNECT(cn, dtgv_ctdd);
            Show();
        }


        private void dtgv_ctdd_Click(object sender, EventArgs e)
        {
            int curow = dtgv_ctdd.CurrentRow.Index;
            txt_masv.Text = dtgv_ctdd.Rows[curow].Cells[0].Value.ToString();
            txt_malop.Text = dtgv_ctdd.Rows[curow].Cells[1].Value.ToString();
            txt_sotietcophep.Text = dtgv_ctdd.Rows[curow].Cells[2].Value.ToString();
            txt_sotietkophep.Text = dtgv_ctdd.Rows[curow].Cells[3].Value.ToString();

            txt_malop.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }
    }
}
