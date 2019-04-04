using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls
{
    public partial class UCLop : UserControl
    {
        public UCLop()
        {
            InitializeComponent();
        }
        BUS_Lop bUS_Lop = new BUS_Lop();
        private void UCLop_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bUS_Lop.GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTenLop.Enabled = true;
            txtMaLop.Enabled = true;
            cbbDonvi.Enabled = true;

            if (!string.IsNullOrEmpty(txtTenLop.Text) && !string.IsNullOrEmpty(txtMaLop.Text) && !string.IsNullOrEmpty(cbbDonvi.Text))
            {
                try
                {

                    Lop Lop = new Lop();
                    Lop.TenLop = txtTenLop.Text;
                    Lop.DonViId = int.Parse(cbbDonvi.Text);
                    //MessageBox.Show(dAL_Lop.GetIdentityId().ToString());
                    bUS_Lop.Insert(Lop);
                    MessageBox.Show("Thêm thành công!");
                    txtTenLop.Enabled = false;
                    UCLop_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được lớp\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenLop.ResetText();
                    txtTenLop.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenLop, "Chưa điền tên lớp!");
                errorProvider1.SetError(txtMaLop, "Chưa điền tên lớp!");
                errorProvider1.SetError(cbbDonvi, "Chưa điền tên lớp!");
                txtTenLop.ResetText();
                txtTenLop.Focus();
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaLop.Text = gridView1.GetRowCellValue(e.RowHandle, "LopId").ToString();
            txtTenLop.Text = gridView1.GetRowCellValue(e.RowHandle, "tenLop").ToString();
            cbbDonvi.Text = gridView1.GetRowCellValue(e.RowHandle, "DonViId").ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenLop.Text) && !string.IsNullOrEmpty(txtMaLop.Text) && !string.IsNullOrEmpty(cbbDonvi.Text))
            {
                try
                {

                    Lop Lop = new Lop();
                    Lop.TenLop = txtTenLop.Text;
                    Lop.DonViId = int.Parse(cbbDonvi.Text);
                    Lop.LopId = int.Parse( txtMaLop.Text);

                    if (bUS_Lop.Update(Lop) == true)
                    {
                        MessageBox.Show("Đã cập nhập thành công!");
                        txtTenLop.Enabled = false;
                        UCLop_Load(sender, e);
                        // lưu vào log ... viết sau
                    }


                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được lớp\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenLop.ResetText();
                    txtTenLop.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTenLop, "Chưa điền tên lớp!");
                errorProvider1.SetError(txtMaLop, "Chưa điền tên lớp!");
                errorProvider1.SetError(cbbDonvi, "Chưa điền tên lớp!");
                txtTenLop.ResetText();
                txtTenLop.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTenLop.Enabled = true;
            txtMaLop.Enabled = true;
            cbbDonvi.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    bUS_Lop.Delete(int.Parse(txtMaLop.Text));
                    MessageBox.Show("Xóa thành công!");
                    UCLop_Load(sender, e);
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể xóa được bản ghi lớp\nVui lòng kiểm tra lại kết nối và dữ liệu chọn!");
                    txtTenLop.ResetText();
                    txtTenLop.Focus();
                }
            }
        }
    }
}
