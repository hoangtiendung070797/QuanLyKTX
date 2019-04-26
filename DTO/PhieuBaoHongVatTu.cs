using System;

namespace DTO
{
    public class PhieuBaoHongVatTu
    {
        #region Properties
        private int phieuBaoHongVatTuId;
        private string tenPhieuBaoHong;
        private string tenNguoiLap;
        private DateTime ngayBao;
        private string GhiChu;

        private string phongId;
        private int nhanVienId;
        private int nguoiDungId;

        public int PhieuBaoHongVatTuId { get => phieuBaoHongVatTuId; set => phieuBaoHongVatTuId = value; }
        public string TenPhieuBaoHong { get => tenPhieuBaoHong; set => tenPhieuBaoHong = value; }
        public string TenNguoiLap { get => tenNguoiLap; set => tenNguoiLap = value; }
        public DateTime NgayBao { get => ngayBao; set => ngayBao = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
        public int NhanVienId { get => nhanVienId; set => nhanVienId = value; }
        public int NguoiDungId { get => nguoiDungId; set => nguoiDungId = value; }
        public string PhongId { get => phongId; set => phongId = value; }


        #endregion

        #region Initialize
        public PhieuBaoHongVatTu()
        {

        }


        #endregion
    }
}
