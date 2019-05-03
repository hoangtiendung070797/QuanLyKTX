using BUS;
using DTO;
using QuanLyKTX.Forms.FormGiaoDich;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls.UCGiaoDich
{
    public partial class UCThuTienSinhHoat : UserControl
    {
        public UCThuTienSinhHoat()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i.ToString());
            }
            cbThang.Items.Add("All");
        }

      
        #region Properties
        BUS_PhieuThuTienSH BUS_PhieuThuTienSH = new BUS_PhieuThuTienSH();
        PhieuThuTienSH PhieuThuTienSH = new PhieuThuTienSH();
        int PhieuThuTienSHId; // LẤY ID PHIẾU ĐỂ XÓA

        #endregion
        public void LoadPhieuThu()
        {
            gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataNew();

            gridView1.Columns[0].Visible = false;
            gridView1.Columns[2].Visible = false;
            gridView1.Columns[3].Visible = false;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[1].Caption = "Tình trạng thu";
            gridView1.Columns[1].Width = 100;

            gridView1.Columns[5].Caption = "Phòng";
            gridView1.Columns[6].Caption = "Nhân viên";
            gridView1.Columns[7].Caption = "Người dùng";
            gridView1.Columns[8].Caption = "Ngày";
            gridView1.Columns[9].Caption = "Số điện đầu";
            gridView1.Columns[10].Caption = "Số điện cuối";
            gridView1.Columns[11].Caption = "Số nước đầu";
            gridView1.Columns[12].Caption = "Số nước cuối";
            gridView1.Columns[13].Caption = "Số điện thực";
            gridView1.Columns[14].Caption = "Số nước thực";
            gridView1.Columns[15].Caption = "Đơn giá điện";
            gridView1.Columns[16].Caption = "Đơn giá nước";
            gridView1.Columns[17].Caption = "Tiền điện";
            gridView1.Columns[18].Caption = "Tiến nước";
            gridView1.Columns[19].Caption = "Phí dịch vụ";
            gridView1.Columns[20].Caption = "Tổng tiền";
            gridView1.Columns[21].Caption = "Người thu";
            gridView1.Columns[22].Caption = "Ghi chú";

            ///Những cell không được sửa
            gridView1.Columns[5].OptionsColumn.ReadOnly = true;
            gridView1.Columns[6].OptionsColumn.ReadOnly = true;
            gridView1.Columns[7].OptionsColumn.ReadOnly = true;
            gridView1.Columns[8].OptionsColumn.ReadOnly = true;
            gridView1.Columns[9].OptionsColumn.ReadOnly = true;
            gridView1.Columns[11].OptionsColumn.ReadOnly = true;
            gridView1.Columns[13].OptionsColumn.ReadOnly = true;
            gridView1.Columns[14].OptionsColumn.ReadOnly = true;
            gridView1.Columns[17].OptionsColumn.ReadOnly = true;
            gridView1.Columns[18].OptionsColumn.ReadOnly = true;
            gridView1.Columns[20].OptionsColumn.ReadOnly = true;


        }

        public void LoadDataTheoThang()
        {

            switch (DateTime.Now.Month)
            {
                case 1:
                    cbThang.Text = "1";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(1);
                    break;
                case 2:
                    cbThang.Text = "2";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(2);
                    break;
                case 3:
                    cbThang.Text = "3";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(3);
                    break;
                case 4:
                    cbThang.Text = "4";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(4);
                    break;
                case 5:
                    cbThang.Text = "5";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(5);
                    break;
                case 6:
                    cbThang.Text = "6";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(6);
                    break;
                case 7:
                    cbThang.Text = "7";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(7);
                    break;
                case 8:
                    cbThang.Text = "8";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(8);
                    break;
                case 9:
                    cbThang.Text = "9";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(9);
                    break;
                case 10:
                    cbThang.Text = "10";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(10);
                    break;
                case 11:
                    cbThang.Text = "11";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(11);
                    break;
                case 12:
                    cbThang.Text = "12";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(12);
                    break;
                default:
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataNew();
                    break;

            }
        }
        private void UCThuTienSinhHoat_Load(object sender, EventArgs e)
        {
            LoadPhieuThu();
            LoadDataTheoThang();
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTaoPhieuThuTienSH frmTaoPhieuThuTienSH = new FrmTaoPhieuThuTienSH();
                frmTaoPhieuThuTienSH.ShowDialog();                
                if (cbThang.Text == "All")
                {
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataNew();
                }
                else
                {
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(int.Parse(cbThang.Text));
                }
            }
            catch
            {
            }
        }


        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThang.SelectedItem.ToString() == "All")
            {
                gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataNew();
            }
            else
            {
                gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(int.Parse(cbThang.Text));
            }
        }
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                PhieuThuTienSHId = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "PhieuThuTienSHId").ToString());
                
            }
            catch
            {
            }
        }
        FrmSuaPhieuThuTienSH frmSuaPhieuThuTienSH = new FrmSuaPhieuThuTienSH();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
               
                frmSuaPhieuThuTienSH.ShowDialog();
                if (cbThang.Text == "All")
                {
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataNew();
                }
                else
                {
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(int.Parse(cbThang.Text));
                }
            }
            catch
            {

            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            try
            {
              //  MessageBox.Show(PhieuThuTienSHId.ToString());
                BUS_PhieuThuTienSH.Delete(PhieuThuTienSHId);
                //------------Ghi log
                NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                nhatKy.NoiDung = "Xóa thành công phiếu thu tiền sinh hoạt id: " + PhieuThuTienSHId+ " ra khỏi hệ thống";
                nhatKy.ThaoTac = "Xóa";
                nhatKy.ThoiGian = DateTime.Now;
                nhatKy.ChucNang = "Thu tiền sinh hoạt";
                Const.NhatKyHoatDong.Insert(nhatKy);
                //-------------------
                if (cbThang.Text == "All")
                {
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataNew();
                }
                else
                {
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(int.Parse(cbThang.Text));
                }
            }
            catch
            {
            }
        }
        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

            try
            {
                //Sửa trên form
                frmSuaPhieuThuTienSH.GetPhietId =(int)gridView1.GetRowCellValue(e.RowHandle, "PhieuThuTienSHId");
                frmSuaPhieuThuTienSH.cbPhong.SelectedValue = gridView1.GetRowCellValue(e.RowHandle, "PhongId").ToString();
                frmSuaPhieuThuTienSH.cbNhanVien.SelectedValue = gridView1.GetRowCellValue(e.RowHandle, "NhanVienId").ToString();
                frmSuaPhieuThuTienSH.cbNguoiDung.SelectedValue = gridView1.GetRowCellValue(e.RowHandle, "NguoiDungId").ToString();
                frmSuaPhieuThuTienSH.dateEdit1.DateTime = (DateTime)gridView1.GetRowCellValue(e.RowHandle, "ngayThu");
                frmSuaPhieuThuTienSH.txtNguoiThu.Text = gridView1.GetRowCellValue(e.RowHandle, "tenNguoiThu").ToString();
                frmSuaPhieuThuTienSH.txtSoDienDau.Text = gridView1.GetRowCellValue(e.RowHandle, "soDienDau").ToString();
                frmSuaPhieuThuTienSH.txtSoDienCuoi.Text = gridView1.GetRowCellValue(e.RowHandle, "soDienCuoi").ToString();
                frmSuaPhieuThuTienSH.txtSoNuocDau.Text = gridView1.GetRowCellValue(e.RowHandle, "soNuocDau").ToString();
                frmSuaPhieuThuTienSH.txtSoNuocCuoi.Text = gridView1.GetRowCellValue(e.RowHandle, "soNuocCuoi").ToString();
                frmSuaPhieuThuTienSH.txtSoDienThuc.Text = gridView1.GetRowCellValue(e.RowHandle, "soDienThuc").ToString();
                frmSuaPhieuThuTienSH.txtSoNuocThuc.Text = gridView1.GetRowCellValue(e.RowHandle, "soNuocThuc").ToString();
                frmSuaPhieuThuTienSH.txtDonGiaDien.Text = gridView1.GetRowCellValue(e.RowHandle, "donGiaDien").ToString();
                frmSuaPhieuThuTienSH.txtDonGiaNuoc.Text = gridView1.GetRowCellValue(e.RowHandle, "donGiaNuoc").ToString();
                frmSuaPhieuThuTienSH.txtTienDien.Text = gridView1.GetRowCellValue(e.RowHandle, "tienThuDien").ToString();
                frmSuaPhieuThuTienSH.txtTienNuoc.Text = gridView1.GetRowCellValue(e.RowHandle, "tienThuNuoc").ToString();
                frmSuaPhieuThuTienSH.txtPhiDichVu.Text = gridView1.GetRowCellValue(e.RowHandle, "phiDichVu").ToString();
                frmSuaPhieuThuTienSH.txtTongTien.Text = gridView1.GetRowCellValue(e.RowHandle, "tong").ToString();
                frmSuaPhieuThuTienSH.checkBoxTinhTrang.Checked =(bool)gridView1.GetRowCellValue(e.RowHandle, "tinhTrang");
                frmSuaPhieuThuTienSH.txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "ghiChu").ToString();


                // sửa trên gridview
                if (string.IsNullOrEmpty(gridView1.GetRowCellValue(e.RowHandle, "donGiaDien").ToString()))
                {
                    gridView1.SetRowCellValue(e.RowHandle, "donGiaDien", "0");
                }
                if (string.IsNullOrEmpty(gridView1.GetRowCellValue(e.RowHandle, "donGiaNuoc").ToString()))
                {
                    gridView1.SetRowCellValue(e.RowHandle, "donGiaNuoc", "0");
                }
                if (string.IsNullOrEmpty(gridView1.GetRowCellValue(e.RowHandle, "soNuocCuoi").ToString()))
                {
                    gridView1.SetRowCellValue(e.RowHandle, "soNuocCuoi", "0");
                }
                if (string.IsNullOrEmpty(gridView1.GetRowCellValue(e.RowHandle, "soDienCuoi").ToString()))
                {
                    gridView1.SetRowCellValue(e.RowHandle, "soDienCuoi", "0");
                }
                if (string.IsNullOrEmpty(gridView1.GetRowCellValue(e.RowHandle, "phiDichVu").ToString()))
                {
                    gridView1.SetRowCellValue(e.RowHandle, "phiDichVu", "0");
                }
                gridView1.SetRowCellValue(e.RowHandle, "soDienThuc", (decimal.Parse(gridView1.GetRowCellValue(e.RowHandle, "soDienCuoi").ToString()) - decimal.Parse(gridView1.GetRowCellValue(e.RowHandle, "soDienDau").ToString())));
                gridView1.SetRowCellValue(e.RowHandle, "soNuocThuc", (decimal.Parse(gridView1.GetRowCellValue(e.RowHandle, "soNuocCuoi").ToString()) - decimal.Parse(gridView1.GetRowCellValue(e.RowHandle, "soNuocDau").ToString())));
                gridView1.SetRowCellValue(e.RowHandle, "tienThuDien", (decimal.Parse(gridView1.GetRowCellValue(e.RowHandle, "soDienThuc").ToString()) * decimal.Parse(gridView1.GetRowCellValue(e.RowHandle, "donGiaDien").ToString())));
                gridView1.SetRowCellValue(e.RowHandle, "tienThuNuoc", (decimal.Parse(gridView1.GetRowCellValue(e.RowHandle, "soNuocThuc").ToString()) * decimal.Parse(gridView1.GetRowCellValue(e.RowHandle, "donGiaNuoc").ToString())));
                gridView1.SetRowCellValue(e.RowHandle, "tong", (decimal.Parse(gridView1.GetRowCellValue(e.RowHandle, "tienThuDien").ToString()) + decimal.Parse(gridView1.GetRowCellValue(e.RowHandle, "phiDichVu").ToString()) + decimal.Parse(gridView1.GetRowCellValue(e.RowHandle, "tienThuNuoc").ToString())));

                //simpleButton2_Click(sender, e);
            }
            catch
            {


            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                
                if (gridView1.GetRowCellValue(e.RowHandle, "tinhTrang").ToString() == "True")
                {
                    e.Appearance.BackColor = Color.Green;
                }
                else
                {
                    e.Appearance.BackColor = Color.IndianRed;
                }
            }
            catch
            {
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BUS_PhieuThuTienSH.UpdateDetail((DataTable)gridThuTien.DataSource);
            }
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {

        }
    }
}
