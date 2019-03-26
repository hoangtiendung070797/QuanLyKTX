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
    public class DAL_Phong : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_Phong()
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
                string query = "SELECT * FROM Phong";
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


        public bool Insert(Phong phong)
        {
            try
            {
                string query = "SELECT * FROM Phong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["PhongId"] = phong.PhongId;
                row["DayNhaId"] = phong.DayNhaId;
                row["LoaiPhongId"] = phong.LoaiPhongId;
                row["tenPhong"] = phong.TenPhong;
                row["tang"] = phong.Tang;
                row["giaPhong"] = phong.GiaPhong;

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

        public bool Delete(string phongId)
        {
            try
            {
                string query = "SELECT * FROM Phong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phongId);

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

        public bool Update(Phong phong)
        {
            try
            {
                string query = "SELECT * FROM Phong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phong.PhongId);

                if (row != null)
                {
                    row["PhongId"] = phong.PhongId;
                    row["DayNhaId"] = phong.DayNhaId;
                    row["LoaiPhongId"] = phong.LoaiPhongId;
                    row["tenPhong"] = phong.TenPhong;
                    row["tang"] = phong.Tang;
                    row["giaPhong"] = phong.GiaPhong;
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
