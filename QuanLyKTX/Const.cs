using DTO;
using System.Collections.Generic;

namespace QuanLyKTX
{
    public class Const
    {
        public static string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DBQuanLyKyTucXa;Integrated Security=True";
        public static NguoiDung CurrentUser = new NguoiDung();
        public static List<PhanQuyen> PhanQuyens = new List<PhanQuyen>();
        public static bool isFullOp = false;
        public static bool isLogin = false;
    }
}
