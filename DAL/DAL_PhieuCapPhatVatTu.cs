using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_PhieuCapPhatVatTu : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_PhieuCapPhatVatTu()
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
                string query = "SELECT * FROM PhieuCapPhatVatTu";
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


        public bool Insert(PhieuCapPhatVatTu phieuCapPhatVatTu)
        {
            try
            {
                string query = "SELECT * FROM PhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["PhongId"] = phieuCapPhatVatTu.PhongId1;
                row["NhanVienId"] = phieuCapPhatVatTu.NhanVienId;
                row["NguoiDungId"] = phieuCapPhatVatTu.NguoiDungId;
                row["ngayCapPhat"] = phieuCapPhatVatTu.NgayCapPhat;
                row["tenNguoiLap"] = phieuCapPhatVatTu.TenNguoiLap;
                row["ghiChu"] = phieuCapPhatVatTu.GhiChu;

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

        public bool Delete(int phieuCapPhatVatTuId)
        {
            try
            {
                string query = "SELECT * FROM PhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phieuCapPhatVatTuId);

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

        public bool Update(PhieuCapPhatVatTu phieuCapPhatVatTu)
        {
            try
            {
                string query = "SELECT * FROM PhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phieuCapPhatVatTu.PhieuCapPhatVatTuId);

                if (row != null)
                {
                    row["PhongId"] = phieuCapPhatVatTu.PhongId1;
                    row["NhanVienId"] = phieuCapPhatVatTu.NhanVienId;
                    row["NguoiDungId"] = phieuCapPhatVatTu.NguoiDungId;
                    row["ngayCapPhat"] = phieuCapPhatVatTu.NgayCapPhat;
                    row["tenNguoiLap"] = phieuCapPhatVatTu.TenNguoiLap;
                    row["ghiChu"] = phieuCapPhatVatTu.GhiChu;
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
