using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using QuanLyKTX.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class fmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Properties
        public static XtraTabControl tabstatic;
        public enum EnumUCDanhMuc
        {
            UCDanToc, UCDayNha, UCDonVi, UCLoaiDoiTuong, UCLoaiPhong, UCLoiViPham, UCLop, UCNguoiDung, UCPhong, UCQuocTich, UCTinhThanh, UCTonGiao, UCVatTu
        }
        #endregion

        #region Initialize


        public fmMain()
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
        public void AddTabPages()
        { 
            XtraTabPage tabCapNhatSach = new XtraTabPage();
            tabCapNhatSach.Text = "Cập nhật sách";
            if (ExitsTabpages(tabCapNhatSach.Text) == false)
                tabstatic.TabPages.Add(tabCapNhatSach);
            else
            {
                tabCapNhatSach.PageVisible = true;
            }
            //ví dụ muốn add 1 UC
            UCDanToc frm = new UCDanToc();

            // tabCapNhatSach.Controls.Add(frm);
            tabstatic.TabPages[IndexOfTabPage(tabCapNhatSach.Text)].Controls.Add(frm);
            frm.Dock = DockStyle.Fill;

            tabstatic.SelectedTabPage = tabstatic.TabPages[IndexOfTabPage(tabCapNhatSach.Text)];
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

      

        private void btnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnCity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnQuocTich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnGiaPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormBackUp formBackUp = new FormBackUp();
            formBackUp.ShowDialog();
        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnDonVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnViPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnOject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
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
            
        }
        #endregion


        public void Login()
        {
            Disable();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.ShowDialog();
            Enable();
        }

        public void Logout()
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            Disable();
            formDangNhap.ShowDialog();
        }
    }
}
