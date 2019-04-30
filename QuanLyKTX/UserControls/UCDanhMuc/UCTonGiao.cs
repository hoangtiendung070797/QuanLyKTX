using BUS;
using DAL;
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls
{
    public partial class UCTonGiao : UserControl
    {
        public UCTonGiao()
        {
            InitializeComponent();
        }
        BUS_TonGiao bUS_TonGiao = new BUS_TonGiao();
        int chucnang = 0;

        #region Properties
        bool isAddController = true;
        bool isEditController = true;
        bool isDeleteController = true;
        #endregion

        private void UCTonGiao_Load(object sender, EventArgs e)
        {
            reset();
            FixNColumnNames();
        }

        void display()
        {
            gridControl1.DataSource = bUS_TonGiao.GetData();
        }
        void reset()
        {
            LoadControlManagement();
            btnAdd.Enabled = isAddController;
            btnEdit.Enabled = isEditController;
            btnDelete.Enabled = isDeleteController;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMaTonGiao.Enabled = false;
            txtTenTonGiao.Enabled = false;

            txtMaTonGiao.Text = "";
            txtTenTonGiao.Text = "";

            display();

        }

        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã tôn giáo";
            gridView1.Columns[1].Caption = "Tên tôn giáo";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            reset();
            chucnang = 1;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenTonGiao.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenTonGiao.Enabled = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (txtTenTonGiao.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_TonGiao.Delete(int.Parse(txtMaTonGiao.Text)))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Xóa thành công tôn giáo " + txtTenTonGiao.Text + " ra khỏi hệ thống";
                        nhatKy.ThaoTac = "Xóa";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Tôn giáo";
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (txtTenTonGiao.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                errorProvider1.SetError(txtTenTonGiao, "Chưa điền tên.");
            }
            else
            {
                TonGiao tongiao = new TonGiao();

                if (chucnang == 1)
                {
                    tongiao.TenTonGiao = txtTenTonGiao.Text;
                    if (bUS_TonGiao.Insert(tongiao))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Thêm thành công tôn giáo " + txtTenTonGiao.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Tạo";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Tôn giáo";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    }
                  
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    tongiao.TonnGiaoId = int.Parse(txtMaTonGiao.Text);
                    tongiao.TenTonGiao = txtTenTonGiao.Text;
                    if (bUS_TonGiao.Update(tongiao))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Cập nhập thành công tôn giáo " + txtTenTonGiao.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Cập nhập";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Tôn giáo";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                    } 
                    else MessageBox.Show("cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaTonGiao.Text = gridView1.GetRowCellValue(e.RowHandle, "TonGiaoId").ToString();
            txtTenTonGiao.Text = gridView1.GetRowCellValue(e.RowHandle, "tenTonGiao").ToString();
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
