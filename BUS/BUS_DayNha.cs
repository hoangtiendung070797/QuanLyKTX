using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_DayNha
    {
        DAL_DayNha dayNha = new DAL_DayNha();
        public bool Insert(DayNha dayNha)
        {
            return this.dayNha.Insert(dayNha);
        }

        public bool Delete(int dayNhaId)
        {
            return this.dayNha.Delete(dayNhaId);
        }

        public bool Update(DayNha dayNha)
        {
            return this.dayNha.Update(dayNha);
        }

    }
}
