using BUS;
using DevExpress.XtraReports.UI;
using QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeKhenThuong_KyLuat;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeKhenThuong
{
    public partial class UCTKKhenThuongKyLuat : UserControl
    {
        public UCTKKhenThuongKyLuat()
        {
            InitializeComponent();
            LoadData();
        }
        BUS_KhenThuong BUS_KhenThuong = new BUS_KhenThuong();
        BUS_KyLuat BUS_KyLuat = new BUS_KyLuat();

        public void LoadData()
        {
            gridControl1.DataSource = null;
        }


        private void BtnIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonKhenThuong.Checked == true)
                {
                    gridView1.BestFitColumns();
                    XtraReportTKKhenThuong report = new XtraReportTKKhenThuong();
                    report.GridControl = gridView1.GridControl;
                    string Ngay = DateTime.Now.Day.ToString();
                    string Thang = DateTime.Now.Month.ToString();
                    string Nam = DateTime.Now.Year.ToString();
                    report.SetLabel(" Hải Phòng, ngày " + Ngay + " tháng " + Thang + " năm " + Nam);
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreviewDialog();
                }
                else if (radioButtonKyLuat.Checked == true)
                {
                    gridView1.BestFitColumns();
                    XtraReportKyLuat report = new XtraReportKyLuat();
                    string Ngay = DateTime.Now.Day.ToString();
                    string Thang = DateTime.Now.Month.ToString();
                    string Nam = DateTime.Now.Year.ToString();
                    report.SetLabel(" Hải Phòng, ngày " + Ngay + " tháng " + Thang + " năm " + Nam);
                    report.GridControl = gridView1.GridControl;
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreviewDialog();
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn mục in báo cáo, vui lòng chọn báo cáo khen thưởng hoặc kỷ luật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButtonKhenThuong.Focus();
            }
        }

        private void simpleButtonHuyLoc_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            radioButtonKhenThuong.Checked = false;
            radioButtonKyLuat.Checked = false;
        }

        private void simpleButtonLoc_Click(object sender, EventArgs e)
        {
            if (radioButtonKhenThuong.Checked == true)
            {
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                gridControl1.DataSource = BUS_KhenThuong.GetSinhVienTheoKhenThuong();
            }
            else if (radioButtonKyLuat.Checked == true)
            {
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                gridControl1.DataSource = BUS_KyLuat.GetSinhVienTheoKyLuat();
            }
        }
    }
}

