using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls
{
    public partial class UCLop : UserControl
    {
        public UCLop()
        {
            InitializeComponent();
        }
        BUS_Lop bUS_Lop = new BUS_Lop();
        int chucnang = 0;
        BUS_DonVi bus_DonVi = new BUS_DonVi();

        private void UCLop_Load(object sender, EventArgs e)
        {
            reset();
            FixNColumnNames();
        }
        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã lớp";
            gridView1.Columns[1].Caption = "Tên lớp";
            gridView1.Columns[2].Caption = "Đơn vị";
        }

        void display_cbb()
        {
            cbbDonvi.DataSource = bus_DonVi.GetData();
            cbbDonvi.DisplayMember = "tenDonVi";
            cbbDonvi.ValueMember = "DonViId";
        }

        void display()
        {
            gridControl1.DataSource = bUS_Lop.PrintInfor();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
            cbbDonvi.Enabled = false;

            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cbbDonvi.Text = "";

            display();
            display_cbb();
            cbbDonvi.Text = "";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            reset();
            reset();
            chucnang = 1;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenLop.Enabled = true;
            cbbDonvi.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenLop.Enabled = true;
            cbbDonvi.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_Lop.Delete(int.Parse(txtMaLop.Text)))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Xóa thành công lớp " + txtTenLop.Text + " ra khỏi hệ thống";
                        nhatKy.ThaoTac = "Xóa";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Lớp";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Xóa thành công!");
                        reset();
                    }
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            else MessageBox.Show("Thao tác bị lỗi, vui lòng chọn đối tượng.", "Thông báo");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text == "" || cbbDonvi.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                if (txtTenLop.Text == "") errorProvider1.SetError(txtTenLop, "Chưa điền tên.");
                if (cbbDonvi.Text == "") errorProvider1.SetError(cbbDonvi, "Chưa chọn đơn vị.");
            }
            else
            {
                Lop lop = new Lop();

                if (chucnang == 1)
                {
                    lop.TenLop = txtTenLop.Text;
                    lop.DonViId = (int)cbbDonvi.SelectedValue;
           
                    if (bUS_Lop.Insert(lop))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Thêm thành công lớp " + txtTenLop.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Tạo";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Lớp";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    }    
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");
                }

                if (chucnang == 2)
                {
                    lop.LopId = int.Parse(txtMaLop.Text);
                    lop.TenLop = txtTenLop.Text;
                    lop.DonViId = int.Parse(cbbDonvi.SelectedValue.ToString());
                    if (bUS_Lop.Update(lop))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Cập nhập thành công lớp " + txtTenLop.Text + " trong hệ thống";
                        nhatKy.ThaoTac = "Cập nhập";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Lớp";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------

                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                    }
                    else MessageBox.Show("cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }

     

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        int tempDonVi=0;
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaLop.Text = gridView1.GetRowCellValue(e.RowHandle, "LopId").ToString();
            txtTenLop.Text = gridView1.GetRowCellValue(e.RowHandle, "tenLop").ToString();          
            cbbDonvi.Text = gridView1.GetRowCellValue(e.RowHandle, "tenDonVi").ToString();
            MessageBox.Show(cbbDonvi.SelectedValue.ToString());
        }
    }
}
