using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QL_DIEMDANHSV
{
    public class DBconnect
    {
        public static string sqlcon = @"Data Source = DESKTOP-QSULFJV\SQLEXPRESS; Initial Catalog = QL_DIEMDANHSV; user ID = sa; password = 123 ";
        public static SqlConnection connect;


        public static SqlCommand cmd;
        public static SqlDataAdapter da;

        public static DataTable dt;
        public static SqlCommandBuilder bd;
        public static DataSet ds;



        public SqlCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }

        public DataSet DS
        {
            get { return ds; }
            set { ds = value; }
        }

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        public DBconnect()
        {
            connect = new SqlConnection("Data Source = DESKTOP-QSULFJV\\SQLEXPRESS; Initial Catalog = QL_DIEMDANHSV; user ID = sa; password = 123 ");
            ds = new DataSet();
        }
        public DBconnect(string severname, string databasename, string u_id, string pass)
        {
            string connectString = "data source =";
            connectString += severname + "; initial catalog = ";
            connectString += databasename + "; user ID =";
            connectString += u_id + "; password = " + pass;
            connect = new SqlConnection(connectString);
        }
        public void openConnection()
        {
            if (connect.State.ToString() == "Closed")
                connect.Open();
        }
        public void closeConnection()
        {
            if (connect.State.ToString() == "Open")
                connect.Close();
        }
        public int executeNonquery(string sql)
        {
            SqlCommand cmd;

            openConnection();
            cmd = new SqlCommand(sql, Connect);

            int kq = cmd.ExecuteNonQuery();
            closeConnection();
            return kq;
        }
        public int executeScalar(string sql)
        {
            SqlCommand cmd;

            openConnection();
            cmd = new SqlCommand(sql, Connect);

            int kq = (int)cmd.ExecuteScalar();
            closeConnection();
            return kq;
        }
        public SqlDataReader executeReader(string sql)
        {
            SqlCommand cmd;
            openConnection();
            cmd = new SqlCommand(sql, connect);
            //Thực hiện

            SqlDataReader rd = cmd.ExecuteReader();

            return rd;

        }
        public DataTable getDataTable(string sql, string tablename)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(DS, tablename);
            return DS.Tables[tablename];
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

        public static void them_dl(string sql, DataGridView dt)
        {
            try
            {
                connect = new SqlConnection(sqlcon);
                connect.Open();
                cmd = new SqlCommand(sql, connect);
                da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dt.DataSource = tb;
                MessageBox.Show("Thêm thành công !", "Thông báo ");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }
        }
        public static void Save(string sql)
        {


            try
            {
                connect = new SqlConnection(sqlcon);
                connect.Open();
                cmd = new SqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }
        public static void Execute(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    connect = new SqlConnection(sqlcon);
                    connect.Open();
                    cmd = new SqlCommand(sql, connect);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }
        public static void Execute1(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn sửa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    connect = new SqlConnection(sqlcon);
                    connect.Open();
                    cmd = new SqlCommand(sql, connect);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Bạn sửa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }

        }
        public static void Check(string name, string newpass, string newpass1, string sql)
        {
            
            int a = 0;
            connect = new SqlConnection(sqlcon);
            connect.Open();
            if (name == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản ", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {

                cmd = new SqlCommand(sql, connect);
                a = (int)cmd.ExecuteScalar();


                if (a > 0)
                {
                    if (newpass == newpass1)
                    {
                        string sql4 = "update DANGNHAP set PASS = '" + newpass + "' where USERNAME ='" + name + "'";
                        Save(sql4);
                        MessageBox.Show("Đổi mật khẩu thành công!!!", "Thông báo ", MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp !!", "Thông Báo", MessageBoxButtons.OK);
                    }

                }

            }
        }
    }
}

