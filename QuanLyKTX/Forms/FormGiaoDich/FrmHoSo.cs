using BUS;
using DTO;
using QuanLyKTX.Support;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class FrmHoSo : DevExpress.XtraEditors.XtraForm
    {
        #region Properties
        BUS_DoiTuong BUS_DoiTuong = new BUS_DoiTuong();
        BUS_DanToc BUS_DanToc = new BUS_DanToc();
        BUS_LoaiDoiTuong BUS_LoaiDoiTuong = new BUS_LoaiDoiTuong();
        BUS_QuocTich BUS_QuocTich = new BUS_QuocTich();
        BUS_Lop BUS_Lop = new BUS_Lop();
        BUS_TonGiao BUS_TonGiao = new BUS_TonGiao();
        BUS_TinhThanh BUS_TinhThanh = new BUS_TinhThanh();
        SupportImageToDb support = new SupportImageToDb();
        string path = "";
        #endregion


        #region Initialize
        public FrmHoSo()
        {

            InitializeComponent();

        }
        #endregion

        #region Methods
        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "Windows Bitmap|*.bmp|JPEG Image|*.jpg|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureHoSo.Image = Image.FromFile(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
            }
            pictureHoSo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        private void FrmHoSo_Load(object sender, EventArgs e)
        {
            txtHoDem.Focus();
            LoadData();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void btnTaoHoSo_Click(object sender, EventArgs e)
        {
           
            //Nếu không trùng và đầy đủ thông tin cần thiết thì add
             if (!DuplicateCheck() && IsFullInfo())
            {
                DoiTuong doiTuong = new DoiTuong();
                doiTuong.HoDem = txtHoDem.Text;
                doiTuong.Ten = txtTen.Text;
                doiTuong.MaSinhVien = txtMaSinhVien.Text;
                doiTuong.NgaySinh = (DateTime)dateNgaySinh.EditValue;

                bool gioiTinh = true;
                if (rdbNu.Checked)
                    gioiTinh = false;
                doiTuong.GioiTinh = gioiTinh;
                doiTuong.NoiSinh = txtNoiSinh.Text;
                doiTuong.HoKhau = txtHoKhau.Text;
                doiTuong.QueQuan = txtQueQuan.Text;
                doiTuong.Sdt = txtSdt.Text;
                doiTuong.Email = txtEmail.Text;


                doiTuong.LoaiDoiTuongId = (int)cbLoaiDoiTuong.SelectedValue;
                doiTuong.TonGiaoId = (int)cbTonGiao.SelectedValue;
                doiTuong.LopId = (int)cbLop.SelectedValue;
                doiTuong.DanTocId = (int)cbDanToc.SelectedValue;
                doiTuong.TinhThanhId = (int)cbTinhThanh.SelectedValue;
                doiTuong.QuocTichId = (int)cbQuocTich.SelectedValue;
                doiTuong.Image = support.converImgToByte(path);
                doiTuong.GhiChu = txtGhiChu.Text;
                BUS_DoiTuong.Insert(doiTuong);

                //------------Ghi log
                NhatKyHoatDong nhatKy = new NhatKyHoatDong();
                nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
                nhatKy.NoiDung = "Thêm thành công hồ sơ của sinh viên/đối tượng " + doiTuong.HoDem + " " + doiTuong.Ten + " - " + doiTuong.MaSinhVien;
                nhatKy.ThaoTac = "Tạo";
                nhatKy.ThoiGian = DateTime.Now;
                nhatKy.ChucNang = "Hồ sơ";
                Const.NhatKyHoatDong.Insert(nhatKy);
                //-------------------

                MessageBox.Show("Thêm Thành Công!");
                
                this.Close();
            }
            else
            {
                if (DuplicateCheck()) errorProvider1.SetError(txtMaSinhVien,"MSV đã tồn tại");
                if (txtHoDem.Text=="") errorProvider1.SetError(txtHoDem, "Chưa điền tên");
                if (txtTen.Text == "") errorProvider1.SetError(txtTen, "Chưa điền tên");
                if (txtMaSinhVien.Text == "") errorProvider1.SetError(txtMaSinhVien, "Chưa điền msv");
                if (dateNgaySinh.Text == "") errorProvider1.SetError(txtHoDem, "Chưa chọn ngày sinh");
                if (txtNoiSinh.Text == "") errorProvider1.SetError(txtNoiSinh, "Chưa điền dữ liệu");
                if (txtSdt.Text == "") errorProvider1.SetError(txtSdt, "Chưa điền dữ liệu");
                if (txtEmail.Text == "") errorProvider1.SetError(txtEmail, "Chưa điền dữ liệu");
                if (txtHoKhau.Text == "") errorProvider1.SetError(txtHoKhau, "Chưa điền dữ liệu");
                if (txtQueQuan.Text == "") errorProvider1.SetError(txtQueQuan, "Chưa điền dữ liệu");

            }
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


        public void LoadData()
        {
            cbLoaiDoiTuong.DataSource = BUS_LoaiDoiTuong.GetData();
            cbLoaiDoiTuong.DisplayMember = "tenLoaiDoiTuong";
            cbLoaiDoiTuong.ValueMember = "LoaiDoiTuongId";

            cbQuocTich.DataSource = BUS_QuocTich.GetData();
            cbQuocTich.DisplayMember = "tenQuocTich";
            cbQuocTich.ValueMember = "QuocTichId";

            cbTinhThanh.DataSource = BUS_TinhThanh.GetData();
            cbTinhThanh.DisplayMember = "tenTinhThanh";
            cbTinhThanh.ValueMember = "TinhThanhId";

            cbDanToc.DataSource = BUS_DanToc.GetData();
            cbDanToc.DisplayMember = "tenDanToc";
            cbDanToc.ValueMember = "DanTocId";

            cbLop.DataSource = BUS_Lop.GetData();
            cbLop.DisplayMember = "tenLop";
            cbLop.ValueMember = "LopId";

            cbTonGiao.DataSource = BUS_TonGiao.GetData();
            cbTonGiao.DisplayMember = "tenTonGiao";
            cbTonGiao.ValueMember = "TonGiaoId";

        }

        public bool check_LoaiDoiTuong()
        {
            //nếu là loại đối tượng là sinh viên - thì chắc chắn sẽ có mã sinh viên
            if (cbLoaiDoiTuong.Text == "Sinh Viên")
            {

                return true;
            }
            else
            {
                return false;
            }
        }
            public bool DuplicateCheck()
        {
            //nếu là loại đối tượng là sinh viên - thì chắc chắn sẽ có mã sinh viên
            if (cbLoaiDoiTuong.Text == "Sinh Viên")
            {
                //kiểm tra có trùng trong csdl?
                DataTable data = BUS_DoiTuong.GetData();
                DataRow[] row = data.Select("maSinhVien = '" + txtMaSinhVien.Text + "'");

                return (row.Length != 0) ? true : false;
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

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}