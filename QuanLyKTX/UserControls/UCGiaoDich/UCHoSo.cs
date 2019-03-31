using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCHoSo : UserControl
    {
        public UCHoSo()
        {
            InitializeComponent();
        }

        private void UCHoSo_Load(object sender, EventArgs e)
        {
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

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
    }
}
