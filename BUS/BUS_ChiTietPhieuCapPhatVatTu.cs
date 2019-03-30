using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_ChiTietPhieuCapPhatVatTu
    {
        DAL_ChiTietPhieuCapPhatVatTu chiTietPhieuCapPhatVatTu = new DAL_ChiTietPhieuCapPhatVatTu();

        public DAL_ChiTietPhieuCapPhatVatTu ChiTietPhieuCapPhatVatTu { get => chiTietPhieuCapPhatVatTu; set => chiTietPhieuCapPhatVatTu = value; }

        public bool Insert(ChiTietPhieuCapPhatVatTu chiTietPhieuCapPhatVatTu)
        {
            return this.ChiTietPhieuCapPhatVatTu.Insert(chiTietPhieuCapPhatVatTu);
        }

        public bool Delete(int chiTietPhieuCapPhatVatTuId)
        {
            return this.ChiTietPhieuCapPhatVatTu.Delete(chiTietPhieuCapPhatVatTuId);
        }

        public bool Update(ChiTietPhieuCapPhatVatTu chiTietPhieuCapPhatVatTu)
        {
            return this.ChiTietPhieuCapPhatVatTu.Update(chiTietPhieuCapPhatVatTu);
        }
        public DataTable GetData()
        {
            return this.ChiTietPhieuCapPhatVatTu.GetData();
        }
    }
}
