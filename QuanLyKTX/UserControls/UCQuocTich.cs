using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCQuocTich : UserControl
    {
        public UCQuocTich()
        {
            InitializeComponent();
        }
        BUS_QuocTich bUS_QuocTich = new BUS_QuocTich();
        private void UCQuocTich_Load(object sender, EventArgs e)
        {
            gridControlQuocTich.DataSource = bUS_QuocTich.GetData();

        }
     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            


            if (!string.IsNullOrEmpty(txtTenQuocTich.Text))
            {
                try
                {

                    QuocTich quocTich = new QuocTich(txtTenQuocTich.Text);
                    //MessageBox.Show(dAL_QuocTich.GetIdentityId().ToString());
                    bUS_QuocTich.Insert(quocTich);
                    MessageBox.Show("Thêm thành công!");
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể thêm được quốc tịch\nVui lòng kiểm tra lại kết nối và dữ liệu nhập!");
                    txtTenQuocTich.ResetText();
                    txtTenQuocTich.Focus();
                }
            }
            else
            {
                errorProvider.SetError(txtTenQuocTich, "Chưa điền tên quốc tịch!");
                txtTenQuocTich.ResetText();
                txtTenQuocTich.Focus();
            }
        }

        

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaQuocTich.Text = gridView1.GetRowCellValue(e.RowHandle, "QuocTichId").ToString();
            txtTenQuocTich.Text = gridView1.GetRowCellValue(e.RowHandle, "tenQuocTich").ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    bUS_QuocTich.Delete(int.Parse(txtMaQuocTich.Text));
                    MessageBox.Show("Xóa thành công!");
                    gridView1.RefreshData();
                    // lưu vào log ... viết sau
                }
                catch
                {

                    MessageBox.Show("Thao tác bị lỗi, không thể xóa được bản ghi quốc tịch\nVui lòng kiểm tra lại kết nối và dữ liệu chọn!");
                    txtTenQuocTich.ResetText();
                    txtTenQuocTich.Focus();
                }
            }
        }
    }
}
