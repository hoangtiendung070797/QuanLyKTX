using System;

namespace DTO
{
    public class PhieuThuTienSH
    {
        #region Properties
        private int phieuThuTienSHId;
        private string PhongId;
        private int NhanVienId;
        private int NguoiDungId;

        private DateTime ngayThu;
        private int soDienDau;
        private int soDienCuoi;
        private int soNuocDau;
        private int soNuocCuoi;
        private int soDienThuc;
        private int soNuocThuc;
        private decimal donGiaDien;
        private decimal donGiaNuoc;

        private decimal tienThuDien;

        private decimal tienThuNuoc;
        private decimal phiDichVu;
        private decimal tong;
        private string tenNguoiThu;
        private string ghiChu;

        public int PhieuThuTienSHId { get => phieuThuTienSHId; set => phieuThuTienSHId = value; }
        public string PhongId1 { get => PhongId; set => PhongId = value; }
        public int NhanVienId1 { get => NhanVienId; set => NhanVienId = value; }
        public int NguoiDungId1 { get => NguoiDungId; set => NguoiDungId = value; }
        public DateTime NgayThu { get => ngayThu; set => ngayThu = value; }
        public int SoDienDau { get => soDienDau; set => soDienDau = value; }
        public int SoDienCuoi { get => soDienCuoi; set => soDienCuoi = value; }
        public int SoNuocDau { get => soNuocDau; set => soNuocDau = value; }
        public int SoNuocCuoi { get => soNuocCuoi; set => soNuocCuoi = value; }
        public int SoDienThuc { get => soDienThuc; set => soDienThuc = value; }
        public int SoNuocThuc { get => soNuocThuc; set => soNuocThuc = value; }
        public decimal DonGiaDien { get => donGiaDien; set => donGiaDien = value; }
        public decimal DonGiaNuoc { get => donGiaNuoc; set => donGiaNuoc = value; }
        public decimal TienThuDien { get => tienThuDien; set => tienThuDien = value; }
        public decimal TienThuNuoc { get => tienThuNuoc; set => tienThuNuoc = value; }
        public decimal PhiDichVu { get => phiDichVu; set => phiDichVu = value; }
        public decimal Tong { get => tong; set => tong = value; }
        public string TenNguoiThu { get => tenNguoiThu; set => tenNguoiThu = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        #endregion

        #region Initialize
        public PhieuThuTienSH()
        {

        }

       
        #endregion
    }
}
