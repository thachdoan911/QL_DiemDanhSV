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
    public partial class frmLop : Form
    {
        public string chuoi = "select * from LOP";


        DBconnect dbcon = new DBconnect();
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public frmLop()
        {
            InitializeComponent();
            DBconnect.CONNECT(chuoi, dtgv_lnc);
            clear();
            
        }
        public void clear()
        {
            dtgv_lnc.Columns[0].HeaderText = "Mã lớp"; dtgv_lnc.Columns[0].Width = 150;
            dtgv_lnc.Columns[1].HeaderText = "Mã giảng viên"; dtgv_lnc.Columns[1].Width = 150;
            dtgv_lnc.Columns[2].HeaderText = "Tên lớp"; dtgv_lnc.Columns[2].Width = 160;
            dtgv_lnc.Columns[3].HeaderText = "Sỉ số"; dtgv_lnc.Columns[3].Width = 150;
            
            txt_malop.Text = "";
            txt_magv.Text = "";
            txt_tenlop.Text = "";
            txt_siso.Text = "";
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        }

        private void dtgv_lnc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmLOP_Load(object sender, EventArgs e)
        {
   
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_malop.Text == "" || txt_magv.Text == "" || txt_tenlop.Text == "" || txt_siso.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "insert into LOP values('" + txt_malop.Text + "',N'" + txt_magv.Text + "',N'" + txt_tenlop.Text + "','" + txt_siso.Text + "')";
                DBconnect.them_dl(sql1, dtgv_lnc);
                DBconnect.CONNECT(chuoi, dtgv_lnc);
                clear();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from LOP where MALOP= '" + txt_malop.Text + "'";
            DBconnect.Execute(sql);
            DBconnect.CONNECT(chuoi, dtgv_lnc);
            clear();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update LOP set MAGV = '" + txt_magv.Text + "',TENLOP= N'" + txt_tenlop.Text + "',SISO = '" + txt_siso.Text + "' where MALOP='" + txt_malop.Text + "'";
            DBconnect.Execute1(sql);
            DBconnect.CONNECT(chuoi, dtgv_lnc);
            clear();
        }

        private void dtgv_lnc_Click(object sender, EventArgs e)
        {
            int curow = dtgv_lnc.CurrentRow.Index;
            txt_malop.Text = dtgv_lnc.Rows[curow].Cells[0].Value.ToString();
            txt_magv.Text = dtgv_lnc.Rows[curow].Cells[1].Value.ToString();
            txt_tenlop.Text = dtgv_lnc.Rows[curow].Cells[2].Value.ToString();
            txt_siso.Text = dtgv_lnc.Rows[curow].Cells[3].Value.ToString();
 
            txt_malop.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

       
    }
}
