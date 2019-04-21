using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;
namespace QuanLyKTX.Forms.FormGiaoDich
{
    public partial class FormXepPhong : Form
    {
        public FormXepPhong()
        {
            InitializeComponent();
        }

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {

        }
        BUS_LuuTruPhong bus_LuuTruPhong = new BUS_LuuTruPhong();
        BUS_NhanVien bUS_NhanVien = new BUS_NhanVien();
        private void FormXepPhong_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bus_LuuTruPhong.DoiTuong_ChuaCoPhong_GioiTinh(Const.GioiTinhPhong);
            cbbNhanVien.DataSource = bUS_NhanVien.GetData();
            cbbNhanVien.DisplayMember = "tenNhanVien";
            cbbNhanVien.ValueMember = "NhanVienID";
        }

        int doituongID ;

        private void cardView1_Click(object sender, EventArgs e)
        {
            if(cardView1.RowCount !=0)
            {
                DataRow row = cardView1.GetFocusedDataRow();
                doituongID = (int)row["DoiTuongId"];
                txtHoDem.Text = row["hoDem"].ToString();
                txtTen.Text = row["ten"].ToString();
                txtMaSinhVien.Text = row["maSinhVien"].ToString();
                //  pictureHoSo.Image = (Image)row["anh"];

            }






        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            LuuTruPhong luuTruPhong = new LuuTruPhong();

            luuTruPhong.NhanVienId = int.Parse(cbbNhanVien.SelectedValue.ToString());
            luuTruPhong.NguoiDungId = Const.CurrentUser.NguoiDungId;
            luuTruPhong.PhongId = Const.PhongId;
            luuTruPhong.DoiTuongId = doituongID;
            luuTruPhong.NgayXep = DateTime.Now;
            //luuTruPhong.NgayRoi = DateTime.Today;
            luuTruPhong.TrangThai = true;
            bus_LuuTruPhong.Insert(luuTruPhong);

            MessageBox.Show("Thêm vào phòng thành công.","Thông báo");
            Const.PhongId = "";
            this.Close();
        }

        private void searchControl1_SelectedValueChanged(object sender, EventArgs e)
        {
            ////////
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            reset();
        }
        void reset()
        {
            txtHoDem.Text = "";
            txtMaSinhVien.Text = "";
            txtTen.Text = "";
            cbbNhanVien.Text = "";
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Const.PhongId = "";
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
