using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls
{
    public partial class UCVatTu : UserControl
    {
        public UCVatTu()
        {
            InitializeComponent();
        }

        BUS_VatTu bUS_vattu = new BUS_VatTu();
        private void UCVatTu_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bUS_vattu.GetData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtTenVatTu.Enabled = true;
            txtMaVatTu.Enabled = true;
            if (!string.IsNullOrEmpty(txtTenVatTu.Text) && !string.IsNullOrEmpty(txtMaVatTu.Text) && !string.IsNullOrEmpty(txtMoTa.Text) && !string.IsNullOrEmpty(txtSoLuong.Text))
            {
                try
                {

                    VatTu VatTu = new VatTu(txtMaVatTu.Text,txtTenVatTu.Text,txtMoTa.Text,int.Parse(txtSoLuong.Text),txtGhiChu.Text);
                    //MessageBox.Show(dAL_VatTu.GetIdentityId().ToString());
                    bUS_vattu.Insert(VatTu);
                    MessageBox.Show("Thêm thành công!");
                    txtTenVatTu.Enabled = false;
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được vật tư\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenVatTu.ResetText();
                    txtTenVatTu.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenVatTu, "Chưa điền tên vật tư!");
                errorProvider1.SetError(txtMaVatTu, "Chưa điền mã vật tư!");
                errorProvider1.SetError(txtMoTa, "Chưa điền mô tả vật tư!");
                errorProvider1.SetError(txtSoLuong, "Chưa điền số lượng vật tư!");
                txtTenVatTu.ResetText();
                txtTenVatTu.Focus();
            }
        }
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaVatTu.Text = gridView1.GetRowCellValue(e.RowHandle, "VatTuId").ToString();
            txtTenVatTu.Text = gridView1.GetRowCellValue(e.RowHandle, "tenVatTu").ToString();
            txtSoLuong.Text = gridView1.GetRowCellValue(e.RowHandle, "soLuong").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();
            txtMoTa.Text = gridView1.GetRowCellValue(e.RowHandle, "moTa").ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenVatTu.Text) && !string.IsNullOrEmpty(txtMaVatTu.Text) && !string.IsNullOrEmpty(txtMoTa.Text) && !string.IsNullOrEmpty(txtSoLuong.Text))
            {
                try
                {

                    VatTu VatTu = new VatTu((txtMaVatTu.Text), txtTenVatTu.Text, txtMoTa.Text, int.Parse(txtSoLuong.Text), txtGhiChu.Text);
                    VatTu.VatTuId = txtMaVatTu.Text;

                    if(bUS_vattu.Update(VatTu)==true)
                    {
                        MessageBox.Show("Đã cập nhập thành công!");
                        txtTenVatTu.Enabled = false;
                        // lưu vào log ... viết sau
                    }


                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được vật tư\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenVatTu.ResetText();
                    txtTenVatTu.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenVatTu, "Chưa điền tên vật tư!");
                errorProvider1.SetError(txtMaVatTu, "Chưa điền mã vật tư!");
                errorProvider1.SetError(txtMoTa, "Chưa điền mô tả vật tư!");
                errorProvider1.SetError(txtSoLuong, "Chưa điền số lượng vật tư!");
                txtTenVatTu.ResetText();
                txtTenVatTu.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTenVatTu.Enabled = true;
            txtMaVatTu.Enabled = true;
            txtMoTa.Enabled = true;
            txtGhiChu.Enabled = true;
            txtSoLuong.Enabled = true;
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    bUS_vattu.Delete(txtMaVatTu.Text);
                    MessageBox.Show("Xóa thành công!");
                    gridView1.RefreshData();
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể xóa được bản ghi vật tư\nVui lòng kiểm tra lại kết nối và dữ liệu chọn!");
                    txtTenVatTu.ResetText();
                    txtTenVatTu.Focus();
                }
            }
        }
    }
}
