using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCNguoiDung : UserControl
    {
        public UCNguoiDung()
        {
            InitializeComponent();
        }

        BUS_NguoiDung BUS_NguoiDung = new BUS_NguoiDung();
        int chucnang = 0;

        private void UCNguoiDung_Load(object sender, System.EventArgs e)
        {
            reset();
        }

        void display()
        {
            gridControl1.DataSource = BUS_NguoiDung.GetData();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtNguoidungID.Enabled = false;
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            txtHoTen.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;

            txtNguoidungID.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";

            display();
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtNguoidungID.Text = gridView1.GetRowCellValue(e.RowHandle, "NguoiDungId").ToString();
            txtTenDangNhap.Text = gridView1.GetRowCellValue(e.RowHandle, "tenDangNhap").ToString();
            txtMatKhau.Text = gridView1.GetRowCellValue(e.RowHandle, "matKhau").ToString();
            txtHoTen.Text = gridView1.GetRowCellValue(e.RowHandle, "tenDayDu").ToString();
            txtSDT.Text = gridView1.GetRowCellValue(e.RowHandle, "sdt").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(e.RowHandle, "diachi").ToString();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            chucnang = 1;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            txtHoTen.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            txtHoTen.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (txtNguoidungID.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (BUS_NguoiDung.Delete(int.Parse(txtNguoidungID.Text)))
                    {
                        MessageBox.Show("Xóa thành công!");
                        reset();
                    }
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo");
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == ""|| txtDiaChi.Text==""||txtHoTen.Text==""||txtSDT.Text=="")
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
            else
            {
                NguoiDung nguoidung = new NguoiDung();

                if (chucnang == 1)
                {
                    nguoidung.TenDangNhap = txtTenDangNhap.Text;
                    nguoidung.MatKhau = txtMatKhau.Text;
                    nguoidung.TenDayDu = txtTenDangNhap.Text;
                    nguoidung.Sdt = txtSDT.Text;
                    nguoidung.DiaChi = txtDiaChi.Text;

                    if (BUS_NguoiDung.Insert(nguoidung))
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    nguoidung.NguoiDungId = int.Parse(txtNguoidungID.Text);
                    nguoidung.TenDangNhap = txtTenDangNhap.Text;
                    nguoidung.MatKhau = txtMatKhau.Text;
                    nguoidung.TenDayDu = txtTenDangNhap.Text;
                    nguoidung.Sdt = txtSDT.Text;
                    nguoidung.DiaChi = txtDiaChi.Text;
                    if (BUS_NguoiDung.Update(nguoidung))
                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            reset();
        }
    }
}
