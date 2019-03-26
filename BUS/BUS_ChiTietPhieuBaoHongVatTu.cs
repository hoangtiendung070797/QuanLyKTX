using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ChiTietPhieuBaoHongVatTu
    {
        DAL_ChiTietPhieuBaoHongVatTu chiTietPhieuBaoHongVatTu = new DAL_ChiTietPhieuBaoHongVatTu();
        public bool Insert(ChiTietPhieuBaoHongVatTu chiTietPhieuBaoHongVatTu)
        {
            return this.chiTietPhieuBaoHongVatTu.Insert(chiTietPhieuBaoHongVatTu);
        }

        public bool Delete(int chiTietPhieuBaoHongVatTuId)
        {
            return this.chiTietPhieuBaoHongVatTu.Delete(chiTietPhieuBaoHongVatTuId);
        }

        public bool Update(ChiTietPhieuBaoHongVatTu chiTietPhieuBaoHongVatTu)
        {
            return this.chiTietPhieuBaoHongVatTu.Update(chiTietPhieuBaoHongVatTu);
        }
    }
}
