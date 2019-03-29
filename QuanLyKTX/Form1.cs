using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class fmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fmMain()
        {
            InitializeComponent();
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "DevExpress Style";
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
        private void fmMain_Load(object sender, EventArgs e)
        {
           
            skins();
          //  Disable();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog();
  

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtabHienThi_CloseButtonClick(object sender, EventArgs e)
        {
            xtabHienThi.TabPages.Remove(xtabHienThi.SelectedTabPage);
           // DevExpress.XtraTab.XtraTabControl TabControl = (DevExpress.XtraTab.XtraTabControl)sender;
           //  int i = TabControl.SelectedTabPageIndex;
          //  TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
            // TabControl.SelectedTabPageIndex = i - 1;
        }

        private void btnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Home home = new Home();
            DevExpress.XtraTab.XtraTabPage xtraTabHome = new DevExpress.XtraTab.XtraTabPage();
            xtraTabHome.Name = "tabHome";
            xtraTabHome.Text = "Nhà";
            xtraTabHome.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage  tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Nhà")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }
                
            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(xtraTabHome);
                xtabHienThi.SelectedTabPage = xtraTabHome;
            }
        }

        private void btnCity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TinhThanh tinhThanh = new TinhThanh();
            DevExpress.XtraTab.XtraTabPage tabTinhThanh = new DevExpress.XtraTab.XtraTabPage();           
            tabTinhThanh.Name = "tabTinhThanh";
            tabTinhThanh.Text = "Tỉnh Thành";
            tabTinhThanh.Controls.Add(tinhThanh);
            tinhThanh.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Tỉnh Thành")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }

            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(tabTinhThanh);
                xtabHienThi.SelectedTabPage = tabTinhThanh;
            }
        }

        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanToc danToc = new DanToc();
            DevExpress.XtraTab.XtraTabPage tabDanToc = new DevExpress.XtraTab.XtraTabPage();
            tabDanToc.Name = "tabDanToc";
            tabDanToc.Text = "Dân Tộc";
            tabDanToc.Controls.Add(danToc);
            danToc.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Dân Tộc")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }

            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(tabDanToc);
                xtabHienThi.SelectedTabPage = tabDanToc;
            }
        }

        private void btnQuocTich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuocTich quocTich = new QuocTich();
            DevExpress.XtraTab.XtraTabPage tabQuocTich = new DevExpress.XtraTab.XtraTabPage();
            tabQuocTich.Name = "tabQuocTich";
            tabQuocTich.Text = "Quốc tịch";
            tabQuocTich.Controls.Add(quocTich);
            quocTich.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Quốc tịch")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }

            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(tabQuocTich);
                xtabHienThi.SelectedTabPage = tabQuocTich;
            }
        }

        private void btnGiaPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiaLoaiPhong giaLoaiPhong = new GiaLoaiPhong();
            DevExpress.XtraTab.XtraTabPage tabGiaLoai = new DevExpress.XtraTab.XtraTabPage();
            tabGiaLoai.Name = "tabGiaLoaiPhong";
            tabGiaLoai.Text = "Giá loại phòng";
            tabGiaLoai.Controls.Add(giaLoaiPhong);
            giaLoaiPhong.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Giá loại phòng")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }

            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(tabGiaLoai);
                xtabHienThi.SelectedTabPage = tabGiaLoai;
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhatKyHoatDong nhatky = new NhatKyHoatDong();
            DevExpress.XtraTab.XtraTabPage tabNhatKy = new DevExpress.XtraTab.XtraTabPage();
            tabNhatKy.Name = "tabNhatKy";
            tabNhatKy.Text = "Nhật ký hoạt động";
            tabNhatKy.Controls.Add(nhatky);
            nhatky.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Nhật ký hoạt động")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }

            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(tabNhatKy);
                xtabHienThi.SelectedTabPage = tabNhatKy;
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.ShowDialog();

        }

        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
           
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Restore restore = new Restore();
            restore.ShowDialog();
        }

        private void btnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NguoiDung nguoiDung = new NguoiDung();
            DevExpress.XtraTab.XtraTabPage tabUser = new DevExpress.XtraTab.XtraTabPage();
            tabUser.Name = "tabNhatKy";
            tabUser.Text = "Nhật ký hoạt động";
            tabUser.Controls.Add(nguoiDung);
            nguoiDung.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Quản lý người dùng")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }

            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(tabUser);
                xtabHienThi.SelectedTabPage = tabUser;
            }
        }

        private void btnHoSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
         
            UCHoSo hoSo = new UCHoSo();
            DevExpress.XtraTab.XtraTabPage tabHoSo = new DevExpress.XtraTab.XtraTabPage();
            tabHoSo.Name = "tabHoSo";
            
            tabHoSo.Text = "Hồ sơ";
            tabHoSo.Controls.Add(hoSo);
            hoSo.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Hồ sơ")
                {
                    xtabHienThi.SelectedTabPage = tab;
                    t = 1;
                }

            }
            if (t == 1)
            {

            }
            else
            {
                xtabHienThi.TabPages.Add(tabHoSo);
                xtabHienThi.SelectedTabPage = tabHoSo;
            }
        }

        private void fmMain_Click(object sender, EventArgs e)
        {
            //FrmDangNhap frmDangNhap = new FrmDangNhap();
            //frmDangNhap.ShowDialog();
        }
    }
}
