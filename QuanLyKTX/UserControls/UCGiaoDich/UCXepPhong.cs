using BUS;
using QuanLyKTX.Forms.FormGiaoDich;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls.UCGiaoDich
{
    public partial class UCXepPhong : UserControl
    {
        public UCXepPhong()
        {
            InitializeComponent();
        }
        BUS_Phong bUS_Phong = new BUS_Phong();
        private void UCXepPhong_Load(object sender, EventArgs e)
        {
            display();
            cbbPhong.Text = "Tất cả phòng";
            //grcPhong.DataSource = bUS_Phong.GetEmptyRoom(true);
            
        }
        void display()
        {
            grcPhong.DataSource = bUS_Phong.PrintInfor();
            fixHeaderName();
        }
        void fixHeaderName()
        {
            cardView1.Columns[0].Caption = "ID Phòng";
            cardView1.Columns[1].Caption = "Tên phòng";
            cardView1.Columns[2].Caption = "Tên dãy nhà";
            cardView1.Columns[3].Caption = "Tên loại phòng";
            cardView1.Columns[4].Caption = "Tầng";
            cardView1.Columns[5].Caption = "Giá";
            cardView1.Columns[6].Caption = "Giới tính";
        }

        void display_DoiTuongTrongPhong()
        {
            grcDoiTuong.DataSource = bUS_luutruphong.DoiTuong_TrongPhong(Const.PhongId);
            fixHeaderName_TrongPhong();
        }
        void fixHeaderName_TrongPhong()
        {
            layoutView1.Columns[0].Caption = "Ảnh";
            layoutView1.Columns[1].Caption = "ID đối tượng";
            layoutView1.Columns[2].Caption = "MSV";
            layoutView1.Columns[3].Caption = "Họ đệm";
            layoutView1.Columns[4].Caption = "Tên";
            layoutView1.Columns[5].Caption = "Ngày sinh";
            layoutView1.Columns[6].Caption = "Nơi sinh";
            layoutView1.Columns[7].Caption = "Giới tính";
            layoutView1.Columns[8].Caption = "Hộ khẩu";
            layoutView1.Columns[9].Caption = "Quê quán";
            layoutView1.Columns[10].Caption = "SĐT";
            layoutView1.Columns[11].Caption = "Email";
            layoutView1.Columns[12].Caption = "Ghi chú";
            layoutView1.Columns[13].Caption = "Ngày xếp";
            layoutView1.Columns[14].Caption = "Ngày rời";
            layoutView1.Columns[15].Caption = "Trang thái";
            layoutView1.Columns[16].Visible = false;
            layoutView1.Columns[17].Visible = false;
            layoutView1.Columns[18].Visible = false;
            layoutView1.Columns[19].Visible = false;
        }

        BUS_LuuTruPhong bUS_luutruphong = new BUS_LuuTruPhong();
        private void cardView1_Click(object sender, EventArgs e)
        {
            try
            {
                if(cardView1.RowCount != 0)
                {
                    DataRow row = cardView1.GetFocusedDataRow();

                    Const.PhongId = row["PhongId"].ToString();
                    if (row["thuocGioiTinh"].ToString() == "Nam")
                        Const.GioiTinhPhong = "true";
                    if (row["thuocGioiTinh"].ToString() == "Nữ")
                        Const.GioiTinhPhong = "false";

                    display_DoiTuongTrongPhong();
                }
               
            }
            catch (Exception)
            {

                throw;
            }
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbPhong.SelectedIndex == 0)
                grcPhong.DataSource = bUS_Phong.PrintInfor();
            if (cbbPhong.SelectedIndex == 1)
                grcPhong.DataSource = bUS_Phong.GetEmptyRoom(true);
            if (cbbPhong.SelectedIndex == 2)
                grcPhong.DataSource = bUS_Phong.GetEmptyRoom(false);
           
        }
        
        BUS_Phong bus_phong = new BUS_Phong();
        private void btnVaoPhong_Click(object sender, EventArgs e)
        {
            if(Const.PhongId =="")
            {
                MessageBox.Show("Bạn chưa chọn phòng.","Thông báo");
            }
            else
            {
               
                if(bus_phong.IsFullRoom(Const.PhongId) ==true)
                {
                    MessageBox.Show("Phòng đã đầy","Thông báo");
                }
                else
                {
                    FormXepPhong frmXepPhong = new FormXepPhong();
                    frmXepPhong.ShowDialog();
                    UCXepPhong_Load(sender, e);
                }
                
            }
            
        }

        private void btnRoiPhong_Click(object sender, EventArgs e)
        {
            if (Const.PhongId == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng.", "Thông báo");
            }
            else
            {
                FormRoiPhong frmRoiPhong = new FormRoiPhong();
                frmRoiPhong.ShowDialog();
                UCXepPhong_Load(sender, e);
            }
           
            
        }

    }
}

