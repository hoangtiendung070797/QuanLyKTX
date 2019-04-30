using BUS;
using DAL;
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls
{
    public partial class UCDonVi : UserControl
    {
        public UCDonVi()
        {
            InitializeComponent();
        }
        BUS_DonVi bus_donvi = new BUS_DonVi();
        int chucnang = 0;

        #region Properties
        bool isAddController = true;
        bool isEditController = true;
        bool isDeleteController = true;
        #endregion

        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã đơn vị";
            gridView1.Columns[1].Caption = "Tên đơn vị";
            gridView1.Columns[2].Caption = "Địa chỉ";
            gridView1.Columns[3].Caption = "SĐT";
            gridView1.Columns[4].Caption = "Ghi chú";
        }
        void display()
        {
            gridControl1.DataSource = bus_donvi.GetData();
            FixNColumnNames();
        }
        void reset()
        {
            LoadControlManagement();
            btnAdd.Enabled = isAddController;
            btnEdit.Enabled = isEditController;
            btnDelete.Enabled = isDeleteController;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

             txtMaDonVi.Enabled = false;
             txtTenDonVi.Enabled = false;
             txtDiaChi.Enabled = false;
             txtSDT.Enabled = false;
             txtGhiChu.Enabled = false;

             txtMaDonVi.Text = "";
             txtTenDonVi.Text = "";
             txtSDT.Text = "";
             txtDiaChi.Text = "";
             txtGhiChu.Text = "";

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

            txtTenDonVi.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtGhiChu.Enabled = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenDonVi.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtGhiChu.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaDonVi.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus_donvi.Delete(int.Parse(txtMaDonVi.Text)))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Xóa thành công đơn vị " + txtTenDonVi.Text + " ra khỏi hệ thống";
                        nhatKy.ThaoTac = "Xóa";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Đơn vị";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------

                        MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo.");

                    }
                    else MessageBox.Show("Xóa dữ liệu lỗi.", "Thông báo.");
                    reset();
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenDonVi.Text == "" || txtSDT.Text==""||txtDiaChi.Text=="")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                if (txtTenDonVi.Text == "") errorProvider1.SetError(txtTenDonVi, "Chưa điền tên.");
                if (txtSDT.Text == "") errorProvider1.SetError(txtSDT, "Chưa điền sđt.");
                if (txtDiaChi.Text == "") errorProvider1.SetError(txtDiaChi, "Chưa điền địa chỉ.");
            }
                
            else
            {
                DonVi donvi = new DonVi();

                if (chucnang == 1)
                {                   
                    donvi.TenDonVi = txtTenDonVi.Text;
                    donvi.Sdt = txtSDT.Text;
                    donvi.DiaChi = txtDiaChi.Text;
                    donvi.GhiChu = txtGhiChu.Text;
                    if (bus_donvi.Insert(donvi))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Thêm thành công đơn vị " + txtTenDonVi.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Tạo";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Đơn vị";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------

                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    }    
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");
                }

                if (chucnang == 2)
                {
                    donvi.DonViId = int.Parse(txtMaDonVi.Text);
                    donvi.TenDonVi = txtTenDonVi.Text;
                    donvi.Sdt = txtSDT.Text;
                    donvi.DiaChi = txtDiaChi.Text;
                    donvi.GhiChu = txtGhiChu.Text;
                    if (bus_donvi.Update(donvi))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Cập nhập thành công đơn vị " + txtTenDonVi.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Cập nhập";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Đơn vị";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------

                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                    }      
                    else MessageBox.Show("Cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaDonVi.Text = gridView1.GetRowCellValue(e.RowHandle, "DonViId").ToString();
            txtTenDonVi.Text = gridView1.GetRowCellValue(e.RowHandle, "tenDonVi").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(e.RowHandle, "diaChi").ToString();
            txtSDT.Text = gridView1.GetRowCellValue(e.RowHandle, "sdt").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();
        }

        private void UCDonVi_Load(object sender, EventArgs e)
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
        public void LoadControlManagement()
        {

            if (Const.CurrentUser.TenDangNhap != "admin")
            {
                var query = Const.PhanQuyens.Where(x => x.TenChucNang == this.Tag.ToString()).Single();
                isAddController = query.ChucNangThem;
                isEditController = query.ChucNangSua;
                isDeleteController = query.ChucNangXoa;
            }
            else
            {
                isAddController = true;
                isEditController = true;
                isDeleteController = true;
            }

        }
    }
}
