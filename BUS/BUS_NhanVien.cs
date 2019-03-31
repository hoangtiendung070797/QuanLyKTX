using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien nhanVien = new DAL_NhanVien();

        public DAL_NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }

        public bool Insert(NhanVien nhanVien)
        {
            return this.NhanVien.Insert(nhanVien);
        }

        public bool Delete(int nhanVienId)
        {
            return this.NhanVien.Delete(nhanVienId);
        }

        public bool Update(NhanVien nhanVien)
        {
            return this.NhanVien.Update(nhanVien);
        }
        public DataTable GetData()
        {
            return this.NhanVien.GetData();
        }
    }
}
