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
    public class BUS_KyLuat
    {
        DAL_KyLuat kyLuat = new DAL_KyLuat();

        public DAL_KyLuat KyLuat { get => kyLuat; set => kyLuat = value; }

        public bool Insert(KyLuat kyLuat)
        {
            return this.KyLuat.Insert(kyLuat);
        }

        public bool Delete(int kyLuatId)
        {
            return this.KyLuat.Delete(kyLuatId);
        }

        public bool Update(KyLuat kyLuat)
        {
            return this.KyLuat.Update(kyLuat);
        }
        public DataTable GetData()
        {
            return this.KyLuat.GetData();
        }

    }
}
