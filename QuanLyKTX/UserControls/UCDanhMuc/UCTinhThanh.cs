using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCTinhThanh : UserControl
    {
        
        public UCTinhThanh()
        {
            InitializeComponent();
        }
        BUS_TinhThanh bUS_TinhThanh = new BUS_TinhThanh();

        private void UCTinhThanh_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bUS_TinhThanh.GetData();
            FixNColumnNames();
        }
        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã tỉnh thành";
            gridView1.Columns[1].Caption = "Tên tỉnh thành ";
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaTinhThanh.Text = gridView1.GetRowCellValue(e.RowHandle, "TinhThanhId").ToString();
            txtTenTinhThanh.Text = gridView1.GetRowCellValue(e.RowHandle, "tenTinhThanh").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtTenTinhThanh.Enabled = true;

            if (!string.IsNullOrEmpty(txtTenTinhThanh.Text))
            {
                try
                {

                    TinhThanh tinhThanh = new TinhThanh(int.Parse(txtMaTinhThanh.Text),txtTenTinhThanh.Text);
                    //MessageBox.Show(dAL_QuocTich.GetIdentityId().ToString());
                    bUS_TinhThanh.Insert(tinhThanh);
                    MessageBox.Show("Thêm thành công!");
                    txtTenTinhThanh.Enabled = false;
                    UCTinhThanh_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được tỉnh thành\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenTinhThanh.ResetText();
                    txtTenTinhThanh.Focus();
                }
            }
            else
            {
                errorProvider.SetError(txtTenTinhThanh, "Chưa điền tên tỉnh thành!");
                txtTenTinhThanh.ResetText();
                txtTenTinhThanh.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTenTinhThanh.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenTinhThanh.Text))
            {
                try
                {

                    TinhThanh tinhthanh = new TinhThanh(int.Parse(txtMaTinhThanh.Text),txtTenTinhThanh.Text);
                    tinhthanh.TinhThanhId = int.Parse(txtMaTinhThanh.Text);

                    if (bUS_TinhThanh.Update(tinhthanh) == true)
                    {
                        MessageBox.Show("Đã cập nhập thành công!");
                        txtTenTinhThanh.Enabled = false;
                        UCTinhThanh_Load(sender, e);
                        // lưu vào log ... viết sau
                    }


                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể sửa được tỉnh thành\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenTinhThanh.ResetText();
                    txtTenTinhThanh.Focus();
                }
            }
            else
            {
                errorProvider.SetError(txtTenTinhThanh, "Chưa điền tên ỉnh thành!");
                txtTenTinhThanh.ResetText();
                txtTenTinhThanh.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    bUS_TinhThanh.Delete(int.Parse(txtMaTinhThanh.Text));
                    MessageBox.Show("Xóa thành công!");
                    UCTinhThanh_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể xóa được bản ghi tỉnh thành\nVui lòng kiểm tra lại kết nối và dữ liệu chọn!");
                    txtTenTinhThanh.ResetText();
                    txtTenTinhThanh.Focus();
                }
            }
        }
    }
}
