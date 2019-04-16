using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;
using System.Data;


namespace QuanLyKTX.UserControls
{
    public partial class UCPhong : UserControl
    {
        public UCPhong()
        {
            InitializeComponent();
        }
        BUS_Phong bUS_Phong = new BUS_Phong();
        BUS_LoaiPhong bus_loaiphong = new BUS_LoaiPhong();
        BUS_DayNha bus_daynha = new BUS_DayNha();
        int chucnang = 0;

        private void UCPhong_Load(object sender, EventArgs e)
        {
            reset();
            //  FixNColumnNames();
        }
        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã phòng";
            gridView1.Columns[2].Caption = "Dãy nhà";
            gridView1.Columns[3].Caption = "Loại phòng";
            gridView1.Columns[1].Caption = "Tên phòng";
            gridView1.Columns[4].Caption = "Tầng";
            gridView1.Columns[5].Caption = "Giá phòng";
        }

    
        void display_cbb()
        {
            cbbLoaiPhong.DataSource = bus_loaiphong.GetData();
            cbbLoaiPhong.DisplayMember = "tenLoaiPhong";
            cbbLoaiPhong.ValueMember = "LoaiPhongId";
            cbbDayNha.DataSource = bus_daynha.GetData();
            cbbDayNha.DisplayMember = "tenDayNha";
            cbbDayNha.ValueMember = "DayNhaId";
        }

        void display()
        {
            gridControl1.DataSource = bUS_Phong.PrintInfor();
            FixNColumnNames();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMaPhong.Enabled = false;
            txtTenPhong.Enabled = false;
            txtTang.Enabled = false;
            txtGiaPhong.Enabled = false;
            cbbLoaiPhong.Enabled = false;
            cbbDayNha.Enabled = false;

            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtTang.Text = "";
            txtGiaPhong.Text = "";
            cbbDayNha.Text = "";
            cbbLoaiPhong.Text = "";

            display();
            display_cbb();

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

            txtMaPhong.Enabled = true;
            txtTenPhong.Enabled = true;
            txtTang.Enabled = true;
            txtGiaPhong.Enabled = true;
            cbbLoaiPhong.Enabled = true;
            cbbDayNha.Enabled = true;
        }




        private void btnEdit_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenPhong.Enabled = true;
            txtTang.Enabled = true;
            txtGiaPhong.Enabled = true;
            cbbLoaiPhong.Enabled = true;
            cbbDayNha.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_Phong.Delete(txtMaPhong.Text))
                    {
                        MessageBox.Show("Xóa thành công!");
                        reset();
                    }
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo");
        }

        private void gridView1_CustomRowCellEditForEditing_1(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "PhongId").ToString();         
            txtGiaPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "giaPhong").ToString();
            txtTang.Text = gridView1.GetRowCellValue(e.RowHandle, "tang").ToString();
            txtTenPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "tenPhong").ToString();
            cbbDayNha.Text= gridView1.GetRowCellValue(e.RowHandle, "tenDayNha").ToString();
            cbbLoaiPhong.Text = gridView1.GetRowCellValue(e.RowHandle, "tenLoaiPhong").ToString();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtTenPhong.Text == "" || txtTang.Text == "" || txtMaPhong.Text == "" || txtGiaPhong.Text == "" || cbbLoaiPhong.Text == "" || cbbDayNha.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                if (txtTenPhong.Text == "") errorProvider1.SetError(txtTenPhong, "Chưa điền tên.");
                if (txtTang.Text == "") errorProvider1.SetError(txtTang,"");
                if (txtMaPhong.Text == "") errorProvider1.SetError(txtMaPhong, "Chưa điền mã phòng");
                if (txtGiaPhong.Text == "") errorProvider1.SetError(txtGiaPhong, "Chưa điền giá phòng.");
                if (cbbDayNha.Text == "") errorProvider1.SetError(cbbDayNha, "Chưa chọn dãy nhà.");
                if (cbbLoaiPhong.Text == "") errorProvider1.SetError(cbbLoaiPhong, "Chưa chọn loại phòng.");
            }
            else
            {
                Phong phong = new Phong();

                if (chucnang == 1)
                {
                    phong.PhongId = txtMaPhong.Text;
                    phong.TenPhong = txtTenPhong.Text;
                    phong.GiaPhong = decimal.Parse(txtGiaPhong.Text);
                    phong.Tang = int.Parse(txtTang.Text);
                    phong.DayNhaId = int.Parse(cbbDayNha.SelectedValue.ToString());
                    phong.LoaiPhongId = int.Parse(cbbLoaiPhong.SelectedValue.ToString());

                    if (bUS_Phong.Insert(phong))
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    phong.PhongId = txtMaPhong.Text;
                    phong.TenPhong = txtTenPhong.Text;
                    phong.GiaPhong = decimal.Parse(txtGiaPhong.Text);
                    phong.Tang = int.Parse(txtTang.Text);
                    phong.DayNhaId = int.Parse(cbbDayNha.SelectedValue.ToString());
                    phong.LoaiPhongId = int.Parse(cbbLoaiPhong.SelectedValue.ToString());
                    if (bUS_Phong.Update(phong))
                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
