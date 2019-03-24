namespace DTO
{
    public class QuocTich
    {
        #region Properties
        private int quocTichId;
        private string tenQuocTich;
        public int QuocTichId { get => quocTichId; set => quocTichId = value; }
        public string TenQuocTich { get => tenQuocTich; set => tenQuocTich = value; }
        #endregion
        #region Initialize
        public QuocTich(int QuocTichId, string tenQuocTich)
        {
            this.QuocTichId = QuocTichId;
            this.TenQuocTich = tenQuocTich;
        }

      
        #endregion
    }
}
