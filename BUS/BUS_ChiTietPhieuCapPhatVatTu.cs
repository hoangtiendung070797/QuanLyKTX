using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ChiTietPhieuCapPhatVatTu
    {
        DAL_ChiTietPhieuCapPhatVatTu chiTietPhieuCapPhatVatTu = new DAL_ChiTietPhieuCapPhatVatTu();
        public bool Insert(ChiTietPhieuCapPhatVatTu chiTietPhieuCapPhatVatTu)
        {
            return this.chiTietPhieuCapPhatVatTu.Insert(chiTietPhieuCapPhatVatTu);
        }

        public bool Delete(int chiTietPhieuCapPhatVatTuId)
        {
            return this.chiTietPhieuCapPhatVatTu.Delete(chiTietPhieuCapPhatVatTuId);
        }

        public bool Update(ChiTietPhieuCapPhatVatTu chiTietPhieuCapPhatVatTu)
        {
            return this.chiTietPhieuCapPhatVatTu.Update(chiTietPhieuCapPhatVatTu);
        }
    }
}
