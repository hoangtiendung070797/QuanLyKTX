using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_PhieuBaoHongVatTu
    {
        DAL_PhieuBaoHongVatTu phieuBaoHongVatTu = new DAL_PhieuBaoHongVatTu();

        public DAL_PhieuBaoHongVatTu PhieuBaoHongVatTu { get => phieuBaoHongVatTu; set => phieuBaoHongVatTu = value; }

        public bool Insert(PhieuBaoHongVatTu phieuBaoHongVatTu)
        {
            return this.PhieuBaoHongVatTu.Insert(phieuBaoHongVatTu);
        }

        public bool Delete(int phieuBaoHongVatTuId)
        {
            return this.PhieuBaoHongVatTu.Delete(phieuBaoHongVatTuId);
        }

        public bool Update(PhieuBaoHongVatTu phieuBaoHongVatTu)
        {
            return this.PhieuBaoHongVatTu.Update(phieuBaoHongVatTu);
        }
        public DataTable GetData()
        {
            return this.PhieuBaoHongVatTu.GetData();
        }
        public DataTable GetDataNew()
        {
            return this.PhieuBaoHongVatTu.GetDataNew();
        }

        public DataTable SetPhieuBaoHongID()
        {
            return this.PhieuBaoHongVatTu.SetPhieuBaoHongID();
        }
    }
}
