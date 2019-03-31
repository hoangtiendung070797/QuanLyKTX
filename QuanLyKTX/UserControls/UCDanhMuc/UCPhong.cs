using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls
{
    public partial class UCPhong : UserControl
    {
        public UCPhong()
        {
            InitializeComponent();
        }
        BUS_Phong bUS_Phong = new BUS_Phong();
        private void UCPhong_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bUS_Phong.GetData();
        }





        public void CloseOrOpen()
        {
            txtTenPhong.Enabled = txtTenPhong.Enabled == true ? false : true;
            txtTang.Enabled = txtTang.Enabled == true ? false : true;
            txtMaPhong.Enabled = txtMaPhong.Enabled == true ? false : true;
            txtGiaPhong.Enabled = txtGiaPhong.Enabled == true ? false : true;
            txtDayNha.Enabled = txtDayNha.Enabled == true ? false : true;
            cbbLoaiPhong.Enabled = cbbLoaiPhong.Enabled == true ? false : true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            CloseOrOpen();
            if (!string.IsNullOrEmpty(txtTenPhong.Text) && !string.IsNullOrEmpty(cbbLoaiPhong.Text)  && !string.IsNullOrEmpty(txtMaPhong.Text))
            {
                try
                {

                    Phong phong = new Phong();
                    phong.DayNhaId = int.Parse(txtDayNha.Text);
                    phong.LoaiPhongId = int.Parse(cbbLoaiPhong.Text);
                    phong.TenPhong = txtTenPhong.Text;
                    phong.Tang = int.Parse(txtTang.Text);
                    phong.PhongId = txtMaPhong.Text;
                    phong.GiaPhong = decimal.Parse(txtGiaPhong.Text);
                   
                    bUS_Phong.Insert(phong);
                    MessageBox.Show("Thêm thành công!");

                    CloseOrOpen();
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được phòng\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenPhong.ResetText();
                    txtTenPhong.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenPhong, "Chưa điền tên phòng!");
                txtTenPhong.ResetText();
                txtTenPhong.Focus();
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "PhongId").ToString();
            txtDayNha.Text = gridView1.GetRowCellValue(e.RowHandle, "DayNhaId").ToString();
            cbbLoaiPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "LoaiPhongId").ToString();
            txtGiaPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "giaPhong").ToString();
            txtTang.Text = gridView1.GetRowCellValue(e.RowHandle, "tang").ToString();
            txtTenPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "tenPhong").ToString();
            //
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenPhong.Text))
            {
                try
                {

                    Phong phong = new Phong();
                    phong.PhongId = txtMaPhong.Text;

                    if (bUS_Phong.Update(phong) == true)
                    {
                        MessageBox.Show("Đã cập nhập thành công!");
                        CloseOrOpen();
                        // lưu vào log ... viết sau
                    }


                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được phòng\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenPhong.ResetText();
                    txtTenPhong.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenPhong, "Chưa điền tên phòng!");
                txtTenPhong.ResetText();
                txtTenPhong.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CloseOrOpen();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    bUS_Phong.Delete(txtMaPhong.Text);
                    MessageBox.Show("Xóa thành công!");
                    gridView1.RefreshData();
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể xóa được bản ghi phòng\nVui lòng kiểm tra lại kết nối và dữ liệu chọn!");
                    txtTenPhong.ResetText();
                    txtTenPhong.Focus();
                }
            }
        }
    }
}
