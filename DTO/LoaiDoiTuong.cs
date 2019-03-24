namespace DTO
{
    public class LoaiDoiTuong
    {
        #region Properties
        private int loaiDoiTuongId;
        private string tenLoaiDoiTuong;
        public string TenLoaiDoiTuong { get => tenLoaiDoiTuong; set => tenLoaiDoiTuong = value; }
        public int LoaiDoiTuongId { get => loaiDoiTuongId; set => loaiDoiTuongId = value; }
        #endregion


        #region Initialize
        public LoaiDoiTuong(int loaiDoiTuongId, string TenLoaiDoiTuong)
        {
            this.LoaiDoiTuongId = loaiDoiTuongId;
            this.TenLoaiDoiTuong = tenLoaiDoiTuong;
            
        }
        #endregion
    }
}
