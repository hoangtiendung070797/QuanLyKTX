using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    class BUS_NhatKyHoatDong
    {
        DAL_NhatKyHoatDong nhatKyHoatDong = new DAL_NhatKyHoatDong();
        public bool Insert(NhatKyHoatDong nhatKyHoatDong)
        {
            return this.nhatKyHoatDong.Insert(nhatKyHoatDong);
        }

        public bool Delete(int nhatKyHoatDongId)
        {
            return this.nhatKyHoatDong.Delete(nhatKyHoatDongId);
        }

        public bool Update(NhatKyHoatDong nhatKyHoatDong)
        {
            return this.nhatKyHoatDong.Update(nhatKyHoatDong);
        }

    }
}
