using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_DonVi
    {
        private DAL_DonVi donVi = new DAL_DonVi();

        public DAL_DonVi DonVi { get => donVi; set => donVi = value; }

        public bool Insert(DonVi donVi)
        {
            return this.DonVi.Insert(donVi);
        }
        public DataTable GetData()
        {
            return this.DonVi.GetData();
        }
        public bool Delete(int donViId)
        {
            return this.DonVi.Delete(donViId);
        }

        public bool Update(DonVi donVi)
        {
            return this.DonVi.Update(donVi);
        }

    }
}
