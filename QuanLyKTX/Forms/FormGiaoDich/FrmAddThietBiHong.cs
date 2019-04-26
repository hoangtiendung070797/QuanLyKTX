using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX.Forms.FormGiaoDich
{
    public partial class FrmAddThietBiHong : Form
    {
        public FrmAddThietBiHong()
        {
            InitializeComponent();
            
        }
        private void ckCancel_CheckedChanged(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void FrmAddThietBiHong_Load(object sender, EventArgs e)
        {
            txtSoLuong.Focus();
        }

        private void ckOk_CheckedChanged(object sender, EventArgs e)
        {



        }
        private void ckOk_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "" || txtDonViTinh.Text == "" || txtLyDo.Text == "" || txtYeuCau.Text == "")
            {
                
                MessageBox.Show("Mời điền đủ thông tin bắt buộc (*) !", "Thông báo");               
                return;
            }
            else
            {
                
                    ckOk.Checked = false;                
                    this.Close();
                
            }
        }
    }
}
