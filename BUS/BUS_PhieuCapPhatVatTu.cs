using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_PhieuCapPhatVatTu
    {
        DAL_PhieuCapPhatVatTu phieuCapPhatVatTu = new DAL_PhieuCapPhatVatTu();

        public DAL_PhieuCapPhatVatTu PhieuCapPhatVatTu { get => phieuCapPhatVatTu; set => phieuCapPhatVatTu = value; }

        public bool Insert(PhieuCapPhatVatTu phieuCapPhatVatTu)
        {
            return this.PhieuCapPhatVatTu.Insert(phieuCapPhatVatTu);
        }

        public bool Delete(int phieuCapPhatVatTuId)
        {
            return this.PhieuCapPhatVatTu.Delete(phieuCapPhatVatTuId);
        }

        public bool Update(PhieuCapPhatVatTu phieuCapPhatVatTu)
        {
            return this.PhieuCapPhatVatTu.Update(phieuCapPhatVatTu);
        }
        public DataTable GetData()
        {
            return this.PhieuCapPhatVatTu.GetData();
        }
    }
}
