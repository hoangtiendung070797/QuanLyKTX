using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        BUS_DayNha bUS_DayNha = new BUS_DayNha();
        private void btnThemDayNha_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTenDayNha.Text))
            {
                try
                {
             
                    errorProvider.SetError(txtTenDayNha, "");
                    DayNha dayNha = new DayNha(txtTenDayNha.Text);
                    bUS_DayNha.Insert(dayNha);
                    MessageBox.Show("Thêm thành công!");
                    // lưu vào log ...
                }
                catch
                {
                   
                    throw;
                }
            }
            else
            {
                errorProvider.SetError(txtTenDayNha, "Chưa điền tên dãy nhà!");
                txtTenDayNha.Focus();
            }
           
         

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
