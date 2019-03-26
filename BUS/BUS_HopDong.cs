using DAL;
using DTO;


namespace BUS
{
    public class BUS_HopDong
    {
        DAL_HopDong hopDong = new DAL_HopDong();
        public bool Insert(HopDong hopDong)
        {
            return this.hopDong.Insert(hopDong);
        }

        public bool Delete(int hopDongId)
        {
            return this.hopDong.Delete(hopDongId);
        }

        public bool Update(HopDong hopDong)
        {
            return this.hopDong.Update(hopDong);
        }

    }
}
