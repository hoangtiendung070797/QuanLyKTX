namespace QuanLyKTX.Forms.FormGiaoDich
{
    partial class FormTaoPhieuThuPhiPhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoPhieuThuPhiPhong));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbTinhTrang = new System.Windows.Forms.CheckBox();
            this.cbbNguoiDung = new System.Windows.Forms.ComboBox();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.txtTienThu = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dteDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.dteTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.dteNgayThu = new DevExpress.XtraEditors.DateEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNguoiLap = new System.Windows.Forms.TextBox();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayThu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.groupControl1.Controls.Add(this.cbTinhTrang);
            this.groupControl1.Controls.Add(this.cbbNguoiDung);
            this.groupControl1.Controls.Add(this.cbbNhanVien);
            this.groupControl1.Controls.Add(this.txtTienThu);
            this.groupControl1.Controls.Add(this.txtGhiChu);
            this.groupControl1.Controls.Add(this.dteDenNgay);
            this.groupControl1.Controls.Add(this.dteTuNgay);
            this.groupControl1.Controls.Add(this.dteNgayThu);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtTenNguoiLap);
            this.groupControl1.FireScrollEventOnMouseWheel = true;
            this.groupControl1.InvertTouchScroll = true;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(430, 511);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.AutoSize = true;
            this.cbTinhTrang.Location = new System.Drawing.Point(382, 466);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(15, 14);
            this.cbTinhTrang.TabIndex = 6;
            this.cbTinhTrang.UseVisualStyleBackColor = true;
            // 
            // cbbNguoiDung
            // 
            this.cbbNguoiDung.Enabled = false;
            this.cbbNguoiDung.FormattingEnabled = true;
            this.cbbNguoiDung.Location = new System.Drawing.Point(190, 119);
            this.cbbNguoiDung.Name = "cbbNguoiDung";
            this.cbbNguoiDung.Size = new System.Drawing.Size(207, 21);
            this.cbbNguoiDung.TabIndex = 5;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(190, 26);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(207, 21);
            this.cbbNhanVien.TabIndex = 5;
            this.cbbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbbNhanVien_SelectedIndexChanged);
            // 
            // txtTienThu
            // 
            this.txtTienThu.Location = new System.Drawing.Point(190, 410);
            this.txtTienThu.Name = "txtTienThu";
            this.txtTienThu.Size = new System.Drawing.Size(207, 21);
            this.txtTienThu.TabIndex = 4;
            this.txtTienThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienThu_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(190, 294);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(207, 98);
            this.txtGhiChu.TabIndex = 4;
            // 
            // dteDenNgay
            // 
            this.dteDenNgay.EditValue = null;
            this.dteDenNgay.Location = new System.Drawing.Point(190, 255);
            this.dteDenNgay.Name = "dteDenNgay";
            this.dteDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDenNgay.Size = new System.Drawing.Size(207, 20);
            this.dteDenNgay.TabIndex = 3;
            this.dteDenNgay.EditValueChanged += new System.EventHandler(this.dteTuNgay_EditValueChanged);
            // 
            // dteTuNgay
            // 
            this.dteTuNgay.EditValue = null;
            this.dteTuNgay.Location = new System.Drawing.Point(190, 215);
            this.dteTuNgay.Name = "dteTuNgay";
            this.dteTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Size = new System.Drawing.Size(207, 20);
            this.dteTuNgay.TabIndex = 3;
            // 
            // dteNgayThu
            // 
            this.dteNgayThu.EditValue = null;
            this.dteNgayThu.Location = new System.Drawing.Point(190, 171);
            this.dteNgayThu.Name = "dteNgayThu";
            this.dteNgayThu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayThu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayThu.Size = new System.Drawing.Size(207, 20);
            this.dteNgayThu.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ghi chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tình trạng thu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thu phí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phí tính đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phí tính từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Người dùng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên người lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân viên";
            // 
            // txtTenNguoiLap
            // 
            this.txtTenNguoiLap.Location = new System.Drawing.Point(190, 71);
            this.txtTenNguoiLap.Name = "txtTenNguoiLap";
            this.txtTenNguoiLap.Size = new System.Drawing.Size(207, 21);
            this.txtTenNguoiLap.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.ImageOptions.Image")));
            this.btnOk.Location = new System.Drawing.Point(145, 529);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(144, 43);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(295, 529);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 43);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(448, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(504, 511);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Đối tượng";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(500, 489);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsFind.AllowFindPanel = false;
            this.cardView1.OptionsFind.AlwaysVisible = true;
            this.cardView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.cardView1.Click += new System.EventHandler(this.cardView1_Click);
            // 
            // FormTaoPhieuThuPhiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(964, 577);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTaoPhieuThuPhiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo phiếu thu phí phòng";
            this.Load += new System.EventHandler(this.FormTaoPhieuThuPhiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayThu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNguoiLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbNguoiDung;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.TextBox txtTienThu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private DevExpress.XtraEditors.DateEdit dteDenNgay;
        private DevExpress.XtraEditors.DateEdit dteTuNgay;
        private DevExpress.XtraEditors.DateEdit dteNgayThu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.CheckBox cbTinhTrang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    }
}