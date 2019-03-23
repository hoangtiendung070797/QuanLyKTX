namespace DTO
{
    public class LoiViPham
    {
        #region Properties
        private int loiViPhamId;
        private string tenLoiViPham;
        private string noiDung;
        private string hinhThucXuLy;
        private string ghiChu;

        public int LoiViPhamId { get => loiViPhamId; set => loiViPhamId = value; }
        public string TenLoiViPham { get => tenLoiViPham; set => tenLoiViPham = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string HinhThucXuLy { get => hinhThucXuLy; set => hinhThucXuLy = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        #endregion


        #region Initialize
        public LoiViPham(int id, string ten, string noidung, string hinhthuc, string ghichu = "")
        {
            this.LoiViPhamId = id;
            this.TenLoiViPham = ten;
            this.NoiDung = noidung;
            this.HinhThucXuLy = hinhthuc;
            this.GhiChu = ghichu;
        }

      

        #endregion
    }
}
