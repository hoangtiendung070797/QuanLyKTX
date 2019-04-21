using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_NhatKyHoatDong : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_NhatKyHoatDong()
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
                string query = "SELECT * FROM NhatKyHoatDong";
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
        public DataTable PrintfAllInfor()
        {
            try
            {
                string query = "SELECT NhatKyHoatDongId, tenDangNhap, chucNang, thaoTac, noiDung, thoiGian FROM dbo.NhatKyHoatDong INNER JOIN dbo.NguoiDung ON NguoiDung.NguoiDungId = NhatKyHoatDong.NguoiDungId";
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
        

        public bool Insert(NhatKyHoatDong nhatKyHoatDong)
        {
            try
            {
                string query = "SELECT * FROM NhatKyHoatDong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["NguoiDungId"] = nhatKyHoatDong.NguoiDungId;
                row["chucNang"] = nhatKyHoatDong.ChucNang;                 
                row["thaoTac"] = nhatKyHoatDong.ThaoTac;
                row["noiDung"] = nhatKyHoatDong.NoiDung;
                row["thoiGian"] = nhatKyHoatDong.ThoiGian;
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

        public bool Delete(int nhatKyHoatDongId)
        {
            try
            {
                string query = "SELECT * FROM NhatKyHoatDong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(nhatKyHoatDongId);

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

        public bool Update(NhatKyHoatDong nhatKyHoatDong)
        {
            try
            {
                string query = "SELECT * FROM NhatKyHoatDong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(nhatKyHoatDong.NhatKyHoatDongId);

                if (row != null)
                {
                    row["NguoiDungId"] = nhatKyHoatDong.NguoiDungId;
                    row["chucNang"] = nhatKyHoatDong.ChucNang;                  
                    row["thaoTac"] = nhatKyHoatDong.ThaoTac;
                    row["noiDung"] = nhatKyHoatDong.NoiDung;
                    row["thoiGian"] = nhatKyHoatDong.ThoiGian;
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


        public DataTable GetDataByUser(string userName)
        {
            try
            {
                string query = "SELECT NhatKyHoatDongId,tenDangNhap, chucNang, thaoTac, noiDung,thoiGian FROM dbo.NhatKyHoatDong INNER JOIN dbo.NguoiDung ON NguoiDung.NguoiDungId = NhatKyHoatDong.NguoiDungId WHERE tenDangNhap = '" + userName + "'";
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

        public DataTable GetDataByDate(DateTime date)
        {
            try
            {
                string query = "SELECT NhatKyHoatDongId,tenDangNhap, chucNang, thaoTac, noiDung,thoiGian FROM dbo.NhatKyHoatDong INNER JOIN dbo.NguoiDung ON NguoiDung.NguoiDungId = NhatKyHoatDong.NguoiDungId WHERE convert(DATE,thoiGian) = '" + date.ToString("yyyy-MM-dd") +  "'";
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

        public DataTable GetDataByAction(string action)
        {
            try
            {
                string query = "SELECT NhatKyHoatDongId,tenDangNhap, chucNang, thaoTac, noiDung,thoiGian FROM dbo.NhatKyHoatDong INNER JOIN dbo.NguoiDung ON NguoiDung.NguoiDungId = NhatKyHoatDong.NguoiDungId WHERE thaoTac = N'"+action +"'";
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

        public DataTable GetDataByFunction(string fun)
        {
            try
            {
                string query = "SELECT NhatKyHoatDongId,tenDangNhap, chucNang, thaoTac, noiDung,thoiGian FROM dbo.NhatKyHoatDong INNER JOIN dbo.NguoiDung ON NguoiDung.NguoiDungId = NhatKyHoatDong.NguoiDungId WHERE chucNang = N'" + fun + "'";
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
        public DataTable GetDataByAllCondition(string userName,DateTime date,string action,string fun)
        {
            try
            {
                string query = "SELECT NhatKyHoatDongId,tenDangNhap, chucNang, thaoTac, noiDung,thoiGian FROM dbo.NhatKyHoatDong INNER JOIN dbo.NguoiDung ON NguoiDung.NguoiDungId = NhatKyHoatDong.NguoiDungId WHERE convert(DATE,thoiGian) = '" + date.ToString("yyyy-MM-dd") + "'" +
                    " AND tenDangNhap = '" + userName + "'";
                if (action != "Tất cả")
                    query += " AND thaoTac = N'" + action + "'";
                if (fun != "Tất cả")
                    query += " AND chucNang = N'" + fun + "'";
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
        #endregion
    }
}
