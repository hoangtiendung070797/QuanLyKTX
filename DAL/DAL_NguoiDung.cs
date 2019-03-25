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
    public class DAL_NguoiDung : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_NguoiDung()
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
                string query = "SELECT * FROM NguoiDung";
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


        public bool Insert(NguoiDung nguoiDung)
        {
            try
            {
                string query = "SELECT * FROM NguoiDung";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["tenDangNhap"] = nguoiDung.TenDangNhap;
                row["matKhau"] = nguoiDung.MatKhau;
                row["tenDayDu"] = nguoiDung.TenDayDu;
                row["sdt"] = nguoiDung.Sdt;
                row["diachi"] = nguoiDung.DiaChi;
                row["ChucVu"] = nguoiDung.ChucVu;
                row["quyen"] = nguoiDung.Quyen;

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

        public bool Delete(int nguoiDungId)
        {
            try
            {
                string query = "SELECT * FROM NguoiDung";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(nguoiDungId);

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

        public bool Update(NguoiDung nguoiDung)
        {
            try
            {
                string query = "SELECT * FROM NguoiDung";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(nguoiDung.NguoiDungId);

                if (row != null)
                {
                    row["tenDangNhap"] = nguoiDung.TenDangNhap;
                    row["matKhau"] = nguoiDung.MatKhau;
                    row["tenDayDu"] = nguoiDung.TenDayDu;
                    row["sdt"] = nguoiDung.Sdt;
                    row["diachi"] = nguoiDung.DiaChi;
                    row["ChucVu"] = nguoiDung.ChucVu;
                    row["quyen"] = nguoiDung.Quyen;
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
