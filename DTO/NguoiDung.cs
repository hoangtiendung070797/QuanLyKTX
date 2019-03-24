using System;

namespace DTO
{
    public class NguoiDung
    {
        #region Properties
        private int nguoiDungId;
        private string tenDangNhap;
        private string matKhau;
        private string tenDayDu;
        private string sdt;
        private string diaChi;
        private string chucVu;
        private int quyen;

        public int NguoiDungId { get => nguoiDungId; set => nguoiDungId = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenDayDu { get => tenDayDu; set => tenDayDu = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int Quyen { get => quyen; set => quyen = value; }

        #endregion


        #region Initialize
        public NguoiDung(int id, string acc, string mk, string ten, string sdt, string diachi, string chucvu, int quyen=3)
        {
            this.NguoiDungId = id;
            this.TenDangNhap = acc;
            this.MatKhau = mk;
            this.TenDayDu = ten;
            this.Sdt = sdt;
            this.DiaChi = diachi;
            this.ChucVu = chucvu;
            this.Quyen = quyen;
        }

      



        #endregion
    }
}
