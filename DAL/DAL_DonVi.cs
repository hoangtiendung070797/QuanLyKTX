using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_DonVi : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_DonVi()
        {
            table = GetData();
            table.PrimaryKey = new DataColumn[] {table.Columns[0]};

        }
        #endregion

        #region Methods
        public DataTable GetData()
        {
            try
            {
                string query = "SELECT * FROM DonVi";
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


        public bool Insert(DonVi donVi)
        {
            try
            {
                string query = "SELECT * FROM DonVi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["tenDonVi"] = donVi.TenDonVi;
                row["diaChi"] = donVi.DiaChi;
                row["sdt"] = donVi.Sdt;
                row["ghiChu"] = donVi.GhiChu;

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

        public bool Delete(int donViId)
        {
            try
            {
                string query = "SELECT * FROM DonVi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(donViId);

                if(row != null)
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

        public bool Update(DonVi donVi)
        {
            try
            {
                string query = "SELECT * FROM DonVi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(donVi.DonViId);

                if (row != null)
                {
                    row["tenDonVi"] = donVi.TenDonVi;
                    row["diaChi"] = donVi.DiaChi;
                    row["sdt"] = donVi.Sdt;
                    row["ghiChu"] = donVi.GhiChu;
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
