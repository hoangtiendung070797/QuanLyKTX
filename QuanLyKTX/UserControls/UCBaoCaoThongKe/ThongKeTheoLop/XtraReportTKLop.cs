using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;

namespace QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeTheoLop
{
    public partial class XtraReportTKLop : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportTKLop()
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
    }
}
