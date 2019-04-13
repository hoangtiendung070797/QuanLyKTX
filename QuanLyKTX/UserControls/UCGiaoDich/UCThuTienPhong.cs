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
using QuanLyKTX.Forms;

namespace QuanLyKTX.UserControls.UCGiaoDich
{
    public partial class UCThuTienPhong : UserControl
    {
        public UCThuTienPhong()
        {
            InitializeComponent();
        }
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_PhieuThuTienPhong BUS_PhieuThuTienPhong = new BUS_PhieuThuTienPhong();

        private void UCThuTienPhong_Load(object sender, EventArgs e)
        {
            cmbNhanVien.DataSource = BUS_NhanVien.GetData();
            cmbNhanVien.DisplayMember = "tenNhanVien";
            cmbNhanVien.ValueMember = "NhanVienId";
            cmbTaiKhoan.Text = Const.CurrentUser.TenDangNhap;
            cmbTaiKhoan.Enabled = false;
            dateNgayLapPhieu.EditValue = DateTime.Now;
            dateTuNgay.EditValue = DateTime.Now;
            dateDenNgay.EditValue = DateTime.Now;

            gridControl1.DataSource = BUS_PhieuThuTienPhong.GetData();
            gridView1.Columns[4].Visible = false;
        }

        private void btnTaoDanhSachPhieuKy_Click(object sender, EventArgs e)
        {
            
        }

        public void CreateFeeEmpty(DateTime tuNgay, DateTime denNgay)
        {
            //kiểm tra các đối tượng chưa tạo bản ghi dựa vào DoiTuongId + tuNgay + denNgay


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormDSThuTienPhong formDSThuTienPhong = new FormDSThuTienPhong();
            formDSThuTienPhong.Show();

        }
    }
}
