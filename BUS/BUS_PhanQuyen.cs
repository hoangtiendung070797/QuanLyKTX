using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_PhanQuyen
    {

        DAL_PhanQuyen phanQuyen = new DAL_PhanQuyen();

        public DAL_PhanQuyen PhanQuyen { get => phanQuyen; set => phanQuyen = value; }

        public bool Insert(PhanQuyen phanQuyen)
        {
            return this.PhanQuyen.Insert(phanQuyen);
        }

        public bool Delete(int phanQuyenId)
        {
            return this.PhanQuyen.Delete(phanQuyenId);
        }

        public bool Update(PhanQuyen phanQuyen)
        {
            return this.PhanQuyen.Update(phanQuyen);
        }
        public DataTable GetData()
        {
            return this.PhanQuyen.GetData();
        }
        public DataTable GetDetailPhanQuyen(int nguoiDungId)
        {
            return this.PhanQuyen.GetDetailPhanQuyen(nguoiDungId);
        }

        public bool IsNguoiDungIdInPQ(int nguoiDungId)
        {
            return this.PhanQuyen.IsNguoiDungIdInPQ(nguoiDungId);
        }

        public bool UpdateDetail(DataTable table)
        {
            return this.PhanQuyen.UpdateDetail(table);
        }
    }
}
