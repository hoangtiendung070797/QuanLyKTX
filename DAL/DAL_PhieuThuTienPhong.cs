using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
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
        #endregion
    }
}
