﻿using DTO;
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
        public DataTable PrintInfor()  // //thay đổi 
        {
            try
            {
                string query = "SELECT Phong.PhongId,tenPhong,DayNha.tenDayNha,LoaiPhong.tenLoaiPhong,Phong.tang,giaPhong,case thuocGioiTinh when 1 then N'Nam' when 0 then N'Nữ' end as 'thuocGioiTinh' FROM LoaiPhong join Phong join DayNha on DayNha.DayNhaId=Phong.DayNhaId on Phong.LoaiPhongId = LoaiPhong.LoaiPhongId";
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

        public DataTable GetDataNew()////////////
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
                row["thuocGioiTinh"] = phong.ThuocGioiTinh;

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
                    row["thuocGioiTinh"] = phong.ThuocGioiTinh;
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
        public DataTable GetEmptyRoom(bool check) //thay đổi 
        {
            DataTable table = this.PrintInfor();
            DataTable result = new DataTable();
            // Phong.PhongId,tenPhong,DayNha.tenDayNha,LoaiPhong.tenLoaiPhong,Phong.tang,giaPhong,case thuocGioiTinh when 1 then N'Nam' when 0 then N'N
            //Adding columns to datatable

            result.Columns.Add("PhongId", typeof(string));
            result.Columns.Add("tenPhong", typeof(string));
            result.Columns.Add("tenDayNha", typeof(string));
            result.Columns.Add("tenLoaiPhong", typeof(string));
            result.Columns.Add("tang", typeof(int));
            result.Columns.Add("giaPhong", typeof(decimal));
            result.Columns.Add("thuocGioiTinh", typeof(string));

            foreach (DataRow row in table.Rows)
            {
                if (check)
                {
                    if (!IsFullRoom(row["PhongId"].ToString()))
                    {
                        DataRow temp = result.NewRow();

                        temp["PhongId"] = row["PhongId"];
                        temp["tenPhong"] = row["tenPhong"];
                        temp["tenDayNha"] = row["tenDayNha"];
                        temp["tenLoaiPhong"] = row["tenLoaiPhong"];
                        temp["tang"] = row["tang"];
                        temp["giaPhong"] = row["giaPhong"];
                        temp["thuocGioiTinh"] = row["thuocGioiTinh"];
                        result.Rows.Add(temp);
                    }
                }
                else
                {
                    if (IsFullRoom(row["PhongId"].ToString()))
                    {
                        DataRow temp = result.NewRow();

                        temp["PhongId"] = row["PhongId"];
                        temp["tenPhong"] = row["tenPhong"];
                        temp["tenDayNha"] = row["tenDayNha"];
                        temp["tenLoaiPhong"] = row["tenLoaiPhong"];
                        temp["tang"] = row["tang"];
                        temp["giaPhong"] = row["giaPhong"];
                        temp["thuocGioiTinh"] = row["thuocGioiTinh"];
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
        public DataTable GetSinhVienTheoPhong(string phongId, int dayNhaId)
        {
            try
            {
                string query = "Select DoiTuong.hoDem + N' '+ DoiTuong.ten as N'Họ và tên',DoiTuong.maSinhVien as N'Mã sinh viên', DoiTuong.ngaySinh AS N'Ngày sinh', Case when  DoiTuong.gioiTinh = 1 then N'Nam' when DoiTuong.gioiTinh = 0 then N'Nữ' end as N'Giới tính', Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Tên Phòng', LoaiPhong.tenLoaiPhong as N'Loại Phòng', LoaiPhong.soLuongtoiDa as N'Số lượng tối đa' FROM LoaiPhong inner join DayNha inner join Phong inner join LuuTruPhong inner join DoiTuong on DoiTuong.DoiTuongId = LuuTruPhong.DoiTuongId on Phong.PhongId = LuuTruPhong.PhongId on Phong.DayNhaId = DayNha.DayNhaId on Phong.LoaiPhongId = LoaiPhong.LoaiPhongId WHERE Phong.DayNhaID = " + dayNhaId + " and Phong.PhongId = '" + phongId + "'";
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
        public DataTable GetDataSinhVienTheoPhong()
        {
            try
            {
                string query = "Select DoiTuong.hoDem + N' '+ DoiTuong.ten as N'Họ và tên',DoiTuong.maSinhVien as N'Mã sinh viên', DoiTuong.ngaySinh AS N'Ngày sinh', Case when  DoiTuong.gioiTinh = 1 then N'Nam' when DoiTuong.gioiTinh = 0 then N'Nữ' end as N'Giới tính', Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Tên Phòng', LoaiPhong.tenLoaiPhong as N'Loại Phòng', LoaiPhong.soLuongtoiDa as N'Số lượng tối đa' FROM LoaiPhong inner join DayNha inner join Phong inner join LuuTruPhong inner join DoiTuong on DoiTuong.DoiTuongId = LuuTruPhong.DoiTuongId on Phong.PhongId = LuuTruPhong.PhongId on Phong.DayNhaId = DayNha.DayNhaId on Phong.LoaiPhongId = LoaiPhong.LoaiPhongId";
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
