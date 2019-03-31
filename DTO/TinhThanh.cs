namespace DTO
{
    public class TinhThanh
    {
        #region Properties
        private int tinhThanhId;
        private string tenTinhThanh;
        public int TinhThanhId { get => tinhThanhId; set => tinhThanhId = value; }
        public string TenTinhThanh { get => tenTinhThanh; set => tenTinhThanh = value; }

        #endregion
        #region Initialize
        public TinhThanh(int TinhThanhId, string tenTinhThanh)
        {
            this.TinhThanhId = TinhThanhId;
            this.TenTinhThanh = tenTinhThanh;
        }

       public TinhThanh() { }

        #endregion
    }
}
