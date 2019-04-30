using BUS;
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCDayNha : UserControl
    {
        #region Properties
        bool isAddController = true;
        bool isEditController = true;
        bool isDeleteController = true;
        #endregion

        public UCDayNha()
        {
            InitializeComponent();
        }
        BUS_DayNha bUS_DayNha = new BUS_DayNha();
        int chucnang = 0;

        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã dãy nhà";
            gridView1.Columns[1].Caption = "Tên dãy nhà";
            gridView1.Columns[2].Caption = "Ghi chú";
        }

        void display()
        {
            gridControl1.DataSource = bUS_DayNha.GetData();
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

            txtDayNhaId.Enabled = false;
            txtTenDayNha.Enabled = false;
            txtGhiChu.Enabled = false;

            txtDayNhaId.Text = "";
            txtTenDayNha.Text = "";
            txtGhiChu.Text = "";

            display();
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtDayNhaId.Text = gridView1.GetRowCellValue(e.RowHandle, "DayNhaId").ToString();
            txtTenDayNha.Text = gridView1.GetRowCellValue(e.RowHandle, "tenDayNha").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();
        }

        private void btnThemDayNha_Click(object sender, EventArgs e)
        {
            reset();
            chucnang = 1;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenDayNha.Enabled = true;
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

            txtTenDayNha.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDayNhaId.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_DayNha.Delete(int.Parse(txtDayNhaId.Text)))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Xóa thành công dãy nhà " + txtTenDayNha.Text + " ra khỏi hệ thống";
                        nhatKy.ThaoTac = "Xóa";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Dãy nhà";
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

            if (txtTenDayNha.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                errorProvider1.SetError(txtTenDayNha, "Chưa điền tên.");
            }
                
            else
            {
                DayNha daynha = new DayNha();
                if (chucnang == 1)
                {
                    daynha.TenDayNha = txtTenDayNha.Text;
                    daynha.GhiChu = txtGhiChu.Text;                
                    if (bUS_DayNha.Insert(daynha))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Thêm thành công dãy nhà " + txtTenDayNha.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Tạo";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Dãy nhà";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    }  
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");
                }

                if (chucnang == 2)
                {
                    daynha.DayNhaId = int.Parse(txtDayNhaId.Text);
                    daynha.TenDayNha = txtTenDayNha.Text;
                    daynha.GhiChu = txtGhiChu.Text;
                    if (bUS_DayNha.Update(daynha))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Cập nhập thành công dãy nhà " + txtTenDayNha.Text + " trong hệ thống";
                        nhatKy.ThaoTac = "Cập nhập";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Dãy nhà";
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

        private void UCDayNha_Load(object sender, EventArgs e)
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
