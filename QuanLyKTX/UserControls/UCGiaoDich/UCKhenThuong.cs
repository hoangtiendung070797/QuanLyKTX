using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls.UCGiaoDich
{
    public partial class UCKhenThuong : UserControl
    {
        public UCKhenThuong()
        {
            InitializeComponent();
        }

        BUS_KhenThuong bus_KhenThuong = new BUS_KhenThuong();
        DataTable doituong = new DataTable();
        BUS_DoiTuong bus_doituong = new BUS_DoiTuong();
        int TempDoiTuongID = 0;
        int chucnang = 0;

        private void txtMSV_EditValueChanged(object sender, EventArgs e)
        {
            doituong = bus_doituong.GetData_Find(txtMSV.Text);
            if (doituong.Rows.Count != 0)
            {
                txtHoTen.Text = doituong.Rows[0][8].ToString() + doituong.Rows[0][9].ToString();
                TempDoiTuongID = int.Parse(doituong.Rows[0][0].ToString());
                MessageBox.Show(TempDoiTuongID.ToString());
            }             
            else
                txtHoTen.Text = "";
        }

        private void UCKhenThuong_Load(object sender, EventArgs e)
        {
            reset();
        }

        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "ID Khen Thưởng";
            gridView1.Columns[1].Caption = "ID Đối Tượng";
          //  gridView1.Columns[2].Caption = "ID Đối Tượng";
            gridView1.Columns[2].Caption = "Mã Sinh Viên";
            gridView1.Columns[3].Caption = "Họ Đệm";
            gridView1.Columns[4].Caption = "Tên";
            gridView1.Columns[5].Caption = "Tên Khen Thưởng";
            gridView1.Columns[6].Caption = "Nội Dung";
            gridView1.Columns[7].Caption = "Ngày";
            gridView1.Columns[8].Caption = "Ghi Chú";

        }
        void display()
        {
            gridControl1.DataSource = bus_KhenThuong.GetData();
            FixNColumnNames();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMSV.Enabled = false;
            txtHoTen.Enabled = false;
            txtGhiChu.Enabled = false;
            txtNoiDung.Enabled = false;
            dpkNgayThem.Enabled = false;
            txtTenKhenthuong.Enabled = false;

            txtMSV.Text = "";
            txtHoTen.Text = "";
            txtGhiChu.Text = "";
            txtNoiDung.Text = "";
            txtTenKhenthuong.Text = "";

            TempDoiTuongID = 0;
            khenthuongID = 0;

            display();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            chucnang = 1;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtMSV.Enabled = true;
            txtTenKhenthuong.Enabled = true;
            txtNoiDung.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtMSV.Enabled = true;
            txtTenKhenthuong.Enabled = true;
            txtNoiDung.Enabled = true;
            txtGhiChu.Enabled = true;
            dpkNgayThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(bus_KhenThuong.Delete(khenthuongID))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Xóa thành công khen thưởng " + txtTenKhenthuong.Text + " - MSV: " + txtMSV.Text +  "/"  + txtHoTen.Text;
                        nhatKy.ThaoTac = "Xóa";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Khen thưởng, kỷ luật";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Xóa thành công!");
                        reset();
                    }
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo"); 
        }

        int khenthuongID = 0;      
        int doituongID;
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            khenthuongID = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "KhenThuongId").ToString());
            doituongID = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "DoiTuongId").ToString());
            txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();
            txtNoiDung.Text = gridView1.GetRowCellValue(e.RowHandle, "noiDung").ToString();
            txtTenKhenthuong.Text = gridView1.GetRowCellValue(e.RowHandle, "tenKhenThuong").ToString();
            dpkNgayThem.Text = gridView1.GetRowCellValue(e.RowHandle, "ngay").ToString();          
            txtHoTen.Text= gridView1.GetRowCellValue(e.RowHandle, "hoDem").ToString() + " "+ gridView1.GetRowCellValue(e.RowHandle, "ten").ToString();
            txtMSV.Text = gridView1.GetRowCellValue(e.RowHandle, "maSinhVien").ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text == "" || txtHoTen.Text == "" || txtNoiDung.Text == "" || txtTenKhenthuong.Text == "" )
            {
                if(txtHoTen.Text=="")
                    MessageBox.Show("Không tìm thấy đối tượng.");
                if (txtNoiDung.Text == "") errorProvider1.SetError(txtNoiDung, "Chưa điền nội dung.");
                if (txtTenKhenthuong.Text == "") errorProvider1.SetError(txtTenKhenthuong, "Chưa điền tên.");
            }
                
            else
            {
                KhenThuong khenthuong = new KhenThuong();

                if (chucnang == 1)
                {
                    khenthuong.DoiTuongId = TempDoiTuongID;
                    khenthuong.TenKhenThuong = txtTenKhenthuong.Text;
                    khenthuong.NoiDung = txtNoiDung.Text;
                    khenthuong.Ngay = DateTime.Now;
                    khenthuong.GhiChu = txtGhiChu.Text;
                    
        
                    if (bus_KhenThuong.Insert(khenthuong))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Thêm thành công khen thưởng " + txtTenKhenthuong.Text + " - MSV: " + txtMSV.Text + "/" + txtHoTen.Text;
                        nhatKy.ThaoTac = "Tạo";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Khen thưởng, kỷ luật";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    }
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    khenthuong.KhenThuongId = khenthuongID;
                    khenthuong.DoiTuongId = doituongID;
                    khenthuong.TenKhenThuong = txtTenKhenthuong.Text;
                    khenthuong.NoiDung = txtNoiDung.Text;
                    khenthuong.Ngay = dpkNgayThem.Value;
                    khenthuong.GhiChu = txtGhiChu.Text;
                    if (bus_KhenThuong.Update(khenthuong))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Cập nhật thành công khen thưởng " + txtTenKhenthuong.Text + " - MSV: " + txtMSV.Text + "/" + txtHoTen.Text;
                        nhatKy.ThaoTac = "Cập nhật";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Khen thưởng, kỷ luật";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                    }
                    else MessageBox.Show("cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void txtMSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
