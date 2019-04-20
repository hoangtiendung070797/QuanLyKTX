using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCLoaiPhong : UserControl
    {
        public UCLoaiPhong()
        {
            InitializeComponent();
        }
        BUS_LoaiPhong bUS_LoaiPhong = new BUS_LoaiPhong();
        int chucnang = 0;



        void display()
        {
            gridControl1.DataSource = bUS_LoaiPhong.GetData();
            FixNColumnNames();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMaLoaiPhong.Enabled = false;
            txtTenLoaiPhong.Enabled = false;
            txtSoNguoi.Enabled = false;
            txtGia.Enabled = false;

            txtMaLoaiPhong.Text = "";
            txtTenLoaiPhong.Text = "";
            txtSoNguoi.Text = "";
            txtGia.Text = "";

            display();
        }



        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã loại phòng";
            gridView1.Columns[1].Caption = "Tên loại phòng";
            gridView1.Columns[2].Caption = "Số lượng tối đa";
            gridView1.Columns[3].Caption = "Giá loại phòng";

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

            txtTenLoaiPhong.Enabled = true;
            txtSoNguoi.Enabled = true;
            txtGia.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenLoaiPhong.Enabled = true;
            txtSoNguoi.Enabled = true;
            txtGia.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiPhong.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_LoaiPhong.Delete(int.Parse(txtMaLoaiPhong.Text)))
                    {
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
            if (txtTenLoaiPhong.Text == ""||txtGia.Text==""||txtSoNguoi.Text=="")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                if (txtTenLoaiPhong.Text == "") errorProvider1.SetError(txtTenLoaiPhong, "Chưa điền tên.");
                if (txtSoNguoi.Text == "") errorProvider1.SetError(txtSoNguoi, "Chưa điền số người.");
                if (txtGia.Text == "") errorProvider1.SetError(txtGia, "Chưa điền giá.");
            }
                
            else
            {
                LoaiPhong loaiphong = new LoaiPhong();

                if (chucnang == 1)
                {
                    loaiphong.TenLoaiPhong = txtTenLoaiPhong.Text;
                    loaiphong.SoLuongtoiDa = int.Parse(txtSoNguoi.Text);
                    loaiphong.GiaLoaiPhong = decimal.Parse(txtGia.Text);
                    if (bUS_LoaiPhong.Insert(loaiphong))
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    loaiphong.LoaiPhongId = int.Parse(txtMaLoaiPhong.Text);
                    loaiphong.TenLoaiPhong = txtTenLoaiPhong.Text;
                    loaiphong.SoLuongtoiDa = int.Parse(txtSoNguoi.Text);
                    loaiphong.GiaLoaiPhong = decimal.Parse(txtGia.Text);
                    if (bUS_LoaiPhong.Update(loaiphong))
                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }


        private void gridView1_CustomRowCellEditForEditing_1(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaLoaiPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "LoaiPhongId").ToString();
            txtTenLoaiPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "tenLoaiPhong").ToString();
            txtGia.Text = gridView1.GetRowCellValue(e.RowHandle, "giaLoaiPhong").ToString();
            txtSoNguoi.Text = gridView1.GetRowCellValue(e.RowHandle, "soLuongtoiDa").ToString();
        }

        private void UCLoaiPhong_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoNguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
