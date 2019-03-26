using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_PhieuBaoHongVatTu
    {
        DAL_PhieuBaoHongVatTu phieuBaoHongVatTu = new DAL_PhieuBaoHongVatTu();
        public bool Insert(PhieuBaoHongVatTu phieuBaoHongVatTu)
        {
            return this.phieuBaoHongVatTu.Insert(phieuBaoHongVatTu);
        }

        public bool Delete(int phieuBaoHongVatTuId)
        {
            return this.phieuBaoHongVatTu.Delete(phieuBaoHongVatTuId);
        }

        public bool Update(PhieuBaoHongVatTu phieuBaoHongVatTu)
        {
            return this.phieuBaoHongVatTu.Update(phieuBaoHongVatTu);
        }
    }
}
