using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_VatTu : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_VatTu()
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
                string query = "SELECT * FROM VatTu";
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
        public DataTable SeachData(string text)
        {
            try
            {
                string query = "SELECT * FROM dbo.VatTu WHERE VatTuId LIKE '%"+text+"%' OR tenVatTu LIKE N'%"+text+"%'";
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

        public bool Insert(VatTu vatTu)
        {
            try
            {
                string query = "SELECT * FROM VatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["VatTuId"] = vatTu.VatTuId;
                row["tenVatTu"] = vatTu.TenVatTu;
                row["soLuong"] = vatTu.SoLuong;
                row["ghiChu"] = vatTu.GhiChu;
                row["moTa "] = vatTu.MoTa;

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

        public bool Delete(string vatTuId)
        {
            try
            {
                string query = "SELECT * FROM VatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(vatTuId);

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

        public bool Update(VatTu vatTu)
        {
            try
            {
                string query = "SELECT * FROM VatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(vatTu.VatTuId);

                if (row != null)
                {
                    row["VatTuId"] = vatTu.VatTuId;
                    row["tenVatTu"] = vatTu.TenVatTu;
                    row["soLuong"] = vatTu.SoLuong;
                    row["ghiChu"] = vatTu.GhiChu;
                    row["moTa "] = vatTu.MoTa;
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
