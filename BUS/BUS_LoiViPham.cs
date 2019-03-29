using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_LoiViPham
    {
        DAL_LoiViPham loiViPham = new DAL_LoiViPham();
        public bool Insert(LoiViPham loiViPham)
        {
            return this.loiViPham.Insert(loiViPham);
        }

        public bool Delete(int loiViPhamId)
        {
            return this.loiViPham.Delete(loiViPhamId);
        }

        public bool Update(LoiViPham loiViPham)
        {
            return this.loiViPham.Update(loiViPham);
        }
        public DataTable GetData()
        {
            return this.loiViPham.GetData();
        }
    }
}
