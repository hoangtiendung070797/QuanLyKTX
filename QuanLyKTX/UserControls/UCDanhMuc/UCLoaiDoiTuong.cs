﻿using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls
{
    public partial class UCLoaiDoiTuong : UserControl
    {
        public UCLoaiDoiTuong()
        {
            InitializeComponent();
        }

        BUS_LoaiDoiTuong bUS_LoaiDoiTuong = new BUS_LoaiDoiTuong();
        int chucnang = 0;
       

        void display()
        {
            gridControl1.DataSource = bUS_LoaiDoiTuong.GetData();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMaLoaiDoiTuong.Enabled = false;
            txtTenLoaiDoiTuong.Enabled = false;

            txtMaLoaiDoiTuong.Text = "";
            txtTenLoaiDoiTuong.Text = "";

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

            txtTenLoaiDoiTuong.Enabled = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenLoaiDoiTuong.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiDoiTuong.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_LoaiDoiTuong.Delete(int.Parse(txtMaLoaiDoiTuong.Text)))
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
            if (txtTenLoaiDoiTuong.Text == "" )
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
            else
            {
                LoaiDoiTuong loaidoituong = new LoaiDoiTuong();

                if (chucnang == 1)
                {
                    loaidoituong.TenLoaiDoiTuong = txtTenLoaiDoiTuong.Text;
                    if (bUS_LoaiDoiTuong.Insert(loaidoituong))
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    loaidoituong.LoaiDoiTuongId = int.Parse(txtMaLoaiDoiTuong.Text);
                    loaidoituong.TenLoaiDoiTuong = txtTenLoaiDoiTuong.Text;
                    if(bUS_LoaiDoiTuong.Update(loaidoituong))
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
            txtMaLoaiDoiTuong.Text = gridView1.GetRowCellValue(e.RowHandle, "LoaiDoiTuongId").ToString();
            txtTenLoaiDoiTuong.Text = gridView1.GetRowCellValue(e.RowHandle, "tenLoaiDoiTuong").ToString();
        }

        private void UCLoaiDoiTuong_Load(object sender, EventArgs e)
        {
            reset();
        }
    }
}
