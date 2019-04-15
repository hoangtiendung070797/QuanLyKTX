using BUS;
using DTO;
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


        public void Login()
        {
            try
            {
                data = bUS_NguoiDung.GetData();
                if (data != null && !string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassWord.Text))
                {
                    if (CheckUsername(txtUserName.Text))
                    {
                        if (CheckPass(txtPassWord.Text))
                        {

                            //mở chức năng tương ứng với user
                           //MessageBox.Show(Const.CurrentUser.TenDangNhap + " đăng nhập thành công!");

                            if (Const.CurrentUser.TenDangNhap == "admin")
                            {
                                Const.isFullOp = true;
                                Const.isLogin = true;
                                NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                                nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                                nhatKy.NoiDung = "Tài khoản: admin đã đăng nhập";
                                nhatKy.ThaoTac = "";
                                nhatKy.ThoiGian = DateTime.Now;
                                nhatKy.ChucNang = "Đăng nhập";



                                Const.NhatKyHoatDong.Insert(nhatKy);
                                return;
                            }
                            BUS_PhanQuyen bUS_PhanQuyen = new BUS_PhanQuyen();
                            data = bUS_PhanQuyen.GetDetailPhanQuyen(Const.CurrentUser.NguoiDungId);
                            for (int i = 0; i < data.Rows.Count; i++)
                            {
                                PhanQuyen quyen = new PhanQuyen();

                                quyen.TenNhomChucNang = data.Rows[i][1].ToString();
                                quyen.TenChucNang = data.Rows[i][2].ToString();
                                quyen.ChucNangThem = (bool)data.Rows[i][3];

                                quyen.ChucNangSua = (bool)data.Rows[i][4];
                                quyen.ChucNangXoa = (bool)data.Rows[i][5];
                                quyen.ChucNangDoc = (bool)data.Rows[i][6];
                                Const.PhanQuyens.Add(quyen);
                            }


                            Const.isLogin = true;

                            NhatKyHoatDong nhatKyHoatDong = new NhatKyHoatDong();
                            nhatKyHoatDong.NguoiDungId = Const.CurrentUser.NguoiDungId;
                            nhatKyHoatDong.NoiDung = "Tài khoản: "+ Const.CurrentUser.TenDangNhap+ " đã đăng nhập";
                            nhatKyHoatDong.ThaoTac = "";
                            nhatKyHoatDong.ThoiGian = DateTime.Now;
                            nhatKyHoatDong.ChucNang = "Đăng nhập";



                            Const.NhatKyHoatDong.Insert(nhatKyHoatDong);
                        }
                        else
                        {
                            MessageBox.Show(CheckPass(txtPassWord.Text).ToString());
                            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                            errorProvider1.BlinkRate = 500;
                            errorProvider1.SetError(txtPassWord, "Sai mật khâu người dùng!");
                            Const.isLogin = false;
                        }
                    }
                    else
                    {
                        errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                        errorProvider1.BlinkRate = 500;
                        errorProvider1.SetError(txtUserName, "Sai tên tài khoản người dùng!");
                        Const.isLogin = false ;
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

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
            if (Const.isLogin)
            {
                if(checkBoxGhiNho.Checked)
                {
                    Properties.Settings.Default.isCheckMemory = true;
                    Properties.Settings.Default.users = txtUserName.Text;
                    Properties.Settings.Default.pass = txtPassWord.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.isCheckMemory = false;
                    Properties.Settings.Default.users = "";
                    Properties.Settings.Default.pass = "";
                    Properties.Settings.Default.Save();
                }

                NhatKyHoatDong nhatKyHoatDong = new NhatKyHoatDong();
                nhatKyHoatDong.NguoiDungId = Const.CurrentUser.NguoiDungId;
                nhatKyHoatDong.NoiDung = "Tài khoản: "+ Const.CurrentUser.TenDangNhap +" đã đăng nhập";
                nhatKyHoatDong.ThaoTac = "";
                nhatKyHoatDong.ThoiGian = DateTime.Now;
                nhatKyHoatDong.ChucNang = "Đăng nhập";



                Const.NhatKyHoatDong.Insert(nhatKyHoatDong);
                this.Close();
            }
               

            Reset();
        }

        public void Reset()
        {
            txtPassWord.ResetText();
            txtUserName.ResetText();
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Properties.Settings.Default.users;
            txtPassWord.Text = Properties.Settings.Default.pass;
            checkBoxGhiNho.Checked = Properties.Settings.Default.isCheckMemory;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát?","Thoát chương trình",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Const.isLogin = true;
                Application.Exit();
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Const.isLogin)
                e.Cancel = true;
        }
    }
}