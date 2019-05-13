using BUS;
using DAL;
using DTO;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCNguoiDung : UserControl
    {
        public UCNguoiDung()
        {
            InitializeComponent();
        }
        public string HashPassword(string pass)
        {

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }

        BUS_NguoiDung BUS_NguoiDung = new BUS_NguoiDung();
        int chucnang = 0;

        private void UCNguoiDung_Load(object sender, System.EventArgs e)
        {
            reset();
        }

        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "ID Người dùng";
            gridView1.Columns[1].Caption = "Tên đăng nhập";
            gridView1.Columns[2].Caption = "Mật khẩu";
            gridView1.Columns[3].Caption = "Họ tên";
            gridView1.Columns[4].Caption = "SĐT";
            gridView1.Columns[5].Caption = "Địa chỉ";
        }

        void display()
        {
            gridControl1.DataSource = BUS_NguoiDung.GetData();
            FixNColumnNames();
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
            reset();
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
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Xóa thành công user: " + txtTenDangNhap.Text + " ra khỏi hệ thống";
                        nhatKy.ThaoTac = "Xóa";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Người dùng";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        reset();
                    }
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo");
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
           

            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtDiaChi.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "")
            {
                
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                if (txtTenDangNhap.Text == "") errorProvider1.SetError(txtTenDangNhap, "Chưa điền tên đăng nhập.");
                if (txtMatKhau.Text == "") errorProvider1.SetError(txtMatKhau, "Chưa điền mật khẩu.");
                if (txtDiaChi.Text == "") errorProvider1.SetError(txtDiaChi, "Chưa điền địa chỉ.");
                if (txtHoTen.Text == "") errorProvider1.SetError(txtHoTen, "Chưa điền tên.");
                if (txtSDT.Text == "") errorProvider1.SetError(txtSDT, "Chưa điền sđt.");

            }
            else
            {
                NguoiDung nguoidung = new NguoiDung();

                if (chucnang == 1)
                {
                    nguoidung.TenDangNhap = txtTenDangNhap.Text;
                    nguoidung.MatKhau = HashPassword(txtMatKhau.Text);
                    nguoidung.TenDayDu = txtHoTen.Text;
                    nguoidung.Sdt = txtSDT.Text;
                    nguoidung.DiaChi = txtDiaChi.Text;
   
                    if (BUS_NguoiDung.Insert(nguoidung))
                    {
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");

                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Thêm thành công user: " + nguoidung.TenDangNhap + " vào hệ thống";
                        nhatKy.ThaoTac = "Tạo";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Người dùng";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                    }
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    nguoidung.NguoiDungId = int.Parse(txtNguoidungID.Text);
                    nguoidung.TenDangNhap = txtTenDangNhap.Text;
                    nguoidung.MatKhau = HashPassword(txtMatKhau.Text);
                    nguoidung.TenDayDu = txtHoTen.Text;
                    nguoidung.Sdt = txtSDT.Text;
                    nguoidung.DiaChi = txtDiaChi.Text;
                    if (BUS_NguoiDung.Update(nguoidung))
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Cập nhập thành công user: " + nguoidung.TenDangNhap + " vào hệ thống";
                        nhatKy.ThaoTac = "Cập nhập";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Người dùng";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                    }
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
