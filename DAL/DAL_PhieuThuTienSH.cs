using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_PhieuThuTienSH : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_PhieuThuTienSH()
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
                string query = "SELECT * FROM PhieuThuTienSH";
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


        public bool Insert(PhieuThuTienSH phieuThuTienSH)
        {
            try
            {
                string query = "SELECT * FROM PhieuThuTienSH";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["PhongId"] = phieuThuTienSH.PhongId1;
                row["NhanVienId"] = phieuThuTienSH.NhanVienId1;
                row["NguoiDungId"] = phieuThuTienSH.NguoiDungId1;
                row["ngayThu"] = phieuThuTienSH.NgayThu;
                row["soDienDau"] = phieuThuTienSH.SoDienDau;
                row["soDienCuoi"] = phieuThuTienSH.SoDienCuoi;
                row["soNuocDau"] = phieuThuTienSH.SoNuocDau;
                row["soNuocCuoi"] = phieuThuTienSH.SoNuocCuoi;
                row["soDienThuc"] = phieuThuTienSH.SoDienThuc;
                row["soNuocThuc"] = phieuThuTienSH.SoNuocThuc;
                row["donGiaDien"] = phieuThuTienSH.DonGiaDien;
                row["donGiaNuoc"] = phieuThuTienSH.DonGiaNuoc;
                row["tienThuDien"] = phieuThuTienSH.TienThuDien;
                row["tienThuNuoc"] = phieuThuTienSH.TienThuNuoc;
                row["phiDichVu"] = phieuThuTienSH.PhiDichVu;
                row["tong"] = phieuThuTienSH.Tong;
                row["tenNguoiThu"] = phieuThuTienSH.TenNguoiThu;
                row["ghiChu"] = phieuThuTienSH.GhiChu;

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

        public bool Delete(int phieuThuTienSHId)
        {
            try
            {
                string query = "SELECT * FROM PhieuThuTienSH";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phieuThuTienSHId);

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

        public bool Update(PhieuThuTienSH phieuThuTienSH)
        {
            try
            {
                string query = "SELECT * FROM PhieuThuTienSH";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phieuThuTienSH.PhieuThuTienSHId);

                if (row != null)
                {
                    row["PhongId"] = phieuThuTienSH.PhongId1;
                    row["NhanVienId"] = phieuThuTienSH.NhanVienId1;
                    row["NguoiDungId"] = phieuThuTienSH.NguoiDungId1;
                    row["ngayThu"] = phieuThuTienSH.NgayThu;
                    row["soDienDau"] = phieuThuTienSH.SoDienDau;
                    row["soDienCuoi"] = phieuThuTienSH.SoDienCuoi;
                    row["soNuocDau"] = phieuThuTienSH.SoNuocDau;
                    row["soNuocCuoi"] = phieuThuTienSH.SoNuocCuoi;
                    row["soDienThuc"] = phieuThuTienSH.SoDienThuc;
                    row["soNuocThuc"] = phieuThuTienSH.SoNuocThuc;
                    row["donGiaDien"] = phieuThuTienSH.DonGiaDien;
                    row["donGiaNuoc"] = phieuThuTienSH.DonGiaNuoc;
                    row["tienThuDien"] = phieuThuTienSH.TienThuDien;
                    row["tienThuNuoc"] = phieuThuTienSH.TienThuNuoc;
                    row["phiDichVu"] = phieuThuTienSH.PhiDichVu;
                    row["tong"] = phieuThuTienSH.Tong;
                    row["tenNguoiThu"] = phieuThuTienSH.TenNguoiThu;
                    row["ghiChu"] = phieuThuTienSH.GhiChu;
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

        public DataTable GetPhongTheoPhieuThuTienSH(string phongId, int dayNhaId)
        {
            try
            {
                string query = "select Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Tên Phòng', PhieuThuTienSH.soDienCuoi - PhieuThuTienSH.soDienDau as N'Số Điện', PhieuThuTienSH.soNuocCuoi - PhieuThuTienSH.soNuocDau as N'Số Nước',PhieuThuTienSH.donGiaDien as N'Đơn giá điện', PhieuThuTienSH.donGiaNuoc as N'Đơn giá nước', PhieuThuTienSH.phiDichVu as N'Tiền dịch vụ', PhieuThuTienSH.tong as N'Tổng tiền', PhieuThuTienSH.ngayThu as N'Ngày thu' from PhieuThuTienSH inner join Phong inner join DayNha on DayNha.DayNhaId = Phong.DayNhaId on Phong.PhongId = PhieuThuTienSH.PhongId WHERE Phong.DayNhaID = " + dayNhaId + " and PhieuThuTienSH.PhongId = '" + phongId + "'";
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
        public DataTable GetDataPhieuThuTienSH()
        {
            try
            {
                string query = "select Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Tên Phòng', PhieuThuTienSH.soDienCuoi - PhieuThuTienSH.soDienDau as N'Số Điện', PhieuThuTienSH.soNuocCuoi - PhieuThuTienSH.soNuocDau as N'Số Nước',PhieuThuTienSH.donGiaDien as N'Đơn giá điện', PhieuThuTienSH.donGiaNuoc as N'Đơn giá nước', PhieuThuTienSH.phiDichVu as N'Tiền dịch vụ', PhieuThuTienSH.tong as N'Tổng tiền', PhieuThuTienSH.ngayThu as N'Ngày thu' from PhieuThuTienSH inner join Phong inner join DayNha on DayNha.DayNhaId = Phong.DayNhaId on Phong.PhongId = PhieuThuTienSH.PhongId";
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
