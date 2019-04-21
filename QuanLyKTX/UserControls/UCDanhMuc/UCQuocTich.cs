using BUS;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCQuocTich : UserControl
    {
        public UCQuocTich()
        {
            InitializeComponent();
        }
        BUS_QuocTich bUS_QuocTich = new BUS_QuocTich();
        int chucnang = 0;

        private void UCQuocTich_Load(object sender, EventArgs e)
        {
            gridControlQuocTich.DataSource = bUS_QuocTich.GetData();
            FixNColumnNames();
        }
        void display()
        {
            gridControlQuocTich.DataSource = bUS_QuocTich.GetData();
        }
        void reset()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtMaQuocTich.Enabled = false;
            txtTenQuocTich.Enabled = false;

            txtMaQuocTich.Text = "";
            txtTenQuocTich.Text = "";

            display();
           
        }


        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaQuocTich.Text = gridView1.GetRowCellValue(e.RowHandle, "QuocTichId").ToString();
            txtTenQuocTich.Text = gridView1.GetRowCellValue(e.RowHandle, "tenQuocTich").ToString();
        }

    
        public void FixNColumnNames()
        {
            gridView1.Columns[0].Caption = "Mã quốc tịch";
            gridView1.Columns[1].Caption = "Tên quốc tịch";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            reset();
            chucnang = 1;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenQuocTich.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chucnang = 2;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtTenQuocTich.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaQuocTich.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này ?", "Đồng ý Ok-Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bUS_QuocTich.Delete(int.Parse(txtMaQuocTich.Text)))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Xóa thành công quốc tịch " + txtTenQuocTich.Text + " ra khỏi hệ thống";
                        nhatKy.ThaoTac = "Xóa";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Quốc tịch";
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
            if (txtTenQuocTich.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ.");
                errorProvider.SetError(txtTenQuocTich, "Chưa điền tên.");
            }
            else
            {
                QuocTich quoctich = new QuocTich();

                if (chucnang == 1)
                {
                    quoctich.TenQuocTich = txtTenQuocTich.Text;
                    if (bUS_QuocTich.Insert(quoctich))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Thêm thành công quốc tịch " + txtTenQuocTich.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Tạo";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Quốc tịch";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo.");
                    }
                    else MessageBox.Show("Thêm dữ liệu lỗi.", "Thông báo.");

                }

                if (chucnang == 2)
                {
                    quoctich.QuocTichId = int.Parse(txtMaQuocTich.Text);
                    quoctich.TenQuocTich = txtTenQuocTich.Text;
                    if (bUS_QuocTich.Update(quoctich))
                    {
                        //------------Ghi log
                        NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                        nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                        nhatKy.NoiDung = "Cập nhập thành công quốc tịch " + txtTenQuocTich.Text + " vào hệ thống";
                        nhatKy.ThaoTac = "Cập nhập";
                        nhatKy.ThoiGian = DateTime.Now;
                        nhatKy.ChucNang = "Quốc tịch";
                        Const.NhatKyHoatDong.Insert(nhatKy);
                        //-------------------
                        MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo.");
                    }
                    else MessageBox.Show("cập nhật dữ liệu lỗi.", "Thông báo.");
                }
                reset();
            }
        }

        private void btnCacnel_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
