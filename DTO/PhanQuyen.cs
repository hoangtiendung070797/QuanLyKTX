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
        private string tenChucNang;
        private int nguoiDungId;
        private string tenNhomChucNang;
        private bool chucNangThem;
        private bool chucNangSua;
        private bool chucNangXoa;
        private bool chucNangDoc;

        public int PhanQuyenId { get => phanQuyenId; set => phanQuyenId = value; }
        public string TenChucNang { get => tenChucNang; set => tenChucNang = value; }
        public int NguoiDungId { get => nguoiDungId; set => nguoiDungId = value; }
        public string TenNhomChucNang { get => tenNhomChucNang; set => tenNhomChucNang = value; }
        public bool ChucNangThem { get => chucNangThem; set => chucNangThem = value; }
        public bool ChucNangSua { get => chucNangSua; set => chucNangSua = value; }
        public bool ChucNangXoa { get => chucNangXoa; set => chucNangXoa = value; }
        public bool ChucNangDoc { get => chucNangDoc; set => chucNangDoc = value; }

        #endregion

        #region Initialize
        public PhanQuyen()
        {

        }
     



        #endregion
    }
}
