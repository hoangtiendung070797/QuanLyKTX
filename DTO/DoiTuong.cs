using System;


namespace DTO
{
    public class DoiTuong
    {
        #region Properties
        private int doiTuongId;
        private int loaiDoiTuongId;
        private int tonGiaoId;
        private int quocTichId;
        private int tinhThanhId;
        private int lopId;


        private string maSinhVien;
        private string hoDem;
        private string ten;
        private DateTime ngaySinh;
        private string noiSinh;
        private bool gioiTinh;
        private string hoKhau;
        private string queQuan;
        private string sdt;
        private string email;
        private string ghiChu;
        private int danTocId;

        private byte[] image;
        private string cmnd;
        private string hoTenBo;
        private DateTime ngaySinhBo;
        private string ngheNghiepBo;
        private string noiCongTacBo;
        private string sdtBoCoDinh;
        private string sdtDDBo;

        private string hoTenMe;
        private DateTime ngaySinhMe;
        private string ngheNghiepMe;
        private string noiCongTacMe;
        private string sdtMeCoDinh;
        private string sdtDDMe;

        public int DoiTuongId { get => doiTuongId; set => doiTuongId = value; }
        public int LoaiDoiTuongId { get => loaiDoiTuongId; set => loaiDoiTuongId = value; }
        public int TonGiaoId { get => tonGiaoId; set => tonGiaoId = value; }
        public int QuocTichId { get => quocTichId; set => quocTichId = value; }
        public int TinhThanhId { get => tinhThanhId; set => tinhThanhId = value; }
        public int LopId { get => lopId; set => lopId = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string HoDem { get => hoDem; set => hoDem = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string NoiSinh { get => noiSinh; set => noiSinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string HoKhau { get => hoKhau; set => hoKhau = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int DanTocId { get => danTocId; set => danTocId = value; }
        public byte[] Image { get => image; set => image = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string HoTenBo { get => hoTenBo; set => hoTenBo = value; }
        public DateTime NgaySinhBo { get => ngaySinhBo; set => ngaySinhBo = value; }
        public string NgheNghiepBo { get => ngheNghiepBo; set => ngheNghiepBo = value; }
        public string NoiCongTacBo { get => noiCongTacBo; set => noiCongTacBo = value; }
        public string SdtBoCoDinh { get => sdtBoCoDinh; set => sdtBoCoDinh = value; }
        public string SdtDDBo { get => sdtDDBo; set => sdtDDBo = value; }
        public string HoTenMe { get => hoTenMe; set => hoTenMe = value; }
        public DateTime NgaySinhMe { get => ngaySinhMe; set => ngaySinhMe = value; }
        public string NgheNghiepMe { get => ngheNghiepMe; set => ngheNghiepMe = value; }
        public string NoiCongTacMe { get => noiCongTacMe; set => noiCongTacMe = value; }
        public string SdtMeCoDinh { get => sdtMeCoDinh; set => sdtMeCoDinh = value; }
        public string SdtDDMe { get => sdtDDMe; set => sdtDDMe = value; }
        #endregion


        #region Initialize
        public DoiTuong(int doiTuongId, int loaiDoiTuongId, int TonGiaoId, int QuocTichId, int TinhThanhId, int LopId, string maSinhVien,
                                                                                                                      string hoDem,
                                                                                                                        string ten,
                                                                                                                         DateTime ngaySinh,
                                                                                                                        string noiSinh,
                                                                                                                        bool gioiTinh,
                                                                                                                         string hoKhau,
                                                                                                                         string queQuan,
                                                                                                                         string sdt,
                                                                                                                         string email,
                                                                                                                         string ghiChu
            )
        {
            this.DoiTuongId = doiTuongId;
            this.LoaiDoiTuongId = loaiDoiTuongId;
            this.TonGiaoId = TonGiaoId;
            this.QuocTichId = QuocTichId;
            this.TinhThanhId = TinhThanhId;
            this.LopId = LopId;
            this.MaSinhVien = maSinhVien;
            this.HoDem = hoDem;
            this.Ten = ten;
            this.NgaySinh = ngaySinh;
            this.NoiSinh = noiSinh;
            this.GioiTinh = gioiTinh;
            this.HoKhau = hoKhau;
            this.QueQuan = queQuan;
            this.Sdt = sdt;
            this.Email = email;
            this.GhiChu = ghiChu;

        }

       public DoiTuong()
        {

        }


        #endregion
    }
}
