using QuanLyKTX.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            //SupportSendEmail supportSendEmail = new SupportSendEmail();
            //supportSendEmail.SendAll();

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(textBox1.Text);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }


            textBox1.Text = hasPass;
        }
    }
}
