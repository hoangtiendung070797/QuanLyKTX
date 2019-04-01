namespace DTO
{
    public class Lop
    {
        #region Properties
        private int lopId;
        private string tenLop;
        private int donViId;

        public int LopId { get => lopId; set => lopId = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int DonViId { get => donViId; set => donViId = value; }

        #endregion

        #region Initialize
        public Lop(int lopId, string tenLop, int donViId = 0)
        {
            this.LopId = lopId;
            this.TenLop = tenLop;
            this.DonViId = donViId;
        }
        public Lop()
        {

        }
        #endregion
    }
}
