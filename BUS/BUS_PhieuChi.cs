using DAL;
using DTO;
namespace BUS
{
    public class BUS_PhieuChi
    {
        DAL_PhieuChi phieuChi = new DAL_PhieuChi();
        public bool Insert(PhieuChi phieuChi)
        {
            return this.phieuChi.Insert(phieuChi);
        }

        public bool Delete(int phieuChiId)
        {
            return this.phieuChi.Delete(phieuChiId);
        }

        public bool Update(PhieuChi phieuChi)
        {
            return this.phieuChi.Update(phieuChi);
        }
    }
}
