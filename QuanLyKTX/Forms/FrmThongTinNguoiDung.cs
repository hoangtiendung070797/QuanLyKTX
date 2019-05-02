using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX.Forms
{
    public partial class FrmThongTinNguoiDung : Form
    {
        public FrmThongTinNguoiDung()
        {
            InitializeComponent();
        }

        private void FrmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Const.CurrentUser.TenDangNhap.ToString();
            txtMatKhau.Text = Const.CurrentUser.MatKhau.ToString();
            txtTenDayDu.Text = Const.CurrentUser.TenDayDu.ToString();
            txtSoDienThoai.Text = Const.CurrentUser.Sdt.ToString();
            txtDiaChi.Text = Const.CurrentUser.DiaChi.ToString();

            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            txtTenDayDu.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtDiaChi.Enabled = false;
        }
    }
}
