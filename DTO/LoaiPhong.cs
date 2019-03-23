namespace DTO
{
    public class LoaiPhong
    {
        #region Properties
        private int loaiPhongId;
        private string tenLoaiPhong;
        private int soLuongtoiDa;
        private decimal giaLoaiPhong;

        public int LoaiPhongId { get => loaiPhongId; set => loaiPhongId = value; }
        public string TenLoaiPhong { get => tenLoaiPhong; set => tenLoaiPhong = value; }
        public int SoLuongtoiDa { get => soLuongtoiDa; set => soLuongtoiDa = value; }
        public decimal GiaLoaiPhong { get => giaLoaiPhong; set => giaLoaiPhong = value; }

        #endregion


        #region Initialize
        public LoaiPhong(int id, string ten, int sl, decimal gia)
        {
            this.LoaiPhongId = id;
            this.TenLoaiPhong = ten;
            this.SoLuongtoiDa = sl;
            this.GiaLoaiPhong = gia;
        }

   




        #endregion
    }
}
