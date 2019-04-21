using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls.UCHeThong
{
    public partial class UCNhanVien : UserControl
    {
        public UCNhanVien()
        {
            InitializeComponent();
        }

        BUS_NhanVien bUS_nhanvien = new BUS_NhanVien();
        int chucnang = 0;

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            reset();            
        }

        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã nhân viên";
            gridView1.Columns[1].Caption = "Tên nhân viên";
            gridView1.Columns[2].Caption = "SĐT";
            gridView1.Columns[3].Caption = "Email";
            gridView1.Columns[4].Caption = "Ngày sinh";
            gridView1.Columns[5].Caption = "chức vụ";
            gridView1.Columns[6].Caption = "Địa chỉ";
            gridView1.Columns[7].Caption = "Phụ trách";
        }

        void display()
        {
            gridControl1.DataSource = bUS_nhanvien.GetData();
            FixNColumnNames();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtChucVu.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
            txtdiachi.Enabled = false;
            txtPhuTrach.Enabled = false;

            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtChucVu.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtPhuTrach.Text = "";
            txtdiachi.Text = "";

            display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            reset();
            chucnang = 1;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenNV.Enabled = true;
            txtChucVu.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;
            txtdiachi.Enabled = true;
            txtPhuTrach.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenNV.Enabled = true;
            txtChucVu.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;
            txtdiachi.Enabled = true;
            txtPhuTrach.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_nhanvien.Delete(int.Parse(txtMaNV.Text)))
                    {
                        MessageBox.Show("Xóa thành công!");
                        reset();
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Xóa thành công nhân viên: " + txtTenNV.Text + " ra khỏi hệ thống";
                        nhatKy.ThaoTac = "Xóa";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Nhân viên";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                    }
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" || txtSDT.Text == "" || txtChucVu.Text == ""|| txtEmail.Text==""|| txtdiachi.Text==""||txtPhuTrach.Text=="")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                if (txtTenNV.Text == "") errorProvider1.SetError(txtTenNV, "Chưa điền tên.");
                if (txtChucVu.Text == "") errorProvider1.SetError(txtChucVu, "Chưa điền thông tin.");
                if (txtSDT.Text == "") errorProvider1.SetError(txtSDT, "Chưa điền thông tin.");
                if (txtEmail.Text == "") errorProvider1.SetError(txtEmail, "Chưa điền tên.");
                if (txtdiachi.Text == "") errorProvider1.SetError(txtdiachi, "Chưa điền thông tin.");
                if (txtPhuTrach.Text == "") errorProvider1.SetError(txtPhuTrach, "Chưa điền thông tin.");
            }
            else
            {
                NhanVien nhanvien = new NhanVien();

                if (chucnang == 1)
                {
                    nhanvien.TenNhanVien = txtTenNV.Text;
                    nhanvien.ChucVu = txtChucVu.Text;
                    nhanvien.Sdt = txtSDT.Text;
                    nhanvien.PhuTrach = txtPhuTrach.Text;
                    nhanvien.DiaChi = txtdiachi.Text;
                    nhanvien.Email = txtEmail.Text;
                    nhanvien.NgaySinh = (DateTime)dpkNgaySinh.Value;
                    if (bUS_nhanvien.Insert(nhanvien))
                    {
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");

                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Thêm thành công nhân viên: " + txtTenNV.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Tạo";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Nhân viên";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                    }
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    nhanvien.NhanVienId = int.Parse(txtMaNV.Text);
                    nhanvien.TenNhanVien = txtTenNV.Text;
                    nhanvien.ChucVu = txtChucVu.Text;
                    nhanvien.Sdt = txtSDT.Text;
                    nhanvien.PhuTrach = txtPhuTrach.Text;
                    nhanvien.DiaChi = txtdiachi.Text;
                    nhanvien.Email = txtEmail.Text;
                    nhanvien.NgaySinh = (DateTime)dpkNgaySinh.Value;
                    if (bUS_nhanvien.Update(nhanvien))
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Cập nhập thành công nhân viên: " + txtTenNV.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Cập nhập";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Nhân viên";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                    }
                    else MessageBox.Show("cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaNV.Text = gridView1.GetRowCellValue(e.RowHandle, "NhanVienID").ToString();
            txtTenNV.Text = gridView1.GetRowCellValue(e.RowHandle, "tenNhanVien").ToString();
            dpkNgaySinh.Text = gridView1.GetRowCellValue(e.RowHandle, "ngaySinh").ToString();
            txtChucVu.Text = gridView1.GetRowCellValue(e.RowHandle, "chucVu").ToString();
            txtSDT.Text = gridView1.GetRowCellValue(e.RowHandle, "sdt").ToString();
            txtEmail.Text = gridView1.GetRowCellValue(e.RowHandle, "email").ToString();
            txtdiachi.Text = gridView1.GetRowCellValue(e.RowHandle, "diaChi").ToString();
            txtPhuTrach.Text = gridView1.GetRowCellValue(e.RowHandle, "phuTrach").ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
