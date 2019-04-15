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
        public DataTable GetDataListView()
        {
            return this.ChiTietPhieuCapPhatVatTu.GetDataListView();
        }
        public int GetIndex(string PhieuCapPhatId)
        {
            return this.ChiTietPhieuCapPhatVatTu.GetIndex(PhieuCapPhatId);
        }
        public bool CheckVatTu(int phieuCapPhatId, string vatTuId)
        {
            return this.ChiTietPhieuCapPhatVatTu.CheckVatTu(phieuCapPhatId, vatTuId);
        }

        public int GetChiTietID(int phieuCapPhatId, string vatTuId)
        {
            return this.ChiTietPhieuCapPhatVatTu.GetChiTietID(phieuCapPhatId, vatTuId);
        }

        public DataTable GetVatTuTheoPhong(string phongID, int dayNhaId)
        {
            return this.chiTietPhieuCapPhatVatTu.GetVatTuTheoPhong(phongID, dayNhaId);
        }
        public DataTable GetDataVatTuTheoPhong()
        {
            return this.ChiTietPhieuCapPhatVatTu.GetDataVatTuTheoPhong();
        }
    }
}
