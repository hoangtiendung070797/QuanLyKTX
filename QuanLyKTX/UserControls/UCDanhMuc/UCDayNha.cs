using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCDayNha : UserControl
    {
        public UCDayNha()
        {
            InitializeComponent();
        }
        BUS_DayNha bUS_DayNha = new BUS_DayNha();
        private void UCDayNha_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bUS_DayNha.GetData();
        }
        private void btnThemDayNha_Click(object sender, EventArgs e)
        {
            txtTenDayNha.Enabled = true;

            if (!string.IsNullOrEmpty(txtTenDayNha.Text))
            {
                try
                {

                    DayNha dayNha = new DayNha(txtTenDayNha.Text);
             
                    bUS_DayNha.Insert(dayNha);
                    MessageBox.Show("Thêm thành công!");
                    txtTenDayNha.Enabled = false;
                    UCDayNha_Load(sender, e);

                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được dãy nhà\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenDayNha.ResetText();
                    txtTenDayNha.Focus();
                }
            }
            else
            {
                errorProvider.SetError(txtTenDayNha, "Chưa điền tên dãy nhà!");
                txtTenDayNha.ResetText();
                txtTenDayNha.Focus();
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtDayNhaId.Text = gridViewDayNha.GetRowCellValue(e.RowHandle, "DayNhaId").ToString();
            txtTenDayNha.Text = gridViewDayNha.GetRowCellValue(e.RowHandle, "tenDayNha").ToString();
        }

        private void btnLuuDayNha_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenDayNha.Text))
            {
                try
                {

                    DayNha DayNha = new DayNha(txtTenDayNha.Text);
                    DayNha.DayNhaId = int.Parse(txtDayNhaId.Text);

                    if (bUS_DayNha.Update(DayNha) == true)
                    {
                        UCDayNha_Load(sender, e);
                        MessageBox.Show("Đã cập nhập thành công!");
                        txtTenDayNha.Enabled = false;
                        // lưu vào log ... viết sau
                    }


                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được dãy nhà\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenDayNha.ResetText();
                    txtTenDayNha.Focus();
                }
            }
            else
            {
                errorProvider.SetError(txtTenDayNha, "Chưa điền tên dãy nhà!");
                txtTenDayNha.ResetText();
                txtTenDayNha.Focus();
            }
        }

        private void btnSuaDayNha_Click(object sender, EventArgs e)
        {
            txtTenDayNha.Enabled = true;
        }

        private void z_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    bUS_DayNha.Delete(int.Parse(txtDayNhaId.Text));
                    MessageBox.Show("Xóa thành công!");
                    UCDayNha_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể xóa được bản ghi dãy nhà\nVui lòng kiểm tra lại kết nối và dữ liệu chọn!");
                    txtTenDayNha.ResetText();
                    txtTenDayNha.Focus();
                }
            }
        }
    }
}
