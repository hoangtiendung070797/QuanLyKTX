using BUS;
using DAL;
using DTO;
using System;
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
        private void UCTonGiao_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bUS_TonGiao.GetData();

        }
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaTonGiao.Text = gridView1.GetRowCellValue(e.RowHandle, "TonGiaoId").ToString();
            txtTenTonGiao.Text = gridView1.GetRowCellValue(e.RowHandle, "tenTonGiao").ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTenTonGiao.Enabled = true;

            if (!string.IsNullOrEmpty(txtTenTonGiao.Text))
            {
                try
                {

                    TonGiao tongiao = new TonGiao(int.Parse(txtMaTonGiao.Text),txtTenTonGiao.Text);
                    //MessageBox.Show(dAL_QuocTich.GetIdentityId().ToString());
                    bUS_TonGiao.Insert(tongiao);
                    MessageBox.Show("Thêm thành công!");
                    txtTenTonGiao.Enabled = false;
                    UCTonGiao_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được tôn giáo\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenTonGiao.ResetText();
                    txtTenTonGiao.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenTonGiao, "Chưa điền tên tôn giáo!");
                txtTenTonGiao.ResetText();
                txtTenTonGiao.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    bUS_TonGiao.Delete(int.Parse(txtMaTonGiao.Text));
                    MessageBox.Show("Xóa thành công!");
                    UCTonGiao_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể xóa được bản ghi tôn giáo\nVui lòng kiểm tra lại kết nối và dữ liệu chọn!");
                    txtTenTonGiao.ResetText();
                    txtTenTonGiao.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenTonGiao.Text))
            {
                try
                {

                    TonGiao tongiao = new TonGiao(int.Parse(txtMaTonGiao.Text),txtTenTonGiao.Text);
                    tongiao.TonnGiaoId = int.Parse(txtMaTonGiao.Text);

                    if (bUS_TonGiao.Update(tongiao) == true)
                    {
                        MessageBox.Show("Đã cập nhập thành công!");
                        txtTenTonGiao.Enabled = false;
                        UCTonGiao_Load(sender, e);
                        // lưu vào log ... viết sau
                    }


                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được tôn giáo\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenTonGiao.ResetText();
                    txtTenTonGiao.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenTonGiao, "Chưa điền tên tôn giáo!");
                txtTenTonGiao.ResetText();
                txtTenTonGiao.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTenTonGiao.Enabled = true;
        }
    }
}
