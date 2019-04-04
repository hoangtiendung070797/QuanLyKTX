using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls
{
    public partial class UCLoiViPham : UserControl
    {
        public UCLoiViPham()
        {
            InitializeComponent();
        }
        BUS_LoiViPham bUS_LoiViPham = new BUS_LoiViPham();
        private void UCLoiViPham_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bUS_LoiViPham.GetData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTenLoi.Enabled = true;
            txtMaLoi.Enabled = true;
            txtHinhThucXuLy.Enabled = true;
            txtNoiDung.Enabled = true;
            txtGhiChu.Enabled = true;

            if (!string.IsNullOrEmpty(txtTenLoi.Text))
            {
                try
                {

                    LoiViPham loivipham = new LoiViPham(int.Parse(txtMaLoi.Text),txtTenLoi.Text,txtNoiDung.Text,txtHinhThucXuLy.Text,txtGhiChu.Text);
                    //MessageBox.Show(dAL_QuocTich.GetIdentityId().ToString());
                    bUS_LoiViPham.Insert(loivipham);
                    MessageBox.Show("Thêm thành công!");
                    txtTenLoi.Enabled = false;
                    UCLoiViPham_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được lỗi vi phạm\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenLoi.ResetText();
                    txtTenLoi.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenLoi, "Chưa điền tên lỗi vi phạm!");
                txtTenLoi.ResetText();
                txtTenLoi.Focus();
            }
        }
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaLoi.Text = gridView1.GetRowCellValue(e.RowHandle, "LoiViPhamId").ToString();
            txtTenLoi.Text = gridView1.GetRowCellValue(e.RowHandle, "tenLoiViPham").ToString();
            txtNoiDung.Text = gridView1.GetRowCellValue(e.RowHandle, "noiDung").ToString();
            txtHinhThucXuLy.Text = gridView1.GetRowCellValue(e.RowHandle, "hinhThucXuLy").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();
          
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenLoi.Text))
            {
                try
                {

                    LoiViPham loivipham = new LoiViPham(int.Parse(txtMaLoi.Text), txtTenLoi.Text, txtNoiDung.Text, txtHinhThucXuLy.Text, txtGhiChu.Text);
                    loivipham.LoiViPhamId = int.Parse(txtMaLoi.Text);

                    if (bUS_LoiViPham.Update(loivipham) == true)
                    {
                        MessageBox.Show("Đã cập nhập thành công!");
                        txtTenLoi.Enabled = false;
                        UCLoiViPham_Load(sender, e);
                        // lưu vào log ... viết sau
                    }


                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được lỗi vi phạm\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenLoi.ResetText();
                    txtTenLoi.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenLoi, "Chưa điền tên lỗi vi phạm!");
                txtTenLoi.ResetText();
                txtTenLoi.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTenLoi.Enabled = true;
            txtMaLoi.Enabled = true;
            txtHinhThucXuLy.Enabled = true;
            txtNoiDung.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    bUS_LoiViPham.Delete(int.Parse(txtMaLoi.Text));
                    MessageBox.Show("Xóa thành công!");
                    UCLoiViPham_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể xóa được bản ghi lỗi vi phạm\nVui lòng kiểm tra lại kết nối và dữ liệu chọn!");
                    txtTenLoi.ResetText();
                    txtTenLoi.Focus();
                }
            }
        }
    }
}
