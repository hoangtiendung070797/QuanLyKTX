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

namespace QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKePhieuThuTienPhong
{
    public partial class UCTKThuTienPhong : UserControl
    {
        public UCTKThuTienPhong()
        {
            InitializeComponent();
            LoadData();
        }
        BUS_PhieuThuTienPhong BUS_PhieuThuTienPhong = new BUS_PhieuThuTienPhong();
        private void UCTKLop_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {         
            gridControl1.DataSource = BUS_PhieuThuTienPhong.GetDataPhieuThuTienPhong();
        }


        private void BtnIn_Click(object sender, EventArgs e)
        {
            gridView1.BestFitColumns();
            XtraReportTKThuTienPhong report = new XtraReportTKThuTienPhong();
            report.GridControl = gridView1.GridControl;
            string Ngay = DateTime.Now.Day.ToString();
            string Thang = DateTime.Now.Month.ToString();
            string Nam = DateTime.Now.Year.ToString();
            report.SetLabel(" Hải Phòng, ngày " + Ngay + " tháng " + Thang + " năm " + Nam);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void BtnLoc_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButtonLoc_Click(object sender, EventArgs e)
        {
            if (radioButtonDaThu.Checked == true)
                gridControl1.DataSource = BUS_PhieuThuTienPhong.GetSinhVienTheoTinhTrangPhieuThuTienPhong(1);
            else if (radioButtonChuaThu.Checked == true)
                gridControl1.DataSource = BUS_PhieuThuTienPhong.GetSinhVienTheoTinhTrangPhieuThuTienPhong(0);
        }
    }
}
