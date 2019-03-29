using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_LoaiPhong
    {
        DAL_LoaiPhong LoaiPhong = new DAL_LoaiPhong();
        public bool Insert(LoaiPhong loaiPhong)
        {
            return this.LoaiPhong.Insert(loaiPhong);
        }

        public bool Delete(int loaiPhongId)
        {
            return this.LoaiPhong.Delete(loaiPhongId);
        }

        public bool Update(LoaiPhong loaiPhong)
        {
            return this.LoaiPhong.Update(loaiPhong);
        }
        public DataTable GetData()
        {
            return this.LoaiPhong.GetData();
        }
    }
}
