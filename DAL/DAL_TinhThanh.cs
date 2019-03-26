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
    public class DAL_TinhThanh : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_TinhThanh()
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
                string query = "SELECT * FROM TinhThanh";
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


        public bool Insert(TinhThanh tinhThanh)
        {
            try
            {
                string query = "SELECT * FROM TinhThanh";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["tenTinhThanh"] = tinhThanh.TenTinhThanh;

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

        public bool Delete(int tinhThanhId)
        {
            try
            {
                string query = "SELECT * FROM TinhThanh";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(tinhThanhId);

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

        public bool Update(TinhThanh tinhThanh)
        {
            try
            {
                string query = "SELECT * FROM TinhThanh";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(tinhThanh.TinhThanhId);

                if (row != null)
                {
                    row["tenTinhThanh"] = tinhThanh.TenTinhThanh;
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
