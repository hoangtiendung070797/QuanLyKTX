using QuanLyKTX.Support;
using System.Data;

namespace QuanLyKTX.UserControls.UCInHoaDon.HoaDonThuTienSH
{
    public partial class XtraReportHoaDonThuTienSH : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportHoaDonThuTienSH()
        {
            InitializeComponent();
        }
        ReadNumber readNumber = new ReadNumber();
        public void SetAllProperty(DataTable table)
        {
            
        }


    }
}
