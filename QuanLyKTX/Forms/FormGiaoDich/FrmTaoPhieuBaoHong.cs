using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;
namespace QuanLyKTX.Forms.FormGiaoDich
{
    public partial class FrmTaoPhieuBaoHong : Form
    {
        public FrmTaoPhieuBaoHong()
        {
            InitializeComponent();
            LoadComBoBox();
            SetColumn_ThietBi();
        }
        #region Prototies
        PhieuBaoHongVatTu PhieuBaoHongVatTu = new PhieuBaoHongVatTu();
        ChiTietPhieuBaoHongVatTu ChiTietPhieuBaoHongVatTu = new ChiTietPhieuBaoHongVatTu();
        BUS_Phong BUS_Phong = new BUS_Phong();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_NguoiDung BUS_NguoiDung = new BUS_NguoiDung();
        BUS_VatTu BUS_VatTu = new BUS_VatTu();
        BUS_PhieuBaoHongVatTu BUS_PhieuBaoHongVatTu = new BUS_PhieuBaoHongVatTu();
        BUS_ChiTietPhieuBaoHongVatTu BUS_ChiTietPhieuBaoHongVatTu = new BUS_ChiTietPhieuBaoHongVatTu();

        int i = 1;
        #endregion
        public void LoadComBoBox()
        {
            cbPhong.DataSource = BUS_Phong.GetData();
            cbPhong.DisplayMember = "tenPhong";
            cbPhong.ValueMember = "PhongId";
            cbPhong.SelectedValue = "";

            cbNhanVien.DataSource = BUS_NhanVien.GetData();
            cbNhanVien.DisplayMember = "tenNhanVien";
            cbNhanVien.ValueMember = "NhanVienID";
            cbNhanVien.SelectedValue = 0;

            cbNguoiDung.DataSource = BUS_NguoiDung.GetData();
            cbNguoiDung.DisplayMember = "tenDangNhap";
            cbNguoiDung.ValueMember = "NguoiDungId";
            cbNguoiDung.SelectedValue = 0;

            cbVatTu.DataSource = BUS_VatTu.GetData();
            cbVatTu.DisplayMember = "tenVatTu";
            cbVatTu.ValueMember = "VatTuId";
            cbVatTu.SelectedValue = "";

            dateNgayBao.DateTime = DateTime.Now;
        }

        public void SetColumn_ThietBi()
        {
            listViewThietBi.Columns.Add("STT",30);
            listViewThietBi.Columns.Add("Mã vật tư", 100);
            listViewThietBi.Columns.Add("Tên vật tư", 100);
            listViewThietBi.Columns.Add("Số lượng",100);
            listViewThietBi.Columns.Add("Đơn vị tính", 100);
            listViewThietBi.Columns.Add("Lý do", 100);
            listViewThietBi.Columns.Add("Yêu cầu", 100);
            listViewThietBi.Columns.Add("Ghi chú", 100);
            listViewThietBi.GridLines = true;
            listViewThietBi.FullRowSelect = true;
        }
        private void FrmTaoPhieuBaoHong_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddThietBiHong frmAddThietBiHong = new FrmAddThietBiHong();
            if (cbVatTu.Text == "")
            {
                MessageBox.Show("Mời chọn vật tư", "Thông báo");
                return;
            }
            else
            {              
                frmAddThietBiHong.txtMaVatTu.Text = cbVatTu.SelectedValue.ToString();
                frmAddThietBiHong.txtTenVatTu.Text = cbVatTu.Text;
                
                frmAddThietBiHong.ShowDialog();               
                if (frmAddThietBiHong.ckOk.Checked == true)
                {
                    ListViewItem item = new ListViewItem(i.ToString());
                    item.SubItems.Add(frmAddThietBiHong.txtMaVatTu.Text);
                    item.SubItems.Add(frmAddThietBiHong.txtTenVatTu.Text);
                    item.SubItems.Add(frmAddThietBiHong.txtSoLuong.Text);
                    item.SubItems.Add(frmAddThietBiHong.txtDonViTinh.Text);
                    item.SubItems.Add(frmAddThietBiHong.txtLyDo.Text);
                    item.SubItems.Add(frmAddThietBiHong.txtYeuCau.Text);
                    item.SubItems.Add(frmAddThietBiHong.txtGhiChu.Text);
                    listViewThietBi.Items.Add(item);
                    i++;

                }
            }
            
        }

        private void btnDeletee_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewThietBi.SelectedItems)
            {
                listViewThietBi.Items.Remove(item);
                i--;
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy bỏ hay không ?","Thông báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                this.Close();
            }
            
        }

        // Set giá trị cho phiếu báo hỏng
        public void SetPhieuBaoHong()
        {
            PhieuBaoHongVatTu.TenPhieuBaoHong = txtTenPhieu.Text;
            PhieuBaoHongVatTu.PhongId = cbPhong.SelectedValue.ToString();
            PhieuBaoHongVatTu.NgayBao = dateNgayBao.DateTime;
            PhieuBaoHongVatTu.TenNguoiLap = txtNguoiLap.Text;
            PhieuBaoHongVatTu.NhanVienId = (int)cbNhanVien.SelectedValue;
            PhieuBaoHongVatTu.NguoiDungId = (int)cbNguoiDung.SelectedValue;
            PhieuBaoHongVatTu.GhiChu1 = txtGhiChu.Text;
                
        }
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenPhieu.Text == "" || cbPhong.Text == "" || dateNgayBao.Text == "" || txtNguoiLap.Text == "" || cbNhanVien.Text == "" || cbNguoiDung.Text == "")
                {
                    MessageBox.Show("Mời điền đủ thông tin bắt buộc (*) !", "Thông báo");
                    return;
                }
                SetPhieuBaoHong();
                BUS_PhieuBaoHongVatTu.Insert(PhieuBaoHongVatTu);                
                foreach (DataRow row in BUS_PhieuBaoHongVatTu.SetPhieuBaoHongID().Rows)
                {
                    for (int i = 0; i < listViewThietBi.Items.Count; i++)
                    {
                        ChiTietPhieuBaoHongVatTu.PhieuBaoHongVatTuId = (int)row["PhieuBaoHongVatTuId"];
                        ChiTietPhieuBaoHongVatTu.VatTuId = listViewThietBi.Items[i].SubItems[1].Text;
                        ChiTietPhieuBaoHongVatTu.SoLuong = int.Parse(listViewThietBi.Items[i].SubItems[3].Text);
                        ChiTietPhieuBaoHongVatTu.DonViTinh = listViewThietBi.Items[i].SubItems[4].Text;
                        ChiTietPhieuBaoHongVatTu.LyDo = listViewThietBi.Items[i].SubItems[5].Text;
                        ChiTietPhieuBaoHongVatTu.YeuCau = listViewThietBi.Items[i].SubItems[6].Text;
                        ChiTietPhieuBaoHongVatTu.GhiChu = listViewThietBi.Items[i].SubItems[7].Text;
                        BUS_ChiTietPhieuBaoHongVatTu.Insert(ChiTietPhieuBaoHongVatTu);

                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Tạo thành công báo hỏng  vật tư-id: " + ChiTietPhieuBaoHongVatTu.VatTuId + " số lượng: " + ChiTietPhieuBaoHongVatTu.SoLuong + " vào hệ thống";
                        nhatKy.ThaoTac = "Tạo";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Yêu cầu sữa chữa thiết bị vật tư";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                    }
                }
                MessageBox.Show("Đã tạo phiếu thành công", "Thông báo");
                this.Close();               
            }
            catch
            {
                MessageBox.Show("Lỗi! không thể tạo phiếu mời kiểm tra và thử lại","Thông báo");
             
            }
            
        }
    }
}
