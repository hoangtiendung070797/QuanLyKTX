using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_DoiTuong
    {
        DAL_DoiTuong doiTuong = new DAL_DoiTuong();
        public bool Insert(DoiTuong doiTuong)
        {
            return this.doiTuong.Insert(doiTuong);
        }

        public bool Delete(int doiTuongId)
        {
            return this.doiTuong.Delete(doiTuongId);
        }

        public bool Update(DoiTuong doiTuong)
        {
            return this.doiTuong.Update(doiTuong);
        }

    }
}
