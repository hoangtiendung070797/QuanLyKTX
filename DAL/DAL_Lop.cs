using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Lop : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_Lop()
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
                string query = "SELECT Lop.LopId,tenLop,DonVi.DonViId,tenDonVi FROM Lop join DonVi on DonVi.DonViId = Lop.DonViId";
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


        public bool Insert(Lop lop)
        {
            try
            {
                string query = "SELECT * FROM Lop";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["tenLop"] = lop.TenLop;
                row["DonViId"] = lop.DonViId;

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

        public bool Delete(int lopId)
        {
            try
            {
                string query = "SELECT * FROM Lop";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(lopId);

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

        public bool Update(Lop lop)
        {
            try
            {
                string query = "SELECT * FROM Lop";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(lop.LopId);

                if (row != null)
                {
                    row["tenLop"] = lop.TenLop;
                    row["DonViId"] = lop.DonViId;
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
        public DataTable GetSinhVienTheoLop(int lopId)
        {
            try
            {
                string query = "Select DoiTuong.hoDem + N' '+ DoiTuong.ten as N'Họ và tên',DoiTuong.maSinhVien as N'Mã sinh viên', DoiTuong.ngaySinh AS N'Ngày sinh', Case when  DoiTuong.gioiTinh = 1 then N'Nam' when DoiTuong.gioiTinh = 0 then N'Nữ' end as N'Giới tính', Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Phòng',Lop.tenLop as N'Tên lớp'  FROM Lop inner join DoiTuong inner join LuuTruPhong inner join Phong inner join DayNha on  DayNha.DayNhaId = Phong.DayNhaId  on Phong.PhongId = LuuTruPhong.PhongId on LuuTruPhong.DoiTuongId = DoiTuong.DoiTuongId on DoiTuong.LopId = Lop.LopId WHERE Lop.LopId = " + lopId;
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
        public DataTable GetDataLop()
        {
            try
            {
                string query = "Select DoiTuong.hoDem + N' '+ DoiTuong.ten as N'Họ và tên',DoiTuong.maSinhVien as N'Mã sinh viên', DoiTuong.ngaySinh AS N'Ngày sinh', Case when  DoiTuong.gioiTinh = 1 then N'Nam' when DoiTuong.gioiTinh = 0 then N'Nữ' end as N'Giới tính', Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Phòng',Lop.tenLop as N'Tên lớp'  FROM Lop inner join DoiTuong inner join LuuTruPhong inner join Phong inner join DayNha on  DayNha.DayNhaId = Phong.DayNhaId  on Phong.PhongId = LuuTruPhong.PhongId on LuuTruPhong.DoiTuongId = DoiTuong.DoiTuongId on DoiTuong.LopId = Lop.LopId";
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
