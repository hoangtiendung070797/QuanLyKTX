namespace QuanLyKTX.UserControls.UCGiaoDich
{
    partial class UCKhenThuong_KyLuat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKhenThuong_KyLuat));
            this.tabPaneGroup = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabKhenThuong = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabKyLuat = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneGroup)).BeginInit();
            this.tabPaneGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPaneGroup
            // 
            this.tabPaneGroup.Controls.Add(this.tabKhenThuong);
            this.tabPaneGroup.Controls.Add(this.tabKyLuat);
            this.tabPaneGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaneGroup.Location = new System.Drawing.Point(0, 0);
            this.tabPaneGroup.Name = "tabPaneGroup";
            this.tabPaneGroup.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageOrText;
            this.tabPaneGroup.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabKhenThuong,
            this.tabKyLuat});
            this.tabPaneGroup.RegularSize = new System.Drawing.Size(1101, 587);
            this.tabPaneGroup.SelectedPage = this.tabKyLuat;
            this.tabPaneGroup.Size = new System.Drawing.Size(1101, 587);
            this.tabPaneGroup.TabAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.tabPaneGroup.TabIndex = 0;
            this.tabPaneGroup.TransitionType = DevExpress.Utils.Animation.Transitions.PushFade;
            // 
            // tabKhenThuong
            // 
            this.tabKhenThuong.Caption = "Khen thưởng";
            this.tabKhenThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabKhenThuong.Image = ((System.Drawing.Image)(resources.GetObject("tabKhenThuong.Image")));
            this.tabKhenThuong.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabKhenThuong.Name = "tabKhenThuong";
            this.tabKhenThuong.PageText = "";
            this.tabKhenThuong.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabKhenThuong.Size = new System.Drawing.Size(1083, 524);
            // 
            // tabKyLuat
            // 
            this.tabKyLuat.AllowTouchScroll = true;
            this.tabKyLuat.AutoScroll = true;
            this.tabKyLuat.Caption = "Kỷ luật";
            this.tabKyLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabKyLuat.Image = ((System.Drawing.Image)(resources.GetObject("tabKyLuat.Image")));
            this.tabKyLuat.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabKyLuat.Name = "tabKyLuat";
            this.tabKyLuat.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabKyLuat.Size = new System.Drawing.Size(1083, 524);
            // 
            // UCKhenThuong_KyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPaneGroup);
            this.Name = "UCKhenThuong_KyLuat";
            this.Size = new System.Drawing.Size(1101, 587);
            this.Load += new System.EventHandler(this.UCKhenThuong_KyLuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneGroup)).EndInit();
            this.tabPaneGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPaneGroup;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabKhenThuong;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabKyLuat;
    }
}
