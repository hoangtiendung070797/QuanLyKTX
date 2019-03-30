using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_LoaiDoiTuong
    {
        DAL_LoaiDoiTuong loaiDoiTuong = new DAL_LoaiDoiTuong();

        public DAL_LoaiDoiTuong LoaiDoiTuong { get => loaiDoiTuong; set => loaiDoiTuong = value; }

        public bool Insert(LoaiDoiTuong loaiDoiTuong)
        {
            return this.LoaiDoiTuong.Insert(loaiDoiTuong);
        }

        public bool Delete(int loaiDoiTuongId)
        {
            return this.LoaiDoiTuong.Delete(loaiDoiTuongId);
        }

        public bool Update(LoaiDoiTuong loaiDoiTuong)
        {
            return this.LoaiDoiTuong.Update(loaiDoiTuong);
        }

        public DataTable GetData()
        {
            return this.LoaiDoiTuong.GetData();
        }
    }
}
