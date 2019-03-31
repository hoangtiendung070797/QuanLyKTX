namespace DTO
{
    public class DanToc
    {
        #region  Properties
        private int danTocId;
        private string tenDanToc;

        public int DanTocId { get => danTocId; set => danTocId = value; }
        public string TenDanToc { get => tenDanToc; set => tenDanToc = value; }

        #endregion

        #region Initialize
        public DanToc()
        {

        }
        public DanToc(int id,string name)
        {
            this.DanTocId = id;
            this.TenDanToc = name;
        }
        #endregion

    }
}
