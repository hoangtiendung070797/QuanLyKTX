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
    public class DAL_ThuocViPham : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_ThuocViPham()
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
                string query = "SELECT * FROM ThuocViPham";
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


        public bool Insert(ThuocViPham thuocViPham)
        {
            try
            {
                string query = "SELECT * FROM ThuocViPham";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["KyLuatId "] = thuocViPham.KyLuatId;
                row["LoiViPhamId "] = thuocViPham.LoiViPhamId;
                row["lanTaiPham "] = thuocViPham.LanTaiPham;

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

        public bool Delete(int thuocViPhamId)
        {
            try
            {
                string query = "SELECT * FROM ThuocViPham";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(thuocViPhamId);

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

        public bool Update(ThuocViPham thuocViPham)
        {
            try
            {
                string query = "SELECT * FROM ThuocViPham";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(thuocViPham.ThuocViPhamId);

                if (row != null)
                {
                    row["KyLuatId "] = thuocViPham.KyLuatId;
                    row["LoiViPhamId "] = thuocViPham.LoiViPhamId;
                    row["lanTaiPham "] = thuocViPham.LanTaiPham;
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
