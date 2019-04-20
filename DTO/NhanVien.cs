using System;

namespace DTO
{
    public class NhanVien
    {
        #region Properties


        private int nhanVienId;
        private string tenNhanVien;
        private string sdt;
        private string email;
        private DateTime ngaySinh;
        private string chucVu;
        private string diaChi;
        private string phuTrach;

        public int NhanVienId { get => nhanVienId; set => nhanVienId = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string PhuTrach { get => phuTrach; set => phuTrach = value; }

        #endregion


        #region Initialize
        public NhanVien()
        {

        }

        #endregion
    }
}
