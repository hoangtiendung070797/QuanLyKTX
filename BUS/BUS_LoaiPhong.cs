using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_LoaiPhong
    {
        DAL_LoaiPhong LoaiPhong = new DAL_LoaiPhong();

        public DAL_LoaiPhong LoaiPhong1 { get => LoaiPhong; set => LoaiPhong = value; }

        public bool Insert(LoaiPhong loaiPhong)
        {
            return this.LoaiPhong1.Insert(loaiPhong);
        }

        public bool Delete(int loaiPhongId)
        {
            return this.LoaiPhong1.Delete(loaiPhongId);
        }

        public bool Update(LoaiPhong loaiPhong)
        {
            return this.LoaiPhong1.Update(loaiPhong);
        }
        public DataTable GetData()
        {
            return this.LoaiPhong1.GetData();
        }
    }
}
