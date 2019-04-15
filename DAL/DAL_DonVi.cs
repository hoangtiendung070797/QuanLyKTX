using DTO;
using System;
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
            table.PrimaryKey = new DataColumn[] { table.Columns[0] };

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
            // try
            //  {
            table = GetData();
            string query = "SELECT * FROM DonVi";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            table = GetData();
            table.PrimaryKey = new DataColumn[] { table.Columns[0] };
            DataRow row = table.Rows.Find(donViId);

            if (row != null)
            {
                row.Delete();
            }

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(table);
            return true;
        }
        //  catch (Exception e)
        //  { 

        //     return false;
        //     }
        //   }

        public bool Update(DonVi donVi)
        {
            try
            {
                string query = "SELECT * FROM DonVi";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
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
        //Lấy ra thông tin sinh viên nội trú theo lớp.
        public DataTable GetSinhVienTheoDonVi(int donViId)
        {
            try
            {
                string query = "Select DoiTuong.hoDem + N' '+ DoiTuong.ten as N'Họ và tên',DoiTuong.maSinhVien as N'Mã sinh viên', DoiTuong.ngaySinh AS N'Ngày sinh', Case when  DoiTuong.gioiTinh = 1 then N'Nam' when DoiTuong.gioiTinh = 0 then N'Nữ' end as N'Giới tính', Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Phòng',Lop.tenLop as N'Tên lớp', DonVi.tenDonVi as N'Tên Đơn Vị' FROM DonVi inner join Lop inner join DoiTuong inner join LuuTruPhong inner join Phong inner join DayNha on  DayNha.DayNhaId = Phong.DayNhaId  on Phong.PhongId = LuuTruPhong.PhongId on LuuTruPhong.DoiTuongId = DoiTuong.DoiTuongId on DoiTuong.LopId = Lop.LopId on Lop.DonViID = DonVi.DonViID WHERE DonVi.DonViId = " + donViId;
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
        public DataTable GetDataDonVi()
        {
            try
            {
                string query = "Select DoiTuong.hoDem + N' '+ DoiTuong.ten as N'Họ và tên',DoiTuong.maSinhVien as N'Mã sinh viên', DoiTuong.ngaySinh AS N'Ngày sinh', Case when  DoiTuong.gioiTinh = 1 then N'Nam' when DoiTuong.gioiTinh = 0 then N'Nữ' end as N'Giới tính', Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Phòng',Lop.tenLop as N'Tên lớp', DonVi.tenDonVi as N'Tên Đơn Vị' FROM DonVi inner join Lop inner join DoiTuong inner join LuuTruPhong inner join Phong inner join DayNha on  DayNha.DayNhaId = Phong.DayNhaId  on Phong.PhongId = LuuTruPhong.PhongId on LuuTruPhong.DoiTuongId = DoiTuong.DoiTuongId on DoiTuong.LopId = Lop.LopId on Lop.DonViID = DonVi.DonViID";
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
