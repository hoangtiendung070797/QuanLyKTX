using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_VatTu
    {
        private DAL_VatTu vatTu = new DAL_VatTu();

        public DAL_VatTu VatTu { get => vatTu; set => vatTu = value; }

        public bool Insert(VatTu vatTu)
        {
            return this.VatTu.Insert(vatTu);
        }

        public bool Delete(string vatTuId)
        {
            return this.VatTu.Delete(vatTuId);
        }

        public bool Update(VatTu vatTu)
        {
            return this.VatTu.Update(vatTu);
        }
        public DataTable GetData()
        {
            return this.VatTu.GetData();
        }
    }
}
