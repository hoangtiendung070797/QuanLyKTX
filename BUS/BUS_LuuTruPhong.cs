using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    class BUS_LuuTruPhong
    {
        DAL_LuuTruPhong luuTruPhong = new DAL_LuuTruPhong();
        public bool Insert(LuuTruPhong luuTruPhong)
        {
            return this.luuTruPhong.Insert(luuTruPhong);
        }

        public bool Delete(int LuuTruPhongId)
        {
            return this.luuTruPhong.Delete(LuuTruPhongId);
        }

        public bool Update(LuuTruPhong luuTruPhong)
        {
            return this.luuTruPhong.Update(luuTruPhong);
        }

    }
}
