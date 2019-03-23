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
    public partial class Restore : DevExpress.XtraEditors.XtraForm
    {
        public Restore()
        {
            InitializeComponent();
        }

        private void btnDuongDan_Click(object sender, EventArgs e)
        {
            if (openFileRestore.ShowDialog() == DialogResult.OK)
            {
                txtThuMucFile.Text = openFileRestore.FileName;
            }
        }
    }
}