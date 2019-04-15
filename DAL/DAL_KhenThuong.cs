using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_KhenThuong : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_KhenThuong()
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
                string query = "SELECT KhenThuong.KhenThuongId,DoiTuong.DoiTuongId,maSinhVien,hoDem,ten,KhenThuong.tenKhenThuong,noiDung,ngay,KhenThuong.ghiChu FROM KhenThuong join DoiTuong on DoiTuong.DoiTuongId=KhenThuong.DoiTuongId";
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


        public bool Insert(KhenThuong khenThuong)
        {
            try
            {
                string query = "SELECT * FROM KhenThuong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["DoiTuongId"] = khenThuong.DoiTuongId;
                row["tenKhenThuong"] = khenThuong.TenKhenThuong;
                row["noiDung"] = khenThuong.NoiDung;
                row["ngay"] = khenThuong.Ngay;
                row["ghiChu"] = khenThuong.GhiChu;

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

        public bool Delete(int KhenThuongId)
        {
            try
            {
                string query = "SELECT * FROM KhenThuong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(KhenThuongId);

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

        public bool Update(KhenThuong khenThuong)
        {
            try
            {
                string query = "SELECT * FROM KhenThuong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(khenThuong.DoiTuongId);

                if (row != null)
                {
                    row["DoiTuongId"] = khenThuong.DoiTuongId;
                    row["tenKhenThuong"] = khenThuong.TenKhenThuong;
                    row["noiDung"] = khenThuong.NoiDung;
                    row["ngay"] = khenThuong.Ngay;
                    row["ghiChu"] = khenThuong.GhiChu;
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
        public DataTable GetSinhVienTheoKhenThuong()
        {
            try
            {
                string query = "Select DoiTuong.hoDem + N' '+ DoiTuong.ten as N'Họ và tên',DoiTuong.maSinhVien as N'Mã sinh viên', DoiTuong.ngaySinh AS N'Ngày sinh', Case when  DoiTuong.gioiTinh = 1 then N'Nam' when DoiTuong.gioiTinh = 0 then N'Nữ' end as N'Giới tính', KhenThuong.tenKhenThuong as N'Tên khen thưởng', KhenThuong.noiDung as N'Nội dung khen thưởng', KhenThuong.ngay as N'Ngày khen thưởng' From KhenThuong inner join DoiTuong on DoiTuong.DoiTuongId = KhenThuong.DoiTuongId";
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
