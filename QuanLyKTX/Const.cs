using DTO;
using BUS;
using System.Collections.Generic;
using System.Data;

namespace QuanLyKTX
{
    public class Const
    {
        public static string ConnectionString = @"Data Source=DESKTOP-APH6IS0\SQLEXPRESS;Initial Catalog=DBQuanLyKyTucXa;Integrated Security=True";
        public static NguoiDung CurrentUser = new NguoiDung();
        public static DataTable DanhSachQuyen = new DataTable();

        public static List<PhanQuyen> PhanQuyens = new List<PhanQuyen>();
        public static bool isFullOp = false;
        public static bool isLogin = false;
        public static int DoiTuongId = 0;
        public static int NguoiDungId = 0;
        public static BUS_NhatKyHoatDong NhatKyHoatDong = new BUS_NhatKyHoatDong();

        public static string PhongId = "";
    }
}
