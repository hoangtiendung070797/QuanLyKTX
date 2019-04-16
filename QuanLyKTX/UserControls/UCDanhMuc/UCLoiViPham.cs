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
        int chucnang = 0;
        private void UCLoiViPham_Load_1(object sender, EventArgs e)
        {
            reset();
            FixNColumnNames();
        }   

        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã lỗi vi phạm";
            gridView1.Columns[1].Caption = "Tên lỗi vi phạm";
            gridView1.Columns[2].Caption = "Nội dung";
            gridView1.Columns[3].Caption = "Hình thức xử lý";
            gridView1.Columns[4].Caption = "Ghi chú";
        }

        void display()
        {
            gridControl1.DataSource = bUS_LoiViPham.GetData();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMaLoi.Enabled = false;
            txtTenLoi.Enabled = false;
            txtNoiDung.Enabled = false;
            txtHinhThucXuLy.Enabled = false;
            txtGhiChu.Enabled = false;

            txtMaLoi.Text = "";
            txtTenLoi.Text = "";
            txtNoiDung.Text = "";
            txtHinhThucXuLy.Text = "";
            txtGhiChu.Text = "";

            display();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            reset();
            chucnang = 1;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenLoi.Enabled = true;
            txtNoiDung.Enabled = true;
            txtHinhThucXuLy.Enabled = true;
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

            txtTenLoi.Enabled = true;
            txtNoiDung.Enabled = true;
            txtHinhThucXuLy.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaLoi.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_LoiViPham.Delete(int.Parse(txtMaLoi.Text)))
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
            if (txtTenLoi.Text == "" || txtHinhThucXuLy.Text == "" || txtNoiDung.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                if (txtTenLoi.Text == "") errorProvider1.SetError(txtTenLoi, "Chưa điền tên.");
                if (txtNoiDung.Text == "") errorProvider1.SetError(txtNoiDung, "Chưa điền thông tin.");
                if (txtHinhThucXuLy.Text == "") errorProvider1.SetError(txtHinhThucXuLy, "Chưa điền thông tin.");
            }
            else
            {
                LoiViPham loivipham = new LoiViPham();

                if (chucnang == 1)
                {
                    loivipham.TenLoiViPham = txtTenLoi.Text;
                    loivipham.NoiDung = txtNoiDung.Text;
                    loivipham.HinhThucXuLy = txtHinhThucXuLy.Text;
                    loivipham.GhiChu = txtGhiChu.Text;
                    if (bUS_LoiViPham.Insert(loivipham))
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    loivipham.LoiViPhamId = int.Parse(txtMaLoi.Text);
                    loivipham.TenLoiViPham = txtTenLoi.Text;
                    loivipham.NoiDung = txtNoiDung.Text;
                    loivipham.HinhThucXuLy = txtHinhThucXuLy.Text;
                    loivipham.GhiChu = txtGhiChu.Text;
                    if (bUS_LoiViPham.Update(loivipham))
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

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaLoi.Text = gridView1.GetRowCellValue(e.RowHandle, "LoiViPhamId").ToString();
            txtTenLoi.Text = gridView1.GetRowCellValue(e.RowHandle, "tenLoiViPham").ToString();
            txtNoiDung.Text = gridView1.GetRowCellValue(e.RowHandle, "noiDung").ToString();
            txtHinhThucXuLy.Text = gridView1.GetRowCellValue(e.RowHandle, "hinhThucXuLy").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();
    
        }

        
    }
}
