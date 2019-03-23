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
    public partial class Backup : DevExpress.XtraEditors.XtraForm
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void btnDuongDan_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtThuMuc.Text = saveFileDialog1.FileName;
            }
        }

        private void btnDuongDan1_Click(object sender, EventArgs e)
        {
            if (folderBackup.ShowDialog() == DialogResult.OK)
            {
                txtThuMucAuto.Text = folderBackup.SelectedPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

        }
    }
}