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
        int chucnang = 0;

        void display()
        {
            gridControl1.DataSource = bus_donvi.GetData();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

             txtMaDonVi.Enabled = false;
             txtTenDonVi.Enabled = false;
             txtDiaChi.Enabled = false;
             txtSDT.Enabled = false;
             txtGhiChu.Enabled = false;

             txtMaDonVi.Text = "";
             txtTenDonVi.Text = "";
             txtSDT.Text = "";
             txtDiaChi.Text = "";
             txtGhiChu.Text = "";

            display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chucnang = 1;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenDonVi.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtGhiChu.Enabled = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenDonVi.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtGhiChu.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaDonVi.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus_donvi.Delete(int.Parse(txtMaDonVi.Text)))
                        MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("Xóa dữ liệu lỗi.", "Thông báo.");
                    reset();
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenDonVi.Text == "" || txtSDT.Text==""||txtDiaChi.Text=="")
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
            else
            {
                DonVi donvi = new DonVi();

                if (chucnang == 1)
                {                   
                    donvi.TenDonVi = txtTenDonVi.Text;
                    donvi.Sdt = txtSDT.Text;
                    donvi.DiaChi = txtDiaChi.Text;
                    donvi.GhiChu = txtGhiChu.Text;
                    if (bus_donvi.Insert(donvi))
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");
                }

                if (chucnang == 2)
                {
                    donvi.DonViId = int.Parse(txtMaDonVi.Text);
                    donvi.TenDonVi = txtTenDonVi.Text;
                    donvi.Sdt = txtSDT.Text;
                    donvi.DiaChi = txtDiaChi.Text;
                    donvi.GhiChu = txtGhiChu.Text;
                    if (bus_donvi.Update(donvi))
                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("Cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaDonVi.Text = gridView1.GetRowCellValue(e.RowHandle, "DonViId").ToString();
            txtTenDonVi.Text = gridView1.GetRowCellValue(e.RowHandle, "tenDonVi").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(e.RowHandle, "diaChi").ToString();
            txtSDT.Text = gridView1.GetRowCellValue(e.RowHandle, "sdt").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();
        }

        private void UCDonVi_Load(object sender, EventArgs e)
        {
            reset();
        }
    }
}
