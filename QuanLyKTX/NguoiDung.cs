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
    public partial class NguoiDung : UserControl
    {
        public NguoiDung()
        {
            InitializeComponent();
            
        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }
    }
}
