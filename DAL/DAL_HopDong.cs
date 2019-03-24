using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HopDong:DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_HopDong()
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
                string query = "SELECT * FROM HopDong";
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


        public bool Insert(HopDong hopDong)
        {
            try
            {
                string query = "SELECT * FROM HopDong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();

                
                row["tenHopDong"] = hopDong.TenHopDong;
                row["tuNgay"] = hopDong.TuNgay;
                row["denNgay"] = hopDong.DenNgay;
                row["thoiHanTheoNam"] = hopDong.ThoiHanTheoNam;
                row["thoiHanTheoThang"] = hopDong.ThoiHanTheoThang;
                row["noiDung"] = hopDong.NoiDung;
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

        public bool Delete(int hopDongId)
        {
            try
            {
                string query = "SELECT * FROM DonVi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(hopDongId);

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

        public bool Update(HopDong hopDong)
        {
            try
            {
                string query = "SELECT * FROM HopDong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(hopDong.HopDongId);

                if (row != null)
                {
                    row["tenHopDong"] = hopDong.TenHopDong;
                    row["tuNgay"] = hopDong.TuNgay;
                    row["denNgay"] = hopDong.DenNgay;
                    row["thoiHanTheoNam"] = hopDong.ThoiHanTheoNam;
                    row["thoiHanTheoThang"] = hopDong.ThoiHanTheoThang;
                    row["noiDung"] = hopDong.NoiDung;
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
