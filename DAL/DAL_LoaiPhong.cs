using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_LoaiPhong : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_LoaiPhong()
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
                string query = "SELECT * FROM LoaiPhong";
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


        public bool Insert(LoaiPhong loaiPhong)
        {
            try
            {
                string query = "SELECT * FROM LoaiPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();

                row["tenLoaiPhong"] = loaiPhong.TenLoaiPhong;
                row["soLuongtoiDa"] = loaiPhong.SoLuongtoiDa;
                row["giaLoaiPhong"] = loaiPhong.GiaLoaiPhong;

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

        public bool Delete(int loaiPhongId)
        {
            try
            {
                string query = "SELECT * FROM LoaiPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(loaiPhongId);

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

        public bool Update(LoaiPhong loaiPhong)
        {
            try
            {
                string query = "SELECT * FROM LoaiPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(loaiPhong.LoaiPhongId);

                if (row != null)
                {
                    row["tenLoaiPhong"] = loaiPhong.TenLoaiPhong;
                    row["soLuongtoiDa"] = loaiPhong.SoLuongtoiDa;
                    row["giaLoaiPhong"] = loaiPhong.GiaLoaiPhong;
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
