using BUS;
using QuanLyKTX.Forms.FormGiaoDich;
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
            UCHoSo_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(Const.DoiTuongId!=0)
            {
                FormCapNhapHoSo formCapNhapHoSo = new FormCapNhapHoSo();
                formCapNhapHoSo.ShowDialog();
                UCHoSo_Load(sender, e);
            }
            else
            {

                MessageBox.Show("Bạn cần chọn hồ sơ cần sửa!");
            }
            
        }

    

    
        private void layoutViewHoSo_CardClick(object sender, DevExpress.XtraGrid.Views.Layout.Events.CardClickEventArgs e)
        {
            DataRow row = layoutViewHoSo.GetFocusedDataRow();
            Const.DoiTuongId = (int)row["Mã Hồ Sơ"];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn xóa hồ sơ?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BUS_DoiTuong.Delete(Const.DoiTuongId);
                    UCHoSo_Load(sender, e);
                }
                catch
                {

                    MessageBox.Show("Hồ sơ này liên quan đến tác vụ khác đang hiện hữu, bạn cần xóa các dữ liệu liên quan trước.");
                }
               
            }
                
        }
    }
}
