using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_ChiTietPhieuBaoHongVatTu
    {
        DAL_ChiTietPhieuBaoHongVatTu chiTietPhieuBaoHongVatTu = new DAL_ChiTietPhieuBaoHongVatTu();

        public DAL_ChiTietPhieuBaoHongVatTu ChiTietPhieuBaoHongVatTu { get => chiTietPhieuBaoHongVatTu; set => chiTietPhieuBaoHongVatTu = value; }

        public bool Insert(ChiTietPhieuBaoHongVatTu chiTietPhieuBaoHongVatTu)
        {
            return this.ChiTietPhieuBaoHongVatTu.Insert(chiTietPhieuBaoHongVatTu);
        }

        public bool Delete(int chiTietPhieuBaoHongVatTuId)
        {
            return this.ChiTietPhieuBaoHongVatTu.Delete(chiTietPhieuBaoHongVatTuId);
        }

        public bool Update(ChiTietPhieuBaoHongVatTu chiTietPhieuBaoHongVatTu)
        {
            return this.ChiTietPhieuBaoHongVatTu.Update(chiTietPhieuBaoHongVatTu);
        }

        public DataTable GetData()
        {
            return this.ChiTietPhieuBaoHongVatTu.GetData();
        }
        public DataTable GetVatTuHongTheoPhong(string phongID, int dayNhaId)
        {
            return this.chiTietPhieuBaoHongVatTu.GetVatTuHongTheoPhong(phongID, dayNhaId);
        }
        public DataTable GetDataVatTuHongTheoPhong()
        {
            return this.ChiTietPhieuBaoHongVatTu.GetDataVatTuHongTheoPhong();
        }
    }
}
