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
    public partial class UCHopDong : UserControl
    {
        public UCHopDong()
        {
            InitializeComponent();
        }

        BUS_HopDong bUS_HopDong = new BUS_HopDong();
        DataTable doituong = new DataTable();
        BUS_DoiTuong bus_doituong = new BUS_DoiTuong();
        int TempDoiTuongID = 0;
        int chucnang = 0;

        private void UCHopDong_Load(object sender, EventArgs e)
        {
            reset();
        }

        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "ID Hợp Đồng";
            gridView1.Columns[1].Caption = "Tên Hợp Đồng";
            gridView1.Columns[2].Caption = "ID Đối Tượng";
            gridView1.Columns[3].Caption = "Mã Sinh Viên";
            gridView1.Columns[4].Caption = "Họ Đệm";
            gridView1.Columns[5].Caption = "Tên";
            gridView1.Columns[6].Caption = "Từ Ngày";
            gridView1.Columns[7].Caption = "Đến Ngày";
            gridView1.Columns[8].Caption = "Thời Hạn Theo Năm";
            gridView1.Columns[9].Caption = "Thời Hạn Theo Tháng";
            gridView1.Columns[10].Caption = "Nội Dung";
        }
        void display()
        {
            gridControl1.DataSource = bUS_HopDong.PrintInfor();
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
            txtTenHopDong.Enabled = false;
            dpkTuNgay.Enabled = false;
            dpkTuNgay.Enabled = false;
            txtNoiDung.Enabled = false;
            txtThoiHanTheoNam.Enabled = false;
            txtThoiHanTheoThang.Enabled = false;

            txtMSV.Text = "";
            txtHoTen.Text = "";
            txtTenHopDong.Text = "";
            txtNoiDung.Text = "";          
            txtThoiHanTheoNam.Text = "";
            txtThoiHanTheoThang.Text = "";

            TempDoiTuongID = 0;
            HopDongid = 0;

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

            txtMSV.Enabled = true;         
            txtTenHopDong.Enabled = true;
            dpkTuNgay.Enabled = true;
            dpkTuNgay.Enabled = true;
            txtNoiDung.Enabled = true;
            txtThoiHanTheoNam.Enabled = true;
            txtThoiHanTheoThang.Enabled = true;
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
            txtTenHopDong.Enabled = true;
            dpkTuNgay.Enabled = true;
            dpkTuNgay.Enabled = true;
            txtNoiDung.Enabled = true;
            txtThoiHanTheoNam.Enabled = true;
            txtThoiHanTheoThang.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_HopDong.Delete(HopDongid))
                    {
                        MessageBox.Show("Xóa thành công!");
                        reset();
                    }
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo");
        }

      

        int HopDongid = 0;
        int doituongID;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text == "" || txtHoTen.Text == "" || txtNoiDung.Text == "" || txtTenHopDong.Text == ""||txtThoiHanTheoNam.Text==""||txtThoiHanTheoThang.Text=="")
            {
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Không tìm thấy đối tượng.");
                    if (txtMSV.Text == "") errorProvider1.SetError(txtMSV, "Chưa điền MSV.");
                }
                if (txtNoiDung.Text == "") errorProvider1.SetError(txtNoiDung, "Chưa điền nội dung.");
                if (txtTenHopDong.Text == "") errorProvider1.SetError(txtTenHopDong, "Chưa điền tên.");
                if (txtThoiHanTheoNam.Text == "") errorProvider1.SetError(txtThoiHanTheoNam, "Chưa điền nội dung.");
                if (txtThoiHanTheoThang.Text == "") errorProvider1.SetError(txtThoiHanTheoThang, "Chưa điền nội dung.");
            }

            else
            {
                HopDong hopdong = new HopDong();

                if (chucnang == 1)
                {
                    
                        hopdong.DoiTuongId = TempDoiTuongID;
                        hopdong.TenHopDong = txtTenHopDong.Text;
                        hopdong.NoiDung = txtNoiDung.Text;
                        hopdong.TuNgay = (DateTime)dpkTuNgay.Value;
                        hopdong.DenNgay = (DateTime)dpkDenNgay.Value;
                        hopdong.ThoiHanTheoNam = int.Parse(txtThoiHanTheoNam.Text);
                        hopdong.ThoiHanTheoThang = int.Parse(txtThoiHanTheoThang.Text);

                        if (bUS_HopDong.Insert(hopdong))
                            MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                        else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");
                    
                }

                if (chucnang == 2)
                {
                    hopdong.HopDongId = HopDongid;
                    hopdong.DoiTuongId = doituongID;
                    hopdong.TenHopDong = txtTenHopDong.Text;
                    hopdong.NoiDung = txtNoiDung.Text;
                    hopdong.TuNgay = dpkTuNgay.Value;
                    hopdong.DenNgay = dpkDenNgay.Value;
                    hopdong.ThoiHanTheoNam = int.Parse(txtThoiHanTheoNam.Text);
                    hopdong.ThoiHanTheoThang = int.Parse(txtThoiHanTheoThang.Text);
                    if (bUS_HopDong.Update(hopdong))
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
            HopDongid = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "HopDongId").ToString());
            doituongID = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "DoiTuongId").ToString());
            txtNoiDung.Text = gridView1.GetRowCellValue(e.RowHandle, "noiDung").ToString();
            txtTenHopDong.Text = gridView1.GetRowCellValue(e.RowHandle, "tenHopDong").ToString();
            dpkTuNgay.Text = gridView1.GetRowCellValue(e.RowHandle, "tuNgay").ToString();
            dpkDenNgay.Text = gridView1.GetRowCellValue(e.RowHandle, "denNgay").ToString();
            txtThoiHanTheoNam.Text= gridView1.GetRowCellValue(e.RowHandle, "thoiHanTheoNam").ToString();
            txtThoiHanTheoThang.Text = gridView1.GetRowCellValue(e.RowHandle, "thoiHanTheoThang").ToString();
            txtHoTen.Text = gridView1.GetRowCellValue(e.RowHandle, "hoDem").ToString() + " " + gridView1.GetRowCellValue(e.RowHandle, "ten").ToString();
            txtMSV.Text = gridView1.GetRowCellValue(e.RowHandle, "maSinhVien").ToString();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            doituong = bus_doituong.GetData_Find(txtMSV.Text);
            if (doituong.Rows.Count != 0)
            {
                txtHoTen.Text = doituong.Rows[0][8].ToString() + doituong.Rows[0][9].ToString();
                TempDoiTuongID = int.Parse(doituong.Rows[0][0].ToString());
              //  MessageBox.Show(TempDoiTuongID.ToString());
            }
            else
                txtHoTen.Text = "";
        }
    }
}
