using System;

namespace DTO
{
    public class PhieuChi
    {
        #region Properties
        private int phieuChiId;
        private DateTime ngayChi;
        private int nhanVienId;
        private int nguoiDungId;

        private string noiDung;
        private string ghiChu;
        private decimal soTien;

        public int PhieuChiId { get => phieuChiId; set => phieuChiId = value; }
        public DateTime NgayChi { get => ngayChi; set => ngayChi = value; }
        public int NhanVienId { get => nhanVienId; set => nhanVienId = value; }
        public int NguoiDungId { get => nguoiDungId; set => nguoiDungId = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public decimal SoTien { get => soTien; set => soTien = value; }


        #endregion
    }
}
