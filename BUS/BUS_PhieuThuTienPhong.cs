using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_PhieuThuTienPhong
    {
        DAL_PhieuThuTienPhong phieuThuTienPhong = new DAL_PhieuThuTienPhong();

        public DAL_PhieuThuTienPhong PhieuThuTienPhong { get => phieuThuTienPhong; set => phieuThuTienPhong = value; }

        public bool Insert(PhieuThuTienPhong phieuThuTienPhong)
        {
            return this.PhieuThuTienPhong.Insert(phieuThuTienPhong);
        }

        public bool Delete(int PhieuThuTienPhongId)
        {
            return this.PhieuThuTienPhong.Delete(PhieuThuTienPhongId);
        }

        public bool Update(PhieuThuTienPhong phieuThuTienPhong)
        {
            return this.PhieuThuTienPhong.Update(phieuThuTienPhong);
        }
        public DataTable GetData()
        {
            return this.PhieuThuTienPhong.GetData();
        }
    }
}
