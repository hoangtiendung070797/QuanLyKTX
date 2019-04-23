using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKTX.Forms.FormGiaoDich
{
    public partial class FrmSuaPhieuThuTienSH : DevExpress.XtraEditors.XtraForm
    {
        public FrmSuaPhieuThuTienSH()
        {
            InitializeComponent();
            LoadComBoBox();
        }

        #region Properties
        BUS_PhieuThuTienSH BUS_PhieuThuTienSH = new BUS_PhieuThuTienSH();
        BUS_Phong BUS_Phong = new BUS_Phong();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_NguoiDung BUS_NguoiDung = new BUS_NguoiDung();
        PhieuThuTienSH PhieuThuTienSH = new PhieuThuTienSH();
        public int GetPhietId = 0;
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
        }     
        private void FrmTaoPhieuThuTienSH_Load(object sender, EventArgs e)
        {            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void cbPhong_SelectedValueChanged(object sender, EventArgs e) // ở form sửa này thì cái này không cần thiết
        {
            try
            {              
                 if (BUS_PhieuThuTienSH.DienNuocDau(cbPhong.SelectedValue.ToString()).Rows.Count == 0)
                    {
                        txtSoDienDau.Text = "0";
                        txtSoNuocDau.Text = "0";
                    }
                    else
                    {
                        foreach (DataRow row in BUS_PhieuThuTienSH.DienNuocDau(cbPhong.SelectedValue.ToString()).Rows)
                        {
                            txtSoDienDau.Text = row["soDienCuoi"].ToString();
                            txtSoNuocDau.Text = row["soNuocCuoi"].ToString();
                        }
                    }       
            }
            catch
            {           
            }                       
        }
        #region Xử lý các textbox tính tiền
        private void txtSoDienCuoi_TextChanged(object sender, EventArgs e)
        {
            if (txtSoDienCuoi.Text == "")
            {
                txtSoDienThuc.Text = "0";
             
            }
            else
            {
                txtSoDienThuc.Text = (decimal.Parse(txtSoDienCuoi.Text) - decimal.Parse(txtSoDienDau.Text)).ToString();
                
            }
            
        }

        private void txtSoNuocCuoi_TextChanged(object sender, EventArgs e)
        {
            if (txtSoNuocCuoi.Text == "")
            {
                txtSoNuocThuc.Text = "0";
              
            }
            else
            {
                txtSoNuocThuc.Text = (decimal.Parse(txtSoNuocCuoi.Text) - decimal.Parse(txtSoNuocDau.Text)).ToString();
               
            }
        }

        private void txtDonGiaDien_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaDien.Text == "")
            {
                txtTienDien.Text = "0";
            }
            else
            {
                txtTienDien.Text = (decimal.Parse(txtSoDienThuc.Text) * decimal.Parse(txtDonGiaDien.Text)).ToString();
               
            }
        }

        private void txtDonGiaNuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaNuoc.Text == "")
            {
                txtTienNuoc.Text = "0";
            }
            else
            {
                txtTienNuoc.Text = (decimal.Parse(txtSoNuocThuc.Text) * decimal.Parse(txtDonGiaNuoc.Text)).ToString();
                
            }
        }

        private void txtPhiDichVu_TextChanged(object sender, EventArgs e)
        {
            if (txtPhiDichVu.Text !="")
            {
                txtTongTien.Text = (decimal.Parse(txtTienDien.Text) + decimal.Parse(txtTienNuoc.Text) + decimal.Parse(txtPhiDichVu.Text)).ToString();
            }
            else
            {
                txtTongTien.Text = (decimal.Parse(txtTienDien.Text) + decimal.Parse(txtTienNuoc.Text)).ToString();
            }
        }
           

        private void txtTienDien_TextChanged(object sender, EventArgs e)
        {
            if (txtTienDien.Text != "0")
            {
                txtTongTien.Text = (decimal.Parse(txtTienDien.Text) + decimal.Parse(txtTienNuoc.Text)).ToString();
            }
            else
            {
                txtTongTien.Text = (0 + decimal.Parse(txtTienNuoc.Text)).ToString();
            }
        }

        private void txtTienNuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtTienNuoc.Text != "0")
            {
                txtTongTien.Text = (decimal.Parse(txtTienDien.Text) + decimal.Parse(txtTienNuoc.Text)).ToString();
            }
            else
            {
                txtTongTien.Text = (decimal.Parse(txtTienDien.Text) + 0).ToString();
            }
        }

        private void txtSoDienThuc_TextChanged(object sender, EventArgs e)
        {
            if (txtSoDienThuc.Text != "0")
            {
                if (decimal.Parse(txtSoDienThuc.Text) <0)
                {
                    return;
                }
                else
                {
                    if (txtDonGiaDien.Text == "")
                    {
                        txtTienDien.Text = (decimal.Parse(txtSoDienThuc.Text) * 0).ToString();
                    }
                    else
                     txtTienDien.Text = (decimal.Parse(txtSoDienThuc.Text) * decimal.Parse(txtDonGiaDien.Text)).ToString();
                }
                   
            }
            else
            {
                if (txtDonGiaDien.Text == "")
                {
                    txtTienDien.Text = "0";
                }
                else
                {
                    txtTienDien.Text = (0 * decimal.Parse(txtDonGiaDien.Text)).ToString();
                }
                
            }
        }

        private void txtSoNuocThuc_TextChanged(object sender, EventArgs e)
        {
            if (txtSoNuocThuc.Text != "0")
            {
                if (decimal.Parse(txtSoNuocThuc.Text) < 0)
                {
                    return;
                }
                else
                {
                    if (txtDonGiaNuoc.Text=="")
                    {
                        txtTienNuoc.Text = (decimal.Parse(txtSoNuocThuc.Text) * 0).ToString();
                    }
                    else
                        txtTienNuoc.Text = (decimal.Parse(txtSoNuocThuc.Text) * decimal.Parse(txtDonGiaNuoc.Text)).ToString();
                }
                
            }
            else
            {
                if (txtDonGiaNuoc.Text == "")
                {
                    txtTienNuoc.Text = "0";
                }
                else
                    txtTienNuoc.Text = (0 * decimal.Parse(txtDonGiaNuoc.Text)).ToString();
            }
        }
        #endregion

        public void GetThuoctinh()
        {
            PhieuThuTienSH.TinhTrang = checkBoxTinhTrang.Checked;
            PhieuThuTienSH.PhongId1 = cbPhong.SelectedValue.ToString();
            PhieuThuTienSH.NhanVienId1 = int.Parse(cbNhanVien.SelectedValue.ToString());
            PhieuThuTienSH.NguoiDungId1 = int.Parse(cbNguoiDung.SelectedValue.ToString());
            PhieuThuTienSH.NgayThu = DateTime.Now;
            PhieuThuTienSH.TenNguoiThu = txtNguoiThu.Text;
            PhieuThuTienSH.SoDienDau = int.Parse(txtSoDienDau.Text);
            PhieuThuTienSH.SoDienCuoi= int.Parse(txtSoDienCuoi.Text);
            PhieuThuTienSH.SoNuocDau = int.Parse(txtSoNuocDau.Text);
            PhieuThuTienSH.SoNuocCuoi = int.Parse(txtSoNuocCuoi.Text);
            PhieuThuTienSH.SoDienThuc = int.Parse(txtSoDienThuc.Text);
            PhieuThuTienSH.SoNuocThuc = int.Parse(txtSoNuocThuc.Text);
            PhieuThuTienSH.DonGiaDien = decimal.Parse(txtDonGiaDien.Text);
            PhieuThuTienSH.DonGiaNuoc = decimal.Parse(txtDonGiaNuoc.Text);
            PhieuThuTienSH.TienThuDien = decimal.Parse(txtTienDien.Text);
            PhieuThuTienSH.TienThuNuoc = decimal.Parse(txtTienNuoc.Text);
            if (txtPhiDichVu.Text == "")
            {
                PhieuThuTienSH.PhiDichVu = 0;
            }
            else
            {
                PhieuThuTienSH.PhiDichVu = decimal.Parse(txtPhiDichVu.Text);
            }           
            PhieuThuTienSH.Tong = decimal.Parse(txtTongTien.Text);
            PhieuThuTienSH.GhiChu = txtGhiChu.Text;


        }
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhật không?","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (txtSoDienCuoi.Text == "" || txtSoNuocCuoi.Text == "" || txtDonGiaDien.Text == "" || txtDonGiaNuoc.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền đủ thông tin điện nước");
                        return;
                    }
                    PhieuThuTienSH.PhieuThuTienSHId = GetPhietId;
                    GetThuoctinh();
                    BUS_PhieuThuTienSH.Update(PhieuThuTienSH);
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi! không cập nhật được xin mời kiểm tra và thử lại");
            }
            
        }

        private void txtChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}