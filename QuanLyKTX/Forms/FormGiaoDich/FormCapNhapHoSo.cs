using BUS;
using DevExpress.XtraEditors;
using DTO;
using QuanLyKTX.Support;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKTX.Forms.FormGiaoDich
{
    public partial class FormCapNhapHoSo : Form
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


        public FormCapNhapHoSo()
        {
            InitializeComponent();
        }
        #endregion


        #region Methods


        private void FormCapNhapHoSo_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadInforObj();
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
                && !string.IsNullOrEmpty(txtCMND.Text) && !string.IsNullOrEmpty(txtHoTenBo.Text)
                && !string.IsNullOrEmpty(dateEditNgaySinhBo.Text) && !string.IsNullOrEmpty(txtNgheNghiepBo.Text)
                && !string.IsNullOrEmpty(txtNoiCongTacBo.Text) && !string.IsNullOrEmpty(txtFaxBo.Text)
                && !string.IsNullOrEmpty(txtTelBo.Text) && !string.IsNullOrEmpty(txtHoTenMe.Text)
                && !string.IsNullOrEmpty(dateEditNgaySinhMe.Text) && !string.IsNullOrEmpty(txtNgheNghiepMe.Text)
                && !string.IsNullOrEmpty(txtNoiCongTacMe.Text) && !string.IsNullOrEmpty(txtFaxMe.Text)
                && !string.IsNullOrEmpty(txtTelMe.Text)
                )
            {
                return true;
            }
            else return false;
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
            foreach (Control item in groupControl1.Controls)
            {

                if (item is TextBox)
                    item.Text = "";
                if (item is DateEdit)
                    item.Text = "";
                if (item is System.Windows.Forms.ComboBox)
                    item.Text = "";
            }
            txtHoDem.Focus();
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


        /// <summary>
        /// Load dữ liệu theo Id hiện có.
        /// </summary>
        public void LoadInforObj()
        {
            DataRow row = BUS_DoiTuong.GetById(Const.DoiTuongId);
            txtHoDem.Text = row["hoDem"].ToString();
            txtTen.Text = row["ten"].ToString();
            txtMaSinhVien.Text = row["maSinhVien"].ToString();
            dateNgaySinh.EditValue = (DateTime)row["ngaySinh"];
            bool gioiTinh = (bool)row["gioiTinh"];
            if (gioiTinh)
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;
            txtNoiSinh.Text = row["noiSinh"].ToString();
            txtSdt.Text = row["sdt"].ToString();
            txtEmail.Text = row["email"].ToString();
            cbLoaiDoiTuong.SelectedValue = row["LoaiDoiTuongId"];
            cbLop.SelectedValue = row["LopId"];
            txtHoKhau.Text = row["hoKhau"].ToString();
            txtQueQuan.Text = row["queQuan"].ToString();
            cbTinhThanh.SelectedValue = row["TinhThanhId"];
            cbTonGiao.SelectedValue = row["TonGiaoId"];
            cbQuocTich.SelectedValue = row["QuocTichId"];
            cbDanToc.SelectedValue = row["DanTocId"];

            txtCMND.Text = row["cmnd"].ToString();
            txtHoTenBo.Text = row["hoTenBo"].ToString();
            dateEditNgaySinhBo.EditValue = (DateTime)row["ngaySinhBo"];
            txtNgheNghiepBo.Text = row["ngheNghiepBo"].ToString();
            txtNoiCongTacBo.Text = row["noiCongTacBo"].ToString();
            txtFaxBo.Text = row["sdtBoCoDinh"].ToString();
            txtTelBo.Text = row["sdtDDBo"].ToString();
            txtHoTenMe.Text = row["hoTenMe"].ToString();
            dateEditNgaySinhMe.EditValue = (DateTime)row["ngaySinhMe"];
            txtNgheNghiepMe.Text = row["ngheNghiepMe"].ToString();
            txtNoiCongTacMe.Text = row["noiCongTacMe"].ToString();
            txtFaxMe.Text = row["sdtMeCoDinh"].ToString();
            txtTelMe.Text = row["sdtDDMe"].ToString();

            txtGhiChu.Text = row["ghiChu"].ToString();

            //Load Ảnh

            try
            {
                string str = Convert.ToBase64String((byte[])row["anh"]);
                tempPic = (byte[])row["anh"];
                pictureHoSo.Image = support.ByteToImg(str);
                pictureHoSo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            }
            catch
            {


            }



        }

        byte[] tempPic;
        #endregion

        private void btnCapNhap_Click(object sender, EventArgs e)
        {

            //Nếu không trùng và đầy đủ thông tin cần thiết thì add

            DoiTuong doiTuong = new DoiTuong();
            doiTuong.DoiTuongId = Const.DoiTuongId;
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

            doiTuong.Cmnd = txtCMND.Text;
            doiTuong.HoTenBo = txtHoTenBo.Text;
            doiTuong.NgaySinhBo = (DateTime)dateEditNgaySinhBo.EditValue;
            doiTuong.NgheNghiepBo = txtNgheNghiepBo.Text;
            doiTuong.NoiCongTacBo = txtNoiCongTacBo.Text;
            doiTuong.SdtBoCoDinh = txtFaxBo.Text;
            doiTuong.SdtDDBo = txtTelBo.Text;
            doiTuong.HoTenMe = txtHoTenMe.Text;
            doiTuong.NgaySinhMe = (DateTime)dateEditNgaySinhMe.EditValue;
            doiTuong.NgheNghiepMe = txtNgheNghiepMe.Text;
            doiTuong.NoiCongTacMe = txtNoiCongTacMe.Text;
            doiTuong.SdtMeCoDinh = txtFaxMe.Text;
            doiTuong.SdtDDMe = txtTelMe.Text;

            doiTuong.Image = (!string.IsNullOrEmpty(path)) ? support.converImgToByte(path) : tempPic;
            doiTuong.GhiChu = txtGhiChu.Text;

            BUS_DoiTuong.Update(doiTuong);

            //------------Ghi log
            NhatKyHoatDong nhatKy = new NhatKyHoatDong();
            nhatKy.NguoiDungId = Const.CurrentUser.NguoiDungId;
            nhatKy.NoiDung = "Cập nhập thành công hồ sơ của sinh viên/đối tượng " + doiTuong.HoDem + " " + doiTuong.Ten + " - " + doiTuong.MaSinhVien;
            nhatKy.ThaoTac = "Cập nhập";
            nhatKy.ThoiGian = DateTime.Now;
            nhatKy.ChucNang = "Hồ sơ";
            Const.NhatKyHoatDong.Insert(nhatKy);
            //-------------------

            MessageBox.Show("Cập nhập Thành Công!");
            this.Close();


        }

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "JPEG Image|*.jpg|Windows Bitmap|*.bmp|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureHoSo.Image = Image.FromFile(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
            }
            pictureHoSo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
