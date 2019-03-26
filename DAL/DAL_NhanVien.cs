using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_NhanVien : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_NhanVien()
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
                string query = "SELECT * FROM NhanVien";
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


        public bool Insert(NhanVien nhanVien)
        {
            try
            {
                string query = "SELECT * FROM NhanVien";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["tenNhanVien"] = nhanVien.TenNhanVien;
                row["sdt"] = nhanVien.Sdt;
                row["email"] = nhanVien.Email;
                row["ngaySinh"] = nhanVien.NgaySinh;
                row["chucVu"] = nhanVien.ChucVu;
                row["diaChi"] = nhanVien.DiaChi;
                row["phuTrach"] = nhanVien.PhuTrach;

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

        public bool Delete(int nhanVienId)
        {
            try
            {
                string query = "SELECT * FROM NhanVien";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(nhanVienId);

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

        public bool Update(NhanVien nhanVien)
        {
            try
            {
                string query = "SELECT * FROM NhanVien";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(nhanVien.NhanVienId);

                if (row != null)
                {
                    row["tenNhanVien"] = nhanVien.TenNhanVien;
                    row["sdt"] = nhanVien.Sdt;
                    row["email"] = nhanVien.Email;
                    row["ngaySinh"] = nhanVien.NgaySinh;
                    row["chucVu"] = nhanVien.ChucVu;
                    row["diaChi"] = nhanVien.DiaChi;
                    row["phuTrach"] = nhanVien.PhuTrach;
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
