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
        int chucnang = 0;

        private void UCTinhThanh_Load(object sender, EventArgs e)
        {
            reset();
            FixNColumnNames();
        }
        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã tỉnh thành";
            gridView1.Columns[1].Caption = "Tên tỉnh thành ";
        }

        void display()
        {
            gridControl1.DataSource = bUS_TinhThanh.GetData();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMaTinhThanh.Enabled = false;
            txtTenTinhThanh.Enabled = false;

            txtMaTinhThanh.Text = "";
            txtTenTinhThanh.Text = "";

            display();

        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaTinhThanh.Text = gridView1.GetRowCellValue(e.RowHandle, "TinhThanhId").ToString();
            txtTenTinhThanh.Text = gridView1.GetRowCellValue(e.RowHandle, "tenTinhThanh").ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chucnang = 1;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenTinhThanh.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenTinhThanh.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaTinhThanh.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_TinhThanh.Delete(int.Parse(txtMaTinhThanh.Text)))
                    {
                        MessageBox.Show("Xóa thành công!");
                        reset();
                    }
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenTinhThanh.Text == "")
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
            else
            {
                TinhThanh tinhthanh = new TinhThanh();

                if (chucnang == 1)
                {
                    tinhthanh.TenTinhThanh = txtTenTinhThanh.Text;
                    if (bUS_TinhThanh.Insert(tinhthanh))
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    tinhthanh.TinhThanhId = int.Parse(txtMaTinhThanh.Text);
                    tinhthanh.TenTinhThanh = txtTenTinhThanh.Text;
                    if (bUS_TinhThanh.Update(tinhthanh))
                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
