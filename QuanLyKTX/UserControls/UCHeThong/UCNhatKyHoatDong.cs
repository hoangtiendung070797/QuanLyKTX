using BUS;
using DevExpress.Utils;
using System;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCNhatKyHoatDong : UserControl
    {
        public UCNhatKyHoatDong()
        {
            InitializeComponent();
        }
        BUS_NguoiDung bUS_NguoiDung = new BUS_NguoiDung();
        public void AddComboboxChucNang()
        {
            cbbChucNang.Items.Add("Tất cả");
            cbbChucNang.Items.Add("Đổi mật khẩu");
            cbbChucNang.Items.Add("Nhật kí hoạt động");
            cbbChucNang.Items.Add("Thông tin người dùng");
            cbbChucNang.Items.Add("Phân quyền người dùng");
            cbbChucNang.Items.Add("Người dùng");
            cbbChucNang.Items.Add("Sao lưu dữ liệu");
            cbbChucNang.Items.Add("Phục hồi dữ liệu");
            cbbChucNang.Items.Add("Giao diện");
            cbbChucNang.Items.Add("Nhập dữ liệu Excel");
            cbbChucNang.Items.Add("Đăng xuất");
            cbbChucNang.Items.Add("Hồ sơ");
            cbbChucNang.Items.Add("Hợp đồng");
            cbbChucNang.Items.Add("Đổi mật khẩu");
            cbbChucNang.Items.Add("Xếp phòng");
            cbbChucNang.Items.Add("Cấp phát thiết bị vật tư");
            cbbChucNang.Items.Add("Khen thưởng, kỷ luật");
            cbbChucNang.Items.Add("Phiếu thu tiền phòng");
            cbbChucNang.Items.Add("Phiếu thu tiền sinh hoạt");
            cbbChucNang.Items.Add("Phiếu yêu cầu cấp phát vật tư");
            cbbChucNang.Items.Add("Phiếu yêu cầu sữa chữa thiết bị vật tư");
            cbbChucNang.Items.Add("Nhà");
            cbbChucNang.Items.Add("Phòng");
            cbbChucNang.Items.Add("Loại phòng");

            cbbChucNang.Items.Add("Vật tư, thiết bị");
            cbbChucNang.Items.Add("Loại đối tượng");
            cbbChucNang.Items.Add("Đơn vị");


            cbbChucNang.Items.Add("Lớp");
            cbbChucNang.Items.Add("Lỗi vi phạm");
            cbbChucNang.Items.Add("Tỉnh thành");

            cbbChucNang.Items.Add("Dân tộc");
            cbbChucNang.Items.Add("Tôn giáo");
            cbbChucNang.Items.Add("Quốc tịch");

            cbbChucNang.Items.Add("Thống kê theo đơn vị");
            cbbChucNang.Items.Add("Thống kê khen thưởng, kỷ luật");
            cbbChucNang.Items.Add("Thống kê theo danh sách phòng");

            cbbChucNang.Items.Add("Thống kê theo lớp");
            cbbChucNang.Items.Add("Vật tư hỏng theo phòng");
            cbbChucNang.Items.Add("Vật tư theo phòng");
            cbbChucNang.Items.Add("Thống kê thu phí phòng");
            cbbChucNang.Items.Add("Thống kê phí sinh hoạt");
        }

        private void UCNhatKyHoatDong_Load(object sender, EventArgs e)
        {
            cbbTenNguoiDung.DataSource = bUS_NguoiDung.GetData();
            cbbTenNguoiDung.DisplayMember = "tenDangNhap";
            cbbTenNguoiDung.ValueMember = "NguoiDungId";

            cbbThaoTac.Items.Add("Tất cả");
            cbbThaoTac.Items.Add("Tạo");
            cbbThaoTac.Items.Add("Cập nhập");
            cbbThaoTac.Items.Add("Xóa");
          

            AddComboboxChucNang();

            //load table on gridview
            gridControl1.DataSource = Const.NhatKyHoatDong.PrintfAllInfor();
            FixColumnName();
        }

        private void btnXemLog_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = Const.NhatKyHoatDong.GetDataByAllCondition(cbbTenNguoiDung.Text, dateEditNgay.DateTime,cbbThaoTac.Text,cbbChucNang.Text);
            FixColumnName();
        }

        private void cbbTenNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!toggleSwitch.IsOn)
            {
                gridControl1.DataSource = Const.NhatKyHoatDong.GetDataByUser(cbbTenNguoiDung.Text);
                FixColumnName();
            }
           
        }

        private void dateEditNgay_EditValueChanged(object sender, EventArgs e)
        {
            if (!toggleSwitch.IsOn)
            {
                gridControl1.DataSource = Const.NhatKyHoatDong.GetDataByDate(dateEditNgay.DateTime);

                FixColumnName();
            }
        }

        private void cbbThaoTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!toggleSwitch.IsOn)
            {
                if(cbbThaoTac.Text != "Tất cả")
                {
                    gridControl1.DataSource = Const.NhatKyHoatDong.GetDataByAction(cbbThaoTac.Text);

                }
                else
                {
                    gridControl1.DataSource = Const.NhatKyHoatDong.PrintfAllInfor();
                }

                FixColumnName();
            }
        }

        private void cbbChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!toggleSwitch.IsOn)
            {
                if (cbbThaoTac.Text != "Tất cả")
                {
                    gridControl1.DataSource = Const.NhatKyHoatDong.GetDataByFunction(cbbChucNang.Text);

                }
                else
                {
                    gridControl1.DataSource = Const.NhatKyHoatDong.PrintfAllInfor();
        
                }

                FixColumnName();
            }
        }


        public void FixColumnName()
        {
            gridView1.Columns[0].Caption = "Mã nhật ký hoạt động";
            gridView1.Columns[1].Caption = "Tên người dùng";
            gridView1.Columns[2].Caption = "Chức năng";
            gridView1.Columns[3].Caption = "Thao tác";
            gridView1.Columns[4].Caption = "Nội dung";
            gridView1.Columns[5].Caption = "Thời gian";

            gridView1.Columns[5].DisplayFormat.FormatType = FormatType.DateTime;
            gridView1.Columns[5].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";

        }
    }
}
