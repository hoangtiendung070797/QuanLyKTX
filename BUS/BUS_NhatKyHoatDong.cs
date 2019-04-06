using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_NhatKyHoatDong
    {
        DAL_NhatKyHoatDong nhatKyHoatDong = new DAL_NhatKyHoatDong();

        public DAL_NhatKyHoatDong NhatKyHoatDong { get => nhatKyHoatDong; set => nhatKyHoatDong = value; }

        public bool Insert(NhatKyHoatDong nhatKyHoatDong)
        {
            return this.NhatKyHoatDong.Insert(nhatKyHoatDong);
        }

        public bool Delete(int nhatKyHoatDongId)
        {
            return this.NhatKyHoatDong.Delete(nhatKyHoatDongId);
        }

        public bool Update(NhatKyHoatDong nhatKyHoatDong)
        {
            return this.NhatKyHoatDong.Update(nhatKyHoatDong);
        }
        public DataTable GetData()
        {
            return this.NhatKyHoatDong.GetData();
        }
    }
}
