using QuanLyKTX.Forms;
using QuanLyKTX.UserControls;
using System;
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
            themes.LookAndFeel.SkinName = "Office 2013 Dark Gray";
        }
        
        private void fmMain_Load(object sender, EventArgs e)
        {
           
            skins();
  

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtabHienThi_CloseButtonClick(object sender, EventArgs e)
        {
            xtabHienThi.TabPages.Remove(xtabHienThi.SelectedTabPage);
            //DevExpress.XtraTab.XtraTabControl TabControl = (DevExpress.XtraTab.XtraTabControl)sender;
            // int i = TabControl.SelectedTabPageIndex;
            //TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
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
            UCTinhThanh tinhThanh = new UCTinhThanh();
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
            UCDanToc danToc = new UCDanToc();
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
            UCQuocTich quocTich = new UCQuocTich();
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
            UCGiaLoaiPhong giaLoaiPhong = new UCGiaLoaiPhong();
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

        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormBackUp formBackUp = new FormBackUp();
            formBackUp.Show();
        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            UCTonGiao TonGiao = new UCTonGiao();
            DevExpress.XtraTab.XtraTabPage tabTonGiao = new DevExpress.XtraTab.XtraTabPage();
            tabTonGiao.Name = "tabTonGiao";
            tabTonGiao.Text = "Tôn Giáo";
            tabTonGiao.Controls.Add(TonGiao);
            TonGiao.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Tôn Giáo")
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
                xtabHienThi.TabPages.Add(tabTonGiao);
                xtabHienThi.SelectedTabPage = tabTonGiao;
            }
        }

        private void btnRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCPhong Phong = new UCPhong();
            DevExpress.XtraTab.XtraTabPage tabPhong = new DevExpress.XtraTab.XtraTabPage();
            tabPhong.Name = "tabPhong";
            tabPhong.Text = "Phòng";
            tabPhong.Controls.Add(Phong);
            Phong.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Phòng")
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
                xtabHienThi.TabPages.Add(tabPhong);
                xtabHienThi.SelectedTabPage = tabPhong;
            }
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCVatTu VatTu = new UCVatTu();
            DevExpress.XtraTab.XtraTabPage tabvatTu = new DevExpress.XtraTab.XtraTabPage();
            tabvatTu.Name = "tabVatTu";
            tabvatTu.Text = "Vật Tư";
            tabvatTu.Controls.Add(VatTu);
            VatTu.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Vật Tư")
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
                xtabHienThi.TabPages.Add(tabvatTu);
                xtabHienThi.SelectedTabPage = tabvatTu;
            }
        }

        private void btnDonVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCDonVi DonVi = new UCDonVi();
            DevExpress.XtraTab.XtraTabPage tabdonVi = new DevExpress.XtraTab.XtraTabPage();
            tabdonVi.Name = "tabDonvi";
            tabdonVi.Text = "Đơn Vị";
            tabdonVi.Controls.Add(DonVi);
            DonVi.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Đơn Vị")
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
                xtabHienThi.TabPages.Add(tabdonVi);
                xtabHienThi.SelectedTabPage = tabdonVi;
            }
        }

        private void btnClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCLop Lop = new UCLop();
            DevExpress.XtraTab.XtraTabPage tabLop = new DevExpress.XtraTab.XtraTabPage();
            tabLop.Name = "tabLop";
            tabLop.Text = "Lớp";
            tabLop.Controls.Add(Lop);
            Lop.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Lớp")
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
                xtabHienThi.TabPages.Add(tabLop);
                xtabHienThi.SelectedTabPage = tabLop;
            }
        }

        private void btnViPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCLoiViPham LoiViPham = new UCLoiViPham();
            DevExpress.XtraTab.XtraTabPage tabLoiViPham = new DevExpress.XtraTab.XtraTabPage();
            tabLoiViPham.Name = "tabLoiViPham";
            tabLoiViPham.Text = "Lỗi vi Phạm";
            tabLoiViPham.Controls.Add(LoiViPham);
            LoiViPham.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Lỗi vi Phạm")
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
                xtabHienThi.TabPages.Add(tabLoiViPham);
                xtabHienThi.SelectedTabPage = tabLoiViPham;
            }
        }

        private void btnOject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCLoaiDoiTuong LoaiDoiTuong = new UCLoaiDoiTuong();
            DevExpress.XtraTab.XtraTabPage tabLoaiDoiTuong = new DevExpress.XtraTab.XtraTabPage();
            tabLoaiDoiTuong.Name = "tabLoaiDoiTuong";
            tabLoaiDoiTuong.Text = "Loại Đối Tượng";
            tabLoaiDoiTuong.Controls.Add(LoaiDoiTuong);
            LoaiDoiTuong.Dock = DockStyle.Fill;
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabHienThi.TabPages)
            {
                if (tab.Text == "Loại Đối Tượng")
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
                xtabHienThi.TabPages.Add(tabLoaiDoiTuong);
                xtabHienThi.SelectedTabPage = tabLoaiDoiTuong;
            }
        }

        private void btnKhoiPhuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormRestore formRestore = new FormRestore();
            formRestore.StartPosition = FormStartPosition.CenterParent;
            formRestore.ShowDialog();
            
        }
    }
}
