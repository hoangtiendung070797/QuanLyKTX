using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_NguoiDung
    {
        DAL_NguoiDung nguoiDung = new DAL_NguoiDung();
        public bool Insert(NguoiDung nguoiDung)
        {
            return this.nguoiDung.Insert(nguoiDung);
        }

        public bool Delete(int NguoiDungId)
        {
            return this.nguoiDung.Delete(NguoiDungId);
        }

        public bool Update(NguoiDung nguoiDung)
        {
            return this.nguoiDung.Update(nguoiDung);
        }

    }
}
