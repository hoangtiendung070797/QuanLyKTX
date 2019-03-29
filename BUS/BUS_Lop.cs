using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_Lop
    {
        DAL_Lop lop = new DAL_Lop();
        public bool Insert(Lop lop)
        {
            return this.lop.Insert(lop);
        }

        public bool Delete(int lopId)
        {
            return this.lop.Delete(lopId);
        }

        public bool Update(Lop lop)
        {
            return this.lop.Update(lop);
        }
        public DataTable GetData()
        {
            return this.lop.GetData();
        }
    }
}
