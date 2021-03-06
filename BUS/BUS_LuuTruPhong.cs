﻿using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_LuuTruPhong
    {
        DAL_LuuTruPhong luuTruPhong = new DAL_LuuTruPhong();

        public DAL_LuuTruPhong LuuTruPhong { get => luuTruPhong; set => luuTruPhong = value; }

        public bool Insert(LuuTruPhong luuTruPhong)
        {
            return this.LuuTruPhong.Insert(luuTruPhong);
        }

        public bool Delete(int LuuTruPhongId)
        {
            return this.LuuTruPhong.Delete(LuuTruPhongId);
        }

        public bool Update(LuuTruPhong luuTruPhong)
        {
            return this.LuuTruPhong.Update(luuTruPhong);
        }

        public DataTable GetData()
        {
            return this.LuuTruPhong.GetData();
        }
        public DataTable DoiTuong_TrongPhong(string phongid)
        {
            return this.LuuTruPhong.DoiTuong_TrongPhong(phongid);
        }
    
        public DataTable DoiTuong_ChuaCoPhong_GioiTinh(string GioiTinh)
        {
            return this.LuuTruPhong.DoiTuong_ChuaCoPhong_GioiTinh(GioiTinh);
        }
    }
}
