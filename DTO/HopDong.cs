using System;

namespace DTO
{
    public class HopDong
    {
        #region Properties
        private int hopDongId;
        private string tenHopDong;
        private DateTime tuNgay;
        private DateTime denNgay;
        private int thoiHanTheoNam;
        private int thoiHanTheoThang;
        private string noiDung;
        private int doiTuongId;

        public int HopDongId { get => hopDongId; set => hopDongId = value; }
        public string TenHopDong { get => tenHopDong; set => tenHopDong = value; }
        public DateTime TuNgay { get => tuNgay; set => tuNgay = value; }
        public DateTime DenNgay { get => denNgay; set => denNgay = value; }
        public int ThoiHanTheoNam { get => thoiHanTheoNam; set => thoiHanTheoNam = value; }
        public int ThoiHanTheoThang { get => thoiHanTheoThang; set => thoiHanTheoThang = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public int DoiTuongId { get => doiTuongId; set => doiTuongId = value; }
        #endregion


        #region Initialize
        public HopDong(int hopDongId, string tenHopDong, DateTime tuNgay, DateTime denNgay, int thoiHanTheoNam, int thoiHanTheoThang, string noiDung,int doiTuongId)
        {
            this.HopDongId = hopDongId;
            this.TenHopDong = tenHopDong;
            this.TuNgay = tuNgay;
            this.DenNgay = denNgay;
            this.ThoiHanTheoNam = thoiHanTheoNam;
            this.ThoiHanTheoThang = thoiHanTheoThang;
            this.NoiDung = noiDung;
            this.DoiTuongId = doiTuongId;
        }

       
        public HopDong()
        {

        }





        #endregion
    }
}
