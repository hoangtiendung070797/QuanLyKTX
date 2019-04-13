using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls.UCGiaoDich
{
    public partial class UCKhenThuong : UserControl
    {
        public UCKhenThuong()
        {
            InitializeComponent();
        }

        BUS_KhenThuong bus_KhenThuong = new BUS_KhenThuong();
        DataTable doituong = new DataTable();
        BUS_DoiTuong bus_doituong = new BUS_DoiTuong();
        int TempDoiTuongID = 0;
        int chucnang = 0;
        private void txtMSV_EditValueChanged(object sender, EventArgs e)
        {
            doituong = bus_doituong.GetData_Find(txtMSV.Text);
            if (doituong.Rows.Count != 0)
            {
                txtHoTen.Text = doituong.Rows[0][8].ToString() + doituong.Rows[0][9].ToString();
                TempDoiTuongID = int.Parse(doituong.Rows[0][0].ToString());
                MessageBox.Show(TempDoiTuongID.ToString());
            }             
            else
                txtHoTen.Text = "";
        }

        private void UCKhenThuong_Load(object sender, EventArgs e)
        {
            display();
        }

        void display()
        {
            gridControl1.DataSource = bus_KhenThuong.GetData();
        }
        void reset()
        {
            txtMSV.Enabled = false;
            txtHoTen.Enabled = false;
            txtGhiChu.Enabled = false;
            txtNoiDung.Enabled = false;
            dpkNgayThem.Enabled = false;
            txtTenKhenthuong.Enabled = false;

            txtMSV.Text = "";
            txtHoTen.Text = "";
            txtGhiChu.Text = "";
            txtNoiDung.Text = "";
            txtTenKhenthuong.Text = "";

            TempDoiTuongID = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            chucnang = 1;

            txtMSV.Enabled = true;        
            txtGhiChu.Enabled = true;
            txtNoiDung.Enabled = true;
            txtTenKhenthuong.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            txtGhiChu.Enabled = true;
            txtNoiDung.Enabled = true;
            txtTenKhenthuong.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bus_KhenThuong.Delete(khenthuongID);
                    MessageBox.Show("Xóa thành công!");
                    reset();
                    display();
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo"); 
        }

        int khenthuongID = 0;      
        int doituongID;
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            khenthuongID = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "KhenThuongId").ToString());
            doituongID = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "DoiTuongId").ToString());
            txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();
            txtNoiDung.Text = gridView1.GetRowCellValue(e.RowHandle, "noiDung").ToString();
            txtTenKhenthuong.Text = gridView1.GetRowCellValue(e.RowHandle, "tenKhenThuong").ToString();
            dpkNgayThem.Text = gridView1.GetRowCellValue(e.RowHandle, "ngay").ToString();          
            txtHoTen.Text= gridView1.GetRowCellValue(e.RowHandle, "hoDem").ToString() + " "+ gridView1.GetRowCellValue(e.RowHandle, "ten").ToString();
            txtMSV.Text = gridView1.GetRowCellValue(e.RowHandle, "hoDem").ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(chucnang ==1)
            {
                if(txtMSV.Text=="" || txtHoTen.Text=="" || txtTenKhenthuong.Text =="" || txtNoiDung.Text =="")
                {
                    MessageBox.Show("Dữ liệu nhập chưa đủ", "Thông báo");

                    // bắt lỗi
                }
                else
                {
                    KhenThuong khenthuong = new KhenThuong();
                    khenthuong.DoiTuongId = TempDoiTuongID;
                    khenthuong.TenKhenThuong = txtTenKhenthuong.Text;
                    khenthuong.NoiDung = txtNoiDung.Text;
                    khenthuong.Ngay = DateTime.Now;
                    khenthuong.GhiChu = txtGhiChu.Text;
                    bus_KhenThuong.Insert(khenthuong);
                    MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                }
            }
            if(chucnang ==2)
            {
                KhenThuong khenthuong = new KhenThuong();
                khenthuong.DoiTuongId = TempDoiTuongID;
                khenthuong.TenKhenThuong = txtTenKhenthuong.Text;
                khenthuong.NoiDung = txtNoiDung.Text;
                khenthuong.Ngay = DateTime.Now;
                khenthuong.GhiChu = txtGhiChu.Text;
                bus_KhenThuong.Update(khenthuong);
                MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
            }
        }
    }
}
