using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ChiTietPhieuBaoHongVatTu : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_ChiTietPhieuBaoHongVatTu()
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
                string query = "SELECT * FROM ChiTietPhieuBaoHongVatTu";
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


        public bool Insert(ChiTietPhieuBaoHongVatTu chiTietPhieuBaoHongVatTu)
        {
            try
            {
                string query = "SELECT * FROM ChiTietPhieuBaoHongVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["PhieuBaoHongVatTuId"] = chiTietPhieuBaoHongVatTu.PhieuBaoHongVatTuId;
                row["VatTuId"] = chiTietPhieuBaoHongVatTu.VatTuId;
                row["PhongId"] = chiTietPhieuBaoHongVatTu.PhongId;
                row["soLuong"] = chiTietPhieuBaoHongVatTu.SoLuong;
                row["donViTinh"] = chiTietPhieuBaoHongVatTu.DonViTinh;
                row["lyDo"] = chiTietPhieuBaoHongVatTu.LyDo;
                row["yeuCau"] = chiTietPhieuBaoHongVatTu.YeuCau;
                row["ghiChu"] = chiTietPhieuBaoHongVatTu.GhiChu;
 
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

        public bool Delete(int ChiTietPhieuBaoHongVatTuId)
        {
            try
            {
                string query = "SELECT * FROM ChiTietPhieuBaoHongVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(ChiTietPhieuBaoHongVatTuId);

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

        public bool Update(ChiTietPhieuBaoHongVatTu chiTietPhieuBaoHongVatTu)
        {
            try
            {
                string query = "SELECT * FROM ChiTietPhieuBaoHongVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(chiTietPhieuBaoHongVatTu.ChiTietPhieuBaoHongVatTuId);

                if (row != null)
                {
                    row["PhieuBaoHongVatTuId"] = chiTietPhieuBaoHongVatTu.PhieuBaoHongVatTuId;
                    row["VatTuId"] = chiTietPhieuBaoHongVatTu.VatTuId;
                    row["PhongId"] = chiTietPhieuBaoHongVatTu.PhongId;
                    row["soLuong"] = chiTietPhieuBaoHongVatTu.SoLuong;
                    row["donViTinh"] = chiTietPhieuBaoHongVatTu.DonViTinh;
                    row["lyDo"] = chiTietPhieuBaoHongVatTu.LyDo;
                    row["yeuCau"] = chiTietPhieuBaoHongVatTu.YeuCau;
                    row["ghiChu"] = chiTietPhieuBaoHongVatTu.GhiChu;
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
