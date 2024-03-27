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
    public partial class frmDoiMatKhau : Form
    {
        DBconnect dbcon = new DBconnect();
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            string sql = "Select count(*) from DANGNHAP where USERNAME ='" + txt_taikhoan.Text.Trim() + "' ";
            if (txt_matkhau.Text.Length < 6)
            {
                MessageBox.Show("Mât khẩu ít nhất phải từ 6 kí tự trở lên!!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DBconnect.Check(txt_taikhoan.Text, txt_matkhau.Text, txt_xacnhan.Text, sql);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }



        private void btn_anhien_Click(object sender, EventArgs e)
        {
            if (txt_matkhau.PasswordChar == '●')
            {
                btn_anhien.BringToFront();
                txt_matkhau.PasswordChar = '\0';
            }
            else if (txt_matkhau.PasswordChar == '\0')
            {
                btn_anhien.BringToFront();
                txt_matkhau.PasswordChar = '●';
            }
        }

        private void btn_anhien1_Click(object sender, EventArgs e)
        {

            if (txt_matkhau.PasswordChar == '●')
            {
                btn_anhien.BringToFront();
                txt_matkhau.PasswordChar = '\0';
            }
            else if (txt_matkhau.PasswordChar == '\0')
            {
                btn_anhien.BringToFront();
                txt_matkhau.PasswordChar = '●';
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
