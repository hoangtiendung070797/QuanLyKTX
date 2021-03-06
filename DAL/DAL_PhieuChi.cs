﻿using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_PhieuChi : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_PhieuChi()
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
                string query = "SELECT * FROM PhieuChi";
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

        public DataTable GetDataNew()
        {
            try
            {
                string query = "SELECT PhieuChiId,PhieuChi.NhanVienId,PhieuChi.NguoiDungId,tenNhanVien,tenDangNhap,ngayChi,soTien,noiDung,ghiChu " +
                    "FROM dbo.PhieuChi JOIN dbo.NhanVien ON NhanVien.NhanVienID = PhieuChi.NhanVienId " +
                    "JOIN	dbo.NguoiDung ON NguoiDung.NguoiDungId = PhieuChi.NguoiDungId";
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

        public bool Insert(PhieuChi phieuChi)
        {
            try
            {
                string query = "SELECT * FROM PhieuChi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["NhanVienId"] = phieuChi.NhanVienId;
                row["NguoiDungId"] = phieuChi.NguoiDungId;
                row["ngayChi"] = phieuChi.NgayChi;
                row["noiDung"] = phieuChi.NoiDung;
                row["ghiChu"] = phieuChi.GhiChu;
                row["soTien"] = phieuChi.SoTien;

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

        public bool Delete(int phieuChiId)
        {
            try
            {
                string query = "SELECT * FROM PhieuChi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(phieuChiId);

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

        public bool Update(PhieuChi phieuChi)
        {
            try
            {
                string query = "SELECT * FROM PhieuChi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(phieuChi.PhieuChiId);

                if (row != null)
                {
                    row["NhanVienId"] = phieuChi.NhanVienId;
                    row["NguoiDungId"] = phieuChi.NguoiDungId;
                    row["ngayChi"] = phieuChi.NgayChi;
                    row["noiDung"] = phieuChi.NoiDung;
                    row["ghiChu"] = phieuChi.GhiChu;
                    row["soTien"] = phieuChi.SoTien;
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
