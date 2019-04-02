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
            if(Const.DoiTuongId!=0)
            {
                FrmThongTinHoSo frmThongTinHoSo = new FrmThongTinHoSo();
                frmThongTinHoSo.ShowDialog();
            }
            else
            {

                MessageBox.Show("Bạn cần chọn hồ sơ cần sửa!");
            }
            
        }

    

    
        private void layoutViewHoSo_CardClick(object sender, DevExpress.XtraGrid.Views.Layout.Events.CardClickEventArgs e)
        {
            DataRow row = layoutViewHoSo.GetFocusedDataRow();
            Const.DoiTuongId = (int)row["DoiTuongId"];
        }
    }
}
