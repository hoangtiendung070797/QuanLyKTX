using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_LuuTruPhong : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_LuuTruPhong()
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
                string query = "SELECT * FROM LuuTruPhong";
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

        public DataTable DoiTuong_TrongPhong(string phongId)
        {
            try
            {
                string query = "SELECT DoiTuong.anh,DoiTuong.DoiTuongId,maSinhVien,hoDem,ten,ngaySinh,noiSinh,gioiTinh,hoKhau,queQuan,sdt,email,ghiChu,LuuTruPhong.ngayXep,ngayRoi,trangThai,LuuTruPhong.LuuTruPhongId,NguoiDungId,NhanVienId,PhongId from LuuTruPhong join DoiTuong on DoiTuong.DoiTuongId = LuuTruPhong.DoiTuongId  where LuuTruPhong.PhongId = '" + phongId + "' and LuuTruPhong.trangThai = 1";
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


        public DataTable DoiTuong_ChuaCoPhong_GioiTinh(string gioitinh)     //thay đổi => BUS
        {
            try
            {
                string query = "select t.anh,t.DoiTuongId,t.maSinhVien,t.hoDem,t.ten,t.ngaySinh,t.noiSinh,t.gioiTinh,t.hoKhau,t.queQuan,t.sdt,t.email,t.ghiChu from DoiTuong  as t where  t.gioiTinh = 'true' and (t.DoiTuongId not in (select LuuTruPhong.DoiTuongId from LuuTruPhong) or  (select COUNT(*) from LuuTruPhong where LuuTruPhong.trangThai = 1 and  LuuTruPhong.DoiTuongId = t.DoiTuongId) = 0)";
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

        public bool Insert(LuuTruPhong luuTruPhong)
        {
            try
            {
                string query = "SELECT * FROM LuuTruPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["NhanVienId"] = luuTruPhong.NhanVienId;
                row["NguoiDungId"] = luuTruPhong.NguoiDungId;
                row["PhongId"] = luuTruPhong.PhongId;
                row["DoiTuongId"] = luuTruPhong.DoiTuongId;
                row["ngayXep"] = luuTruPhong.NgayXep;
                row["ngayRoi"] = luuTruPhong.NgayRoi;
                row["trangThai"] = luuTruPhong.TrangThai;

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

        public bool Delete(int luuTruPhongId)
        {
            try
            {
                string query = "SELECT * FROM LuuTruPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(luuTruPhongId);

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

        public bool Update(LuuTruPhong luuTruPhong)
        {
            try
            {
                string query = "SELECT * FROM LuuTruPhong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(luuTruPhong.LuuTruPhongId);

                if (row != null)
                {
                    row["NhanVienId"] = luuTruPhong.NhanVienId;
                    row["NguoiDungId"] = luuTruPhong.NguoiDungId;
                    row["PhongId"] = luuTruPhong.PhongId;
                    row["DoiTuongId"] = luuTruPhong.DoiTuongId;
                    row["ngayXep"] = luuTruPhong.NgayXep;
                    row["ngayRoi"] = luuTruPhong.NgayRoi;
                    row["trangThai"] = luuTruPhong.TrangThai;
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
