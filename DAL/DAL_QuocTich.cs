using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_QuocTich:DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_QuocTich()
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
                string query = "SELECT QuocTichId as N'ID', tenQuocTich as N'Quốc Tịch' FROM QuocTich";
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


        public bool Insert(QuocTich quocTich)
        {
            try
            {
                string query = "SELECT * FROM QuocTich";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["QuocTichId"] = quocTich.QuocTichId;
                row["tenQuocTich"] = quocTich.TenQuocTich;
              

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

        public bool Delete(int quocTichId)
        {
            try
            {
                string query = "SELECT * FROM QuocTich";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(quocTichId);

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

        public bool Update(QuocTich quocTich)
        {
            try
            {
                string query = "SELECT * FROM QuocTich";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(quocTich.QuocTichId);

                if (row != null)
                {
                    row["tenQuocTich"] = quocTich.TenQuocTich;
                 
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
