using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_TinhThanh
    {
        private DAL_TinhThanh tinhThanh = new DAL_TinhThanh();

        public DAL_TinhThanh TinhThanh { get => tinhThanh; set => tinhThanh = value; }

        public bool Insert(TinhThanh tinhThanh)
        {
            return this.TinhThanh.Insert(tinhThanh);
        }

        public DataTable GetData()
        {
            return this.TinhThanh.GetData();
        }
        public bool Delete(int tinhThanhId)
        {
            return this.TinhThanh.Delete(tinhThanhId);
        }

        public bool Update(TinhThanh tinhThanh)
        {
            return this.TinhThanh.Update(tinhThanh);
        }

    }
}
