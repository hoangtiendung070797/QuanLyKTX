using BUS;
using DAL;
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCTinhThanh : UserControl
    {
        
        public UCTinhThanh()
        {
            InitializeComponent();
        }
        BUS_TinhThanh bUS_TinhThanh = new BUS_TinhThanh();
        int chucnang = 0;

        #region Properties
        bool isAddController = true;
        bool isEditController = true;
        bool isDeleteController = true;
        #endregion

        private void UCTinhThanh_Load(object sender, EventArgs e)
        {
            reset();
            FixNColumnNames();
        }
        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã tỉnh thành";
            gridView1.Columns[1].Caption = "Tên tỉnh thành ";
        }

        void display()
        {
            gridControl1.DataSource = bUS_TinhThanh.GetData();
        }
        void reset()
        {
            LoadControlManagement();
            btnAdd.Enabled = isAddController;
            btnEdit.Enabled = isEditController;
            btnDelete.Enabled = isDeleteController;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMaTinhThanh.Enabled = false;
            txtTenTinhThanh.Enabled = false;

            txtMaTinhThanh.Text = "";
            txtTenTinhThanh.Text = "";

            display();

        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaTinhThanh.Text = gridView1.GetRowCellValue(e.RowHandle, "TinhThanhId").ToString();
            txtTenTinhThanh.Text = gridView1.GetRowCellValue(e.RowHandle, "tenTinhThanh").ToString();
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

            txtTenTinhThanh.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenTinhThanh.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaTinhThanh.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_TinhThanh.Delete(int.Parse(txtMaTinhThanh.Text)))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Xóa thành công tỉnh thành " + txtTenTinhThanh.Text + " ra khỏi hệ thống";
                        nhatKy.ThaoTac = "Xóa";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Tỉnh thành";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenTinhThanh.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
               errorProvider.SetError(txtTenTinhThanh, "Chưa điền tên.");
            }
            else
            {
                TinhThanh tinhthanh = new TinhThanh();

                if (chucnang == 1)
                {
                    tinhthanh.TenTinhThanh = txtTenTinhThanh.Text;
                    if (bUS_TinhThanh.Insert(tinhthanh))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Thêm thành công tỉnh thành " + txtTenTinhThanh.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Tạo";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Tỉnh thành";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    }
                   
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    tinhthanh.TinhThanhId = int.Parse(txtMaTinhThanh.Text);
                    tinhthanh.TenTinhThanh = txtTenTinhThanh.Text;
                    if (bUS_TinhThanh.Update(tinhthanh))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Cập nhập thành công tỉnh thành " + txtTenTinhThanh.Text + " trong hệ thống";
                        nhatKy.ThaoTac = "Cập nhập";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Tỉnh thành";
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
