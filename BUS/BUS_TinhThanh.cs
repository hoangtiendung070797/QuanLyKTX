using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    class BUS_TinhThanh
    {
        DAL_TinhThanh tinhThanh = new DAL_TinhThanh();
        public bool Insert(TinhThanh tinhThanh)
        {
            return this.tinhThanh.Insert(tinhThanh);
        }

        public bool Delete(int tinhThanhId)
        {
            return this.tinhThanh.Delete(tinhThanhId);
        }

        public bool Update(TinhThanh tinhThanh)
        {
            return this.tinhThanh.Update(tinhThanh);
        }

    }
}
