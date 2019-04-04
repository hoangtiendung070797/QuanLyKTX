using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls
{
    public partial class UCDonVi : UserControl
    {
        public UCDonVi()
        {
            InitializeComponent();
        }
        BUS_DonVi bus_donvi = new BUS_DonVi();
        private void UCDonVi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bus_donvi.GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTenDonVi.Enabled = true;
            txtMaDonVi.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtGhiChu.Enabled = true;

            if (!string.IsNullOrEmpty(txtTenDonVi.Text) && !string.IsNullOrEmpty(txtMaDonVi.Text) && !string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtSDT.Text))
            {
                try
                {

                    DonVi DonVi = new DonVi(int.Parse(txtMaDonVi.Text),txtTenDonVi.Text);
                    DonVi.Sdt = txtSDT.Text;
                    DonVi.GhiChu = txtGhiChu.Text;
                    //MessageBox.Show(dAL_DonVi.GetIdentityId().ToString());
                    bus_donvi.Insert(DonVi);
                    MessageBox.Show("Thêm thành công!");
                    txtTenDonVi.Enabled = false;
                    UCDonVi_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được đơn vị\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenDonVi.ResetText();
                    txtTenDonVi.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenDonVi, "Chưa điền tên đơn vị!");
                errorProvider1.SetError(txtMaDonVi, "Chưa điền mã đơn vị!");
                errorProvider1.SetError(txtDiaChi, "Chưa điền tên địa chỉ!");
                errorProvider1.SetError(txtSDT, "Chưa điền SĐT!");
                txtTenDonVi.ResetText();
                txtTenDonVi.Focus();
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaDonVi.Text = gridView1.GetRowCellValue(e.RowHandle, "DonViId").ToString();
            txtTenDonVi.Text = gridView1.GetRowCellValue(e.RowHandle, "tenDonVi").ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    bus_donvi.Delete(int.Parse(txtMaDonVi.Text));
                    MessageBox.Show("Xóa thành công!");
                    UCDonVi_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể xóa được bản ghi đơn vị\nVui lòng kiểm tra lại kết nối và dữ liệu chọn!");
                    txtTenDonVi.ResetText();
                    txtTenDonVi.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenDonVi.Text) && !string.IsNullOrEmpty(txtMaDonVi.Text) && !string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtSDT.Text))
            {
                try
                {

                    DonVi DonVi = new DonVi(int.Parse(txtMaDonVi.Text),txtTenDonVi.Text);
                    DonVi.DonViId = int.Parse(txtMaDonVi.Text);

                    if (bus_donvi.Update(DonVi) == true)
                    {
                        MessageBox.Show("Đã cập nhập thành công!");
                        txtTenDonVi.Enabled = false;
                        UCDonVi_Load(sender, e);
                        // lưu vào log ... viết sau
                    }


                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được đơn vị\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenDonVi.ResetText();
                    txtTenDonVi.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenDonVi, "Chưa điền tên đơn vị!");
                errorProvider1.SetError(txtMaDonVi, "Chưa điền mã đơn vị!");
                errorProvider1.SetError(txtDiaChi, "Chưa điền tên địa chỉ!");
                errorProvider1.SetError(txtSDT, "Chưa điền SĐT!");
                txtTenDonVi.ResetText();
                txtTenDonVi.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTenDonVi.Enabled = true;
            txtMaDonVi.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtGhiChu.Enabled = true;
        }
    }
}
