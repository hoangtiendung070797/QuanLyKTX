using System;

namespace DTO
{
    public class PhieuCapPhatVatTu
    {
        #region Properties
        private int phieuCapPhatVatTuId;
        private string PhongId;
        private int nhanVienId;
        private int nguoiDungId;
        private DateTime ngayCapPhat;
        private string tenNguoiLap;
        private string ghiChu;

        public int PhieuCapPhatVatTuId { get => phieuCapPhatVatTuId; set => phieuCapPhatVatTuId = value; }
        public string PhongId1 { get => PhongId; set => PhongId = value; }
        public int NhanVienId { get => nhanVienId; set => nhanVienId = value; }
        public DateTime NgayCapPhat { get => ngayCapPhat; set => ngayCapPhat = value; }
        public string TenNguoiLap { get => tenNguoiLap; set => tenNguoiLap = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int NguoiDungId { get => nguoiDungId; set => nguoiDungId = value; }
        #endregion

        #region Initialize
        public PhieuCapPhatVatTu()
        {

        }
        #endregion
    }
}
