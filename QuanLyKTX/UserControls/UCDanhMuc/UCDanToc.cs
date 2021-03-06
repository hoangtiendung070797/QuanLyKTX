﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCDanToc : UserControl
    {
        #region Properties
        bool isAddController = true;
        bool isFixController = true;
        bool isDeleteController = true;
        #endregion
        public UCDanToc()
        {
            InitializeComponent();

        }
        BUS_DanToc bus_DanToc = new BUS_DanToc();
        int chucnang = 0;

      
        private void UCDanToc_Load(object sender, EventArgs e)
        {
            reset();
        }

        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã dân tộc";
            gridView1.Columns[1].Caption = "Tên dân tộc";
        }
        void display()
        {
            gridControl1.DataSource = bus_DanToc.GetData();
            FixNColumnNames();
        }
        void reset()
        {
            LoadControlManagement();
            btnAdd.Enabled = isAddController;
            btnEdit.Enabled = isFixController;
            btnDelete.Enabled = isDeleteController;

            btnSave.Enabled = false;
            btncancel.Enabled = false;

            txtMaDanToc.Enabled = false;
            txtTenDanToc.Enabled = false;

            txtMaDanToc.Text = "";
            txtTenDanToc.Text = "";

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
            btncancel.Enabled = true;

            txtTenDanToc.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;
            btncancel.Enabled = true;

            txtTenDanToc.Enabled = true;
        }
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaDanToc.Text = gridView1.GetRowCellValue(e.RowHandle, "DanTocId").ToString();
            txtTenDanToc.Text = gridView1.GetRowCellValue(e.RowHandle, "tenDanToc").ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenDanToc.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                errorProvider1.SetError(txtTenDanToc,"Chưa điền tên.");
            }
                
            else
            {
                DanToc dantoc = new DanToc();
                if (chucnang == 1)
                {
                    dantoc.TenDanToc = txtTenDanToc.Text;
                    if(bus_DanToc.Insert(dantoc))
                    {
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "thêm thành công dân tộc " + txtMaDanToc.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Tạo";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Dân tộc";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                    }
                  
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");
                }

                if (chucnang == 2)
                {                   
                    dantoc.DanTocId = int.Parse(txtMaDanToc.Text);
                    dantoc.TenDanToc = txtTenDanToc.Text;
                    if (bus_DanToc.Update(dantoc))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Cập nhập thành công dân tộc " + txtMaDanToc.Text + " trong hệ thống";
                        nhatKy.ThaoTac = "Cập nhập";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Dân tộc";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("cập nhật dữ liệu thành công.", "Thông báo.");
                    }
                    else MessageBox.Show("Cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaDanToc.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus_DanToc.Delete(int.Parse(txtMaDanToc.Text)))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Xóa thành công dân tộc " + txtMaDanToc.Text + " ra khỏi hệ thống";
                        nhatKy.ThaoTac = "Xóa";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Dân tộc";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo.");
                    }
                  
                    else MessageBox.Show("Xóa dữ liệu lỗi.", "Thông báo.");
                    reset();
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo");
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void LoadControlManagement()
        {
            var query = Const.PhanQuyens.Where(x => x.TenChucNang == this.Tag.ToString()).Single();
            if(Const.CurrentUser.TenDangNhap != "admin")
            {
                isAddController = query.ChucNangThem;
                isFixController = query.ChucNangSua ;
                isDeleteController = query.ChucNangXoa;
            }
        }
        
    }
}

