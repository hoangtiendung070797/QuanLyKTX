using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_Lop
    {
        DAL_Lop lop = new DAL_Lop();

        public DAL_Lop Lop { get => lop; set => lop = value; }

        public bool Insert(Lop lop)
        {
            return this.Lop.Insert(lop);
        }

        public bool Delete(int lopId)
        {
            return this.Lop.Delete(lopId);
        }

        public bool Update(Lop lop)
        {
            return this.Lop.Update(lop);
        }
        public DataTable GetData()
        {
            return this.Lop.GetData();
        }
        public DataTable GetSinhVienTheoLop(int lopId)
        {
            return this.Lop.GetSinhVienTheoLop(lopId);
        }
        public DataTable GetDataLop()
        {
            return Lop.GetDataLop();
        }
        public DataTable PrintInfor()
        {
            return this.Lop.PrintInfor();
        }
    }
}
