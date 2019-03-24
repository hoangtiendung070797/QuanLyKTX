namespace DTO
{
    public class ThuocViPham
    {
        #region Properties
        private int thuocViPhamId;
        private int kyLuatId;
        private int loiViPhamId;
        private int lanTaiPham;

        public int ThuocViPhamId { get => thuocViPhamId; set => thuocViPhamId = value; }
        public int KyLuatId { get => kyLuatId; set => kyLuatId = value; }
        public int LoiViPhamId { get => loiViPhamId; set => loiViPhamId = value; }
        public int LanTaiPham { get => lanTaiPham; set => lanTaiPham = value; }


        #endregion


        #region Initialize  
        public ThuocViPham()
        {
        }

        #endregion
    }
}
