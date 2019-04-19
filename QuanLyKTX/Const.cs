using DTO;
using BUS;
using System.Collections.Generic;
using System.Data;
using System;

namespace QuanLyKTX
{
    public class Const
    {
        public static string ConnectionString = @"Data Source=.;Initial Catalog=DBQuanLyKyTucXa;Integrated Security=True";
        public static NguoiDung CurrentUser = new NguoiDung();
        public static DataTable DanhSachQuyen = new DataTable();

        public static List<PhanQuyen> PhanQuyens = new List<PhanQuyen>();
        public static bool isFullOp = false;
        public static bool isLogin = false;
        public static int DoiTuongId = 0;
        public static int NguoiDungId = 0;
        public static BUS_NhatKyHoatDong NhatKyHoatDong = new BUS_NhatKyHoatDong();

        public static string PhongId = "";


        // phần thu tiền phongnf
        public static DateTime TuNgay;
        public static DateTime DenNgay;
        public static decimal PhiPhong4 = 0;
        public static decimal PhiPhong6 = 0;
        public static decimal PhiPhong8 = 0;
    }
}
