﻿using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_PhanQuyen:DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_PhanQuyen()
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
                string query = "SELECT * FROM PhanQuyen";
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


        public bool Insert(PhanQuyen phanQuyen)
        {
            try
            {
                string query = "SELECT * FROM PhanQuyen";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["tenNhomChucNang"] = phanQuyen.TenNhomChucNang;
                row["tenChucNang"] = phanQuyen.TenChucNang;
                row["chucNangThem"] = phanQuyen.ChucNangThem;
                row["chucNangSua"] = phanQuyen.ChucNangSua;
                row["chucNangXoa"] = phanQuyen.ChucNangXoa;
                row["chucNangDoc"] = phanQuyen.ChucNangDoc;

                row["NguoiDungId"] = phanQuyen.NguoiDungId;

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

        public bool Delete(int phanQuyenId)
        {
            try
            {
                string query = "SELECT * FROM PhanQuyen";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phanQuyenId);

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

        public bool Update(PhanQuyen phanQuyen)
        {
            try
            {
                string query = "SELECT * FROM PhanQuyen";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phanQuyen.PhanQuyenId);

                if (row != null)
                {
                    row["tenNhomChucNang"] = phanQuyen.TenNhomChucNang;
                    row["tenChucNang"] = phanQuyen.TenChucNang;
                    row["chucNangThem"] = phanQuyen.ChucNangThem;
                    row["chucNangSua"] = phanQuyen.ChucNangSua;
                    row["chucNangXoa"] = phanQuyen.ChucNangXoa;
                    row["chucNangDoc"] = phanQuyen.ChucNangDoc;

                    row["NguoiDungId"] = phanQuyen.NguoiDungId;

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


        public DataTable GetDetailPhanQuyen(int nguoiDungId)
        {
            try
            {
                string query = "SELECT * FROM PhanQuyen WHERE NguoiDungId = " + nguoiDungId;
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

        public bool IsNguoiDungIdInPQ(int nguoiDungId)
        {
            try
            {
                string query = "SELECT	COUNT(NguoiDungId) FROM dbo.PhanQuyen WHERE NguoiDungId = " + nguoiDungId;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                
                return ((int)table.Rows[0][0] > 0?true:false);
            }
            catch
            {
                return true;
            }
        }


        public bool UpdateDetail(DataTable table)
        {
            try
            {
                string query = "SELECT * FROM PhanQuyen";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                


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
