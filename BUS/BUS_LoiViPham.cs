using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_LoiViPham
    {
        DAL_LoiViPham loiViPham = new DAL_LoiViPham();

        public DAL_LoiViPham LoiViPham { get => loiViPham; set => loiViPham = value; }

        public bool Insert(LoiViPham loiViPham)
        {
            return this.LoiViPham.Insert(loiViPham);
        }

        public bool Delete(int loiViPhamId)
        {
            return this.LoiViPham.Delete(loiViPhamId);
        }

        public bool Update(LoiViPham loiViPham)
        {
            return this.LoiViPham.Update(loiViPham);
        }
        public DataTable GetData()
        {
            return this.LoiViPham.GetData();
        }
    }
}
