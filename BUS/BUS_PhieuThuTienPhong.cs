using DAL;
using DTO;
using System;
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
        public DataTable GetDataById(int doiTuongId)
        {
            return this.PhieuThuTienPhong.GetDataById(doiTuongId);
        }
        public DataTable GetDataByDate(DateTime date)
        {
            return this.PhieuThuTienPhong.GetDataByDate(date);
        }

        public int GetIdentityId()
        {
            return this.PhieuThuTienPhong.GetIdentityId();
        }
        public DataTable PrintInfo()
        {
            return this.PhieuThuTienPhong.PrintInfo();
        }

        public DataTable GetSinhVienTheoTinhTrangPhieuThuTienPhong(int tinhTrang)
        {
            return PhieuThuTienPhong.GetSinhVienTheoTinhTrangPhieuThuTienPhong(tinhTrang);
        }
        public DataTable GetDataPhieuThuTienPhong()
        {
            return this.PhieuThuTienPhong.GetDataPhieuThuTienPhong();
        }
        public DataTable PrinftPhieu(int phieuId)
        {
            return this.PhieuThuTienPhong.PrinftPhieu(phieuId);
        }
    }
}
