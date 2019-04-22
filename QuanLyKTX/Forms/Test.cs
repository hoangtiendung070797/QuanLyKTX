using QuanLyKTX.Support;
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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupportSendEmail supportSendEmail = new SupportSendEmail();
            supportSendEmail.SendAll();
        }
    }
}
