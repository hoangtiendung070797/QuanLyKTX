using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_QuocTich
    {
        DAL_QuocTich quocTich = new DAL_QuocTich();
        public DataTable GetData()
        {
            return this.quocTich.GetData();
        }
        public bool Insert(QuocTich quocTich)
        {
            return this.quocTich.Insert(quocTich);
        }

        public bool Delete(int quocTichId)
        {
            return this.quocTich.Delete(quocTichId);
        }

        public bool Update(QuocTich quocTich)
        {
            return this.quocTich.Update(quocTich);
        }
    }
}
