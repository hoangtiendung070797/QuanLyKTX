using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_QuocTich
    {

        private DAL_QuocTich quocTich = new DAL_QuocTich();

        public DAL_QuocTich QuocTich { get => quocTich; set => quocTich = value; }

        public DataTable GetData()
        {
            return this.QuocTich.GetData();
        }
        public bool Insert(QuocTich quocTich)
        {
            return this.QuocTich.Insert(quocTich);
        }

        public bool Delete(int quocTichId)
        {
            return this.QuocTich.Delete(quocTichId);
        }

        public bool Update(QuocTich quocTich)
        {
            return this.QuocTich.Update(quocTich);
        }
    }
}
