using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_LoiViPham : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_LoiViPham()
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
                string query = "SELECT * FROM LoiViPham";
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


        public bool Insert(LoiViPham loiViPham)
        {
            try
            {
                string query = "SELECT * FROM LoiViPham";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["tenLoiViPham"] = loiViPham.TenLoiViPham;
                row["noiDung"] = loiViPham.NoiDung;
                row["hinhThucXuLy"] = loiViPham.HinhThucXuLy;
                row["ghiChu"] = loiViPham.GhiChu;

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

        public bool Delete(int loiViPhamId)
        {
            try
            {
                string query = "SELECT * FROM LoiViPham";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(loiViPhamId);

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

        public bool Update(LoiViPham loiViPham)
        {
            try
            {
                string query = "SELECT * FROM LoiViPham";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(loiViPham.LoiViPhamId);

                if (row != null)
                {
                    row["tenLoiViPham"] = loiViPham.TenLoiViPham;
                    row["noiDung"] = loiViPham.NoiDung;
                    row["hinhThucXuLy"] = loiViPham.HinhThucXuLy;
                    row["ghiChu"] = loiViPham.GhiChu;
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
