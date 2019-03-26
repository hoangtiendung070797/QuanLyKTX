using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_PhieuCapPhatVatTu
    {
        DAL_PhieuCapPhatVatTu phieuCapPhatVatTu = new DAL_PhieuCapPhatVatTu();
        public bool Insert(PhieuCapPhatVatTu phieuCapPhatVatTu)
        {
            return this.phieuCapPhatVatTu.Insert(phieuCapPhatVatTu);
        }

        public bool Delete(int phieuCapPhatVatTuId)
        {
            return this.phieuCapPhatVatTu.Delete(phieuCapPhatVatTuId);
        }

        public bool Update(PhieuCapPhatVatTu phieuCapPhatVatTu)
        {
            return this.phieuCapPhatVatTu.Update(phieuCapPhatVatTu);
        }
    }
}
