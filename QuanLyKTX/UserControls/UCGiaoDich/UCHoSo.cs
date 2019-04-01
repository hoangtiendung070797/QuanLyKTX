using BUS;
using System;
using System.Data;
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
            gridControl1.DataSource = BUS_DoiTuong.GetFullInfo();
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
            //id = (int)dgvHoSo.GetRowCellValue(e.RowHandle, "DoiTuongId");
            
        }

        private void layoutView1_FocusedRowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            int id = (int)layoutViewHoSo.GetRowCellValue(e.RowHandle, "DoiTuongId");
            MessageBox.Show(id.ToString());
        }

        private void layoutViewHoSo_FieldValueClick(object sender, DevExpress.XtraGrid.Views.Layout.Events.FieldValueClickEventArgs e)
        {
            //DataRow x = layoutViewHoSo.GetFocusedDataRow();
            //MessageBox.Show(x["DoiTuongId"].ToString());

        }

        private void layoutViewHoSo_CardClick(object sender, DevExpress.XtraGrid.Views.Layout.Events.CardClickEventArgs e)
        {
            DataRow x = layoutViewHoSo.GetFocusedDataRow();
            MessageBox.Show(x["Mã Hồ Sơ"].ToString());
        }
    }
}
