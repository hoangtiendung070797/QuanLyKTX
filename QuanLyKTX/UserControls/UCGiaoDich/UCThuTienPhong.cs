using BUS;
using QuanLyKTX.Forms;
using QuanLyKTX.Forms.FormGiaoDich;
using System;
using System.Windows.Forms;

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
        int PhieuThuPhiPhongId = 0;
        private void UCThuTienPhong_Load(object sender, EventArgs e)
        {

            btnCapNhap.Visible = false; 
           
            cbbNhanVienThu.DataSource = BUS_NhanVien.GetData();
            cbbNhanVienThu.DisplayMember = "tenNhanVien";
            cbbNhanVienThu.ValueMember = "NhanVienId";
            

        

            gridControl1.DataSource = BUS_PhieuThuTienPhong.PrintInfo();
            //gridView1.Columns[0].Visible = false;

            //load từ properties
            txtPhiPhong4.Text = Properties.Settings.Default.PhiPhong4.ToString();
            txtPhiPhong6.Text = Properties.Settings.Default.PhiPhong6.ToString();
            txtPhiPhong8.Text = Properties.Settings.Default.PhiPhong8.ToString();
            dteTuNgay.EditValue = Properties.Settings.Default.TuNgay;
            dteDenNgay.EditValue = Properties.Settings.Default.DenNgay;

        }
        public void LoadAgainPhieuThu()
        {
            gridControl1.DataSource = BUS_PhieuThuTienPhong.PrintInfo();
            gridControl1.Refresh();
            gridView1.FocusedRowHandle = gridView1.RowCount -1;
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

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            FormTaoPhieuThuPhiPhong formTaoPhieuThuPhiPhong = new FormTaoPhieuThuPhiPhong();
            formTaoPhieuThuPhiPhong.eventTaoPhieuDone += FormTaoPhieuThuPhiPhong_eventTaoPhieuDone;
            formTaoPhieuThuPhiPhong.Show();
        }

        private void FormTaoPhieuThuPhiPhong_eventTaoPhieuDone(object sender, EventArgs e)
        {
            LoadAgainPhieuThu();
        }

        private void txtPhiPhong4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTaoPhieuTheoKy_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            PhieuThuPhiPhongId = (int)gridView1.GetRowCellValue(e.RowHandle, "PhieuThuTienPhongId");
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Chắc chắn muốn xóa?","Xóa phiếu",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BUS_PhieuThuTienPhong.Delete(PhieuThuPhiPhongId);
                LoadAgainPhieuThu();
            }
        }
    }
}
