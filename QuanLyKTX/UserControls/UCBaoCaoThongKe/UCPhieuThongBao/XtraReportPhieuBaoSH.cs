using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using QuanLyKTX.Support;

namespace QuanLyKTX.UserControls.UCPhieuThongBao
{
    public partial class XtraReportPhieuBaoSH : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportPhieuBaoSH()
        {
            InitializeComponent();
        }
        ReadNumber readNumber = new ReadNumber();
        public void SetAllProperty(DataTable table)
        {
            if (table != null)
            {
                xrLabelTenPhong.Text = table.Rows[0][0].ToString();
                xrLabelSoTienDien.Text = table.Rows[0][1].ToString() + " VNĐ"; 
                xrLabelSoTienNuoc.Text = table.Rows[0][2].ToString() + " VNĐ"; 
                xrLabelTienWifi.Text = table.Rows[0][3].ToString() + " VNĐ"; 
                xrLabelPhiMoiTruong.Text = table.Rows[0][4].ToString() + " VNĐ"; 
                xrLabelSoTienThu.Text = table.Rows[0][5].ToString() + " VNĐ";
                xrLabelVietBangChu.Text = readNumber.NumberToText(table.Rows[0][6].ToString());

                string Ngay = DateTime.Now.Day.ToString();
                string Thang = DateTime.Now.Month.ToString();
                string Nam = DateTime.Now.Year.ToString();
                xrLabelNgayLap.Text = "Ngày " + Ngay + " tháng " + Thang + " năm " + Nam;

            }
        }
    }
}
