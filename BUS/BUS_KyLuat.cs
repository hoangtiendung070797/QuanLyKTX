using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_KyLuat
    {
        DAL_KyLuat kyLuat = new DAL_KyLuat();
        public bool Insert(KyLuat kyLuat)
        {
            return this.kyLuat.Insert(kyLuat);
        }

        public bool Delete(int kyLuatId)
        {
            return this.kyLuat.Delete(kyLuatId);
        }

        public bool Update(KyLuat kyLuat)
        {
            return this.kyLuat.Update(kyLuat);
        }

    }
}
