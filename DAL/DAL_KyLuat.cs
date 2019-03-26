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
    public class DAL_KyLuat : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_KyLuat()
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
                string query = "SELECT * FROM KyLuat";
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


        public bool Insert(KyLuat kyLuat)
        {
            try
            {
                string query = "SELECT * FROM KyLuat";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["DoiTuongId"] = kyLuat.DoiTuongId;
                row["tenKyLuat"] = kyLuat.TenKyLuat;
                row["noiDung"] = kyLuat.NoiDung;
                row["ngay"] = kyLuat.Ngay;
                row["ghiChu"] = kyLuat.GhiChu;

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

        public bool Delete(int kyLuatId)
        {
            try
            {
                string query = "SELECT * FROM DonVi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(kyLuatId);

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

        public bool Update(KyLuat kyLuat)
        {
            try
            {
                string query = "SELECT * FROM KyLuat";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(kyLuat.KyLuatId);

                if (row != null)
                {
                    row["DoiTuongId"] = kyLuat.DoiTuongId;
                    row["tenKyLuat"] = kyLuat.TenKyLuat;
                    row["noiDung"] = kyLuat.NoiDung;
                    row["ngay"] = kyLuat.Ngay;
                    row["ghiChu"] = kyLuat.GhiChu;
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
