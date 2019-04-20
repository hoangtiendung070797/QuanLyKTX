namespace QuanLyKTX.Forms.FormGiaoDich
{
    partial class FormXepPhong
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
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhap = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelControlTitle = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pnllThongTin = new DevExpress.XtraEditors.PanelControl();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.pictureHoSo = new DevExpress.XtraEditors.PictureEdit();
            this.btnNhapLai = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoDem = new System.Windows.Forms.TextBox();
            this.pnlImage = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTitle)).BeginInit();
            this.panelControlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnllThongTin)).BeginInit();
            this.pnllThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHoSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlImage)).BeginInit();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(287, 452);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(111, 38);
            this.btnHuyBo.TabIndex = 19;
            this.btnHuyBo.Text = "Thoát";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(49, 452);
            this.btnCapNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(111, 38);
            this.btnCapNhap.TabIndex = 17;
            this.btnCapNhap.Text = "Xác nhận";
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Đối Tượng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelControlTitle
            // 
            this.panelControlTitle.Controls.Add(this.label1);
            this.panelControlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTitle.Location = new System.Drawing.Point(2, 2);
            this.panelControlTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControlTitle.Name = "panelControlTitle";
            this.panelControlTitle.Size = new System.Drawing.Size(1697, 42);
            this.panelControlTitle.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pnllThongTin);
            this.panelControl2.Controls.Add(this.pnlImage);
            this.panelControl2.Controls.Add(this.panelControlTitle);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1701, 799);
            this.panelControl2.TabIndex = 3;
            // 
            // pnllThongTin
            // 
            this.pnllThongTin.Controls.Add(this.cbbNhanVien);
            this.pnllThongTin.Controls.Add(this.pictureHoSo);
            this.pnllThongTin.Controls.Add(this.btnHuyBo);
            this.pnllThongTin.Controls.Add(this.btnNhapLai);
            this.pnllThongTin.Controls.Add(this.btnCapNhap);
            this.pnllThongTin.Controls.Add(this.txtMaSinhVien);
            this.pnllThongTin.Controls.Add(this.label5);
            this.pnllThongTin.Controls.Add(this.label4);
            this.pnllThongTin.Controls.Add(this.txtTen);
            this.pnllThongTin.Controls.Add(this.label3);
            this.pnllThongTin.Controls.Add(this.label2);
            this.pnllThongTin.Controls.Add(this.txtHoDem);
            this.pnllThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnllThongTin.Location = new System.Drawing.Point(1254, 44);
            this.pnllThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnllThongTin.Name = "pnllThongTin";
            this.pnllThongTin.Size = new System.Drawing.Size(445, 753);
            this.pnllThongTin.TabIndex = 2;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(168, 378);
            this.cbbNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(160, 24);
            this.cbbNhanVien.TabIndex = 100;
            // 
            // pictureHoSo
            // 
            this.pictureHoSo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureHoSo.Location = new System.Drawing.Point(168, 20);
            this.pictureHoSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureHoSo.Name = "pictureHoSo";
            this.pictureHoSo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureHoSo.Properties.ZoomAccelerationFactor = 1D;
            this.pictureHoSo.Size = new System.Drawing.Size(155, 172);
            this.pictureHoSo.TabIndex = 99;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(168, 452);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(111, 38);
            this.btnNhapLai.TabIndex = 18;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSinhVien.Location = new System.Drawing.Point(168, 292);
            this.txtMaSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(256, 16);
            this.txtMaSinhVien.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhân Viên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã sinh viên   :";
            // 
            // txtTen
            // 
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Location = new System.Drawing.Point(168, 252);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(256, 16);
            this.txtTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên        :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ đệm        :";
            // 
            // txtHoDem
            // 
            this.txtHoDem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoDem.Location = new System.Drawing.Point(168, 215);
            this.txtHoDem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(256, 16);
            this.txtHoDem.TabIndex = 0;
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.gridControl1);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImage.Location = new System.Drawing.Point(2, 44);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(1252, 753);
            this.pnlImage.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1248, 749);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.Editable = false;
            this.cardView1.OptionsFind.AllowFindPanel = false;
            this.cardView1.OptionsFind.AlwaysVisible = true;
            this.cardView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.cardView1.OptionsFind.ShowClearButton = false;
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.cardView1.Click += new System.EventHandler(this.cardView1_Click);
            // 
            // FormXepPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 799);
            this.Controls.Add(this.panelControl2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormXepPhong";
            this.Text = "FormXepPhong";
            this.Load += new System.EventHandler(this.FormXepPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTitle)).EndInit();
            this.panelControlTitle.ResumeLayout(false);
            this.panelControlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnllThongTin)).EndInit();
            this.pnllThongTin.ResumeLayout(false);
            this.pnllThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHoSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlImage)).EndInit();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        private DevExpress.XtraEditors.SimpleButton btnCapNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.PanelControl panelControlTitle;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl pnllThongTin;
        private DevExpress.XtraEditors.PictureEdit pictureHoSo;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoDem;
        private DevExpress.XtraEditors.PanelControl pnlImage;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnNhapLai;
    }
}