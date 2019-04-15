using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_KyLuat : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_KyLuat()
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
                string query = "SELECT KyLuat.KyLuatId,DoiTuong.DoiTuongId,maSinhVien,hoDem,ten,KyLuat.tenKyLuat,noiDung,ngay,KyLuat.ghiChu FROM KyLuat join DoiTuong on DoiTuong.DoiTuongId=KyLuat.DoiTuongId";
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


        public bool Insert(KyLuat kyLuat)
        {
            try
            {
                string query = "SELECT * FROM KyLuat";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["DoiTuongId"] = kyLuat.DoiTuongId;
                row["tenKyLuat"] = kyLuat.TenKyLuat;
                row["noiDung"] = kyLuat.NoiDung;
                row["ngay"] = kyLuat.Ngay;
                row["ghiChu"] = kyLuat.GhiChu;

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

        public bool Delete(int kyLuatId)
        {
            try
            {
                string query = "SELECT * FROM KyLuat";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(kyLuatId);

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

        public bool Update(KyLuat kyLuat)
        {
            try
            {
                string query = "SELECT * FROM KyLuat";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(kyLuat.KyLuatId);

                if (row != null)
                {
                    row["DoiTuongId"] = kyLuat.DoiTuongId;
                    row["tenKyLuat"] = kyLuat.TenKyLuat;
                    row["noiDung"] = kyLuat.NoiDung;
                    row["ngay"] = kyLuat.Ngay;
                    row["ghiChu"] = kyLuat.GhiChu;
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
        public DataTable GetSinhVienTheoKyLuat()
        {
            try
            {
                string query = "Select DoiTuong.hoDem + N' '+ DoiTuong.ten as N'Họ và tên',DoiTuong.maSinhVien as N'Mã sinh viên', DoiTuong.ngaySinh AS N'Ngày sinh', Case when  DoiTuong.gioiTinh = 1 then N'Nam' when DoiTuong.gioiTinh = 0 then N'Nữ' end as N'Giới tính', KyLuat.tenKyLuat as N'Tên kỷ luật', KyLuat.noiDung as N'Nội dung kỷ luật', KyLuat.ngay as N'Ngày kỷ luật', ThuocViPham.lanTaiPham as N'Lần tái phạm'  From ThuocViPham inner join KyLuat inner join DoiTuong on DoiTuong.DoiTuongId = KyLuat.DoiTuongId on KyLuat.KyLuatId = ThuocViPham.KyLuatId";
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
