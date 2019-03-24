using DAL;
using DTO;

namespace BUS
{
    public class BUS_DonVi
    {
        DAL_DonVi donVi = new DAL_DonVi();
        public bool Insert(DonVi donVi)
        {
            return this.donVi.Insert(donVi);
        }

        public bool Delete(int donViId)
        {
            return this.donVi.Delete(donViId);
        }

        public bool Update(DonVi donVi)
        {
            return this.donVi.Update(donVi);
        }

    }
}
