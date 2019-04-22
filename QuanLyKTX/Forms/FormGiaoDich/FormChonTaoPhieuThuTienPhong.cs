using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX.Forms
{
    public partial class FormDSThuTienPhong : Form
    {
        public FormDSThuTienPhong()
        {
            InitializeComponent();
        }
        BUS_PhieuThuTienPhong bUS_PhieuThuTienPhong = new BUS_PhieuThuTienPhong();
        private void searchControl1_EditValueChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(searchControl1.Text))
                gridControl1.DataSource = bUS_PhieuThuTienPhong.GetDataById(int.Parse(searchControl1.Text));


        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = bUS_PhieuThuTienPhong.GetDataByDate((DateTime)dateEdit1.EditValue);
        }

        private void FormDSThuTienPhong_Resize(object sender, EventArgs e)
        {
            pnlGrid.Width = this.Width - (label1.Width + searchControl1.Width + 50);
        }
    }
}
