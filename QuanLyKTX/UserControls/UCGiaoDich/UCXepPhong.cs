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
            grcPhong.DataSource = bUS_Phong.GetData();
            cbbPhong.Text = "Tất cả phòng";
            //grcPhong.DataSource = bUS_Phong.GetEmptyRoom(true);
            
        }
        BUS_LuuTruPhong bUS_luutruphong = new BUS_LuuTruPhong();
        private void cardView1_Click(object sender, EventArgs e)
        {
            DataRow row = cardView1.GetFocusedDataRow();

            Const.PhongId = row["PhongId"].ToString();
            grcDoiTuong.DataSource = bUS_luutruphong.DoiTuong_TrongPhong(Const.PhongId);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbPhong.SelectedIndex == 0)
                grcPhong.DataSource = bUS_Phong.GetData();
            if (cbbPhong.SelectedIndex == 1)
                grcPhong.DataSource = bUS_Phong.GetEmptyRoom(true);
            if (cbbPhong.SelectedIndex == 2)
                grcPhong.DataSource = bUS_Phong.GetEmptyRoom(false);

        }
        //   BUS_LuuTruPhong bus_LuuTruPhong = new BUS_LuuTruPhong();
        //   DataTable bangsoluongnguoi = new DataTable();
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

