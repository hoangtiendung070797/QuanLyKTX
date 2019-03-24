namespace DTO
{
    public class ChiTietPhieuCapPhatVatTu
    {
        #region Properties
        private int chiTietPhieuCapPhatVatTuId;
        private int phieuCapPhatVatTuId;
        private string vatTuId;

        private string PhongId;
        private int soLuong;
        private string donViTinh;

        private string tinhTrang;
        private int tyLeHoatDong;

        private decimal donGiaVatTu;
        private decimal thanhTien;
        private string ghiChu;

        public int PhieuCapPhatVatTuId { get => phieuCapPhatVatTuId; set => phieuCapPhatVatTuId = value; }
        public string VatTuId { get => vatTuId; set => vatTuId = value; }
        public string PhongId1 { get => PhongId; set => PhongId = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int TyLeHoatDong { get => tyLeHoatDong; set => tyLeHoatDong = value; }
        public decimal DonGiaVatTu { get => donGiaVatTu; set => donGiaVatTu = value; }
        public decimal ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int ChiTietPhieuCapPhatVatTuId { get => chiTietPhieuCapPhatVatTuId; set => chiTietPhieuCapPhatVatTuId = value; }
        #endregion

        #region Initialize
        public ChiTietPhieuCapPhatVatTu()
        {

        }

      
        #endregion
    }
}
