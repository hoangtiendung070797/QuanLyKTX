using DAL;
using DTO;
using System.Data;
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
        public DataTable GetData()
        {
            return this.dayNha.GetData();
        }
    }
}
