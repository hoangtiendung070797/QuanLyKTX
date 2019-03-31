using BUS;
using System;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCHoSo : UserControl
    {
        public UCHoSo()
        {
            InitializeComponent();
        }
        BUS_DoiTuong BUS_DoiTuong = new BUS_DoiTuong();
        int id;
        private void UCHoSo_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BUS_DoiTuong.GetData();
        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmHoSo frmHoSo = new FrmHoSo();
            frmHoSo.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmThongTinHoSo frmThongTinHoSo = new FrmThongTinHoSo();
            frmThongTinHoSo.ShowDialog();
        }

        private void dgvHoSo_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            id = (int)dgvHoSo.GetRowCellValue(e.RowHandle, "DoiTuongId");
        }
    }
}
