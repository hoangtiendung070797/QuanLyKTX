using DAL;
using DTO;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien nhanVien = new DAL_NhanVien();
        public bool Insert(NhanVien nhanVien)
        {
            return this.nhanVien.Insert(nhanVien);
        }

        public bool Delete(int nhanVienId)
        {
            return this.nhanVien.Delete(nhanVienId);
        }

        public bool Update(NhanVien nhanVien)
        {
            return this.nhanVien.Update(nhanVien);
        }
    }
}
