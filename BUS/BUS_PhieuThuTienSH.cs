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
    }
}
