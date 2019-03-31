namespace DTO
{
    public class TonGiao
    {
        #region Properties
        private int tonnGiaoId;
        private string tenTonGiao;
        public int TonnGiaoId { get => tonnGiaoId; set => tonnGiaoId = value; }
        public string TenTonGiao { get => tenTonGiao; set => tenTonGiao = value; }
        #endregion
        #region Initialize
        public TonGiao(int TonGiaoId, string tenDonVi)
        {
            this.TonnGiaoId = TonGiaoId;
            this.TenTonGiao = tenDonVi;
        }
        public TonGiao() { }
        #endregion
    }
}
