namespace QuanLyKTX
{
    partial class UCNhatKyHoatDong
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnXemLog = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditNgay = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbbTenNguoiDung = new System.Windows.Forms.ComboBox();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbbThaoTac = new System.Windows.Forms.ComboBox();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbbChucNang = new System.Windows.Forms.ComboBox();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbChucNang);
            this.layoutControl1.Controls.Add(this.cbbThaoTac);
            this.layoutControl1.Controls.Add(this.cbbTenNguoiDung);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btnXemLog);
            this.layoutControl1.Controls.Add(this.dateEditNgay);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(895, 316, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(859, 495);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 82);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(835, 401);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnXemLog
            // 
            this.btnXemLog.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLog.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnXemLog.Appearance.Options.UseFont = true;
            this.btnXemLog.Appearance.Options.UseForeColor = true;
            this.btnXemLog.Location = new System.Drawing.Point(742, 56);
            this.btnXemLog.Name = "btnXemLog";
            this.btnXemLog.Size = new System.Drawing.Size(105, 22);
            this.btnXemLog.StyleController = this.layoutControl1;
            this.btnXemLog.TabIndex = 10;
            this.btnXemLog.Text = "Xem log";
            // 
            // dateEditNgay
            // 
            this.dateEditNgay.EditValue = null;
            this.dateEditNgay.Location = new System.Drawing.Point(49, 56);
            this.dateEditNgay.Name = "dateEditNgay";
            this.dateEditNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgay.Size = new System.Drawing.Size(101, 20);
            this.dateEditNgay.StyleController = this.layoutControl1;
            this.dateEditNgay.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "NHẬT KÝ HOẠT ĐỘNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem3,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem9,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(859, 495);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(839, 20);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(839, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEditNgay;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(142, 26);
            this.layoutControlItem2.Text = "Ngày :";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(32, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnXemLog;
            this.layoutControlItem6.Location = new System.Drawing.Point(730, 44);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(109, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 70);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(839, 405);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // cbbTenNguoiDung
            // 
            this.cbbTenNguoiDung.FormattingEnabled = true;
            this.cbbTenNguoiDung.Location = new System.Drawing.Point(232, 56);
            this.cbbTenNguoiDung.Name = "cbbTenNguoiDung";
            this.cbbTenNguoiDung.Size = new System.Drawing.Size(101, 21);
            this.cbbTenNguoiDung.TabIndex = 15;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.cbbTenNguoiDung;
            this.layoutControlItem9.Location = new System.Drawing.Point(142, 44);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(183, 26);
            this.layoutControlItem9.Text = "Tên người dùng";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(75, 13);
            // 
            // cbbThaoTac
            // 
            this.cbbThaoTac.FormattingEnabled = true;
            this.cbbThaoTac.Location = new System.Drawing.Point(415, 56);
            this.cbbThaoTac.Name = "cbbThaoTac";
            this.cbbThaoTac.Size = new System.Drawing.Size(79, 21);
            this.cbbThaoTac.TabIndex = 16;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbbThaoTac;
            this.layoutControlItem4.Location = new System.Drawing.Point(325, 44);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(161, 26);
            this.layoutControlItem4.Text = "Thao tác";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 13);
            // 
            // cbbChucNang
            // 
            this.cbbChucNang.FormattingEnabled = true;
            this.cbbChucNang.Location = new System.Drawing.Point(576, 56);
            this.cbbChucNang.Name = "cbbChucNang";
            this.cbbChucNang.Size = new System.Drawing.Size(162, 21);
            this.cbbChucNang.TabIndex = 17;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbbChucNang;
            this.layoutControlItem5.Location = new System.Drawing.Point(486, 44);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(244, 26);
            this.layoutControlItem5.Text = "Chức năng";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(75, 13);
            // 
            // UCNhatKyHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UCNhatKyHoatDong";
            this.Size = new System.Drawing.Size(859, 495);
            this.Load += new System.EventHandler(this.UCNhatKyHoatDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnXemLog;
        private DevExpress.XtraEditors.DateEdit dateEditNgay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.ComboBox cbbChucNang;
        private System.Windows.Forms.ComboBox cbbThaoTac;
        private System.Windows.Forms.ComboBox cbbTenNguoiDung;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
