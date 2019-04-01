using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_DoiTuong
    {
        DAL_DoiTuong doiTuong = new DAL_DoiTuong();

        public DAL_DoiTuong DoiTuong { get => doiTuong; set => doiTuong = value; }

        public bool Insert(DoiTuong doiTuong)
        {
            return this.DoiTuong.Insert(doiTuong);
        }

        public bool Delete(int doiTuongId)
        {
            return this.DoiTuong.Delete(doiTuongId);
        }

        public bool Update(DoiTuong doiTuong)
        {
            return this.DoiTuong.Update(doiTuong);
        }

        public DataTable GetData()
        {
            return this.DoiTuong.GetData();
        }
        public DataTable GetFullInfo()
        {
            return this.DoiTuong.GetFullInfo();
        }
    }
}
