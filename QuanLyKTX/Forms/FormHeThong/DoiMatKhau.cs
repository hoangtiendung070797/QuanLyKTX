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
    public partial class DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public DoiMatKhau()
        {
            InitializeComponent();
            txtMatKhauOdd.Focus();
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }
    }
}