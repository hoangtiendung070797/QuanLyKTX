using DAL;
using DTO;

namespace BUS
{
    public class BUS_Phong
    {
        DAL_DonVi phong = new DAL_DonVi();
        public bool Insert(DonVi phong)
        {
            return this.phong.Insert(phong);
        }

        public bool Delete(int PhongId)
        {
            return this.phong.Delete(PhongId);
        }

        public bool Update(DonVi phong)
        {
            return this.phong.Update(phong);
        }

    }
}
