using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_PhieuThuTienPhong : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_PhieuThuTienPhong()
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
                string query = "SELECT * FROM PhieuThuTienPhong";
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


        public bool Insert(PhieuThuTienPhong phieuThuTienPhong)
        {
            try
            {
                string query = "SELECT * FROM PhieuThuTienPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();

                row["DoiTuongId"] = phieuThuTienPhong.DoiTuongId;
                row["NhanVienId"] = phieuThuTienPhong.NhanVienId;
                row["NguoiDungId"] = phieuThuTienPhong.NguoiDungId;
                row["tenNguoiLap"] = phieuThuTienPhong.TenNguoiLap;
                row["ngayThu"] = phieuThuTienPhong.NgayThu;
                row["tuNgay"] = phieuThuTienPhong.TuNgay;
                row["denNgay"] = phieuThuTienPhong.DenNgay;
                row["tienThu"] = phieuThuTienPhong.TienThu;
                row["ghiChu"] = phieuThuTienPhong.GhiChu;
                row["tinhTrang"] = phieuThuTienPhong.TinhTrang;

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

        public bool Delete(int phieuThuTienPhongID)
        {
            try
            {
                string query = "SELECT * FROM PhieuThuTienPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(phieuThuTienPhongID);

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

        public bool Update(PhieuThuTienPhong phieuThuTienPhong)
        {
            try
            {
                string query = "SELECT * FROM PhieuThuTienPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(phieuThuTienPhong.PhieuThuTienPhongId);

                if (row != null)
                {
                    row["DoiTuongId"] = phieuThuTienPhong.DoiTuongId;
                    row["NhanVienId"] = phieuThuTienPhong.NhanVienId;
                    row["NguoiDungId"] = phieuThuTienPhong.NguoiDungId;
                    row["tenNguoiLap"] = phieuThuTienPhong.TenNguoiLap;
                    row["ngayThu"] = phieuThuTienPhong.NgayThu;
                    row["tuNgay"] = phieuThuTienPhong.TuNgay;
                    row["denNgay"] = phieuThuTienPhong.DenNgay;
                    row["tienThu"] = phieuThuTienPhong.TienThu;
                    row["ghiChu"] = phieuThuTienPhong.GhiChu;
                    row["tinhTrang"] = phieuThuTienPhong.TinhTrang;
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

        public DataTable GetDataById(int doiTuongId)
        {
            try
            {
                string query = "SELECT dbo.PhieuThuTienPhong.* FROM	 dbo.DoiTuong INNER JOIN dbo.PhieuThuTienPhong ON	PhieuThuTienPhong.DoiTuongId = DoiTuong.DoiTuongId WHERE dbo.PhieuThuTienPhong.DoiTuongId = " + doiTuongId;
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

        public int GetIdentityId()
        {
            string query = "SELECT IDENT_CURRENT('PhieuThuTienPhong') as LastID";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return int.Parse(table.Rows[0][0].ToString());
        }

        public DataTable GetDataByDate(DateTime date)
        {
            try
            {
                string query = "SELECT dbo.PhieuThuTienPhong.* FROM	 dbo.DoiTuong INNER JOIN dbo.PhieuThuTienPhong ON	PhieuThuTienPhong.DoiTuongId = DoiTuong.DoiTuongId WHERE dbo.PhieuThuTienPhong.ngayThu = '" + date.ToString("MM-dd-yyyy") + "'";
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

        public DataTable PrintInfo()
        {

            try
            {
                string query = "SELECT PhieuThuTienPhongId, maSinhVien AS N'MSV',(dbo.DoiTuong.hoDem + N' ' + dbo.DoiTuong.ten) AS N'Họ và tên',ngayThu AS N'Ngày thu',tuNgay AS N'Phí từ ngày', denNgay AS N'Phí đến ngày', tenNguoiLap AS N'Tên người lập phiếu', tienThu AS N'Số tiền thu', CASE WHEN tinhTrang = 1 THEN N'Đã thu' ELSE N'Chưa thu' END  AS N'Tình trạng thu' FROM dbo.PhieuThuTienPhong INNER JOIN dbo.DoiTuong ON	DoiTuong.DoiTuongId = PhieuThuTienPhong.DoiTuongId ";
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
        public bool isInPhieuThuTienPhong(int doiTuongId, DateTime tuNgay, DateTime denNgay)
        {



            return true;
        }

        public DataTable GetSinhVienTheoTinhTrangPhieuThuTienPhong(int tinhTrang)
        {
            try
            {
                string query = "Select DoiTuong.hoDem + N' '+ DoiTuong.ten as N'Họ và tên',DoiTuong.maSinhVien as N'Mã sinh viên', DoiTuong.ngaySinh AS N'Ngày sinh', Case when DoiTuong.gioiTinh = 1 then N'Nam' when DoiTuong.gioiTinh = 0 then N'Nữ' end as N'Giới tính', PhieuThuTienPhong.tuNgay as N'Từ ngày', PhieuThuTienPhong.denNgay as N'Đến ngày', PhieuThuTienPhong.tienThu as N'Tiền thu',Case when PhieuThuTienPhong.tinhTrang = 1 then N'Đã thu' when PhieuThuTienPhong.tinhTrang = 0 then N'Chưa thu' end as N'Tình Trạng', PhieuThuTienPhong.ngayThu as N'Ngày thu', NhanVien.tenNhanVien as N'Tên người lập' FROM NhanVien inner join PhieuThuTienPhong inner join DoiTuong on DoiTuong.DoiTuongId = PhieuThuTienPhong.DoiTuongId on PhieuThuTienPhong.NhanVienId = NhanVien.NhanVienID WHERE PhieuThuTienPhong.tinhTrang = " + tinhTrang;
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
        public DataTable GetDataPhieuThuTienPhong()
        {
            try
            {
                string query = "Select DoiTuong.hoDem + N' '+ DoiTuong.ten as N'Họ và tên',DoiTuong.maSinhVien as N'Mã sinh viên', DoiTuong.ngaySinh AS N'Ngày sinh', Case when  DoiTuong.gioiTinh = 1 then N'Nam' when DoiTuong.gioiTinh = 0 then N'Nữ' end as N'Giới tính', PhieuThuTienPhong.tuNgay as N'Từ ngày', PhieuThuTienPhong.denNgay as N'Đến ngày', PhieuThuTienPhong.tienThu as N'Tiền thu',Case when  PhieuThuTienPhong.tinhTrang = 1 then N'Đã thu' when PhieuThuTienPhong.tinhTrang = 0 then N'Chưa thu' end as N'Tình Trạng', PhieuThuTienPhong.ngayThu as N'Ngày thu', NhanVien.tenNhanVien as N'Tên người lập' FROM NhanVien inner join PhieuThuTienPhong inner join DoiTuong on DoiTuong.DoiTuongId = PhieuThuTienPhong.DoiTuongId on PhieuThuTienPhong.NhanVienId = NhanVien.NhanVienID";
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


        public DataRow GetInforById(int phieuThuTienPhongID)
        {
            try
            {
                string query = "SELECT * FROM PhieuThuTienPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                return table.Rows.Find(phieuThuTienPhongID);

               
            }
            catch
            {

                return null;
            }

        }
        public DataTable PrinftPhieu(int phieuId)
        {
            try
            {
                string query = "SELECT dbo.NhanVien.tenNhanVien, dbo.NhanVien.sdt, dbo.DoiTuong.hoDem + N' ' + dbo.DoiTuong.ten AS hoTen, dbo.DoiTuong.maSinhVien,dbo.PhieuThuTienPhong.tuNgay, dbo.PhieuThuTienPhong.denNgay, dbo.PhieuThuTienPhong.tienThu FROM dbo.NhanVien INNER JOIN dbo.PhieuThuTienPhong INNER JOIN dbo.DoiTuong ON DoiTuong.DoiTuongId = PhieuThuTienPhong.DoiTuongId ON PhieuThuTienPhong.NhanVienId = NhanVien.NhanVienID WHERE dbo.PhieuThuTienPhong.PhieuThuTienPhongId = " + phieuId; ;
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
