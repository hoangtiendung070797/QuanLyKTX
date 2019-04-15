using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ChiTietPhieuBaoHongVatTu : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_ChiTietPhieuBaoHongVatTu()
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
                string query = "SELECT * FROM ChiTietPhieuBaoHongVatTu";
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


        public bool Insert(ChiTietPhieuBaoHongVatTu chiTietPhieuBaoHongVatTu)
        {
            try
            {
                string query = "SELECT * FROM ChiTietPhieuBaoHongVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["PhieuBaoHongVatTuId"] = chiTietPhieuBaoHongVatTu.PhieuBaoHongVatTuId;
                row["VatTuId"] = chiTietPhieuBaoHongVatTu.VatTuId;
                row["PhongId"] = chiTietPhieuBaoHongVatTu.PhongId;
                row["soLuong"] = chiTietPhieuBaoHongVatTu.SoLuong;
                row["donViTinh"] = chiTietPhieuBaoHongVatTu.DonViTinh;
                row["lyDo"] = chiTietPhieuBaoHongVatTu.LyDo;
                row["yeuCau"] = chiTietPhieuBaoHongVatTu.YeuCau;
                row["ghiChu"] = chiTietPhieuBaoHongVatTu.GhiChu;
 
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

        public bool Delete(int ChiTietPhieuBaoHongVatTuId)
        {
            try
            {
                string query = "SELECT * FROM ChiTietPhieuBaoHongVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(ChiTietPhieuBaoHongVatTuId);

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

        public bool Update(ChiTietPhieuBaoHongVatTu chiTietPhieuBaoHongVatTu)
        {
            try
            {
                string query = "SELECT * FROM ChiTietPhieuBaoHongVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(chiTietPhieuBaoHongVatTu.ChiTietPhieuBaoHongVatTuId);

                if (row != null)
                {
                    row["PhieuBaoHongVatTuId"] = chiTietPhieuBaoHongVatTu.PhieuBaoHongVatTuId;
                    row["VatTuId"] = chiTietPhieuBaoHongVatTu.VatTuId;
                    row["PhongId"] = chiTietPhieuBaoHongVatTu.PhongId;
                    row["soLuong"] = chiTietPhieuBaoHongVatTu.SoLuong;
                    row["donViTinh"] = chiTietPhieuBaoHongVatTu.DonViTinh;
                    row["lyDo"] = chiTietPhieuBaoHongVatTu.LyDo;
                    row["yeuCau"] = chiTietPhieuBaoHongVatTu.YeuCau;
                    row["ghiChu"] = chiTietPhieuBaoHongVatTu.GhiChu;
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
        public DataTable GetVatTuHongTheoPhong(string phongId, int dayNhaId)
        {
            try
            {
                string query = "select Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Tên Phòng', VatTu.tenVatTu as N'Tên vật tư', ChiTietPhieuBaoHongVatTu.soLuong as N'Số Lượng', ChiTietPhieuBaoHongVatTu.donViTinh as N'Đơn vị Tính', ChiTietPhieuBaoHongVatTu.lyDo as N'Lý do', ChiTietPhieuBaoHongVatTu.yeuCau as N'Yêu Cầu' FROM VatTu inner join ChiTietPhieuBaoHongVatTu inner join Phong inner join DayNha on DayNha.DayNhaId = Phong.DayNhaId on phong.PhongId = ChiTietPhieuBaoHongVatTu.PhongId on ChiTietPhieuBaoHongVatTu.VatTuId = VatTu.VatTuId WHERE Phong.DayNhaID = " + dayNhaId + " and ChiTietPhieuBaoHongVatTu.PhongId = '" + phongId + "'";
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
        public DataTable GetDataVatTuHongTheoPhong()
        {
            try
            {
                string query = "select Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Tên Phòng', VatTu.tenVatTu as N'Tên vật tư', ChiTietPhieuBaoHongVatTu.soLuong as N'Số Lượng', ChiTietPhieuBaoHongVatTu.donViTinh as N'Đơn vị Tính', ChiTietPhieuBaoHongVatTu.lyDo as N'Lý do', ChiTietPhieuBaoHongVatTu.yeuCau as N'Yêu Cầu' FROM VatTu inner join ChiTietPhieuBaoHongVatTu inner join Phong inner join DayNha on DayNha.DayNhaId = Phong.DayNhaId on phong.PhongId = ChiTietPhieuBaoHongVatTu.PhongId on ChiTietPhieuBaoHongVatTu.VatTuId = VatTu.VatTuId";
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
