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

namespace QuanLyKTX
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" && txtPassWord.Text=="")
            {
                MessageBox.Show("Hãy nhập vào tên tài khoản và mật khẩu !");
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Hãy nhập vào tên tài khoản !");
            }
            else 
            {
                MessageBox.Show("Hãy nhập vào mật khẩu !");
            }
        }
    }
}