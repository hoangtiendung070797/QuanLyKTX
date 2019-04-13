using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.Forms.FormGiaoDich
{
    public partial class FrmSuaPhieuCapPhat : DevExpress.XtraEditors.XtraForm
    {
        public FrmSuaPhieuCapPhat()
        {
            InitializeComponent();

            cbPhong.DataSource = BUS_Phong.GetData();
            cbPhong.DisplayMember = "tenPhong";
            cbPhong.ValueMember = "PhongId";

            cbNhanVien.DataSource = BUS_NhanVien.GetData();
            cbNhanVien.DisplayMember = "tenNhanVien";
            cbNhanVien.ValueMember = "NhanVienID";

            cbNguoiDung.DataSource = BUS_NguoiDung.GetData();
            cbNguoiDung.DisplayMember = "tenDangNhap";
            cbNguoiDung.ValueMember = "NguoiDungId";
        }
        BUS_PhieuCapPhatVatTu BUS_PhieuCapPhatVatTu = new BUS_PhieuCapPhatVatTu();
        BUS_Phong BUS_Phong = new BUS_Phong();
        BUS_NguoiDung BUS_NguoiDung = new BUS_NguoiDung();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        public string id;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateCapPhat.Text);
            PhieuCapPhatVatTu phieuCapPhatVatTu = new PhieuCapPhatVatTu();
            phieuCapPhatVatTu.PhieuCapPhatVatTuId = int.Parse(id);
            phieuCapPhatVatTu.PhongId1 = cbPhong.SelectedValue.ToString();
            phieuCapPhatVatTu.NhanVienId = int.Parse(cbNhanVien.SelectedValue.ToString());
            phieuCapPhatVatTu.NguoiDungId = int.Parse(cbNguoiDung.SelectedValue.ToString());
            phieuCapPhatVatTu.NgayCapPhat = DateTime.Parse(dateCapPhat.Text);
            phieuCapPhatVatTu.TenNguoiLap = txtTenNguoiLap.Text;
            phieuCapPhatVatTu.GhiChu = txtGhiChu.Text;
            try
            {               
                BUS_PhieuCapPhatVatTu.Update(phieuCapPhatVatTu);
                MessageBox.Show("Sửa thành công !");
                this.Close();
            }
            catch
            {

                MessageBox.Show("Lỗi không sửa được mời kiểm tra lại !");
            }
        }

        private void FrmSuaPhieuCapPhat_Load(object sender, EventArgs e)
        {
           
         
        }
    }
}