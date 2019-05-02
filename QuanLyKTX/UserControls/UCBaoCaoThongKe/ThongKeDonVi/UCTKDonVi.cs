using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraReports.UI;

namespace QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeDonVi
{
    public partial class UCTKDonVi : UserControl
    {
        public UCTKDonVi()
        {
            InitializeComponent();
            LoadData();
        }
        BUS_DonVi BUS_Donvi = new BUS_DonVi();

        public void LoadData()
        {
            cmbDonVi.DataSource = BUS_Donvi.GetData();
            cmbDonVi.ValueMember = "DonViId";
            cmbDonVi.DisplayMember = "tenDonvi";
            gridControl1.DataSource = BUS_Donvi.GetDataDonVi();
        }


        private void btnIn_Click(object sender, EventArgs e)
        {
            gridView1.BestFitColumns();
            XtraReportTKDonVi report = new XtraReportTKDonVi();
            report.GridControl = gridView1.GridControl;
            string Ngay = DateTime.Now.Day.ToString();
            string Thang = DateTime.Now.Month.ToString();
            string Nam = DateTime.Now.Year.ToString();
            report.SetLabel(" Hải Phòng, ngày " + Ngay + " tháng " + Thang + " năm " + Nam);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = BUS_Donvi.GetSinhVienTheoDonVi(cmbDonVi.SelectedValue==null?0: (int)cmbDonVi.SelectedValue);
        }

        private void simpleButtonHuyLoc_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
