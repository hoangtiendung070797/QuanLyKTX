using System;
using System.Collections.Generic;
using System.Data;
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

        public DAL_KhenThuong KhenThuong { get => khenThuong; set => khenThuong = value; }

        public bool Insert(KhenThuong khenThuong)
        {
            return this.KhenThuong.Insert(khenThuong);
        }

        public bool Delete(int khenThuongId)
        {
            return this.KhenThuong.Delete(khenThuongId);
        }

        public bool Update(KhenThuong khenThuong)
        {
            return this.KhenThuong.Update(khenThuong);
        }
        public DataTable GetData()
        {
            return this.KhenThuong.GetData();
        }
    }
}
