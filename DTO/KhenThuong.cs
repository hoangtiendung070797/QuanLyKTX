using System;

namespace DTO
{
    public class KhenThuong
    {
        #region Properties
        private int khenThuongId;
        private int doiTuongId;
    

        private string tenKhenThuong;
        private DateTime ngay;
        private string noiDung;
        private string ghiChu;

        
        public int DoiTuongId { get => doiTuongId; set => doiTuongId = value; }
        public string TenKhenThuong { get => tenKhenThuong; set => tenKhenThuong = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int KhenThuongId { get => khenThuongId; set => khenThuongId = value; }

        #endregion


        #region Initialize  
        public KhenThuong()
        {
        }
        #endregion
    }
}
