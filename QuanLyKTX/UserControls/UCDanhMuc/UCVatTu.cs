using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace QuanLyKTX.UserControls
{
    public partial class UCVatTu : UserControl
    {
        public UCVatTu()
        {
            InitializeComponent();
        }

        #region Properties
        bool isAddController = true;
        bool isEditController = true;
        bool isDeleteController = true;
        #endregion

        BUS_VatTu bUS_vattu = new BUS_VatTu();
        int chucnang = 0;

        private void UCVatTu_Load(object sender, EventArgs e)
        {
            reset();
            FixNColumnNames();
        }
        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã vật tư";
            gridView1.Columns[1].Caption = "Tên Vật Tư";
            gridView1.Columns[2].Caption = "Số Lượng";
            gridView1.Columns[3].Caption = "Mô Tả";
            gridView1.Columns[4].Caption = "Ghi Chú";
          
        }

        void display()
        {
            gridControl1.DataSource = bUS_vattu.GetData();
        }
        void reset()
        {
            LoadControlManagement();
            btnAdd.Enabled = isAddController;
            btnEdit.Enabled = isEditController;
            btnDelete.Enabled = isDeleteController;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMaVatTu.Enabled = false;
            txtTenVatTu.Enabled = false;
            txtSoLuong.Enabled = false;
            txtMoTa.Enabled = false;
            txtGhiChu.Enabled = false;

            txtMaVatTu.Text = "";
            txtTenVatTu.Text = "";
            txtMaVatTu.Text = "";
            txtTenVatTu.Text = "";
            txtMaVatTu.Text = "";

            display();

        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaVatTu.Text = gridView1.GetRowCellValue(e.RowHandle, "VatTuId").ToString();
            txtTenVatTu.Text = gridView1.GetRowCellValue(e.RowHandle, "tenVatTu").ToString();
            txtSoLuong.Text = gridView1.GetRowCellValue(e.RowHandle, "soLuong").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();
            txtMoTa.Text = gridView1.GetRowCellValue(e.RowHandle, "moTa").ToString();
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

            txtMaVatTu.Enabled = true;
            txtTenVatTu.Enabled = true;
            txtSoLuong.Enabled = true;
            txtMoTa.Enabled = true;
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

            txtMaVatTu.Enabled = true;
            txtTenVatTu.Enabled = true;
            txtSoLuong.Enabled = true;
            txtMoTa.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaVatTu.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_vattu.Delete(txtMaVatTu.Text))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Xóa thành công vật tư " + txtTenVatTu.Text + " ra khỏi hệ thống";
                        nhatKy.ThaoTac = "Xóa";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Vật tư";
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

        public bool checkma()
        {
            DataTable bang_VatTu = bUS_vattu.GetData();
            bool check = false; // không trùng
            for (int i = 0; i < bang_VatTu.Rows.Count; i++)
                if (txtMaVatTu.Text == bang_VatTu.Rows[i][0].ToString())
                {
                    check = true;   // trùng mã
                    break;
                }
            return check;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenVatTu.Text == "" || txtMaVatTu.Text == "" || txtSoLuong.Text == "" || txtMoTa.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                if (txtMaVatTu.Text == "") errorProvider1.SetError(txtMaVatTu, "Chưa điền mã.");
                if (txtTenVatTu.Text == "") errorProvider1.SetError(txtTenVatTu, "Chưa điền tên.");
                if (txtSoLuong.Text == "") errorProvider1.SetError(txtSoLuong, "Chưa điền số lượng.");
                if (txtMoTa.Text == "") errorProvider1.SetError(txtMoTa, "Chưa điền mô tả.");
            }
            else
            {
                VatTu vattu = new VatTu();

                if (chucnang == 1)
                {
                    if (checkma() == true)
                    {
                        MessageBox.Show("Mã vật tư đã tồn tại.", "Thông Báo");
                        errorProvider1.SetError(txtMaVatTu, "Mã vật tư đã tồn tại.");
                    }
                    else
                    {
                        vattu.VatTuId = txtMaVatTu.Text;
                        vattu.TenVatTu = txtTenVatTu.Text;
                        vattu.SoLuong = int.Parse(txtSoLuong.Text);
                        vattu.MoTa = txtMoTa.Text;
                        vattu.GhiChu = txtGhiChu.Text;
                        if (bUS_vattu.Insert(vattu))
                        {
                            //------------Ghi log
                            NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                            nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                            nhatKy.NoiDung = "Thêm thành công vật tư " + txtTenVatTu.Text + " vào hệ thống";
                            nhatKy.ThaoTac = "Tạo";
                            nhatKy.ThoiGian = DateTime.Now;
                            nhatKy.ChucNang = "Vật tư";
                            Const.NhatKyHoatDong.Insert(nhatKy);
                            //-------------------

                            MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                        }
                        else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");
                        reset();
                    }

                }

                if (chucnang == 2)
                {
                    vattu.VatTuId = txtMaVatTu.Text;
                    vattu.TenVatTu = txtTenVatTu.Text;
                    vattu.SoLuong = int.Parse(txtSoLuong.Text);
                    vattu.MoTa = txtMoTa.Text;
                    vattu.GhiChu = txtGhiChu.Text;
                    if (bUS_vattu.Update(vattu))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Cập nhập thành công vật tư " + txtTenVatTu.Text + " trong hệ thống";
                        nhatKy.ThaoTac = "Cập nhập";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Vật tư";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------

                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                    }
                    else MessageBox.Show("cập nhật dữ liệu lỗi.", "Thông báo.");

                    reset();
                }
                
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
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
