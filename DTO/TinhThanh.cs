using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhThanh
    {
        #region Properties
        private int tinhThanhId;
        private string tenTinhThanh;
        public int TinhThanhId { get => tinhThanhId; set => tinhThanhId = value; }
        public string TenTinhThanh { get => tenTinhThanh; set => tenTinhThanh = value; }

        #endregion
        #region Initialize
        public TinhThanh(int TinhThanhId, string tenTinhThanh)
        {
            this.TinhThanhId = TinhThanhId;
            this.TenTinhThanh = tenTinhThanh;
        }

       

        #endregion
    }
}
