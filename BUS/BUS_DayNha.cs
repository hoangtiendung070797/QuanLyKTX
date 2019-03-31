using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_DayNha
    {
        DAL_DayNha dayNha = new DAL_DayNha();

        public DAL_DayNha DayNha { get => dayNha; set => dayNha = value; }

        public bool Insert(DayNha dayNha)
        {
            return this.DayNha.Insert(dayNha);
        }

        public bool Delete(int dayNhaId)
        {
            return this.DayNha.Delete(dayNhaId);
        }

        public bool Update(DayNha dayNha)
        {
            return this.DayNha.Update(dayNha);
        }
        public DataTable GetData()
        {
            return this.DayNha.GetData();
        }
    }
}
