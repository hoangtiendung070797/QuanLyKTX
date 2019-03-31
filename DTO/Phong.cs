namespace DTO
{
    public class Phong
    {
        private string phongId;
        private int dayNhaId;

        private int loaiPhongId;
        private string tenPhong;
        private int tang;
        private decimal giaPhong;

        public string PhongId { get => phongId; set => phongId = value; }
        public int DayNhaId { get => dayNhaId; set => dayNhaId = value; }
        public int LoaiPhongId { get => loaiPhongId; set => loaiPhongId = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int Tang { get => tang; set => tang = value; }
        public decimal GiaPhong { get => giaPhong; set => giaPhong = value; }


        public Phong(string id,int dayNhaId,int loaiPhongId,string tenPhong, int tang, decimal giaPhong)
        {
            this.PhongId = id;
            this.DayNhaId = dayNhaId;
            this.LoaiPhongId = loaiPhongId;
            this.TenPhong = tenPhong;
            this.Tang = tang;
            this.GiaPhong = giaPhong;
        }
        public Phong()
        {

        }

    }
}
