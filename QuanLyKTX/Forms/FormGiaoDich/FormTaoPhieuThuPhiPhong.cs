using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKTX.Forms.FormGiaoDich
{
    public partial class FormTaoPhieuThuPhiPhong : Form
    {
        #region Properties
        BUS_PhieuThuTienPhong BUS_PhieuThuTienPhong = new BUS_PhieuThuTienPhong();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        int DoiTuongId = 0;
        BUS_NguoiDung BUS_NguoiDung = new BUS_NguoiDung();
        BUS_DoiTuong BUS_DoiTuong = new BUS_DoiTuong();
        #endregion
        public FormTaoPhieuThuPhiPhong()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler eventTaoPhieuDone = null;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(DoiTuongId!= 0 && checkTime((DateTime)dteTuNgay.EditValue, (DateTime)dteDenNgay.EditValue))
            {
                PhieuThuTienPhong phieuThuTienPhong = new PhieuThuTienPhong();
                phieuThuTienPhong.DoiTuongId = DoiTuongId;
                phieuThuTienPhong.NguoiDungId = Const.CurrentUser.NguoiDungId;
                phieuThuTienPhong.NhanVienId = (int)cbbNhanVien.SelectedValue;
                phieuThuTienPhong.TenNguoiLap = cbbNhanVien.SelectedText;
                phieuThuTienPhong.NgayThu = (DateTime)dteNgayThu.EditValue;
                phieuThuTienPhong.TuNgay = (DateTime)dteTuNgay.EditValue;
                phieuThuTienPhong.DenNgay = (DateTime)dteDenNgay.EditValue;
                phieuThuTienPhong.GhiChu = txtGhiChu.Text;
                phieuThuTienPhong.TienThu = int.Parse(txtTienThu.Text);
                phieuThuTienPhong.TinhTrang = (cbTinhTrang.Checked) ? true : false;

    

                if (BUS_PhieuThuTienPhong.Insert(phieuThuTienPhong))
                    MessageBox.Show("Thêm thành công!");
                else
                    MessageBox.Show("Thất bại!");
                DoiTuongId = 0;

                eventTaoPhieuDone(sender, e);
            }
            else
            {
                DoiTuongId = 0;
                MessageBox.Show("Bạn cần chọn đối tượng để tạo phiếu!");
            }


        }

        private void FormTaoPhieuThuPhiPhong_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BUS_DoiTuong.GetData();

            //cbbNguoiDung.DataSource = BUS_NguoiDung.GetData();
            //cbbNguoiDung.DisplayMember = "tenNguoiDung";
            //cbbNguoiDung.ValueMember = "NguoiDungId";

            cbbNguoiDung.SelectedText = Const.CurrentUser.TenDangNhap;

            cbbNhanVien.DataSource = BUS_NhanVien.GetData();
            cbbNhanVien.DisplayMember = "tenNhanVien";
            cbbNhanVien.ValueMember = "NhanVienId";

            txtTenNguoiLap.Text = cbbNhanVien.Text;
            txtTenNguoiLap.Enabled = false;

            //load thuộc tính mặc định
            dteTuNgay.EditValue = Properties.Settings.Default.TuNgay;
            dteDenNgay.EditValue = Properties.Settings.Default.DenNgay;

        }

        public bool checkTime(DateTime date1,DateTime date2)
        {
            TimeSpan timeSpan = date2 - date1;
            return (timeSpan.TotalDays) > 0 ? true : false;
        }

        private void dteTuNgay_EditValueChanged(object sender, EventArgs e)
        {
            if (!checkTime((DateTime)dteTuNgay.EditValue, (DateTime)dteDenNgay.EditValue))
            {
                errorProvider1.SetError(dteDenNgay, "Thời gian này bị sai trình tự!");
                dteTuNgay.Reset();
                dteDenNgay.Reset();
                dteTuNgay.Focus();
            }
                
        }

        private void txtTienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNguoiLap.Text = cbbNhanVien.Text;
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cardView1_Click(object sender, EventArgs e)
        {
            if (cardView1.IsFindPanelVisible)
                cardView1.HideFindPanel();
            else cardView1.ShowFindPanel();

            DataRow row = cardView1.GetFocusedDataRow();

            DoiTuongId = (int)row["DoiTuongId"];
            groupControl2.Text = "Đối tượng - đang chọn " + row["hoDem"].ToString() + " " + row["ten"].ToString() + " MSV: " + row["maSinhVien"].ToString();
        }
    }
}
