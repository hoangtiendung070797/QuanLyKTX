using BUS;
using DTO;
using QuanLyKTX.Support;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;


namespace QuanLyKTX.Forms.FormHeThong
{
    public enum LuaChon
    {
        QuocTich, TonGiao, VatTu, TinhThanh, Phong, Lop, NguoiDung, DonVi, DayNha, LoiViPham, LoaiDoiTuong, LoaiPhong,DanToc
    }
    public partial class FormImportExcel : Form
    {
        #region Properties
        int temp = 0;
        ImportExcel import = new ImportExcel();
        BUS_QuocTich bUS_QuocTich = new BUS_QuocTich();
        BUS_TonGiao bUS_TonGiao = new BUS_TonGiao();
        BUS_VatTu bUS_VatTu = new BUS_VatTu();
        BUS_TinhThanh bUS_TinhThanh = new BUS_TinhThanh();
        BUS_Lop bUS_Lop = new BUS_Lop();
        BUS_Phong bUS_Phong = new BUS_Phong();
        BUS_NguoiDung bUS_NguoiDung = new BUS_NguoiDung();
        BUS_DonVi bUS_DonVi = new BUS_DonVi();
        BUS_DayNha bUS_DayNha = new BUS_DayNha();
        BUS_LoaiPhong bUS_LoaiPhong = new BUS_LoaiPhong();
        BUS_LoaiDoiTuong bUS_LoaiDoiTuong = new BUS_LoaiDoiTuong();
        BUS_LoiViPham bUS_LoiViPham = new BUS_LoiViPham();
        BUS_DanToc bUS_DanToc = new BUS_DanToc();

        string path = "";
        DataTable table = new DataTable();
        #endregion


        #region Initialize
        public FormImportExcel()
        {
            InitializeComponent();
        }
        #endregion

        #region Các nút ấn chọn chức năng import
        private void btnQuocTich_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 0;
            lbllTitle.Text = "Quốc tịch";
            dgvImport.DataSource = bUS_QuocTich.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void btnTonGiao_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 1;
            lbllTitle.Text = "Tôn Giáo";
            dgvImport.DataSource = bUS_TonGiao.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnVatTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 2;
            lbllTitle.Text = "Vật Tư";
            dgvImport.DataSource = bUS_VatTu.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTinhThanh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 3;
            lbllTitle.Text = "Tỉnh Thành";
            dgvImport.DataSource = bUS_TinhThanh.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnPhong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 4;
            lbllTitle.Text = "Phòng";
            dgvImport.DataSource = bUS_Phong.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLop_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 5;
            lbllTitle.Text = "Lớp";
            dgvImport.DataSource = bUS_Lop.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnNguoiDung_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 6;
            lbllTitle.Text = "Người Dùng";
            dgvImport.DataSource = bUS_NguoiDung.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDonVi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 7;
            lbllTitle.Text = "Đơn vị";
            dgvImport.DataSource = bUS_DonVi.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDayNha_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 8;
            lbllTitle.Text = "Dãy Nhà";
            dgvImport.DataSource = bUS_DayNha.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLoiViPham_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 9;
            lbllTitle.Text = "Lỗi Vi Phạm";
            dgvImport.DataSource = bUS_LoiViPham.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLoaiDoiTuong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 10;
            lbllTitle.Text = "Loại Đối Tượng";
            dgvImport.DataSource = bUS_LoaiDoiTuong.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLoaiPhong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 11;
               lbllTitle.Text = "Loại Phòng";
            dgvImport.DataSource = bUS_LoaiPhong.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion

        #region Đường dẫn file -không cần chỉnh
        private void btnDuongDanFile_Click(object sender, EventArgs e)
        {
          
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.DereferenceLinks = true;
            browseFile.Filter = "Excel 2010|*.xlsx|Excel|*.xls";
           
            browseFile.Title = "Browse Excel file";
            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                

                path = browseFile.FileName;
                lblDuongDan.Text = path;
                Process.Start(path);
                
                table = import.ReadDataFromExcelFile(path);
                dgvImport.DataSource = table;
                dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else
            {
                MessageBox.Show("Yêu cầu chọn đường dẫn !");

            }

        }


        #endregion

        #region Thực hiện
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            switch (temp)
            {
                case (int)LuaChon.QuocTich:
                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            QuocTich quocTich = new QuocTich();
                            quocTich.TenQuocTich = table.Rows[i][1].ToString();

                            bUS_QuocTich.Insert(quocTich);
                        }
                    }
                    dgvImport.DataSource = bUS_QuocTich.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                case (int)LuaChon.TonGiao:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            TonGiao tonGiao = new TonGiao();
                            tonGiao.TenTonGiao = table.Rows[i][1].ToString();

                            bUS_TonGiao.Insert(tonGiao);
                        }
                    }
                    dgvImport.DataSource = bUS_TonGiao.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                case (int)LuaChon.VatTu:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            VatTu vattu = new VatTu();
                            vattu.VatTuId = table.Rows[i][0].ToString();    
                            vattu.TenVatTu = table.Rows[i][1].ToString();
                            vattu.MoTa = table.Rows[i][2].ToString();
                            vattu.SoLuong = int.Parse(table.Rows[i][3].ToString());
                            vattu.GhiChu = table.Rows[i][4].ToString();

                            bUS_VatTu.Insert(vattu);
                        }
                    }
                    dgvImport.DataSource = bUS_TonGiao.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                case (int)LuaChon.TinhThanh:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            TinhThanh tinhthanh = new TinhThanh();
                            tinhthanh.TenTinhThanh = table.Rows[i][1].ToString();
                            bUS_TinhThanh.Insert(tinhthanh);
                        }
                    }
                    dgvImport.DataSource = bUS_TinhThanh.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                case (int)LuaChon.Phong:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            Phong phong = new Phong();
                            phong.PhongId = table.Rows[i][0].ToString();
                            phong.DayNhaId = int.Parse(table.Rows[i][1].ToString());
                            phong.LoaiPhongId = int.Parse(table.Rows[i][2].ToString());
                            phong.TenPhong = table.Rows[i][3].ToString();
                            phong.Tang = int.Parse(table.Rows[i][4].ToString());
                            phong.GiaPhong = decimal.Parse( table.Rows[i][5].ToString());
                            bUS_Phong.Insert(phong);
                        }
                    }
                    dgvImport.DataSource = bUS_Phong.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                case (int)LuaChon.Lop:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            Lop lop = new Lop();
                            lop.LopId = int.Parse(table.Rows[i][0].ToString());
                            lop.TenLop = table.Rows[i][1].ToString();
                            lop.DonViId = int.Parse(table.Rows[i][2].ToString());
                            bUS_Lop.Insert(lop);
                        }
                    }
                    dgvImport.DataSource = bUS_Lop.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                case (int)LuaChon.DayNha:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            DayNha dayNha = new DayNha();
                            dayNha.TenDayNha = table.Rows[i][1].ToString();
                            dayNha.GhiChu = table.Rows[i][2].ToString();
                            bUS_DayNha.Insert(dayNha);
                        }
                    }
                    dgvImport.DataSource = bUS_DayNha.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                case (int)LuaChon.DonVi:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            DonVi donVi = new DonVi();
                          
                            donVi.TenDonVi = table.Rows[i][1].ToString();
                            donVi.DiaChi = table.Rows[i][2].ToString();
                            donVi.Sdt = table.Rows[i][3].ToString();
                            donVi.GhiChu = table.Rows[i][4].ToString();
                            bUS_DonVi.Insert(donVi);
                        }
                    }
                    dgvImport.DataSource = bUS_DonVi.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                case (int)LuaChon.LoiViPham:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            LoiViPham loiViPham = new LoiViPham();
                            loiViPham.TenLoiViPham = table.Rows[i][1].ToString();
                            loiViPham.NoiDung = table.Rows[i][2].ToString();
                            loiViPham.HinhThucXuLy = table.Rows[i][3].ToString();
                            loiViPham.GhiChu = table.Rows[i][4].ToString();
                            bUS_LoiViPham.Insert(loiViPham);
                        }
                    }
                    dgvImport.DataSource = bUS_LoiViPham.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                case (int)LuaChon.LoaiDoiTuong:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            LoaiDoiTuong loaiDoiTuong = new LoaiDoiTuong();
                            loaiDoiTuong.TenLoaiDoiTuong = table.Rows[i][1].ToString();
                            bUS_LoaiDoiTuong.Insert(loaiDoiTuong);
                        }
                    }
                    dgvImport.DataSource = bUS_LoaiDoiTuong.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                case (int)LuaChon.LoaiPhong:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            LoaiPhong loaiPhong = new LoaiPhong();
                            loaiPhong.TenLoaiPhong = table.Rows[i][1].ToString();
                            loaiPhong.SoLuongtoiDa = int.Parse(table.Rows[i][2].ToString());
                            loaiPhong.GiaLoaiPhong = decimal.Parse( table.Rows[i][3].ToString());
                            bUS_LoaiPhong.Insert(loaiPhong);
                        }
                    }
                    dgvImport.DataSource = bUS_LoaiPhong.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case (int)LuaChon.NguoiDung:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            NguoiDung nguoiDung = new NguoiDung();
                            nguoiDung.TenDangNhap = table.Rows[i][1].ToString();
                            nguoiDung.MatKhau = table.Rows[i][2].ToString();
                            nguoiDung.TenDayDu = table.Rows[i][3].ToString();
                            nguoiDung.Sdt = table.Rows[i][4].ToString();
                            nguoiDung.DiaChi = table.Rows[i][5].ToString();
                            bUS_NguoiDung.Insert(nguoiDung);
                        }
                    }
                    dgvImport.DataSource = bUS_NguoiDung.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;

                case (int)LuaChon.DanToc:

                    if (table != null)
                    {

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            DanToc danToc = new DanToc();
                            danToc.TenDanToc = table.Rows[i][1].ToString();
                            bUS_DanToc.Insert(danToc);
                        }
                    }
                    dgvImport.DataSource = bUS_DanToc.GetData();
                    dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                default:
                    break;


            }
        }


        #endregion

        private void btnDanToc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            temp = 12;
            lbllTitle.Text = "Dân Tộc";
            dgvImport.DataSource = bUS_DanToc.GetData();
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
