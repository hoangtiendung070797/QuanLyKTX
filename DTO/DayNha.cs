namespace DTO
{
    public class DayNha
    {
        #region Properties
        private int dayNhaId;
        private string tenDayNha;
        public string TenDayNha { get => tenDayNha; set => tenDayNha = value; }
        public int DayNhaId { get => dayNhaId; set => dayNhaId = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        private string ghiChu;
        #endregion


        #region Initialize
        public DayNha(string ten, string ghichu = "")
        {
            this.TenDayNha = ten;
            this.GhiChu = ghichu;
        }

        public DayNha()
        {

        }


        #endregion
    }
}
