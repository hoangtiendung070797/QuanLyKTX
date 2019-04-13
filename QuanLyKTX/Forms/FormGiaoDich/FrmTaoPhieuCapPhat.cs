using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DAL;
using DTO;
using QuanLyKTX.UserControls.UCGiaoDich;

namespace QuanLyKTX.Forms.FormGiaoDich
{
    public partial class FrmTaoPhieuCapPhat : DevExpress.XtraEditors.XtraForm
    {
        public FrmTaoPhieuCapPhat()
        {
            InitializeComponent();
        }
        BUS_PhieuCapPhatVatTu BUS_PhieuCapPhatVatTu = new BUS_PhieuCapPhatVatTu();
        
        BUS_Phong BUS_Phong = new BUS_Phong();
        BUS_NguoiDung BUS_NguoiDung = new BUS_NguoiDung();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();

        private void FrmTaoPhieuCapPhat_Load(object sender, EventArgs e)
        {
            cbPhong.DataSource = BUS_Phong.GetData();
            cbPhong.DisplayMember = "tenPhong";
            cbPhong.ValueMember = "PhongId";

            cbNhanVien.DataSource = BUS_NhanVien.GetData();
            cbNhanVien.DisplayMember = "tenNhanVien";
            cbNhanVien.ValueMember = "NhanVienID";

            cbNguoiDung.DataSource = BUS_NguoiDung.GetData();
            cbNguoiDung.DisplayMember = "tenDangNhap";
            cbNguoiDung.ValueMember = "NguoiDungId";
            dateCapPhat.Text = DateTime.Now.ToString();
        }
        UCPhieuCapPhat uCPhieuCapPhat = new UCPhieuCapPhat();
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PhieuCapPhatVatTu phieuCapPhatVatTu = new PhieuCapPhatVatTu();
            phieuCapPhatVatTu.PhongId1 = cbPhong.SelectedValue.ToString();
            phieuCapPhatVatTu.NhanVienId = int.Parse(cbNhanVien.SelectedValue.ToString());
            phieuCapPhatVatTu.NguoiDungId = int.Parse(cbNguoiDung.SelectedValue.ToString());
            phieuCapPhatVatTu.NgayCapPhat = DateTime.Now;
            phieuCapPhatVatTu.TenNguoiLap = txtTenNguoiLap.Text;
            phieuCapPhatVatTu.GhiChu = txtGhiChu.Text;
            foreach (DataRow row in BUS_PhieuCapPhatVatTu.GetData().Rows)
            {
                if (row["PhongId"].ToString() == cbPhong.SelectedValue.ToString() && DateTime.Parse(row["ngayCapPhat"].ToString()).ToString("dd/MM/yyyy") == dateCapPhat.Text)
                {
                    DialogResult dt = MessageBox.Show("Phiếu cấp phát này đã được tạo mời bạn kiểm tra lại !", "Thông báo", MessageBoxButtons.OKCancel);
                    if (dt == DialogResult.OK)
                    {

                    }
                    else
                        this.Close();

                    return;
                }

            }
             try
             {           
                 BUS_PhieuCapPhatVatTu.Insert(phieuCapPhatVatTu);
                 MessageBox.Show("Tạo thành công !");
                 this.Close();
             }
             catch
             {

                 MessageBox.Show("Lỗi không tạo được !");
             }
             


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn hủy bỏ không ?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (dt == DialogResult.OK)
            {
                this.Close();
            }
          
        }
    }
}