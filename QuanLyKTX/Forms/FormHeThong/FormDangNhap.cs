using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        public void Login()
        {
            using (SqlConnection connection = new SqlConnection(Const.ConnectionString))
            {

            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}