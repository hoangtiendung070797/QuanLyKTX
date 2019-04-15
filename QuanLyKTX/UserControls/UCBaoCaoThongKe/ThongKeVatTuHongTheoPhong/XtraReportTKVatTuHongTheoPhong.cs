﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;

namespace QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeVatTuHongTheoPhong
{
    public partial class XtraReportTKVatTuHongTheoPhong : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportTKVatTuHongTheoPhong()
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
