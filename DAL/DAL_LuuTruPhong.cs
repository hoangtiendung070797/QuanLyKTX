﻿using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_LuuTruPhong : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_LuuTruPhong()
        {
            table = GetData();
            table.PrimaryKey = new DataColumn[] { table.Columns[0] };

        }
        #endregion

        #region Methods
        public DataTable GetData()
        {
            try
            {
                string query = "SELECT * FROM LuuTruPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
            catch
            {
                return null;
            }
        }

        public DataTable DoiTuong_TrongPhong(string phongId)
        {
            try
            {
                string query = "SELECT   DoiTuong.DoiTuongId,anh,maSinhVien,hoDem,ten,LuuTruPhong.LuuTruPhongId,NhanVienId,NguoiDungId,PhongId,ngayXep,ngayRoi,trangThai from LuuTruPhong join DoiTuong on DoiTuong.DoiTuongId = LuuTruPhong.DoiTuongId  where LuuTruPhong.PhongId = '" + phongId + "' and LuuTruPhong.trangThai = 1";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
            catch
            {
                return null;
            }
        }

        public DataTable DoiTuong_ChuaCoPhong()
        {
            try
            {
                string query = "select * from DoiTuong where DoiTuong.DoiTuongId not in (select LuuTruPhong.DoiTuongId from LuuTruPhong) or DoiTuong.DoiTuongId  in (select LuuTruPhong.DoiTuongId from LuuTruPhong where LuuTruPhong.trangThai = 0)";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
            catch
            {
                return null;
            }
        }
        public DataTable DoiTuong_ChuaCoPhong_GioiTinh(string gioitinh)     //thay đổi => BUS
        {
            try
            {
                string query = "select DoiTuong.anh,DoiTuong.DoiTuongId,maSinhVien,hoDem,ten,ngaySinh,noiSinh,gioiTinh,hoKhau,queQuan,sdt,email,ghiChu from DoiTuong  where  DoiTuong.gioiTinh = '" + gioitinh + "' and DoiTuong.DoiTuongId not in (select LuuTruPhong.DoiTuongId from LuuTruPhong) or DoiTuong.DoiTuongId  in (select LuuTruPhong.DoiTuongId from LuuTruPhong where LuuTruPhong.trangThai = 0)";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
            catch
            {
                return null;
            }
        }

        public bool Insert(LuuTruPhong luuTruPhong)
        {
            try
            {
                string query = "SELECT * FROM LuuTruPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["NhanVienId"] = luuTruPhong.NhanVienId;
                row["NguoiDungId"] = luuTruPhong.NguoiDungId;
                row["PhongId"] = luuTruPhong.PhongId;
                row["DoiTuongId"] = luuTruPhong.DoiTuongId;
                row["ngayXep"] = luuTruPhong.NgayXep;
                row["ngayRoi"] = luuTruPhong.NgayRoi;
                row["trangThai"] = luuTruPhong.TrangThai;

                table.Rows.Add(row);

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(table);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int luuTruPhongId)
        {
            try
            {
                string query = "SELECT * FROM LuuTruPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(luuTruPhongId);

                if (row != null)
                {
                    row.Delete();
                }

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(table);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Update(LuuTruPhong luuTruPhong)
        {
            try
            {
                string query = "SELECT * FROM LuuTruPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(luuTruPhong.LuuTruPhongId);

                if (row != null)
                {
                    row["NhanVienId"] = luuTruPhong.NhanVienId;
                    row["NguoiDungId"] = luuTruPhong.NguoiDungId;
                    row["PhongId"] = luuTruPhong.PhongId;
                    row["DoiTuongId"] = luuTruPhong.DoiTuongId;
                    row["ngayXep"] = luuTruPhong.NgayXep;
                    row["ngayRoi"] = luuTruPhong.NgayRoi;
                    row["trangThai"] = luuTruPhong.TrangThai;
                }

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(table);
                return true;
            }
            catch
            {

                return false;
            }
        }
        #endregion
    }
}
