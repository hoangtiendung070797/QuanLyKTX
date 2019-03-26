using System;

namespace DTO
{
    public class PhieuThuTienPhong
    {
        #region Properties
        private int phieuThuTienPhongId;
        private int doiTuongId;
        private int nhanVienId;
        private int nguoiDungId;

        private string tenNguoiLap;
        private DateTime ngayThu;
        private DateTime tuNgay;
        private DateTime denNgay;
        private decimal tienThu;
        private string ghiChu;
        private bool tinhTrang;

        public int PhieuThuTienPhongId { get => phieuThuTienPhongId; set => phieuThuTienPhongId = value; }
        public int DoiTuongId { get => doiTuongId; set => doiTuongId = value; }
        public int NhanVienId { get => nhanVienId; set => nhanVienId = value; }
        public int NguoiDungId { get => nguoiDungId; set => nguoiDungId = value; }
        public string TenNguoiLap { get => tenNguoiLap; set => tenNguoiLap = value; }
        public DateTime NgayThu { get => ngayThu; set => ngayThu = value; }
        public DateTime TuNgay { get => tuNgay; set => tuNgay = value; }
        public DateTime DenNgay { get => denNgay; set => denNgay = value; }
        public decimal TienThu { get => tienThu; set => tienThu = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        #endregion


        #region Initialize  
        public PhieuThuTienPhong()
        {
        }

       
        #endregion
    }
}
