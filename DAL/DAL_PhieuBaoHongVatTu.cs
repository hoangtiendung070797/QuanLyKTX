using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_PhieuBaoHongVatTu : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_PhieuBaoHongVatTu()
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
                string query = "SELECT * FROM PhieuBaoHongVatTu";
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


        public bool Insert(PhieuBaoHongVatTu phieuBaoHongVatTu)
        {
            try
            {
                string query = "SELECT * FROM PhieuBaoHongVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["tenPhieuBaoHong"] = phieuBaoHongVatTu.TenPhieuBaoHong;
                row["tenNguoiLap"] = phieuBaoHongVatTu.TenNguoiLap;
                row["ngayBao"] = phieuBaoHongVatTu.NgayBao;
                row["ghiChu"] = phieuBaoHongVatTu.GhiChu1;
                row["NhanVienId"] = phieuBaoHongVatTu.NhanVienId;
                row["NguoiDungId"] = phieuBaoHongVatTu.NguoiDungId;

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

        public bool Delete(int phieuBaoHongVatTuId)
        {
            try
            {
                string query = "SELECT * FROM PhieuBaoHongVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phieuBaoHongVatTuId);

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

        public bool Update(PhieuBaoHongVatTu phieuBaoHongVatTu)
        {
            try
            {
                string query = "SELECT * FROM PhieuBaoHongVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phieuBaoHongVatTu.PhieuBaoHongVatTuId);

                if (row != null)
                {
                    row["tenPhieuBaoHong"] = phieuBaoHongVatTu.TenPhieuBaoHong;
                    row["tenNguoiLap"] = phieuBaoHongVatTu.TenNguoiLap;
                    row["ngayBao"] = phieuBaoHongVatTu.NgayBao;
                    row["ghiChu"] = phieuBaoHongVatTu.GhiChu1;
                    row["NhanVienId"] = phieuBaoHongVatTu.NhanVienId;
                    row["NguoiDungId"] = phieuBaoHongVatTu.NguoiDungId;
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
