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
                cbThang.Items.Add("Tháng " + i.ToString());
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
                    cbThang.Text = "Tháng 1";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(1);
                    break;
                case 2:
                    cbThang.Text = "Tháng 2";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(2);
                    break;
                case 3:
                    cbThang.Text = "Tháng 3";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(3);
                    break;
                case 4:
                    cbThang.Text = "Tháng 4";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(4);
                    break;
                case 5:
                    cbThang.Text = "Tháng 5";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(5);
                    break;
                case 6:
                    cbThang.Text = "Tháng 6";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(6);
                    break;
                case 7:
                    cbThang.Text = "Tháng 7";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(7);
                    break;
                case 8:
                    cbThang.Text = "Tháng 8";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(8);
                    break;
                case 9:
                    cbThang.Text = "Tháng 9";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(9);
                    break;
                case 10:
                    cbThang.Text = "Tháng 10";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(10);
                    break;
                case 11:
                    cbThang.Text = "Tháng 11";
                    gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(11);
                    break;
                case 12:
                    cbThang.Text = "Tháng 12";
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
            FrmTaoPhieuThuTienSH frmTaoPhieuThuTienSH = new FrmTaoPhieuThuTienSH();
            frmTaoPhieuThuTienSH.ShowDialog();
            LoadDataTheoThang();
           // gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataNew();

        }


        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThang.SelectedItem.ToString() == "All")
            {
                gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataNew();
            }
            else
            {
                string[] temp = cbThang.SelectedItem.ToString().Split(' ');
                gridThuTien.DataSource = BUS_PhieuThuTienSH.GetDataTheoThangNew(int.Parse(temp[1]));
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_PhieuThuTienSH.UpdateDetail((DataTable)gridThuTien.DataSource);
               
            }
            catch
            {
            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(PhieuThuTienSHId.ToString());
                BUS_PhieuThuTienSH.Delete(PhieuThuTienSHId);
                LoadDataTheoThang();
            }
            catch
            {
            }
        }
        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

            try
            {
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
                    e.Appearance.BackColor = Color.RoyalBlue;
                }
                else
                {
                    e.Appearance.BackColor = Color.Red;
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
                simpleButton2.PerformClick();
            }
        }
    }
}
