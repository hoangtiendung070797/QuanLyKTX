using BUS;
using System;
using System.Data;
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
        BUS_NguoiDung bUS_NguoiDung = new BUS_NguoiDung();
        DataTable data;


        public bool Login()
        {
            try
            {
                data = bUS_NguoiDung.GetData();
                if(data != null)
                {
                    if(CheckUsername(txtUserName.Text))
                    {
                        if(CheckPass(txtPassWord.Text))
                        {

                            //phân quyền




                            MessageBox.Show("Bạn đăng nhập thành công!");
                        }
                        else
                        {
                            MessageBox.Show(CheckPass(txtPassWord.Text).ToString());
                            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                            errorProvider1.BlinkRate = 500;
                            errorProvider1.SetError(txtPassWord, "Sai mật khâu người dùng!");

                        }
                    }
                    else
                    {
                        errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                        errorProvider1.BlinkRate = 500;
                        errorProvider1.SetError(txtPassWord, "Sai tên tài khoản người dùng!");
                    }
                }
            }
            catch 
            {

                throw;
            }
           



            return true;
        }

        public bool CheckUsername(string userName)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][1].ToString() == userName)
                {
                    Const.CurrentUser.TenDangNhap = data.Rows[i][1].ToString();
                    Const.CurrentUser.MatKhau = data.Rows[i][2].ToString();
                    Const.CurrentUser.TenDayDu = data.Rows[i][3].ToString();
                    Const.CurrentUser.Sdt = data.Rows[i][4].ToString();
                    Const.CurrentUser.DiaChi = data.Rows[i][5].ToString();
                    Const.CurrentUser.NguoiDungId = int.Parse(data.Rows[i][0].ToString());


               
                    return true;

                }
                    
            }
            return false;


        }

        public bool CheckPass(string pass)
        {
            return (Const.CurrentUser.MatKhau == pass) ? true : false;
           
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}