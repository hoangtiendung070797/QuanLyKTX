using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_PhieuThuTienSH
    {
        DAL_PhieuThuTienSH phieuThuTienSH = new DAL_PhieuThuTienSH();

        public DAL_PhieuThuTienSH PhieuThuTienSH { get => phieuThuTienSH; set => phieuThuTienSH = value; }

        public bool Insert(PhieuThuTienSH phieuThuTienSH)
        {
            return this.PhieuThuTienSH.Insert(phieuThuTienSH);
        }

        public bool Delete(int phieuThuTienSHId)
        {
            return this.PhieuThuTienSH.Delete(phieuThuTienSHId);
        }

        public bool Update(PhieuThuTienSH phieuThuTienSH)
        {
            return this.PhieuThuTienSH.Update(phieuThuTienSH);
        }
        public DataTable GetData()
        {
            return this.PhieuThuTienSH.GetData();
        }
        public DataTable GetPhongTheoPhieuThuTienSH(string phongID, int dayNhaId)
        {
            return this.phieuThuTienSH.GetPhongTheoPhieuThuTienSH(phongID, dayNhaId);
        }
        public DataTable GetDataPhieuThuTienSH()
        {
            return this.PhieuThuTienSH.GetDataPhieuThuTienSH();
        }

        public DataTable DienNuocDau(string phong)
        {
            return this.PhieuThuTienSH.DienNuocDau(phong);
        }
        public bool CheckInPhieuThu(string phongid, string ngaythu)
        {
            return this.PhieuThuTienSH.CheckInPhieuThu(phongid, ngaythu);
        }
        public bool UpdateDetail(DataTable table)
        {
            return this.phieuThuTienSH.UpdateDetail(table);
        }
        public DataTable GetDataNew()
        {
            return this.PhieuThuTienSH.GetDataNew();
        }
        public bool UpdateDetailNew(DataTable table)
        {
            return this.PhieuThuTienSH.UpdateDetailNew(table);
        }


        public DataTable GetDataTheoThangNew(int month)
        {
            return this.PhieuThuTienSH.GetDataTheoThangNew(month);
        }
    }
}
