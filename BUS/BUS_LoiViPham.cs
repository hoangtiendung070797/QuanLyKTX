﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
   public class BUS_LoiViPham
    {
        DAL_LoiViPham loiViPham = new DAL_LoiViPham();
        public bool Insert(LoiViPham loiViPham)
        {
            return this.loiViPham.Insert(loiViPham);
        }

        public bool Delete(int loiViPhamId)
        {
            return this.loiViPham.Delete(loiViPhamId);
        }

        public bool Update(LoiViPham loiViPham)
        {
            return this.loiViPham.Update(loiViPham);
        }

    }
}
