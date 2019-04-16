using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLyKTX.Support;
using System.Data;

namespace QuanLyKTX.UserControls.UCInHoaDon.HoaDonThuTienPhong
{
    public partial class XtraReportHoaDonThuTienPhong : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportHoaDonThuTienPhong()
        {
            InitializeComponent();
        }
        ReadNumber readNumber = new ReadNumber();
        public void SetAllProperty(DataTable table)
        {
            if (table != null)
            {
                xrLabelTenNguoiLap.Text = table.Rows[0][0].ToString();
                xrLabelDienThoai.Text = table.Rows[0][1].ToString();
                xrLabelTenNguoiNop.Text = table.Rows[0][2].ToString();
                xrLabelMaSinhVien.Text = table.Rows[0][3].ToString();
               
                xrLabelTuNgay.Text = table.Rows[0][4].ToString();
                xrLabelDenNgay.Text = table.Rows[0][5].ToString();
                xrLabelSoTienThu.Text = table.Rows[0][6].ToString() + " VNĐ";
                xrLabelVietBangChu.Text = readNumber.NumberToText(table.Rows[0][6].ToString());

                string Ngay = DateTime.Now.Day.ToString();
                string Thang = DateTime.Now.Month.ToString();
                string Nam = DateTime.Now.Year.ToString();
                xrLabelNgayLap.Text = "Ngày " + Ngay + " tháng " + Thang + " năm " + Nam;

            }
        }
    }
}
