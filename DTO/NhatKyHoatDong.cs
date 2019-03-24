using System;

namespace DTO
{
    public class NhatKyHoatDong
    {
        #region Properties
        private decimal nhatKyHoatDongId;
        private int nguoiDungId;
        private string thaoTac;
        private string noiDung;
        private DateTime thoiGian;

        public decimal NhatKyHoatDongId { get => nhatKyHoatDongId; set => nhatKyHoatDongId = value; }
        public int NguoiDungId { get => nguoiDungId; set => nguoiDungId = value; }
        public string ThaoTac { get => thaoTac; set => thaoTac = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }

        #endregion
    }
}
