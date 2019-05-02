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
using QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeTheoLop;
using DevExpress.XtraReports.UI;

namespace QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeTheoDanhSachPhong
{
    public partial class UCTKLop : UserControl
    {
        public UCTKLop()
        {
            InitializeComponent();
            LoadData();
        }

        BUS_Lop BUS_Lop = new BUS_Lop();
        private void UCTKLop_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadData()
        {
            cmbLop.DataSource = BUS_Lop.GetData();
            cmbLop.ValueMember = "LopId";
            cmbLop.DisplayMember = "tenLop";
            gridControl1.DataSource = BUS_Lop.GetDataLop();
        }

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
       
            gridControl1.DataSource = BUS_Lop.GetSinhVienTheoLop(cmbLop.SelectedValue == null ? 0 : (int)cmbLop.SelectedValue);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadData();          
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            gridView1.BestFitColumns();
            XtraReportTKLop report = new XtraReportTKLop();
            report.GridControl = gridView1.GridControl;
            string Ngay = DateTime.Now.Day.ToString();
            string Thang = DateTime.Now.Month.ToString();
            string Nam = DateTime.Now.Year.ToString();
            report.SetLabel(" Hải Phòng, ngày " + Ngay + " tháng " + Thang + " năm " + Nam);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
