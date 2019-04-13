using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Phong : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_Phong()
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
                string query = "SELECT * FROM Phong";
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
                string query = "SELECT PhongId AS 'Mã phòng',tenPhong AS 'Tên Phòng',tenDayNha AS 'Dãy nhà',tenLoaiPhong AS 'Loại Phòng',tang AS 'Tầng',giaPhong AS 'Giá phòng' " +
                    "FROM  dbo.DayNha join dbo.Phong join dbo.LoaiPhong  ON LoaiPhong.LoaiPhongId = Phong.LoaiPhongId ON LoaiPhong.LoaiPhongId = Phong.LoaiPhongId";
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
        public bool Insert(Phong phong)
        {
            try
            {
                string query = "SELECT * FROM Phong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["PhongId"] = phong.PhongId;
                row["DayNhaId"] = phong.DayNhaId;
                row["LoaiPhongId"] = phong.LoaiPhongId;
                row["tenPhong"] = phong.TenPhong;
                row["tang"] = phong.Tang;
                row["giaPhong"] = phong.GiaPhong;

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

        public bool Delete(string phongId)
        {
            try
            {
                string query = "SELECT * FROM Phong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phongId);

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

        public bool Update(Phong phong)
        {
            try
            {
                string query = "SELECT * FROM Phong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(phong.PhongId);

                if (row != null)
                {
                    row["PhongId"] = phong.PhongId;
                    row["DayNhaId"] = phong.DayNhaId;
                    row["LoaiPhongId"] = phong.LoaiPhongId;
                    row["tenPhong"] = phong.TenPhong;
                    row["tang"] = phong.Tang;
                    row["giaPhong"] = phong.GiaPhong;
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
        public DataTable GetEmptyRoom(bool check)
        {
            DataTable table = this.GetData();
            DataTable result = new DataTable();

            //Adding columns to datatable

            result.Columns.Add("PhongId", typeof(string));
            result.Columns.Add("DayNhaId", typeof(int));
            result.Columns.Add("LoaiPhongId", typeof(int));
            result.Columns.Add("tenPhong", typeof(string));
            result.Columns.Add("tang", typeof(int));
            result.Columns.Add("giaPhong", typeof(decimal));


            foreach (DataRow row in table.Rows)
            {
                if (check)
                {
                    if (!IsFullRoom(row["PhongId"].ToString()))
                    {
                        DataRow temp = result.NewRow();

                        temp["PhongId"] = row["PhongId"];
                        temp["DayNhaId"] = row["DayNhaId"];
                        temp["LoaiPhongId"] = row["LoaiPhongId"];
                        temp["tenPhong"] = row["tenPhong"];
                        temp["tang"] = row["tang"];
                        temp["giaPhong"] = row["giaPhong"];

                        result.Rows.Add(temp);
                    }
                }
                else
                {
                    if (IsFullRoom(row["PhongId"].ToString()))
                    {
                        DataRow temp = result.NewRow();

                        temp["PhongId"] = row["PhongId"];
                        temp["DayNhaId"] = row["DayNhaId"];
                        temp["LoaiPhongId"] = row["LoaiPhongId"];
                        temp["tenPhong"] = row["tenPhong"];
                        temp["tang"] = row["tang"];
                        temp["giaPhong"] = row["giaPhong"];

                        result.Rows.Add(temp);
                    }
                }

            }
            return result;
        }

        public bool IsFullRoom(string phongId)
        {
            try
            {
                DataTable table1 = new DataTable();
                DataTable table2 = new DataTable();
                string query1 = "SELECT COUNT(*) FROM dbo.LuuTruPhong WHERE PhongId = '" + phongId + "' and LuuTruPhong.trangThai = 1";
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(query1, connection);

                dataAdapter1.Fill(table1);
                int soLuongTrongPhong = (int)table1.Rows[0][0];

                string query2 = "select LoaiPhong.soLuongtoiDa from LoaiPhong join Phong on  LoaiPhong.LoaiPhongId = Phong.LoaiPhongId where Phong.PhongId = '" + phongId + "'";
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(query2, connection);

                dataAdapter2.Fill(table2);
                int soLuongToiDa = (int)table2.Rows[0][0];
                return (soLuongTrongPhong < soLuongToiDa) ? false : true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
