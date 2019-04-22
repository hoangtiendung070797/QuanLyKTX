using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_PhieuChi
    {
        DAL_PhieuChi phieuChi = new DAL_PhieuChi();

        public DAL_PhieuChi PhieuChi { get => phieuChi; set => phieuChi = value; }

        public bool Insert(PhieuChi phieuChi)
        {
            return this.PhieuChi.Insert(phieuChi);
        }

        public bool Delete(int phieuChiId)
        {
            return this.PhieuChi.Delete(phieuChiId);
        }

        public bool Update(PhieuChi phieuChi)
        {
            return this.PhieuChi.Update(phieuChi);
        }
        public DataTable GetData()
        {
            return this.PhieuChi.GetData();
        }

        public DataTable GetDataNew()
        {
            return this.PhieuChi.GetDataNew();
        }
    }
}
