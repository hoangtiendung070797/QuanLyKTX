using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace QuanLyKTX.UserControls.UCGiaoDich
{
    public partial class UCPhieuChi_HoanTra : UserControl
    {
        public UCPhieuChi_HoanTra()
        {
            InitializeComponent();

        }
        #region 
        PhieuChi PhieuChi = new PhieuChi();
        BUS_PhieuChi BUS_PhieuChi = new BUS_PhieuChi();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_NguoiDung BUS_NguoiDung = new BUS_NguoiDung();
        int PhieuID = 0;
        #endregion
        public void LoadComboxNV_ND()
        {
            //Nhân viên
            cbNhanVien.DataSource = BUS_NhanVien.GetData();
            cbNhanVien.DisplayMember = "tenNhanVien";
            cbNhanVien.ValueMember = "NhanVienId";
            cbNhanVien.SelectedValue = 0;

            //Người dùng

            cbNguoiDung.DataSource = BUS_NguoiDung.GetData();
            cbNguoiDung.DisplayMember = "tenDangNhap";
            cbNguoiDung.ValueMember = "NguoiDungId";
            cbNguoiDung.SelectedValue = 0;

            // date
            dateEdit1.DateTime = DateTime.Now;
        }

        public void resetPhieuChi()
        {
            cbNhanVien.SelectedValue = 0;
            cbNguoiDung.SelectedValue = 0;
            dateEdit1.DateTime = DateTime.Now;
            txtSoTien.Text = "";
            txtNoiDung.Text = "";
            txtghiChu.Text = "";
        }

        public void LoadGridControl() // set tên cột grid
        {
            gridControl1.DataSource = BUS_PhieuChi.GetDataNew();
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Visible = false;
            gridView1.Columns[2].Visible = false;
            gridView1.Columns[3].Caption = "Nhân viên";
            gridView1.Columns[4].Caption = "Người dùng";
            gridView1.Columns[5].Caption = "Ngày";
            gridView1.Columns[6].Caption = "Số tiền";
            gridView1.Columns[7].Caption = "Nội dung";
            gridView1.Columns[8].Caption = "Ghi chú";


        }
        private void UCPhieuChi_HoanTra_Load(object sender, EventArgs e)
        {
            LoadGridControl();
            LoadComboxNV_ND();


        }

        public void SetDataPhieuChi()
        {
            PhieuChi.NhanVienId = (int)cbNhanVien.SelectedValue;
            PhieuChi.NguoiDungId = (int)cbNguoiDung.SelectedValue;
            PhieuChi.NgayChi = dateEdit1.DateTime;
            PhieuChi.SoTien = decimal.Parse(txtSoTien.Text);
            PhieuChi.NoiDung = txtNoiDung.Text;
            PhieuChi.GhiChu = txtghiChu.Text;
        }
        private void btnXoaText_Click(object sender, EventArgs e)
        {
            resetPhieuChi();
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn tạo phiếu hay không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SetDataPhieuChi();
                    BUS_PhieuChi.Insert(PhieuChi);
                    gridControl1.DataSource = BUS_PhieuChi.GetDataNew();
                    resetPhieuChi();
                    MessageBox.Show("Đã tạo phiếu", "Thông báo");

                }
                else
                {
                    resetPhieuChi();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi! không tạo được mời kiểm tra lại thông tin phiếu", "Thông báo");
            }

        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            PhieuChi.PhieuChiId = (int)gridView1.GetRowCellValue(e.RowHandle, "PhieuChiId");
            cbNhanVien.SelectedValue = gridView1.GetRowCellValue(e.RowHandle, "NhanVienId");
            cbNguoiDung.SelectedValue = gridView1.GetRowCellValue(e.RowHandle, "NguoiDungId");
            dateEdit1.DateTime = (DateTime)gridView1.GetRowCellValue(e.RowHandle, "ngayChi");
            txtSoTien.Text = gridView1.GetRowCellValue(e.RowHandle, "soTien").ToString();
            txtNoiDung.Text = gridView1.GetRowCellValue(e.RowHandle, "noiDung").ToString();
            txtghiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhật hay không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    SetDataPhieuChi();
                    BUS_PhieuChi.Update(PhieuChi);
                    gridControl1.DataSource = BUS_PhieuChi.GetDataNew();
                    resetPhieuChi();
                    MessageBox.Show("Đã cập nhật", "Thông báo");
                }
                else
                {
                    resetPhieuChi();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không cập nhật được mời kiểm tra lại thông tin phiếu", "Thông báo");
            }

        }
        
        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                    {
                        int rowHandle = gridView1.GetRowHandle(gridView1.GetRowHandle(i));
                        PhieuID = (int)gridView1.GetRowCellValue(rowHandle, "PhieuChiId");
                        BUS_PhieuChi.Delete(PhieuID);
                    }
                    gridControl1.DataSource = BUS_PhieuChi.GetDataNew();
                    resetPhieuChi();
                    MessageBox.Show("Đã xóa", "Thông báo");
                }
                else
                {
                    resetPhieuChi();
                }

            }
            catch
            {
            }
        }
        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
