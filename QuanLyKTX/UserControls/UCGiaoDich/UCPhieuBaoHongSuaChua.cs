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
using QuanLyKTX.Forms.FormGiaoDich;

namespace QuanLyKTX.UserControls.UCGiaoDich
{
    public partial class UCPhieuBaoHongSuaChua : UserControl
    {
        public UCPhieuBaoHongSuaChua()
        {
            
            InitializeComponent();
        }
        #region Properties 
        PhieuBaoHongVatTu PhieuBaoHongVatTu = new PhieuBaoHongVatTu();
        ChiTietPhieuBaoHongVatTu ChiTietPhieuBaoHongVatTu = new ChiTietPhieuBaoHongVatTu();
        BUS_ChiTietPhieuBaoHongVatTu BUS_ChiTietPhieuBaoHongVatTu = new BUS_ChiTietPhieuBaoHongVatTu();
        BUS_PhieuBaoHongVatTu BUS_PhieuBaoHongVatTu = new BUS_PhieuBaoHongVatTu();

        int phieubaohongId = 0;
        #endregion

        public void LoadPhieuBaoHong()
        {
            gridControlPhieuSuaChua.DataSource = BUS_PhieuBaoHongVatTu.GetDataNew();
            gridViewPhieuSuaChua.Columns[0].Visible = false;
            gridViewPhieuSuaChua.Columns[1].Visible = false;
            gridViewPhieuSuaChua.Columns[2].Visible = false;
            gridViewPhieuSuaChua.Columns[3].Visible = false;

            gridViewPhieuSuaChua.Columns[4].Caption = "Tên phiếu";
            gridViewPhieuSuaChua.Columns[5].Caption = "Phòng";
            gridViewPhieuSuaChua.Columns[6].Caption = "Người lập";
            gridViewPhieuSuaChua.Columns[7].Caption = "Ngày";
            gridViewPhieuSuaChua.Columns[8].Caption = "Nhân viên";
            gridViewPhieuSuaChua.Columns[9].Caption = "Người dùng";
            gridViewPhieuSuaChua.Columns[10].Caption = "Ghi chú";

        }

        public void LoadChiTietPhieu()
        {
            gridControlChiTiet.DataSource = BUS_ChiTietPhieuBaoHongVatTu.GetDataTheoPhieuBaoHong(0);
            
            gridViewChiTiet.Columns[0].Visible = false;
            gridViewChiTiet.Columns[1].Visible = false;
            gridViewChiTiet.Columns[2].Visible = false;

            
            gridViewChiTiet.Columns[3].Caption = "Tên vật tư";
            gridViewChiTiet.Columns[4].Caption = "Số lượng";
            gridViewChiTiet.Columns[5].Caption = "ĐVT";
            gridViewChiTiet.Columns[6].Caption = "Lý do";
            gridViewChiTiet.Columns[7].Caption = "Yêu cầu";
            gridViewChiTiet.Columns[8].Caption = "Ghi chú";

           
        }
        private void UCPhieuBaoHongSuaCHua_Load(object sender, EventArgs e)
        {
            LoadPhieuBaoHong();
            LoadChiTietPhieu();
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuBaoHong frmTaoPhieuBaoHong = new FrmTaoPhieuBaoHong();
            frmTaoPhieuBaoHong.ShowDialog();
            gridControlPhieuSuaChua.DataSource = BUS_PhieuBaoHongVatTu.GetDataNew();
            
        }

        private void gridViewPhieuSuaChua_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            frmSuaPhieuBaoHong.GetPhieuBaoHongId = phieubaohongId = (int)gridViewPhieuSuaChua.GetRowCellValue(e.RowHandle, "PhieuBaoHongVatTuId");            
            gridControlChiTiet.DataSource = BUS_ChiTietPhieuBaoHongVatTu.GetDataTheoPhieuBaoHong(phieubaohongId);
            frmSuaPhieuBaoHong.txtTenPhieu.Text = gridViewPhieuSuaChua.GetRowCellValue(e.RowHandle, "tenPhieuBaoHong").ToString();
            frmSuaPhieuBaoHong.cbPhong.SelectedValue = gridViewPhieuSuaChua.GetRowCellValue(e.RowHandle, "PhongId");
            frmSuaPhieuBaoHong.dateNgayBao.DateTime = (DateTime)gridViewPhieuSuaChua.GetRowCellValue(e.RowHandle, "ngayBao");
            frmSuaPhieuBaoHong.txtNguoiLap.Text = gridViewPhieuSuaChua.GetRowCellValue(e.RowHandle, "tenNguoiLap").ToString();
            frmSuaPhieuBaoHong.cbNhanVien.SelectedValue = gridViewPhieuSuaChua.GetRowCellValue(e.RowHandle, "NhanVienId");
            frmSuaPhieuBaoHong.cbNguoiDung.SelectedValue = gridViewPhieuSuaChua.GetRowCellValue(e.RowHandle, "NguoiDungId");
            frmSuaPhieuBaoHong.txtGhiChu.Text = gridViewPhieuSuaChua.GetRowCellValue(e.RowHandle, "GhiChu").ToString();
            isClicked = true;

        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in BUS_ChiTietPhieuBaoHongVatTu.GetData().Rows)
                {
                    if ((int)row["PhieuBaoHongVatTuId"] == phieubaohongId)
                    {
                        BUS_ChiTietPhieuBaoHongVatTu.Delete((int)row["ChiTietPhieuBaoHongVatTu"]);
                    }
                }
                BUS_PhieuBaoHongVatTu.Delete(phieubaohongId);

                //------------Ghi log
                NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                nhatKy.NoiDung = "Xóa thành công yêu cầu báo hỏng id: " + phieubaohongId + " ra khỏi hệ thống";
                nhatKy.ThaoTac = "Xóa";
                nhatKy.ThoiGian = DateTime.Now;
                nhatKy.ChucNang = "Yêu cầu sữa chữa thiết bị vật tư";
                Const.NhatKyHoatDong.Insert(nhatKy);
                //-------------------

                gridControlChiTiet.DataSource = BUS_ChiTietPhieuBaoHongVatTu.GetDataTheoPhieuBaoHong(0);
                gridControlPhieuSuaChua.DataSource = BUS_PhieuBaoHongVatTu.GetDataNew();
                MessageBox.Show("Đã xóa phiếu", "Thông báo");
                
            }
            catch
            {
                MessageBox.Show("Lỗi! không xóa được mời kiểm tra và thử lại", "Thông báo");
            }
            
        }
        bool isClicked = false; 

        FrmSuaPhieuBaoHong frmSuaPhieuBaoHong = new FrmSuaPhieuBaoHong();
        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isClicked)
                {
                    MessageBox.Show("Bạn chưa chọn phiếu, xin mời chọn phiếu", "Thông báo");
                    return;
                }
                foreach (DataRow row in BUS_ChiTietPhieuBaoHongVatTu.GetDataTheoPhieuBaoHong(phieubaohongId).Rows)
                {
                    int index = 0;
                    try
                    {
                        index = frmSuaPhieuBaoHong.i==null?0: frmSuaPhieuBaoHong.i;
                    }
                    catch (Exception)
                    {
                        index = 0;
                    }
                 
                    ListViewItem item = new ListViewItem(index.ToString());
                    item.SubItems.Add(row["VatTuId"].ToString());
                    item.SubItems.Add(row["tenVatTu"].ToString());
                    item.SubItems.Add(row["soLuong"].ToString());
                    item.SubItems.Add(row["donViTinh"].ToString());
                    item.SubItems.Add(row["lyDo"].ToString());
                    item.SubItems.Add(row["yeuCau"].ToString());
                    item.SubItems.Add(row["ghiChu"].ToString());
                    frmSuaPhieuBaoHong.listViewThietBi.Items.Add(item);
                    frmSuaPhieuBaoHong.i++;
                }
                frmSuaPhieuBaoHong.ShowDialog();
                frmSuaPhieuBaoHong.listViewThietBi.Items.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
    }
}
