namespace DTO
{
    public class VatTu
    {
        #region Properties
        private string vatTuId;
        private string tenVatTu;
        private string moTa;
        private int soLuong;
        private string ghiChu;
        public string VatTuId { get => vatTuId; set => vatTuId = value; }
        public string TenVatTu { get => tenVatTu; set => tenVatTu = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }


        #endregion


        #region Initialize
        public VatTu(string id, string ten, string mota, int soluong, string ghichu)
        {
            this.VatTuId = id;
            this.TenVatTu = ten;
            this.MoTa = mota;
            this.SoLuong = soluong;
            this.GhiChu = ghichu;
        }

        #endregion
    }
}
