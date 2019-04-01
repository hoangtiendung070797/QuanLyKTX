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
using QuanLyKTX.Support;
using BUS;

namespace QuanLyKTX
{
    public partial class FrmHoSo : DevExpress.XtraEditors.XtraForm
    {
        BUS_DoiTuong BUS_DoiTuong = new BUS_DoiTuong();
        SupportImageToDb support = new SupportImageToDb();
        public FrmHoSo()
        {
            
            InitializeComponent();
            
        }

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "Windows Bitmap|*.bmp|JPEG Image|*.jpg|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureHoSo.Image = Image.FromFile(openFileDialog1.FileName);

            }
            pictureHoSo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        private void FrmHoSo_Load(object sender, EventArgs e)
        {
            txtHoDem.Focus();
           
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void btnTaoHoSo_Click(object sender, EventArgs e)
        {
          
            DuplicateCheck();
        }

        public bool IsFullInfo()
        {
            if (
                !string.IsNullOrEmpty(txtHoDem.Text) && !string.IsNullOrEmpty(txtTen.Text)
                && !string.IsNullOrEmpty(txtHoKhau.Text) && !string.IsNullOrEmpty(txtHoKhau.Text)
                && !string.IsNullOrEmpty(txtNoiSinh.Text) && !string.IsNullOrEmpty(txtQueQuan.Text)
                && !string.IsNullOrEmpty(dateNgaySinh.Text) && !string.IsNullOrEmpty(cbLoaiDoiTuong.Text)
                && !string.IsNullOrEmpty(cbLop.Text) && !string.IsNullOrEmpty(cbTinhThanh.Text)
                && !string.IsNullOrEmpty(cbQuocTich.Text) && !string.IsNullOrEmpty(cbTonGiao.Text)
                 && !string.IsNullOrEmpty(txtSdt.Text) && !string.IsNullOrEmpty(txtEmail.Text)
                )
            {
                return true;
            }
            else return false;  
        }

        public bool DuplicateCheck()
        {
            //nếu là loại đối tượng là sinh viên - thì chắc chắn sẽ có mã sinh viên
            if(cbLoaiDoiTuong.Text == "Sinh Viên")
            {
                //kiểm tra có trùng trong csdl?
                DataTable data = BUS_DoiTuong.GetData();
                //for (int i = 0; i < data.Rows.Count; i++)
                //{
                    
                //}
                DataRow[] row = data.Select("maSinhVien = '" + txtMaSinhVien.Text + "'");
                MessageBox.Show(row.Length.ToString());
                    return true;
            }
            else
            {
                return false;
            }
            

        }
        public void Reset()
        {
            foreach (Control item in pnllThongTin.Controls)
            {

                if (item is TextBox)
                    item.ResetText();
            }
        }
    }
}