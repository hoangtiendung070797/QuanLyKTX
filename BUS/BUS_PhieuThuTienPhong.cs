using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_PhieuThuTienPhong
    {
        DAL_PhieuThuTienPhong phieuThuTienPhong = new DAL_PhieuThuTienPhong();
        public bool Insert(PhieuThuTienPhong phieuThuTienPhong)
        {
            return this.phieuThuTienPhong.Insert(phieuThuTienPhong);
        }

        public bool Delete(int PhieuThuTienPhongId)
        {
            return this.phieuThuTienPhong.Delete(PhieuThuTienPhongId);
        }

        public bool Update(PhieuThuTienPhong phieuThuTienPhong)
        {
            return this.phieuThuTienPhong.Update(phieuThuTienPhong);
        }
    }
}
