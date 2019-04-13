using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKTX.Forms.FormGiaoDich
{
    public partial class FormRoiPhong : Form
    {
        public FormRoiPhong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Const.PhongId = "";
            this.Close();
        }

        
   

        BUS_LuuTruPhong bUS_LuuTruPhong = new BUS_LuuTruPhong();
        private void FormRoiPhong_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bUS_LuuTruPhong.DoiTuong_TrongPhong(Const.PhongId);
        }
        int doituongID ;
        int templuutruphongid;
        int tempNguoiDungId = 0;
        int tempNhanVienId = 0;
        string tempPhongId = "";
        DateTime tempNgayXep = DateTime.Now;
        private void cardView1_Click(object sender, EventArgs e)
        {
            DataRow row = cardView1.GetFocusedDataRow();
            templuutruphongid = (int)row["LuuTruPhongId"];
            doituongID = (int)row["DoiTuongId"];

            tempNguoiDungId = (int)row["NguoiDungId"];
            tempNhanVienId = (int)row["NhanVienId"];
            tempNgayXep = (DateTime)row["ngayXep"];
            tempPhongId = row["PhongId"].ToString();
            
            txtHoDem.Text = row["hoDem"].ToString();
            txtTen.Text = row["ten"].ToString();
            txtMaSinhVien.Text = row["maSinhVien"].ToString();

            //load ảnh

        }
        BUS_LuuTruPhong bus_LuuTruPhong = new BUS_LuuTruPhong();
        private void btnRoiPhong_Click(object sender, EventArgs e)
        {
            LuuTruPhong luuTruPhong = new LuuTruPhong();

            luuTruPhong.LuuTruPhongId = templuutruphongid;
            luuTruPhong.NguoiDungId = tempNguoiDungId;
            luuTruPhong.DoiTuongId = doituongID;
            luuTruPhong.NhanVienId = tempNhanVienId;
            luuTruPhong.PhongId = tempPhongId;
            luuTruPhong.NgayXep = tempNgayXep;
            luuTruPhong.NgayRoi = DateTime.Now;
            luuTruPhong.TrangThai = false;
            //  bus_LuuTruPhong.(luuTruPhong);
            bUS_LuuTruPhong.Update(luuTruPhong);

            MessageBox.Show("Rời phòng thành công","Thông báo");
            gridControl1.DataSource = bUS_LuuTruPhong.DoiTuong_TrongPhong(Const.PhongId);
        }
    }
}
