using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;

namespace QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeVatTuTheoPhong
{
    public partial class XtraReportVatTuTheoPhong : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportVatTuTheoPhong()
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
