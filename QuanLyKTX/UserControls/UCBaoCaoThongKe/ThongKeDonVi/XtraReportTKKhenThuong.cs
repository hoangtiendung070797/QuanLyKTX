using DevExpress.XtraGrid;

namespace QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeKhenThuong_KyLuat
{
    public partial class XtraReportTKKhenThuong : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportTKKhenThuong()
        {
            InitializeComponent();
            
        }
        public void SetLabel(string text)
        {
            this.xrLabel8.Text = text;
        }

        private GridControl control;
        public GridControl GridControl
        {
            get
            {
                return control;
            }
            set
            {
                control = value;
                printableComponentContainer1.PrintableComponent = control;
            }
        }
        public GridControl GridControl1 { get; internal set; }
    }
}
