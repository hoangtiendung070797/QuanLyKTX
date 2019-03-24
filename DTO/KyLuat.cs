using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KyLuat
    {
        #region Properties
        private int kyLuatId;
        private int doiTuongId;


        private string tenKyLuat;
        private DateTime ngay;
        private string noiDung;
        private string ghiChu;


        public int DoiTuongId { get => doiTuongId; set => doiTuongId = value; }
       
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int KyLuatId { get => kyLuatId; set => kyLuatId = value; }
        public string TenKyLuat { get => tenKyLuat; set => tenKyLuat = value; }


        #endregion


        #region Initialize  
        public KyLuat()
        {
        }
        #endregion

    }
}
