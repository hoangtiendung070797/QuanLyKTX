using QuanLyKTX.Support;
using System;
using System.Data;

namespace QuanLyKTX.UserControls.UCInHoaDon.HoaDonThuTienSH
{
    public partial class XtraReportHoaDonThuTienSH : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportHoaDonThuTienSH()
        {
            InitializeComponent();
        }
        ReadNumber readNumber = new ReadNumber();
        public void SetAllProperty(DataTable table)
        {
            xrLabelTenNguoiLap.Text = table.Rows[0][0].ToString();
            xrLabelDienThoai.Text = table.Rows[0][1].ToString();
            xrLabelTenPhong.Text = table.Rows[0][2].ToString();
            xrLabelPhiDichVu.Text = table.Rows[0][3].ToString() + " VNĐ";
            xrLabelSoNuocDau.Text = table.Rows[0][4].ToString();
            xrLabelSoDienDau.Text = table.Rows[0][5].ToString();
            xrLabelSoNuocCuoi.Text = table.Rows[0][6].ToString();
            xrLabelSoDienCuoi.Text = table.Rows[0][7].ToString();
            xrLabelSoNuoc.Text = table.Rows[0][8].ToString();
            xrLabelSoDien.Text = table.Rows[0][9].ToString();
            xrLabelDonGiaNuoc.Text = table.Rows[0][10].ToString() + " VNĐ";
            xrLabelDonGiaDien.Text = table.Rows[0][11].ToString() + " VNĐ";
            xrLabelTongTien.Text = table.Rows[0][12].ToString() + " VNĐ";
            xrLabelVietBangChu.Text = readNumber.NumberToText(table.Rows[0][12].ToString());
            string Ngay = DateTime.Now.Day.ToString();
            string Thang = DateTime.Now.Month.ToString();
            string Nam = DateTime.Now.Year.ToString();
            xrLabelNgayLap.Text = "Ngày " + Ngay + " tháng " + Thang + " năm " + Nam;

        }


    }
}
