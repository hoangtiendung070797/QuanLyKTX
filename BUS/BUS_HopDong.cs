using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_HopDong
    {
        DAL_HopDong hopDong = new DAL_HopDong();

        public DAL_HopDong HopDong { get => hopDong; set => hopDong = value; }

        public bool Insert(HopDong hopDong)
        {
            return this.HopDong.Insert(hopDong);
        }

        public bool Delete(int hopDongId)
        {
            return this.HopDong.Delete(hopDongId);
        }

        public bool Update(HopDong hopDong)
        {
            return this.HopDong.Update(hopDong);
        }

        public DataTable GetData()
        {
            return this.HopDong.GetData();
        }
    }
}
