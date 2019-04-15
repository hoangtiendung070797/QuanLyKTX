using BUS;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DTO;
using QuanLyKTX.Forms;
using QuanLyKTX.Forms.FormHeThong;
using QuanLyKTX.UserControls;
using QuanLyKTX.UserControls.UCGiaoDich;
using QuanLyKTX.UserControls.UCHeThong;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Properties
        public static XtraTabControl tabstatic;
        public BUS_PhanQuyen BUS_PhanQuyen = new BUS_PhanQuyen();
        public enum EnumUCDanhMuc
        {
            UCDanToc, UCDayNha, UCDonVi, UCLoaiDoiTuong, UCLoaiPhong, UCLoiViPham, UCLop, UCNguoiDung, UCPhong, UCQuocTich, UCTinhThanh, UCTonGiao, UCVatTu,
            UCNhatKyHoatDong, UCHoSo, UCPhanQuyen, UCThuTienPhong, UCPhieuCapPhat, UCCapPhat, UCXepPhong, UCThuTienSinhHoat
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
            AddTabPages("Dân Tộc", (int)EnumUCDanhMuc.UCDanToc);
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
        private void btnPhanQuyenNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Phân Quyền Người Dùng", (int)EnumUCDanhMuc.UCPhanQuyen);
        }
        private void btnKhoiPhuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormRestore formRestore = new FormRestore();
            formRestore.StartPosition = FormStartPosition.CenterParent;
            formRestore.ShowDialog();

        }

        private void btnNhatKyHoatDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Nhật Ký Hoạt Động", (int)EnumUCDanhMuc.UCNhatKyHoatDong);
        }
        private void btnHoSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages("Hồ Sơ", (int)EnumUCDanhMuc.UCHoSo);
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

            if (Const.CurrentUser.TenDangNhap != "admin")
            {
                DisableItem();
                MoQuyenTuongUng();
            }

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


        private void btnImportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormImportExcel formImportExcel = new FormImportExcel();
            formImportExcel.ShowDialog();
        }



        #endregion



        private void btnThongTinNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

     

        #region  Phân quyền mở các chức năng


        /// <summary>
        /// Nếu trường hợp là chưa có thì add quyền vào(TH user mới) còn bản chất luôn có tất cả các quyền chỉ có điều là được sủ dụng chức năng gì
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCPhanQuyen_LoadPhanQuyen(object sender, EventArgs e)
        {
            if (!BUS_PhanQuyen.IsNguoiDungIdInPQ(Const.NguoiDungId))
            {

                foreach (RibbonPage page in this.ribbonControlMain.Pages)
                {
                    foreach (RibbonPageGroup pageGroup in page.Groups)
                    {
                        foreach (BarButtonItemLink itemLink in pageGroup.ItemLinks)
                        {
                            PhanQuyen quyen = new PhanQuyen();
                            quyen.NguoiDungId = Const.NguoiDungId;
                            quyen.TenNhomChucNang = page.Text;
                            quyen.TenChucNang = itemLink.Caption;
                            quyen.ChucNangThem = true;
                            quyen.ChucNangSua = false;
                            quyen.ChucNangDoc = true;
                            quyen.ChucNangXoa = false;
                            BUS_PhanQuyen.Insert(quyen);


                        }
                    }
                }
            }

        }
        public bool CheckOpen(string str)
        {
            foreach (PhanQuyen item in Const.PhanQuyens)
            {
                if (item.TenChucNang == str && item.ChucNangDoc == true)
                    return true;
            }
            return false;
        }

        public void MoQuyenTuongUng()
        {
            foreach (RibbonPage page in this.ribbonControlMain.Pages)
            {
                foreach (RibbonPageGroup pageGroup in page.Groups)
                {
                    foreach (BarButtonItemLink itemLink in pageGroup.ItemLinks)
                    {
                        if (CheckOpen(itemLink.Caption))
                            itemLink.Item.Enabled = true;


                    }
                }
            }


        }
        public void DisableItem()
        {
            foreach (RibbonPage page in this.ribbonControlMain.Pages)
            {
                foreach (RibbonPageGroup pageGroup in page.Groups)
                {
                    foreach (BarButtonItemLink itemLink in pageGroup.ItemLinks)
                    {
                        itemLink.Item.Enabled = false;



                    }
                }
            }
        }
        #endregion

        private void btnThuTienPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTabPages("Thu Phí Phòng", (int)EnumUCDanhMuc.UCThuTienPhong);
        }

        private void btnPhieuYeuCauCapPhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTabPages("Phiếu yêu cầu cấp phát", (int)EnumUCDanhMuc.UCPhieuCapPhat);
        }

        private void btnCapPhatVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTabPages("Cấp phát vật tư", (int)EnumUCDanhMuc.UCCapPhat);
          
        }
        #region Thêm tabpage
        public void AddTabPages(string nameOfTab, int select)
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

                    UCHoSo uCHoSo = new UCHoSo();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCHoSo);
                    uCHoSo.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];

                    break;

                case (int)EnumUCDanhMuc.UCPhanQuyen:

                    UCPhanQuyen uCPhanQuyen = new UCPhanQuyen();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCPhanQuyen);
                    uCPhanQuyen.LoadPhanQuyen += UCPhanQuyen_LoadPhanQuyen;
                    uCPhanQuyen.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];

                    break;

                case (int)EnumUCDanhMuc.UCThuTienPhong:

                    UCThuTienPhong uCThuTienPhong = new UCThuTienPhong();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCThuTienPhong);
                    uCThuTienPhong.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];

                    break;
                case (int)EnumUCDanhMuc.UCPhieuCapPhat:

                    UCPhieuCapPhat uCPhieuCapPhat = new UCPhieuCapPhat();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCPhieuCapPhat);
                    uCPhieuCapPhat.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];

                    break;
                case (int)EnumUCDanhMuc.UCCapPhat:

                    UCCapPhat uCCapPhat = new UCCapPhat();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCCapPhat);
                    uCCapPhat.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];

                    break;
                case (int)EnumUCDanhMuc.UCXepPhong:

                    UCXepPhong uCXepPhong = new UCXepPhong();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCXepPhong);
                    uCXepPhong.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];

                    break;
                case (int)EnumUCDanhMuc.UCThuTienSinhHoat:
                    UCThuTienSinhHoat uCThuTienSinhHoat = new UCThuTienSinhHoat();
                    tabstatic.TabPages[IndexOfTabPage(tabPage.Text)].Controls.Add(uCThuTienSinhHoat);
                    uCThuTienSinhHoat.Dock = DockStyle.Fill;
                    tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabPage.Text)];
                    break;
                default:
                    break;
            }
        }


        #endregion

        private void btnXepPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTabPages("Xếp phòng", (int)EnumUCDanhMuc.UCXepPhong);
        }

        private void btnThuTienSinhHoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTabPages("Thu tiền sinh hoạt", (int)EnumUCDanhMuc.UCThuTienSinhHoat);
        }
    }
}
