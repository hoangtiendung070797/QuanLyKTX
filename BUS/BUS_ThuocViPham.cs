using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_ThuocViPham
    {
        private DAL_ThuocViPham thuocViPham = new DAL_ThuocViPham();

        public DAL_ThuocViPham ThuocViPham { get => thuocViPham; set => thuocViPham = value; }

        public bool Insert(ThuocViPham thuocViPham)
        {
            return this.ThuocViPham.Insert(thuocViPham);
        }

        public bool Delete(int thuocViPhamId)
        {
            return this.ThuocViPham.Delete(thuocViPhamId);
        }

        public bool Update(ThuocViPham thuocViPham)
        {
            return this.ThuocViPham.Update(thuocViPham);
        }
        public DataTable GetData()
        {
            return this.ThuocViPham.GetData();
        }

    }
}
