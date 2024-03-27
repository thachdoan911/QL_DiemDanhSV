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
using System.Data.Sql;

namespace QL_DIEMDANHSV
{
    public partial class frmDangNhap : Form
    {

        public static string sqlcon = @"Data source=DESKTOP-QSULFJV\SQLEXPRESS; Initial Catalog = QL_DIEMDANHSV; user ID = sa; password = 123";

        DBconnect dbcon = new DBconnect();
        public static SqlConnection connect;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        public static SqlCommandBuilder bd;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }



        public static void CONNECT(string cn, DataGridView db1)
        {
            try
            {

                da = new SqlDataAdapter(cn, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(da);
                da.Fill(dt);
                db1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    dbcon.openConnection();
            //    string taikhoan = txt_tendangnhap.Text;
            //    string matkhau = txt_matkhau.Text;
            //    string sql = "select * from DANGNHAP where USERNAME = '" + taikhoan + "' and PASS = '" + matkhau + "'";
            //    SqlCommand cmd = new SqlCommand(sql,connect);
            //    SqlDataReader da= cmd.ExecuteReader();
            //    if (da.Read() == true)
            //    {
            //        MessageBox.Show("Đăng nhập thành công");
            //        frmHeThong frm = new frmHeThong();
            //        frm.ShowDialog();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác ! Vui lòng thử lại");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Kết nối lỗi !! vui lòng thử lại ");
            //}

            string sql1 = "Select count(*) from DANGNHAP where USERNAME='" + txt_tendangnhap.Text.Trim() + "' and PASS ='" + txt_matkhau.Text.Trim() + "' ";
            if (txt_tendangnhap.Text == "" || txt_matkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin! ", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                int a = 0;
                connect = new SqlConnection(sqlcon);
                connect.Open();

                cmd = new SqlCommand(sql1, connect);
                a = (int)cmd.ExecuteScalar();





                if (a == 0)
                {
                    string t = "Tài khoản hoăc mật khẩu sai !!! Vui lòng thử lại ";
                    MessageBox.Show((t), "Thông báo", MessageBoxButtons.OK);
                }
                else
                { 
                    string sql = "Select QUYENTRUYCAP from DANGNHAP where USERNAME ='" + txt_tendangnhap.Text.Trim() + "'";
                    connect = new SqlConnection(sqlcon);
                    connect.Open();
                    SqlCommand getIsAdmin = new SqlCommand(sql, connect);
                    int getRole = (int)getIsAdmin.ExecuteScalar();

                    if (getRole == 0)
                    {

                        MessageBox.Show("Welcome Phòng Đào Tạo", "Thông báo ", MessageBoxButtons.OK);
                        frmHeThong frm = new frmHeThong();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome Giảng Viên ", "Thông báo ", MessageBoxButtons.OK);
                        frmHeThong frm = new frmHeThong();
                        frm.ShowDialog();
                    }
                      
                }
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
