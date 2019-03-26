using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_PhieuThuTienSH
    {
        DAL_PhieuThuTienSH phieuThuTienSH = new DAL_PhieuThuTienSH();
        public bool Insert(PhieuThuTienSH phieuThuTienSH)
        {
            return this.phieuThuTienSH.Insert(phieuThuTienSH);
        }

        public bool Delete(int phieuThuTienSHId)
        {
            return this.phieuThuTienSH.Delete(phieuThuTienSHId);
        }

        public bool Update(PhieuThuTienSH phieuThuTienSH)
        {
            return this.phieuThuTienSH.Update(phieuThuTienSH);
        }
    }
}
