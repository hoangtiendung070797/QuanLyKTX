using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_KhenThuong
    {
        DAL_KhenThuong khenThuong = new DAL_KhenThuong();
        public bool Insert(KhenThuong khenThuong)
        {
            return this.khenThuong.Insert(khenThuong);
        }

        public bool Delete(int khenThuongId)
        {
            return this.khenThuong.Delete(khenThuongId);
        }

        public bool Update(KhenThuong khenThuong)
        {
            return this.khenThuong.Update(khenThuong);
        }
    }
}
