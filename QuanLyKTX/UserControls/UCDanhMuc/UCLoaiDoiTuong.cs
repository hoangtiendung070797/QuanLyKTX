using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls
{
    public partial class UCLoaiDoiTuong : UserControl
    {
        public UCLoaiDoiTuong()
        {
            InitializeComponent();
        }

        BUS_LoaiDoiTuong bUS_LoaiDoiTuong = new BUS_LoaiDoiTuong();
        private void UCLoaiDoiTuong_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bUS_LoaiDoiTuong.GetData();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTenLoaiDoiTuong.Enabled = true;

            if (!string.IsNullOrEmpty(txtTenLoaiDoiTuong.Text))
            {
                try
                {

                    LoaiDoiTuong LoaiDoiTuong = new LoaiDoiTuong(int.Parse(txtMaLoaiDoiTuong.Text),txtTenLoaiDoiTuong.Text);
                    //MessageBox.Show(dAL_LoaiDoiTuong.GetIdentityId().ToString());
                    bUS_LoaiDoiTuong.Insert(LoaiDoiTuong);
                    MessageBox.Show("Thêm thành công!");
                    txtTenLoaiDoiTuong.Enabled = false;
                    UCLoaiDoiTuong_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được loại đối tượng\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenLoaiDoiTuong.ResetText();
                    txtTenLoaiDoiTuong.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenLoaiDoiTuong, "Chưa điền tên loại đối tượng!");
                txtTenLoaiDoiTuong.ResetText();
                txtTenLoaiDoiTuong.Focus();
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaLoaiDoiTuong.Text = gridView1.GetRowCellValue(e.RowHandle, "LoaiDoiTuongId").ToString();
            txtTenLoaiDoiTuong.Text = gridView1.GetRowCellValue(e.RowHandle, "tenLoaiDoiTuong").ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenLoaiDoiTuong.Text))
            {
                try
                {

                    LoaiDoiTuong loaiDoiTuong = new LoaiDoiTuong(int.Parse(txtMaLoaiDoiTuong.Text),txtTenLoaiDoiTuong.Text);
                    loaiDoiTuong.LoaiDoiTuongId = int.Parse(txtMaLoaiDoiTuong.Text);

                    if (bUS_LoaiDoiTuong.Update(loaiDoiTuong) == true)
                    {
                        MessageBox.Show("Đã cập nhập thành công!");
                        txtTenLoaiDoiTuong.Enabled = false;
                        UCLoaiDoiTuong_Load(sender, e);
                        // lưu vào log ... viết sau
                    }


                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được loại đối tượng\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenLoaiDoiTuong.ResetText();
                    txtTenLoaiDoiTuong.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenLoaiDoiTuong, "Chưa điền tên loại đối tượng!");
                txtTenLoaiDoiTuong.ResetText();
                txtTenLoaiDoiTuong.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTenLoaiDoiTuong.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    bUS_LoaiDoiTuong.Delete(int.Parse(txtMaLoaiDoiTuong.Text));
                    MessageBox.Show("Xóa thành công!");
                    UCLoaiDoiTuong_Load(sender, e);
                    gridView1.RefreshData();
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể xóa được bản ghi loại đối tượng\nVui lòng kiểm tra lại kết nối và dữ liệu chọn!");
                    txtTenLoaiDoiTuong.ResetText();
                    txtTenLoaiDoiTuong.Focus();
                }
            }
        }
    }
}
