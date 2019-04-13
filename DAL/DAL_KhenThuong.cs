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
                string query = "SELECT KhenThuong.KhenThuongId,DoiTuong.DoiTuongId,maSinhVien,hoDem,ten,KhenThuong.tenKhenThuong,noiDung,ngay,ghiChu FROM KhenThuong join ";
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
                row["noiDung "] = khenThuong.NoiDung;
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
                DataRow row = table.Rows.Find(khenThuong.DoiTuongId);

                if (row != null)
                {
                    row["DoiTuongId"] = khenThuong.DoiTuongId;
                    row["tenKhenThuong"] = khenThuong.TenKhenThuong;
                    row["noiDung "] = khenThuong.NoiDung;
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
        #endregion
    }
}
