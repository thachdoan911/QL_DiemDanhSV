using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DIEMDANHSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
            Application.Run(new frmHeThong());
            Application.Run(new frmThongTinSV());
            //Application.Run(new frmThongtinbotrithoigianhoc());
            //Application.Run(new frmThongtinlopmonhoc());
            //Application.Run(new frmThongtinlopnienche());
            //Application.Run(new frmThongtinlopthoigianhoc());
            //Application.Run(new frmThongtinmonhoc());
            //Application.Run(new frmThongtinsv());
            //Application.Run(new frmThongtinsv_lopmh());
            //Application.Run(new frmThongtingiaidoanhoc());
            //Application.Run(new frmThongtingiaovien());
        }
    }
}
