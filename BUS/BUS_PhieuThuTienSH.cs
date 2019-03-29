﻿using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_PhieuThuTienSH
    {
        DAL_PhieuThuTienSH phieuThuTienSH = new DAL_PhieuThuTienSH();
        public bool Insert(PhieuThuTienSH phieuThuTienSH)
        {
            return this.phieuThuTienSH.Insert(phieuThuTienSH);
        }

        public DataTable GetData()
        {
            return this.phieuThuTienSH.GetData();
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
