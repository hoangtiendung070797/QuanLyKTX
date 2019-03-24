using System;

namespace DTO
{
    public class LuuTruPhong
    {
        #region Properties
        private int luuTruPhongId;
        private int nhanVienId;
        private int nguoiDungId;

        private string phongId;
        private int doiTuongId;
        private DateTime ngayXep;

        private DateTime ngayRoi;

        private bool trangThai;
        public int LuuTruPhongId { get => luuTruPhongId; set => luuTruPhongId = value; }
        public int NhanVienId { get => nhanVienId; set => nhanVienId = value; }
        public int NguoiDungId { get => nguoiDungId; set => nguoiDungId = value; }
        public string PhongId { get => phongId; set => phongId = value; }
        public int DoiTuongId { get => doiTuongId; set => doiTuongId = value; }
        public DateTime NgayXep { get => ngayXep; set => ngayXep = value; }
        public DateTime NgayRoi { get => ngayRoi; set => ngayRoi = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        #endregion


        #region Initialize  
        public LuuTruPhong()
        {
        }

      

        #endregion
    }
}
