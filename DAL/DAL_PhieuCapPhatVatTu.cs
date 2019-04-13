using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_PhieuCapPhatVatTu : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        DataTable comboboxPhong = new DataTable();
        DataTable TimKiem = new DataTable();
        #endregion


        #region Initialize

        public DAL_PhieuCapPhatVatTu()
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
                string query = "SELECT * FROM PhieuCapPhatVatTu";
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

       
        public DataTable GetDataNew()
        {
            try
            {
                string query = "SELECT PhieuCapPhatVatTuId, PhieuCapPhatVatTu.PhongId,PhieuCapPhatVatTu.NhanVienId,PhieuCapPhatVatTu.NguoiDungId,tenPhong AS 'Phòng',tenNhanVien AS 'Nhân viên',tenDangNhap AS 'User',ngayCapPhat 'Ngày cấp phát',tenNguoiLap AS 'Người lập',ghiChu AS 'Ghi chú'" +
                   " FROM dbo.PhieuCapPhatVatTu JOIN dbo.Phong ON Phong.PhongId = PhieuCapPhatVatTu.PhongId" +
                   " JOIN dbo.NhanVien ON NhanVien.NhanVienID = PhieuCapPhatVatTu.NhanVienId " +
                    "JOIN dbo.NguoiDung ON NguoiDung.NguoiDungId = PhieuCapPhatVatTu.NguoiDungId";
               // string query = "SELECT PhieuCapPhatVatTuId,tenPhong,tenNhanVien,ngayCapPhat,tenDangNhap,tenNguoiLap,ghiChu " +
                  //  "FROM dbo.PhieuCapPhatVatTu,dbo.Phong,dbo.NhanVien,dbo.NguoiDung " +
                  //  "WHERE NguoiDung.NguoiDungId = PhieuCapPhatVatTu.NguoiDungId AND NhanVien.NhanVienID = PhieuCapPhatVatTu.NhanVienId AND Phong.PhongId = PhieuCapPhatVatTu.PhongId ";
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

        public DataTable TimKiemNgay(string date)
        {
            try
            {
                string query = "SELECT PhieuCapPhatVatTuId, PhieuCapPhatVatTu.PhongId,PhieuCapPhatVatTu.NhanVienId,PhieuCapPhatVatTu.NguoiDungId,tenPhong AS 'Phòng',tenNhanVien AS 'Nhân viên',tenDangNhap AS 'User',ngayCapPhat 'Ngày cấp phát',tenNguoiLap AS 'Người lập',ghiChu AS 'Ghi chú'" +
                   " FROM dbo.PhieuCapPhatVatTu JOIN dbo.Phong ON Phong.PhongId = PhieuCapPhatVatTu.PhongId" +
                   " JOIN dbo.NhanVien ON NhanVien.NhanVienID = PhieuCapPhatVatTu.NhanVienId " +
                    "JOIN dbo.NguoiDung ON NguoiDung.NguoiDungId = PhieuCapPhatVatTu.NguoiDungId WHERE ngayCapPhat = '"+ date +"'";
                // string query = "SELECT PhieuCapPhatVatTuId,tenPhong,tenNhanVien,ngayCapPhat,tenDangNhap,tenNguoiLap,ghiChu " +
                //  "FROM dbo.PhieuCapPhatVatTu,dbo.Phong,dbo.NhanVien,dbo.NguoiDung " +
                //  "WHERE NguoiDung.NguoiDungId = PhieuCapPhatVatTu.NguoiDungId AND NhanVien.NhanVienID = PhieuCapPhatVatTu.NhanVienId AND Phong.PhongId = PhieuCapPhatVatTu.PhongId ";
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

        public DataTable DataPhongNotIn()
        {
            try
            {
                string query = "SELECT PhongId FROM dbo.Phong WHERE  PhongId NOT IN (SELECT PhongId FROM dbo.PhieuCapPhatVatTu)";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(comboboxPhong);
                return comboboxPhong;
            }
            catch
            {
                return null;
            }
        }
        public DataTable DataTimKiem(string s)
        {
            try
            {
                string query = "SELECT PhieuCapPhatVatTuId,tenPhong FROM dbo.PhieuCapPhatVatTu full outer join dbo.Phong on Phong.PhongId = PhieuCapPhatVatTu.PhongId";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(comboboxPhong);
                return comboboxPhong;
            }
            catch
            {
                return null;
            }
        }
        public bool Insert(PhieuCapPhatVatTu phieuCapPhatVatTu)
        {
            try
            {
                string query = "SELECT * FROM PhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["PhongId"] = phieuCapPhatVatTu.PhongId1;
                row["NhanVienId"] = phieuCapPhatVatTu.NhanVienId;
                row["NguoiDungId"] = phieuCapPhatVatTu.NguoiDungId;
                row["ngayCapPhat"] = phieuCapPhatVatTu.NgayCapPhat;
                row["tenNguoiLap"] = phieuCapPhatVatTu.TenNguoiLap;
                row["ghiChu"] = phieuCapPhatVatTu.GhiChu;

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

        public bool Delete(int phieuCapPhatVatTuId)
        {
            try
            {
                string query = "SELECT * FROM PhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(phieuCapPhatVatTuId);

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

        public bool Update(PhieuCapPhatVatTu phieuCapPhatVatTu)
        {
            try
            {
                string query = "SELECT * FROM PhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(phieuCapPhatVatTu.PhieuCapPhatVatTuId);

                if (row != null)
                {
                    row["PhongId"] = phieuCapPhatVatTu.PhongId1;
                    row["NhanVienId"] = phieuCapPhatVatTu.NhanVienId;
                    row["NguoiDungId"] = phieuCapPhatVatTu.NguoiDungId;
                    row["ngayCapPhat"] = phieuCapPhatVatTu.NgayCapPhat;
                    row["tenNguoiLap"] = phieuCapPhatVatTu.TenNguoiLap;
                    row["ghiChu"] = phieuCapPhatVatTu.GhiChu;
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
        public int getPhieuID(string phongid, string ngay)
        {
            DataTable data = this.GetData();
            foreach (DataRow row in data.Rows)
            {
                if (phongid == row["PhongId"].ToString() && ngay == DateTime.Parse( row["ngayCapPhat"].ToString()).ToString("dd/MM/yyyy"))
                {
                    return int.Parse(row["PhieuCapPhatVatTuId"].ToString());
                }
            }
            return 0;
        }
        #endregion
    }
}
