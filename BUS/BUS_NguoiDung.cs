using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_NguoiDung
    {
        DAL_NguoiDung nguoiDung = new DAL_NguoiDung();

        public DAL_NguoiDung NguoiDung { get => nguoiDung; set => nguoiDung = value; }

        public bool Insert(NguoiDung nguoiDung)
        {
            return this.NguoiDung.Insert(nguoiDung);
        }

        public bool Delete(int NguoiDungId)
        {
            return this.NguoiDung.Delete(NguoiDungId);
        }

        public bool Update(NguoiDung nguoiDung)
        {
            return this.NguoiDung.Update(nguoiDung);
        }

        public DataTable GetData()
        {
            return this.NguoiDung.GetData();
        }
    }
}
