namespace DTO
{
    public class DonVi
    {
        #region Properties
        private int donViId;
        private string tenDonVi;
        private string diaChi;
        private string sdt;
        private string ghiChu;

        public int DonViId { get => donViId; set => donViId = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TenDonVi { get => tenDonVi; set => tenDonVi = value; }
        #endregion
        #region Initialize
        public DonVi(int DonViId, string tenDonVi, string diaChi = null, string sdt = null, string ghiChu = null)
        {
            this.DonViId = DonViId;
            this.TenDonVi = tenDonVi;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.GhiChu = ghiChu;
        }
        #endregion
        


    }
}
