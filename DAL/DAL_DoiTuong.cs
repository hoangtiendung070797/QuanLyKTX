using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_DoiTuong : DbConnect
    {
        #region Properties
        DataTable table = new DataTable();
        #endregion


        #region Initialize

        public DAL_DoiTuong()
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
                string query = "SELECT * FROM DoiTuong";
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


        public bool Insert(DoiTuong doiTuong)
        {
            try
            {
                string query = "SELECT * FROM DoiTuong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                table = GetData();
                DataRow row = table.NewRow();
                row["LoaiDoiTuongId"] = doiTuong.LoaiDoiTuongId;
                row["QuocTichId"] = doiTuong.QuocTichId;
                row["TinhThanhId"] = doiTuong.TinhThanhId;
                row["LopId"] = doiTuong.LopId;
                row["DanTocId"] = doiTuong.DanTocId;
                row["TonGiaoId"] = doiTuong.TonGiaoId;
                row["maSinhVien"] = doiTuong.MaSinhVien;
                row["hoDem"] = doiTuong.HoDem;
                row["ten"] = doiTuong.Ten;
                row["ngaySinh"] = doiTuong.NgaySinh;
                row["noiSinh"] = doiTuong.NoiSinh;
                row["gioiTinh"] = doiTuong.GioiTinh;
                row["hoKhau"] = doiTuong.HoKhau;
                row["queQuan"] = doiTuong.QueQuan;
                row["sdt"] = doiTuong.Sdt;
                row["email"] = doiTuong.Email;
                row["ghiChu"] = doiTuong.GhiChu;
                row["anh"] = doiTuong.Image;
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

        public bool Delete(int DoiTuongId)
        {
            try
            {
                string query = "SELECT * FROM DoiTuong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(DoiTuongId);

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

        public bool Update(DoiTuong doiTuong)
        {
            try
            {
                string query = "SELECT * FROM DoiTuong";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataRow row = table.Rows.Find(doiTuong.DoiTuongId);

                if (row != null)
                {
                    row["LoaiDoiTuongId"] = doiTuong.LoaiDoiTuongId;
                    row["QuocTichId"] = doiTuong.QuocTichId;
                    row["TinhThanhId"] = doiTuong.TinhThanhId;
                    row["LopId"] = doiTuong.LopId;
                    row["DanTocId"] = doiTuong.DanTocId;
                    row["TonGiaoId"] = doiTuong.TonGiaoId;
                    row["maSinhVien"] = doiTuong.MaSinhVien;
                    row["hoDem"] = doiTuong.HoDem;
                    row["ten"] = doiTuong.Ten;
                    row["ngaySinh"] = doiTuong.NgaySinh;
                    row["noiSinh"] = doiTuong.NoiSinh;
                    row["gioiTinh"] = doiTuong.GioiTinh;
                    row["hoKhau"] = doiTuong.HoKhau;
                    row["queQuan"] = doiTuong.QueQuan;
                    row["sdt"] = doiTuong.Sdt;
                    row["email"] = doiTuong.Email;
                    row["ghiChu"] = doiTuong.GhiChu;
                    row["anh"] = doiTuong.Image;
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





        //public DataRow GetDataById(int temp)
        //{
        //    try
        //    {
        //        DataTable data = new DataTable();
        //        data = GetFullInfo();

        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}


        /// <summary>
        /// In ra cho đẹp
        /// </summary>
        /// <returns></returns>
        public DataTable GetFullInfo()
        {
            try
            {
                string query = "SELECT t.DoiTuongId AS N'Mã Hồ Sơ',t.anh AS N'Ảnh',t.tenLoaiDoiTuong AS N'Loại Đối Tượng',t.hoDem AS N'Họ',t.ten AS N'Tên',t.ngaySinh AS N'Ngày Sinh',x.tenQuocTich AS N'Quốc Tịch',q.tenDanToc AS N'Dân Tộc',q.tenTonGiao AS N'Tôn Giáo', x.tenTinhThanh AS N'Thuộc Tỉnh Thành',t.noiSinh AS N'Nơi Sinh', t.queQuan AS N'Quê Quán',t.hoKhau AS N'Nơi thường trú',t.sdt AS N'Tel',t.email AS N'Email',t.ghiChu AS N'Ghi chú' FROM ((SELECT  dbo.DonVi.tenDonVi,dbo.Lop.tenLop, dbo.LoaiDoiTuong.tenLoaiDoiTuong ,dbo.DoiTuong.* FROM dbo.DonVi INNER JOIN dbo.Lop INNER JOIN dbo.DoiTuong INNER JOIN dbo.LoaiDoiTuong ON LoaiDoiTuong.LoaiDoiTuongId = DoiTuong.LoaiDoiTuongId ON DoiTuong.LopId = Lop.LopId ON Lop.DonViId = DonVi.DonViId) t INNER JOIN(SELECT dbo.QuocTich.tenQuocTich, dbo.TinhThanh.tenTinhThanh, dbo.DoiTuong.DoiTuongId FROM dbo.QuocTich INNER JOIN dbo.DoiTuong FULL OUTER JOIN dbo.TinhThanh ON TinhThanh.TinhThanhId = DoiTuong.TinhThanhId ON DoiTuong.QuocTichId = QuocTich.QuocTichId) x INNER JOIN(SELECT dbo.DanToc.tenDanToc, dbo.TonGiao.tenTonGiao, dbo.DoiTuong.DoiTuongId FROM dbo.DanToc FULL OUTER JOIN dbo.DoiTuong FULL OUTER JOIN dbo.TonGiao ON TonGiao.TonGiaoId = DoiTuong.TonGiaoId ON DoiTuong.DanTocId = DanToc.DanTocId) q ON q.DoiTuongId = x.DoiTuongId ON x.DoiTuongId = t.DoiTuongId )";
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

        /// <summary>
        /// Lấy ra đối tượng có id truyền vào.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataRow GetById(int id)
        {
            return table.Rows.Find(id);
        }



        #endregion
    }
}
