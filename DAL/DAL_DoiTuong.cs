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
    public class DAL_DoiTuong : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_DoiTuong()
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
                string query = "SELECT * FROM DayNha";
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


        public bool Insert(DoiTuong doiTuong)
        {
            try
            {
                string query = "SELECT * FROM DoiTuong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["LoaiDoiTuongId"] = doiTuong.LoaiDoiTuongId;
                row["QuocTichId"] = doiTuong.QuocTichId;
                row["TinhThanhId"] = doiTuong.TinhThanhId;
                row["LopId"] = doiTuong.LopId;
                row["maSinhVien"] = doiTuong.MaSinhVien;
                row["hoDem "] = doiTuong.HoDem;
                row["ten"] = doiTuong.Ten;
                row["ngaySinh"] = doiTuong.NgaySinh;
                row["noiSinh"] = doiTuong.NoiSinh;
                row["gioiTinh"] = doiTuong.GioiTinh;
                row["hoKhau"] = doiTuong.HoKhau;
                row["queQuan"] = doiTuong.QueQuan;
                row["sdt"] = doiTuong.Sdt;
                row["email"] = doiTuong.Email;
                row["ghiChu"] = doiTuong.GhiChu;

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

        public bool Delete(int DoiTuongId)
        {
            try
            {
                string query = "SELECT * FROM DoiTuong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(DoiTuongId);

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

        public bool Update(DoiTuong doiTuong)
        {
            try
            {
                string query = "SELECT * FROM DoiTuong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(doiTuong.DoiTuongId);

                if (row != null)
                {
                    row["LoaiDoiTuongId"] = doiTuong.LoaiDoiTuongId;
                    row["QuocTichId"] = doiTuong.QuocTichId;
                    row["TinhThanhId"] = doiTuong.TinhThanhId;
                    row["LopId"] = doiTuong.LopId;
                    row["maSinhVien"] = doiTuong.MaSinhVien;
                    row["hoDem "] = doiTuong.HoDem;
                    row["ten"] = doiTuong.Ten;
                    row["ngaySinh"] = doiTuong.NgaySinh;
                    row["noiSinh"] = doiTuong.NoiSinh;
                    row["gioiTinh"] = doiTuong.GioiTinh;
                    row["hoKhau"] = doiTuong.HoKhau;
                    row["queQuan"] = doiTuong.QueQuan;
                    row["sdt"] = doiTuong.Sdt;
                    row["email"] = doiTuong.Email;
                    row["ghiChu"] = doiTuong.GhiChu;
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
