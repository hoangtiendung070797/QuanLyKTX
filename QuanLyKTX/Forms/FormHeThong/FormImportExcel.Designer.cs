namespace QuanLyKTX.Forms.FormHeThong
{
    partial class FormImportExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportExcel));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lblDuongDan = new System.Windows.Forms.Label();
            this.lbllTitle = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.navBarControlImport = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnQuocTich = new DevExpress.XtraNavBar.NavBarItem();
            this.btnTonGiao = new DevExpress.XtraNavBar.NavBarItem();
            this.btnVatTu = new DevExpress.XtraNavBar.NavBarItem();
            this.btnTinhThanh = new DevExpress.XtraNavBar.NavBarItem();
            this.btnPhong = new DevExpress.XtraNavBar.NavBarItem();
            this.btnLop = new DevExpress.XtraNavBar.NavBarItem();
            this.btnNguoiDung = new DevExpress.XtraNavBar.NavBarItem();
            this.btnDonVi = new DevExpress.XtraNavBar.NavBarItem();
            this.btnDayNha = new DevExpress.XtraNavBar.NavBarItem();
            this.btnLoiViPham = new DevExpress.XtraNavBar.NavBarItem();
            this.btnLoaiDoiTuong = new DevExpress.XtraNavBar.NavBarItem();
            this.btnLoaiPhong = new DevExpress.XtraNavBar.NavBarItem();
            this.btnDuongDanFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lblDuongDan);
            this.layoutControl1.Controls.Add(this.lbllTitle);
            this.layoutControl1.Controls.Add(this.progress);
            this.layoutControl1.Controls.Add(this.dgvImport);
            this.layoutControl1.Controls.Add(this.navBarControlImport);
            this.layoutControl1.Controls.Add(this.btnDuongDanFile);
            this.layoutControl1.Controls.Add(this.btnThucHien);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(816, 238, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1056, 570);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lblDuongDan
            // 
            this.lblDuongDan.Location = new System.Drawing.Point(425, 12);
            this.lblDuongDan.Name = "lblDuongDan";
            this.lblDuongDan.Size = new System.Drawing.Size(408, 22);
            this.lblDuongDan.TabIndex = 10;
            this.lblDuongDan.Text = "C:\\\\";
            // 
            // lbllTitle
            // 
            this.lbllTitle.Location = new System.Drawing.Point(197, 12);
            this.lbllTitle.Name = "lbllTitle";
            this.lbllTitle.Size = new System.Drawing.Size(224, 22);
            this.lbllTitle.TabIndex = 8;
            this.lbllTitle.Text = "label2";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 536);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1032, 22);
            this.progress.TabIndex = 6;
            // 
            // dgvImport
            // 
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Location = new System.Drawing.Point(197, 38);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.Size = new System.Drawing.Size(847, 494);
            this.dgvImport.TabIndex = 5;
            // 
            // navBarControlImport
            // 
            this.navBarControlImport.ActiveGroup = this.navBarGroup1;
            this.navBarControlImport.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControlImport.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnQuocTich,
            this.btnTonGiao,
            this.btnVatTu,
            this.btnTinhThanh,
            this.btnPhong,
            this.btnLop,
            this.btnNguoiDung,
            this.btnDonVi,
            this.btnDayNha,
            this.btnLoiViPham,
            this.btnLoaiDoiTuong,
            this.btnLoaiPhong});
            this.navBarControlImport.Location = new System.Drawing.Point(12, 12);
            this.navBarControlImport.Name = "navBarControlImport";
            this.navBarControlImport.OptionsNavPane.ExpandedWidth = 181;
            this.navBarControlImport.Size = new System.Drawing.Size(181, 520);
            this.navBarControlImport.TabIndex = 4;
            this.navBarControlImport.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Danh Mục";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnQuocTich),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnTonGiao),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnVatTu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnTinhThanh),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnPhong),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnLop),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnNguoiDung),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnDonVi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnDayNha),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnLoiViPham),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnLoaiDoiTuong),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnLoaiPhong)});
            this.navBarGroup1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.LargeImage")));
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btnQuocTich
            // 
            this.btnQuocTich.Caption = "Quốc Tịch";
            this.btnQuocTich.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuocTich.LargeImage")));
            this.btnQuocTich.Name = "btnQuocTich";
            this.btnQuocTich.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnQuocTich_LinkClicked);
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Caption = "Tôn Giáo";
            this.btnTonGiao.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTonGiao.LargeImage")));
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnTonGiao_LinkClicked);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Caption = "Vật Tư";
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnVatTu_LinkClicked);
            // 
            // btnTinhThanh
            // 
            this.btnTinhThanh.Caption = "Tỉnh Thành";
            this.btnTinhThanh.Name = "btnTinhThanh";
            this.btnTinhThanh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnTinhThanh_LinkClicked);
            // 
            // btnPhong
            // 
            this.btnPhong.Caption = "Phòng";
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnPhong_LinkClicked);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Name = "btnLop";
            this.btnLop.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnLop_LinkClicked);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.Caption = "Người dùng";
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnNguoiDung_LinkClicked);
            // 
            // btnDonVi
            // 
            this.btnDonVi.Caption = "Đơn Vị";
            this.btnDonVi.Name = "btnDonVi";
            this.btnDonVi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnDonVi_LinkClicked);
            // 
            // btnDayNha
            // 
            this.btnDayNha.Caption = "Dãy Nhà";
            this.btnDayNha.Name = "btnDayNha";
            this.btnDayNha.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnDayNha_LinkClicked);
            // 
            // btnLoiViPham
            // 
            this.btnLoiViPham.Caption = "Lỗi Vi Phạm";
            this.btnLoiViPham.Name = "btnLoiViPham";
            this.btnLoiViPham.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnLoiViPham_LinkClicked);
            // 
            // btnLoaiDoiTuong
            // 
            this.btnLoaiDoiTuong.Caption = "Loại Đối Tượng";
            this.btnLoaiDoiTuong.Name = "btnLoaiDoiTuong";
            this.btnLoaiDoiTuong.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnLoaiDoiTuong_LinkClicked);
            // 
            // btnLoaiPhong
            // 
            this.btnLoaiPhong.Caption = "Loại Phòng";
            this.btnLoaiPhong.Name = "btnLoaiPhong";
            this.btnLoaiPhong.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnLoaiPhong_LinkClicked);
            // 
            // btnDuongDanFile
            // 
            this.btnDuongDanFile.Location = new System.Drawing.Point(837, 12);
            this.btnDuongDanFile.Name = "btnDuongDanFile";
            this.btnDuongDanFile.Size = new System.Drawing.Size(108, 22);
            this.btnDuongDanFile.StyleController = this.layoutControl1;
            this.btnDuongDanFile.TabIndex = 11;
            this.btnDuongDanFile.Text = "Đường dẫn";
            this.btnDuongDanFile.Click += new System.EventHandler(this.btnDuongDanFile_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(949, 12);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(95, 22);
            this.btnThucHien.StyleController = this.layoutControl1;
            this.btnThucHien.TabIndex = 12;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1056, 570);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.navBarControlImport;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(185, 524);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dgvImport;
            this.layoutControlItem2.Location = new System.Drawing.Point(185, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(851, 498);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.progress;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 524);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1036, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lbllTitle;
            this.layoutControlItem5.Location = new System.Drawing.Point(185, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(228, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lblDuongDan;
            this.layoutControlItem4.Location = new System.Drawing.Point(413, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(412, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnDuongDanFile;
            this.layoutControlItem7.Location = new System.Drawing.Point(825, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(112, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnThucHien;
            this.layoutControlItem8.Location = new System.Drawing.Point(937, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(99, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // FormImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 570);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormImportExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập dữ liệu từ Excel";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.ProgressBar progress;
        private DevExpress.XtraNavBar.NavBarControl navBarControlImport;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem btnQuocTich;
        private DevExpress.XtraNavBar.NavBarItem btnTonGiao;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.Label lbllTitle;
        private System.Windows.Forms.DataGridView dgvImport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.Label lblDuongDan;
        private DevExpress.XtraEditors.SimpleButton btnDuongDanFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraNavBar.NavBarItem btnVatTu;
        private DevExpress.XtraNavBar.NavBarItem btnTinhThanh;
        private DevExpress.XtraNavBar.NavBarItem btnPhong;
        private DevExpress.XtraNavBar.NavBarItem btnLop;
        private DevExpress.XtraNavBar.NavBarItem btnNguoiDung;
        private DevExpress.XtraNavBar.NavBarItem btnDonVi;
        private DevExpress.XtraNavBar.NavBarItem btnDayNha;
        private DevExpress.XtraNavBar.NavBarItem btnLoiViPham;
        private DevExpress.XtraNavBar.NavBarItem btnLoaiDoiTuong;
        private DevExpress.XtraNavBar.NavBarItem btnLoaiPhong;
    }
}