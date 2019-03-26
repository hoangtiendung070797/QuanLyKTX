using DAL;
using DTO;

namespace BUS
{
    class BUS_VatTu
    {
        DAL_VatTu vatTu = new DAL_VatTu();
        public bool Insert(VatTu vatTu)
        {
            return this.vatTu.Insert(vatTu);
        }

        public bool Delete(string vatTuId)
        {
            return this.vatTu.Delete(vatTuId);
        }

        public bool Update(VatTu vatTu)
        {
            return this.vatTu.Update(vatTu);
        }
    }
}
