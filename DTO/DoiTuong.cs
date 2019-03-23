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
        private string lopId;


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

        public int DoiTuongId { get => doiTuongId; set => doiTuongId = value; }
        public int LoaiDoiTuongId { get => loaiDoiTuongId; set => loaiDoiTuongId = value; }
        public int TonGiaoId { get => tonGiaoId; set => tonGiaoId = value; }
        public int QuocTichId { get => quocTichId; set => quocTichId = value; }
        public int TinhThanhId { get => tinhThanhId; set => tinhThanhId = value; }
        public string LopId { get => lopId; set => lopId = value; }
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
        #endregion


        #region Initialize
        public DoiTuong(int doiTuongId, int loaiDoiTuongId, int TonGiaoId, int QuocTichId, int TinhThanhId, string LopId, string maSinhVien,
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

       


        #endregion
    }
}
