using System;
using System.Windows.Forms;

namespace QuanLyKTX.Forms.FormGiaoDich
{
    public partial class FrmCapPhatVatTu : DevExpress.XtraEditors.XtraForm
    {
        public FrmCapPhatVatTu()
        {
            InitializeComponent();
            ckOk.Checked = false;
            ckCancel.Checked = false;
        }

   
        private void ckOk_CheckedChanged(object sender, EventArgs e)
        {
            if (ckOk.Checked)
            {
                this.Close();
            }
        }

        private void ckCancel_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCancel.Checked)
            {
                this.Close();
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text=="")
            {
                txtThanhTien.Text = "0";
            }
            else
            {
                txtThanhTien.Text = (double.Parse(txtDonGia.Text) * double.Parse(txtSoLuong.Text)).ToString();
            }
            
        }

 
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }        
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }       
        }
    }
}