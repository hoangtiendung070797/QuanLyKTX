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
using QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeVatTuTheoPhong;
using DevExpress.XtraReports.UI;

namespace QuanLyKTX.UserControls.UCBaoCaoThongKe
{
    public partial class UCTKVatTuTheoPhong : UserControl
    {
        public UCTKVatTuTheoPhong()
        {
            InitializeComponent();
            LoadData();
        }

        BUS_ChiTietPhieuCapPhatVatTu BUS_ChiTietPhieuCapPhatVatTu = new BUS_ChiTietPhieuCapPhatVatTu();
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
            gridControl1.DataSource = BUS_ChiTietPhieuCapPhatVatTu.GetDataVatTuTheoPhong();
        }


        private void BtnIn_Click(object sender, EventArgs e)
        {
            gridView1.BestFitColumns();
            XtraReportVatTuTheoPhong report = new XtraReportVatTuTheoPhong();
            report.GridControl = gridView1.GridControl;
            string Ngay = DateTime.Now.Day.ToString();
            string Thang = DateTime.Now.Month.ToString();
            string Nam = DateTime.Now.Year.ToString();
            report.SetLabel(" Hải Phòng, ngày " + Ngay + " tháng " + Thang + " năm " + Nam);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void SimpleButtonHuyLoc_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void SimpleButtonLoc_Click(object sender, EventArgs e)
        {

            gridControl1.DataSource = BUS_ChiTietPhieuCapPhatVatTu.GetVatTuTheoPhong(cmbPhong.SelectedValue==null?"": cmbPhong.SelectedValue.ToString(), cmbDayNha.SelectedValue==null?0: (int)cmbDayNha.SelectedValue);
        }

    }
}
