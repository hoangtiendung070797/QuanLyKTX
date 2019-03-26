using DAL;
using DTO;

namespace BUS
{
    public class BUS_LoaiDoiTuong
    {
        DAL_LoaiDoiTuong loaiDoiTuong = new DAL_LoaiDoiTuong();
        public bool Insert(LoaiDoiTuong loaiDoiTuong)
        {
            return this.loaiDoiTuong.Insert(loaiDoiTuong);
        }

        public bool Delete(int loaiDoiTuongId)
        {
            return this.loaiDoiTuong.Delete(loaiDoiTuongId);
        }

        public bool Update(LoaiDoiTuong loaiDoiTuong)
        {
            return this.loaiDoiTuong.Update(loaiDoiTuong);
        }

    }
}
