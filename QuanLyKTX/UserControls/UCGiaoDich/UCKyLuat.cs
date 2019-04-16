using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyKTX.UserControls.UCGiaoDich
{
    public partial class UCKyLuat : UserControl
    {
        public UCKyLuat()
        {
            InitializeComponent();
        }

        BUS_KyLuat bus_KyLuat = new BUS_KyLuat();
        DataTable doituong = new DataTable();
        BUS_DoiTuong bus_doituong = new BUS_DoiTuong();
        int TempDoiTuongID = 0;
        int chucnang = 0;

        private void UCKyLuat_Load(object sender, EventArgs e)
        {
            reset();
        }

        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "ID Kỷ Luật";
            gridView1.Columns[1].Caption = "ID Đối Tượng";
            //  gridView1.Columns[2].Caption = "ID Đối Tượng";
            gridView1.Columns[2].Caption = "Mã Sinh Viên";
            gridView1.Columns[3].Caption = "Họ Đệm";
            gridView1.Columns[4].Caption = "Tên";
            gridView1.Columns[5].Caption = "Tên Kỷ Luật";
            gridView1.Columns[6].Caption = "Nội Dung";
            gridView1.Columns[7].Caption = "Ngày";
            gridView1.Columns[8].Caption = "Ghi Chú";

        }
        void display()
        {
            gridControl1.DataSource = bus_KyLuat.GetData();
            FixNColumnNames();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMSV.Enabled = false;
            txtHoTen.Enabled = false;
            txtGhiChu.Enabled = false;
            txtNoiDung.Enabled = false;
            dpkNgayThem.Enabled = false;
            txtTenKyLuat.Enabled = false;

            txtMSV.Text = "";
            txtHoTen.Text = "";
            txtGhiChu.Text = "";
            txtNoiDung.Text = "";
            txtTenKyLuat.Text = "";

            TempDoiTuongID = 0;
            KyLuatID = 0;

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

            txtMSV.Enabled = true;
            txtTenKyLuat.Enabled = true;
            txtNoiDung.Enabled = true;
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

            txtMSV.Enabled = true;
            txtTenKyLuat.Enabled = true;
            txtNoiDung.Enabled = true;
            txtGhiChu.Enabled = true;
            dpkNgayThem.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus_KyLuat.Delete(KyLuatID))
                    {
                        MessageBox.Show("Xóa thành công!");
                        reset();
                    }
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo");
        }

        int KyLuatID = 0;
        int doituongID;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text == "" || txtHoTen.Text == "" || txtNoiDung.Text == "" || txtTenKyLuat.Text == "")
            {
                if (txtHoTen.Text == "")
                    MessageBox.Show("Không tìm thấy đối tượng.");
                if (txtTenKyLuat.Text == "") errorProvider1.SetError(txtTenKyLuat, "Chưa điền tên.");
                if (txtNoiDung.Text == "") errorProvider1.SetError(txtNoiDung, "Chưa điền nội dung.");
            }

            else
            {
                KyLuat Kyluat = new KyLuat();

                if (chucnang == 1)
                {
                    Kyluat.DoiTuongId = TempDoiTuongID;
                    Kyluat.TenKyLuat = txtTenKyLuat.Text;
                    Kyluat.NoiDung = txtNoiDung.Text;
                    Kyluat.Ngay = DateTime.Now;
                    Kyluat.GhiChu = txtGhiChu.Text;


                    if (bus_KyLuat.Insert(Kyluat))
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    Kyluat.KyLuatId = KyLuatID;
                    Kyluat.DoiTuongId = doituongID;
                    Kyluat.TenKyLuat = txtTenKyLuat.Text;
                    Kyluat.NoiDung = txtNoiDung.Text;
                    Kyluat.Ngay = dpkNgayThem.Value;
                    Kyluat.GhiChu = txtGhiChu.Text;
                    if (bus_KyLuat.Update(Kyluat))
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
            KyLuatID = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "KyLuatId").ToString());
            doituongID = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "DoiTuongId").ToString());
            txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();
            txtNoiDung.Text = gridView1.GetRowCellValue(e.RowHandle, "noiDung").ToString();
            txtTenKyLuat.Text = gridView1.GetRowCellValue(e.RowHandle, "tenKyLuat").ToString();
            dpkNgayThem.Text = gridView1.GetRowCellValue(e.RowHandle, "ngay").ToString();
            txtHoTen.Text = gridView1.GetRowCellValue(e.RowHandle, "hoDem").ToString() + " " + gridView1.GetRowCellValue(e.RowHandle, "ten").ToString();
            txtMSV.Text = gridView1.GetRowCellValue(e.RowHandle, "maSinhVien").ToString();
        }

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
    }
}
