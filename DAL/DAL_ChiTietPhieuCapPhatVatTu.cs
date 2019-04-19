using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_ChiTietPhieuCapPhatVatTu : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();

        public object MessageBox { get; private set; }
        #endregion


        #region Initialize

        public DAL_ChiTietPhieuCapPhatVatTu()
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
                string query = "SELECT * FROM ChiTietPhieuCapPhatVatTu";
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

        public DataTable GetDataListView()
        {
            try
            {
                string query = "SELECT * FROM dbo.ChiTietPhieuCapPhatVatTu JOIN dbo.VatTu ON VatTu.VatTuId = ChiTietPhieuCapPhatVatTu.VatTuId";
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

        public int GetIndex(string PhieuCapPhatId)
        {
            try
            {
                string query = "SELECT * FROM dbo.ChiTietPhieuCapPhatVatTu JOIN dbo.VatTu ON VatTu.VatTuId = ChiTietPhieuCapPhatVatTu.VatTuId WHERE PhieuCapPhatVatTuId =" + PhieuCapPhatId;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table.Rows.Count;
            }
            catch
            {
                return 0;
            }
        }

        public bool Insert(ChiTietPhieuCapPhatVatTu chiTietPhieuCapPhatVatTu)
        {
            try
            {
                string query = "SELECT * FROM ChiTietPhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();

                DataRow row = table.NewRow();

                row["PhieuCapPhatVatTuId"] = chiTietPhieuCapPhatVatTu.PhieuCapPhatVatTuId;
                row["VatTuId"] = chiTietPhieuCapPhatVatTu.VatTuId;
                row["PhongId"] = chiTietPhieuCapPhatVatTu.PhongId1;
                row["soLuong"] = chiTietPhieuCapPhatVatTu.SoLuong;
                row["donViTinh"] = chiTietPhieuCapPhatVatTu.DonViTinh;
                row["tinhTrang"] = chiTietPhieuCapPhatVatTu.TinhTrang;
                row["donGiaVatTu"] = chiTietPhieuCapPhatVatTu.DonGiaVatTu;
         
                row["thanhTien"] = chiTietPhieuCapPhatVatTu.ThanhTien;
                row["ghiChu"] = chiTietPhieuCapPhatVatTu.GhiChu;

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

        public bool Delete(int ChiTietPhieuCapPhatVatTuId)
        {
            try
            {

                string query = "SELECT * FROM ChiTietPhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(ChiTietPhieuCapPhatVatTuId);

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



        public bool Update(ChiTietPhieuCapPhatVatTu chiTietPhieuCapPhatVatTu)
        {
            try
            {
                string query = "SELECT * FROM ChiTietPhieuCapPhatVatTu";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                table = GetData();
                table.PrimaryKey = new DataColumn[] { table.Columns[0] };
                DataRow row = table.Rows.Find(chiTietPhieuCapPhatVatTu.ChiTietPhieuCapPhatVatTuId);


                if (row != null)
                {
                    row["PhieuCapPhatVatTuId"] = chiTietPhieuCapPhatVatTu.PhieuCapPhatVatTuId;
                    row["VatTuId"] = chiTietPhieuCapPhatVatTu.VatTuId;
                    row["PhongId"] = chiTietPhieuCapPhatVatTu.PhongId1;
                    row["soLuong"] = chiTietPhieuCapPhatVatTu.SoLuong;
                    row["donViTinh"] = chiTietPhieuCapPhatVatTu.DonViTinh;
                    row["tinhTrang"] = chiTietPhieuCapPhatVatTu.TinhTrang;
                    row["donGiaVatTu"] = chiTietPhieuCapPhatVatTu.DonGiaVatTu;
            
                    row["thanhTien"] = chiTietPhieuCapPhatVatTu.ThanhTien;
                    row["ghiChu"] = chiTietPhieuCapPhatVatTu.GhiChu;
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

        public bool CheckVatTu(int phieuCapPhatId, string vatTuId)
        {
            DataTable data = this.GetData();
            foreach (DataRow row in data.Rows)
            {
                if ((int)row["PhieuCapPhatVatTuId"] == phieuCapPhatId && row["VatTuId"].ToString() == vatTuId)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetChiTietID(int phieuCapPhatId, string vatTuId)
        {
            DataTable data = this.GetData();
            foreach (DataRow row in data.Rows)
            {
                if ((int)row["PhieuCapPhatVatTuId"] == phieuCapPhatId && row["VatTuId"].ToString() == vatTuId)
                {
                    return int.Parse(row["ChiTietPhieuCapPhatVatTuId"].ToString());
                }
            }
            return 0;
        }

        public DataTable GetVatTuTheoPhong(string phongId, int dayNhaId)
        {
            try
            {
                string query = "select Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Tên Phòng', VatTu.tenVatTu as N'Tên vật tư', ChiTietPhieuCapPhatVatTu.soLuong as N'Số Lượng', ChiTietPhieuCapPhatVatTu.donViTinh as N'Đơn vị Tính', ChiTietPhieuCapPhatVatTu.donGiaVatTu as N'Đơn giá vật tư', ChiTietPhieuCapPhatVatTu.thanhTien as N'Thành tiền' FROM DayNha inner join Phong inner join ChiTietPhieuCapPhatVatTu inner join VatTu  on ChiTietPhieuCapPhatVatTu.VatTuId = VatTu.VatTuId on ChiTietPhieuCapPhatVatTu.PhongId = Phong.PhongId on Phong.DayNhaId = DayNha.DayNhaId WHERE Phong.DayNhaID = " + dayNhaId + " and ChiTietPhieuCapPhatVatTu.PhongId = '" + phongId + "'";
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
        public DataTable GetDataVatTuTheoPhong()
        {
            try
            {
                string query = "select Phong.tenPhong + N'-' + DayNha.tenDayNha as N'Tên Phòng', VatTu.tenVatTu as N'Tên vật tư', ChiTietPhieuCapPhatVatTu.soLuong as N'Số Lượng', ChiTietPhieuCapPhatVatTu.donViTinh as N'Đơn vị Tính', ChiTietPhieuCapPhatVatTu.donGiaVatTu as N'Đơn giá vật tư', ChiTietPhieuCapPhatVatTu.thanhTien as N'Thành tiền' FROM DayNha inner join Phong inner join ChiTietPhieuCapPhatVatTu inner join VatTu  on ChiTietPhieuCapPhatVatTu.VatTuId = VatTu.VatTuId on ChiTietPhieuCapPhatVatTu.PhongId = Phong.PhongId on Phong.DayNhaId = DayNha.DayNhaId";
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
