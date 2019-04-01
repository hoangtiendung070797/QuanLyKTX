using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using QuanLyKTX.Forms;
using QuanLyKTX.Forms.FormHeThong;
using QuanLyKTX.UserControls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Properties
        public static XtraTabControl tabstatic;
        public enum EnumUCDanhMuc
        {
            UCDanToc, UCDayNha, UCDonVi, UCLoaiDoiTuong, UCLoaiPhong, UCLoiViPham, UCLop, UCNguoiDung, UCPhong, UCQuocTich, UCTinhThanh, UCTonGiao, UCVatTu,
            UCNhatKyHoatDong,UCHoSo
        }
        #endregion

        #region Initialize


        public FormMain()
        {
            InitializeComponent();
            tabstatic = xtraTabControlMain;
        }
       
        
        private void fmMain_Load(object sender, EventArgs e)
        {
           
            skins();
            Login();
  

        }
        #endregion


        #region Methods

        #region Skin
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2013 Dark Gray";
        }

        public void Disable()
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = false;
            }

        }
        public void Enable()
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = true;
            }

        }
        #endregion

        #region Support for TabPages

        private void SelectTabByTitle(String tabTitle, XtraTabControl tabControl)
        {
            if (tabControl != null)
            {
                XtraTabPage pageToSelect = (from curPage in tabControl.TabPages
                                            where curPage.Text == tabTitle
                                            select curPage).FirstOrDefault();
                if (pageToSelect != null)
                {
                    tabControl.SelectedTabPage = pageToSelect;
                }
            }
        }

        #region Close TabPage
        private void xtraTabControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            int h = 0;
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            if (xtraTabControlMain.SelectedTabPage.Equals((arg.Page as XtraTabPage)))
                h = xtraTabControlMain.SelectedTabPageIndex;
            if ((arg.Page as XtraTabPage).Text != "Start Page")
            {
                xtraTabControlMain.TabPages.Remove((arg.Page as XtraTabPage));

                xtraTabControlMain.SelectedTabPageIndex = h - 1;
            }
            else
                XtraMessageBox.Show("Bạn không thể tắt\nTab bắt đầu này !", "Thông báo");


        }
        #endregion

        #region Kiểm tra TabPabPage có tồn tại không
        public static bool ExitsTabpages(string name)
        {
            foreach (XtraTabPage tabpage in tabstatic.TabPages)
            {
                if (tabpage.Text == name)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Tìm vị trí TabPage
        public static int IndexOfTabPage(string name)
        {
            int position = 0;
            for (int i = 0; i < tabstatic.TabPages.Count; i++)
            {
                if (tabstatic.TabPages[i].Text == name)
                    position = i;
            }
            return position;
        }
        #endregion

        #region Thêm tabpage
        public void AddTabPages(string nameOfTab,int select)
        { 
            XtraTabPage tabPage = new XtraTabPage();
            tabPage.Text = nameOfTab;
            if (ExitsTabpages(tabPage.Text) == false)
                tabstatic.TabPages.Add(tabPage);
            else
            {
                tabPage.PageVisible = true;
            }
            //ví dụ muốn add 1 UC
            switch (select)
            {
                case (int)EnumUCDanhMuc.UCNhatKyHoatDong:

                    UCNhatKyHoatDong uc = new UCNhatKyHoatDong();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uc);
                    uc.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];

                    break;

                case (int)EnumUCDanhMuc.UCDanToc:


                    UCDanToc uCDanToc = new UCDanToc();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCDanToc);
                    uCDanToc.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];
                    break;

                case (int)EnumUCDanhMuc.UCDayNha:

                    UCDayNha ucDayNha = new UCDayNha();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(ucDayNha);
                    ucDayNha.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];
                    break;

                case (int)EnumUCDanhMuc.UCDonVi:

                    UCDonVi uCDonVi = new UCDonVi();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCDonVi);
                    uCDonVi.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];
                    break;

                case (int)EnumUCDanhMuc.UCLoaiDoiTuong:

                    UCLoaiDoiTuong uCLoaiDoiTuong = new UCLoaiDoiTuong();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCLoaiDoiTuong);
                    uCLoaiDoiTuong.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];
                    break;

                case (int)EnumUCDanhMuc.UCLoaiPhong:

                    UCLoaiPhong uCLoaiPhong = new UCLoaiPhong();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCLoaiPhong);
                    uCLoaiPhong.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];
                    break;

                case (int)EnumUCDanhMuc.UCLoiViPham:

                    UCLoiViPham uCLoiViPham = new UCLoiViPham();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCLoiViPham);
                    uCLoiViPham.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];

                    break;
                case (int)EnumUCDanhMuc.UCLop:

                    UCLop uCLop = new UCLop();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCLop);
                    uCLop.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];
                    break;

                case (int)EnumUCDanhMuc.UCNguoiDung:
                    break;

                case (int)EnumUCDanhMuc.UCPhong:


                    UCPhong uCPhong = new UCPhong();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCPhong);
                    uCPhong.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];
                    break;

                case (int)EnumUCDanhMuc.UCQuocTich:

                    UCQuocTich uCQuocTich = new UCQuocTich();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCQuocTich);
                    uCQuocTich.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];
                    break;

                case (int)EnumUCDanhMuc.UCTinhThanh:

                    UCTinhThanh uCTinhThanh = new UCTinhThanh();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCTinhThanh);
                    uCTinhThanh.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];
                    break;

                case (int)EnumUCDanhMuc.UCTonGiao:

                    UCTonGiao uCTonGiao = new UCTonGiao();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCTonGiao);
                    uCTonGiao.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];
                    break;

                case (int)EnumUCDanhMuc.UCVatTu:

                    UCVatTu uCVatTu = new UCVatTu();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCVatTu);
                    uCVatTu.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];

                    break;

                case (int)EnumUCDanhMuc.UCHoSo:

                    UCHoSo uCHoSo  = new UCHoSo();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCHoSo);
                    uCHoSo.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];

                    break;
                default:
                    break;
            }        
        }
        #endregion


        #region Thoát tab
        public static void thoattab()
        {
            int i = tabstatic.SelectedTabPageIndex;
            tabstatic.TabPages.RemoveAt(i);
            tabstatic.SelectedTabPageIndex = i - 1;
        }
        #endregion

        #endregion


        

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        #region Gọi Form Or UserControl.

        

        private void btnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Dãy Nhà", (int)EnumUCDanhMuc.UCDayNha);
        }

        private void btnCity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Tỉnh Thành", (int)EnumUCDanhMuc.UCTinhThanh);
        }

        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Dân Tộc", (int)EnumUCDanhMuc.UCTinhThanh);
        }

        private void btnQuocTich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Quốc Tịch", (int)EnumUCDanhMuc.UCQuocTich);
        }

        private void btnGiaPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Loại Phòng", (int)EnumUCDanhMuc.UCLoaiPhong);
        }

        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormBackUp formBackUp = new FormBackUp();
            formBackUp.ShowDialog();
        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Tôn Giáo", (int)EnumUCDanhMuc.UCTonGiao);
        }

        private void btnRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Phòng", (int)EnumUCDanhMuc.UCPhong);
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Vật Tư", (int)EnumUCDanhMuc.UCVatTu);
        }

        private void btnDonVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Đơn Vị", (int)EnumUCDanhMuc.UCDonVi);
        }

        private void btnClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Lớp", (int)EnumUCDanhMuc.UCLop);
        }

        private void btnViPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Lỗi Vi Phạm", (int)EnumUCDanhMuc.UCLoiViPham);
        }

        private void btnOject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Loại Đối Tượng", (int)EnumUCDanhMuc.UCLoaiDoiTuong);
        }

        private void btnKhoiPhuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormRestore formRestore = new FormRestore();
            formRestore.StartPosition = FormStartPosition.CenterParent;
            formRestore.ShowDialog();
            
        }



        #endregion

        #region Phần Hệ Thống
        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDoiMatKhau formDoiMatKhau = new FormDoiMatKhau();
            formDoiMatKhau.ShowDialog();
        }

        private void btnNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Logout();


        }
        #endregion

        #region Đăng Nhập - Đăng Xuất

        

        public void Login()
        {
            Disable();
            FormDangNhap formDangNhap = new FormDangNhap();
            while (!Const.isLogin)
            {
                formDangNhap.ShowDialog();
            }
            Enable();
        }

        public void Logout()
        {
            Const.isLogin = false;
            Disable();
            FormDangNhap formDangNhap = new FormDangNhap();
            while (!Const.isLogin)
            {
                formDangNhap.ShowDialog();
            }
        }
        #endregion
        private void btnNhatKyHoatDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Nhật Ký Hoạt Động", (int)EnumUCDanhMuc.UCNhatKyHoatDong);
        }

        private void btnImportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormImportExcel formImportExcel = new FormImportExcel();
            formImportExcel.ShowDialog();
        }



        #endregion

        private void btnHoSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Hồ Sơ", (int)EnumUCDanhMuc.UCHoSo);
        }
    }
}
