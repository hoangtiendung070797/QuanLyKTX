using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX.UserControls.UCGiaoDich
{
    public partial class UCKhenThuong_KyLuat : UserControl
    {
        public UCKhenThuong_KyLuat()
        {
            InitializeComponent();
        }

        private void UCKhenThuong_KyLuat_Load(object sender, EventArgs e)
        {
            UCKhenThuong uCKhenThuong = new UCKhenThuong();
            uCKhenThuong.Dock = DockStyle.Fill;
            tabKhenThuong.Controls.Add(uCKhenThuong);

            UCKyLuat uCKyLuat = new UCKyLuat();
            uCKyLuat.Dock = DockStyle.Fill;
            tabKyLuat.Controls.Add(uCKyLuat);

        }
    }
}
