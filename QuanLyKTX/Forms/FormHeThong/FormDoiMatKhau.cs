using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class FormDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
            txtMatKhauOdd.Focus();
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }

        public bool IsEmptyInfor()
        {
            if (string.IsNullOrEmpty(txtMatKhauOdd.Text) || string.IsNullOrEmpty(txtMatKhauNew.Text) || string.IsNullOrEmpty(txtXacNhan.Text))
            {
                simpleLabelItem1.Text = "Vui Lòng nhập đủ thông tin!";
                txtMatKhauNew.Text = "";
                txtXacNhan.Text = "";
                txtMatKhauOdd.Text = "";
                txtMatKhauOdd.Focus();
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public bool IsCoincident()
        {
            if(Const.CurrentUser.MatKhau == txtMatKhauNew.Text)
            {
                simpleLabelItem1.Text = "Mật khẩu trùng với mật khẩu cũ!";
                txtMatKhauNew.Text = "";
                txtXacNhan.Text = "";
                txtMatKhauOdd.Text = "";
                txtMatKhauOdd.Focus();
                return true;
            }
            return false;
        }
        public bool IsFalseAgainPass()
        {
            if(txtMatKhauNew.Text != txtXacNhan.Text)
            {
                simpleLabelItem1.Text = "Xác nhận mật khẩu mới khác với mật khẩu mới!";
                txtMatKhauNew.Text = "";
                txtXacNhan.Text = "";
                txtMatKhauNew.Focus();
                return true;
            }
            return false;   
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(!IsEmptyInfor()&&!IsCoincident())
            {
                try
                {
                    BUS_NguoiDung bUS_NguoiDung = new BUS_NguoiDung();
                    Const.CurrentUser.MatKhau = txtMatKhauNew.Text;
                    bUS_NguoiDung.Update(Const.CurrentUser);
                    MessageBox.Show("Đổi mật khâu thành công!");

                    //------------Ghi log
                    NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                    nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                    nhatKy.NoiDung = "Đổi mật khẩu tài khoản " + Const.CurrentUser.TenDangNhap;
                    nhatKy.ThaoTac = "";
                    nhatKy.ThoiGian = DateTime.Now;
                    nhatKy.ChucNang = "Đổi mật khẩu";
                    Const.NhatKyHoatDong.Insert(nhatKy);
                    //-------------------
                }
                catch 
                {
                    MessageBox.Show("Có lỗi xảy ra!!!");
                    throw;
                }
               
            }
        }
    }
}