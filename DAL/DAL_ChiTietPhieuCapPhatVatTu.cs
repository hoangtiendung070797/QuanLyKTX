using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_ChiTietPhieuCapPhatVatTu : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_ChiTietPhieuCapPhatVatTu()
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
                string query = "SELECT * FROM ChiTietPhieuCapPhatVatTu";
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


        public bool Insert(ChiTietPhieuCapPhatVatTu chiTietPhieuCapPhatVatTu)
        {
            try
            {
                string query = "SELECT * FROM ChiTietPhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["PhieuCapPhatVatTuId"] = chiTietPhieuCapPhatVatTu.PhieuCapPhatVatTuId;
                row["VatTuId"] = chiTietPhieuCapPhatVatTu.VatTuId;
                row["PhongId"] = chiTietPhieuCapPhatVatTu.PhongId1;
                row["soLuong"] = chiTietPhieuCapPhatVatTu.SoLuong;
                row["donViTinh"] = chiTietPhieuCapPhatVatTu.DonViTinh;
    
                row["thanhTien"] = chiTietPhieuCapPhatVatTu.ThanhTien;
                row["ghiChu"] = chiTietPhieuCapPhatVatTu.GhiChu;

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

        public bool Delete(int ChiTietPhieuCapPhatVatTuId)
        {
            try
            {
                string query = "SELECT * FROM chiTietPhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(ChiTietPhieuCapPhatVatTuId);

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

        public bool Update(ChiTietPhieuCapPhatVatTu chiTietPhieuCapPhatVatTu)
        {
            try
            {
                string query = "SELECT * FROM ChiTietPhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(chiTietPhieuCapPhatVatTu.ChiTietPhieuCapPhatVatTuId);

                if (row != null)
                {
                    row["PhieuCapPhatVatTuId"] = chiTietPhieuCapPhatVatTu.PhieuCapPhatVatTuId;
                    row["VatTuId"] = chiTietPhieuCapPhatVatTu.VatTuId;
                    row["PhongId"] = chiTietPhieuCapPhatVatTu.PhongId1;
                    row["soLuong"] = chiTietPhieuCapPhatVatTu.SoLuong;
                    row["donViTinh"] = chiTietPhieuCapPhatVatTu.DonViTinh;
       
                    row["thanhTien"] = chiTietPhieuCapPhatVatTu.ThanhTien;
                    row["ghiChu"] = chiTietPhieuCapPhatVatTu.GhiChu;
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
