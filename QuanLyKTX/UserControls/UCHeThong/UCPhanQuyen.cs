using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls.UCHeThong
{
    public partial class UCPhanQuyen : UserControl
    {
        public UCPhanQuyen()
        {
            InitializeComponent();
        }
        BUS_PhanQuyen BUS_PhanQuyen = new BUS_PhanQuyen();
        BUS_NguoiDung BUS_NguoiDung = new BUS_NguoiDung();

        public event EventHandler LoadPhanQuyen = null;

        private void UCPhanQuyen_Load_1(object sender, System.EventArgs e)
        {
            gridControl2.DataSource = BUS_NguoiDung.GetData();
        }

        private void cardView1_DoubleClick(object sender, System.EventArgs e)
        {
            DataRow row = cardView1.GetFocusedDataRow();
     
            Const.NguoiDungId = (int)row["NguoiDungId"];

            LoadPhanQuyen(sender, e);

            LoadDetailPhanQuyen();

        }

        public void LoadDetailPhanQuyen()
        {
            gridControl1.DataSource = BUS_PhanQuyen.GetDetailPhanQuyen(Const.NguoiDungId);
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Caption = "Tên nhóm chức năng";
            gridView1.Columns[2].Caption = "Tên chức năng";
            gridView1.Columns[3].Caption = "Quyền thêm bản ghi";
            gridView1.Columns[4].Caption = "Quyền cập nhập bản ghi";
            gridView1.Columns[5].Caption = "Quyền xóa bản ghi";
            gridView1.Columns[6].Caption = "Quyền tìm kiếm,đọc bản ghi";

        }
    

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (BUS_PhanQuyen.UpdateDetail((DataTable)gridControl1.DataSource))
                MessageBox.Show("Cập nhập thành công!");
            //------------Ghi log
            NhatKyHoatDong nhatKy = new NhatKyHoatDong();
            nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
            nhatKy.NoiDung = Const.CurrentUser.TenDangNhap + " cập nhập quyền cho " + Const.NguoiDungId;
            nhatKy.ThaoTac = "Cập nhập";
            nhatKy.ThoiGian = DateTime.Now;
            nhatKy.ChucNang = "Nhật ký hoạt động";
            Const.NhatKyHoatDong.Insert(nhatKy);
            //-------------------
        }


    }
}
