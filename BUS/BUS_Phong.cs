using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_Phong
    {
        DAL_Phong phong = new DAL_Phong();

        public DAL_Phong Phong { get => phong; set => phong = value; }

        public bool Insert(Phong phong)
        {
            return this.Phong.Insert(phong);
        }

        public bool Delete(string PhongId)
        {
            return this.Phong.Delete(PhongId);
        }

        public bool Update(Phong phong)
        {
            return this.Phong.Update(phong);
        }
        public DataTable GetData()
        {
            return this.Phong.GetData();
        }
    }
}
