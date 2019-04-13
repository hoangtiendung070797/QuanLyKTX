using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKTX.UserControls.UCGiaoDich;

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

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

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

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