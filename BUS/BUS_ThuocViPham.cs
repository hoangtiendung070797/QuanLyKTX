using DAL;
using DTO;

namespace BUS
{
    public class BUS_ThuocViPham
    {
        DAL_ThuocViPham thuocViPham = new DAL_ThuocViPham();
        public bool Insert(ThuocViPham thuocViPham)
        {
            return this.thuocViPham.Insert(thuocViPham);
        }

        public bool Delete(int thuocViPhamId)
        {
            return this.thuocViPham.Delete(thuocViPhamId);
        }

        public bool Update(ThuocViPham thuocViPham)
        {
            return this.thuocViPham.Update(thuocViPham);
        }

    }
}
