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

namespace QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeSinhVienTheoDSPhong
{
    public partial class UCTKSinhVienTheoDSPhong : UserControl
    {
        public UCTKSinhVienTheoDSPhong()
        {
            InitializeComponent();
            LoadData();
        }
        BUS_Phong BUS_Phong = new BUS_Phong();
        BUS_DayNha BUS_DayNha = new BUS_DayNha();
        public void LoadData()
        {
            cmbPhong.DataSource = BUS_Phong.GetData();
            cmbPhong.ValueMember = "PhongId";
            cmbPhong.DisplayMember = "tenPhong";
            cmbDayNha.DataSource = BUS_DayNha.GetData();
            cmbDayNha.ValueMember = "DayNhaId";
            cmbDayNha.DisplayMember = "tenDayNha";
            gridControl1.DataSource = BUS_Phong.GetDataSinhVienTheoPhong();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = BUS_Phong.GetSinhVienTheoPhong(cmbPhong.SelectedValue==null?"": cmbPhong.SelectedValue.ToString(), cmbDayNha.SelectedValue==null?0: (int)cmbDayNha.SelectedValue);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            gridView1.BestFitColumns();
            XtraReportTKSinhVienTheoPhong report = new XtraReportTKSinhVienTheoPhong();
            string Ngay = DateTime.Now.Day.ToString();
            string Thang = DateTime.Now.Month.ToString();
            string Nam = DateTime.Now.Year.ToString();
            report.SetLabel(" Hải Phòng, ngày " + Ngay + " tháng " + Thang + " năm " + Nam);
            report.GridControl = gridView1.GridControl;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}

