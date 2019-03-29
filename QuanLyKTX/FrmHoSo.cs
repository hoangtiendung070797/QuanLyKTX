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

namespace QuanLyKTX
{
    public partial class FrmHoSo : DevExpress.XtraEditors.XtraForm
    {
        public FrmHoSo()
        {
            
            InitializeComponent();
            
        }

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureHoSo.Image = Image.FromFile(openFileDialog1.FileName);

            }
            pictureHoSo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        private void FrmHoSo_Load(object sender, EventArgs e)
        {
            txtHoDem.Focus();
        }
    }
}