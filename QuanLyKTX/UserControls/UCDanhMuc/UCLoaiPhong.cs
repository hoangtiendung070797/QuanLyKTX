using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCGiaLoaiPhong : UserControl
    {
        public UCGiaLoaiPhong()
        {
            InitializeComponent();
        }
        BUS_LoaiPhong bUS_LoaiPhong = new BUS_LoaiPhong();
        private void UCGiaLoaiPhong_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bUS_LoaiPhong.GetData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTenLoaiPhong.Enabled = true;
            txtMaLoaiPhong.Enabled = true;
            txtGia.Enabled = true;
            txtSoNguoi.Enabled = true;

            if (!string.IsNullOrEmpty(txtTenLoaiPhong.Text) && !string.IsNullOrEmpty(txtMaLoaiPhong.Text) && !string.IsNullOrEmpty(txtSoNguoi.Text) && !string.IsNullOrEmpty(txtGia.Text))
            {
                try
                {

                    LoaiPhong loaiPhong = new LoaiPhong(int.Parse(txtMaLoaiPhong.Text),txtTenLoaiPhong.Text,int.Parse(txtSoNguoi.Text),decimal.Parse(txtGia.Text));
                    //MessageBox.Show(dAL_LoaiPhong.GetIdentityId().ToString());
                    bUS_LoaiPhong.Insert(loaiPhong);
                    MessageBox.Show("Thêm thành công!");
                    txtTenLoaiPhong.Enabled = false;
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được loại phòng\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenLoaiPhong.ResetText();
                    txtTenLoaiPhong.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenLoaiPhong, "Chưa điền tên loại phòng!");
                txtTenLoaiPhong.ResetText();
                txtTenLoaiPhong.Focus();
            }
        }
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaLoaiPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "LoaiPhongId").ToString();
            txtTenLoaiPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "tenLoaiPhong").ToString();
            txtSoNguoi.Text = gridView1.GetRowCellValue(e.RowHandle, "soLuongtoiDa").ToString();
            txtGia.Text = gridView1.GetRowCellValue(e.RowHandle, "giaLoaiPhong").ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenLoaiPhong.Text) && !string.IsNullOrEmpty(txtMaLoaiPhong.Text) && !string.IsNullOrEmpty(txtSoNguoi.Text) && !string.IsNullOrEmpty(txtGia.Text))
            {
                try
                {

                    LoaiPhong LoaiPhong = new LoaiPhong(int.Parse(txtMaLoaiPhong.Text), txtTenLoaiPhong.Text, int.Parse(txtSoNguoi.Text), decimal.Parse(txtGia.Text));
                    LoaiPhong.LoaiPhongId = int.Parse(txtMaLoaiPhong.Text);

                    if (bUS_LoaiPhong.Update(LoaiPhong) == true)
                    {
                        MessageBox.Show("Đã cập nhập thành công!");
                        txtTenLoaiPhong.Enabled = false;
                        // lưu vào log ... viết sau
                    }


                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được loại phòng\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenLoaiPhong.ResetText();
                    txtTenLoaiPhong.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenLoaiPhong, "Chưa điền tên loại phòng!");
                txtTenLoaiPhong.ResetText();
                txtTenLoaiPhong.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTenLoaiPhong.Enabled = true;
            txtMaLoaiPhong.Enabled = true;
            txtGia.Enabled = true;
            txtSoNguoi.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    bUS_LoaiPhong.Delete(int.Parse(txtMaLoaiPhong.Text));
                    MessageBox.Show("Xóa thành công!");
                    gridView1.RefreshData();
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể xóa được bản ghi loại phòng\nVui lòng kiểm tra lại kết nối và dữ liệu chọn!");
                    txtTenLoaiPhong.ResetText();
                    txtTenLoaiPhong.Focus();
                }
            }
        }
    }
}
