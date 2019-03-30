using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;
namespace QuanLyKTX.UserControls
{
    public partial class UCDonVi : UserControl
    {
        public UCDonVi()
        {
            InitializeComponent();
            
        }
        BUS_DonVi BusDonVi = new BUS_DonVi();
        private void UCDonVi_Load(object sender, EventArgs e)
        {
            gridControlDonVi.DataSource = BusDonVi.GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DonVi donVi = new DonVi(txtMaDonVi.Text, txtTenDonVi.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtGhiChu.Text);
            if (BusDonVi.Insert(donVi))
            {
                gridControlDonVi.DataSource = BusDonVi.GetData();
                MessageBox.Show("thành công");
            }
            else
            {
                MessageBox.Show("tèo");
            }

        }
    }
}
