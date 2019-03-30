using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyen
    {
        #region  Properties
        private int phanQuyenId;
        private string tenPhanQuyen;
        private int nguoiDungId;

        public int PhanQuyenId { get => phanQuyenId; set => phanQuyenId = value; }
        public string TenPhanQuyen { get => tenPhanQuyen; set => tenPhanQuyen = value; }
        public int NguoiDungId { get => nguoiDungId; set => nguoiDungId = value; }
        #endregion

        #region Initialize
        public PhanQuyen()
        {

        }
        public PhanQuyen( string name,int nguoiDungId)
        {
            this.TenPhanQuyen = name;
            this.NguoiDungId = nguoiDungId;
        }

      
        #endregion
    }
}
