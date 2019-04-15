using BUS;
using QuanLyKTX.Forms.FormGiaoDich;
using System;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls.UCGiaoDich
{
    public partial class UCPhieuCapPhat : UserControl
    {
        public UCPhieuCapPhat()
        {
            InitializeComponent();
           
        }
        #region properties
        string temp;
        #endregion
        BUS_PhieuCapPhatVatTu BUS_PhieuCapPhatVatTu = new BUS_PhieuCapPhatVatTu();
        private void UCPhieuCapPhat_Load(object sender, EventArgs e)
        {
           gridControlPhieuCP.DataSource = BUS_PhieuCapPhatVatTu.GetDataNew();
           gridView1.Columns[0].Visible = false;
           gridView1.Columns[1].Visible = false;
           gridView1.Columns[2].Visible = false;
           gridView1.Columns[3].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmTaoPhieuCapPhat frmTaoPhieuCapPhat = new FrmTaoPhieuCapPhat();
            frmTaoPhieuCapPhat.ShowDialog();
            gridControlPhieuCP.DataSource = BUS_PhieuCapPhatVatTu.GetDataNew();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phiếu này hay không ? ","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
               // MessageBox.Show(temp);
                if(BUS_PhieuCapPhatVatTu.Delete(int.Parse(temp)))
                {
                    MessageBox.Show("Phiếu đã được xóa !");
                }
                MessageBox.Show("Không thể xóa phiếu này !");
                
            }
            gridControlPhieuCP.DataSource = BUS_PhieuCapPhatVatTu.GetDataNew();
        }
        FrmSuaPhieuCapPhat sua = new FrmSuaPhieuCapPhat();
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            
            temp = gridView1.GetRowCellValue(e.RowHandle, "PhieuCapPhatVatTuId").ToString();
            sua.id = temp;
            sua.cbPhong.SelectedValue = gridView1.GetRowCellValue(e.RowHandle, "PhongId").ToString();
            
            sua.cbNhanVien.SelectedValue = gridView1.GetRowCellValue(e.RowHandle, "NhanVienId").ToString();
            sua.cbNguoiDung.SelectedValue = gridView1.GetRowCellValue(e.RowHandle ,"NguoiDungId").ToString();
            
            sua.dateCapPhat.Text = gridView1.GetRowCellValue(e.RowHandle, "Ngày cấp phát").ToString();
            sua.txtTenNguoiLap.Text = gridView1.GetRowCellValue(e.RowHandle, "Người lập").ToString();
            sua.txtGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "Ghi chú").ToString();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sua.ShowDialog();
            gridControlPhieuCP.DataSource = BUS_PhieuCapPhatVatTu.GetDataNew();
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {           
            gridControlPhieuCP.DataSource = BUS_PhieuCapPhatVatTu.TimKiemNgay(dateEdit1.Text);
        }

        private void btnHienThiAll_Click(object sender, EventArgs e)
        {
            gridControlPhieuCP.DataSource = BUS_PhieuCapPhatVatTu.GetDataNew();
        }

        private void dateEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {

        }
    }
}
