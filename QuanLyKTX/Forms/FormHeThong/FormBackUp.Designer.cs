namespace QuanLyKTX.Forms
{
    partial class FormBackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackUp));
            this.btnPath = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControlBackUp = new DevExpress.XtraEditors.GroupControl();
            this.checkEditGhiDe = new DevExpress.XtraEditors.CheckEdit();
            this.txtTenTapTin = new System.Windows.Forms.TextBox();
            this.progressBarCoolDown = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.btnTroGiup = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBackUp)).BeginInit();
            this.groupControlBackUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditGhiDe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.EditValue = "C:\\SQLBackup\\DBQuanLyKyTucXa.bak";
            this.btnPath.Location = new System.Drawing.Point(281, 109);
            this.btnPath.Name = "btnPath";
            this.btnPath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Properties.Appearance.Options.UseFont = true;
            this.btnPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnPath.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_Properties_ButtonClick);
            this.btnPath.Size = new System.Drawing.Size(388, 26);
            this.btnPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đường dẫn thư mục";
            // 
            // groupControlBackUp
            // 
            this.groupControlBackUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControlBackUp.Controls.Add(this.checkEditGhiDe);
            this.groupControlBackUp.Controls.Add(this.btnDong);
            this.groupControlBackUp.Controls.Add(this.btnThucHien);
            this.groupControlBackUp.Controls.Add(this.btnTroGiup);
            this.groupControlBackUp.Controls.Add(this.txtTenTapTin);
            this.groupControlBackUp.Controls.Add(this.progressBarCoolDown);
            this.groupControlBackUp.Controls.Add(this.label1);
            this.groupControlBackUp.Controls.Add(this.btnPath);
            this.groupControlBackUp.Controls.Add(this.label3);
            this.groupControlBackUp.Controls.Add(this.label2);
            this.groupControlBackUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlBackUp.Location = new System.Drawing.Point(0, 0);
            this.groupControlBackUp.Name = "groupControlBackUp";
            this.groupControlBackUp.Size = new System.Drawing.Size(681, 235);
            this.groupControlBackUp.TabIndex = 6;
            this.groupControlBackUp.Text = "Thao tác chức năng";
            // 
            // checkEditGhiDe
            // 
            this.checkEditGhiDe.Location = new System.Drawing.Point(169, 194);
            this.checkEditGhiDe.Name = "checkEditGhiDe";
            this.checkEditGhiDe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditGhiDe.Properties.Appearance.Options.UseFont = true;
            this.checkEditGhiDe.Properties.Caption = "Ghi đè tập tin cũ";
            this.checkEditGhiDe.Size = new System.Drawing.Size(159, 20);
            this.checkEditGhiDe.TabIndex = 8;
            // 
            // txtTenTapTin
            // 
            this.txtTenTapTin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTapTin.Location = new System.Drawing.Point(281, 72);
            this.txtTenTapTin.Name = "txtTenTapTin";
            this.txtTenTapTin.Size = new System.Drawing.Size(388, 23);
            this.txtTenTapTin.TabIndex = 5;
            // 
            // progressBarCoolDown
            // 
            this.progressBarCoolDown.Location = new System.Drawing.Point(281, 36);
            this.progressBarCoolDown.Name = "progressBarCoolDown";
            this.progressBarCoolDown.Size = new System.Drawing.Size(388, 23);
            this.progressBarCoolDown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiến trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên tập tin";
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.AppearanceDisabled.BackColor = System.Drawing.Color.LightGray;
            this.btnDong.AppearanceDisabled.Options.UseBackColor = true;
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnDong.Location = new System.Drawing.Point(546, 185);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(123, 38);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.Appearance.Options.UseFont = true;
            this.btnThucHien.AppearanceDisabled.BackColor = System.Drawing.Color.LightGray;
            this.btnThucHien.AppearanceDisabled.Options.UseBackColor = true;
            this.btnThucHien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThucHien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.ImageOptions.Image")));
            this.btnThucHien.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnThucHien.Location = new System.Drawing.Point(396, 185);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(123, 38);
            this.btnThucHien.TabIndex = 6;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroGiup.Appearance.Options.UseFont = true;
            this.btnTroGiup.AppearanceDisabled.BackColor = System.Drawing.Color.LightGray;
            this.btnTroGiup.AppearanceDisabled.Options.UseBackColor = true;
            this.btnTroGiup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTroGiup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTroGiup.ImageOptions.Image")));
            this.btnTroGiup.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnTroGiup.Location = new System.Drawing.Point(16, 185);
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(123, 38);
            this.btnTroGiup.TabIndex = 6;
            this.btnTroGiup.Text = "Trợ giúp";
            // 
            // FormBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 235);
            this.ControlBox = false;
            this.Controls.Add(this.groupControlBackUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackUp";
            this.Text = "Sao lưu dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.btnPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBackUp)).EndInit();
            this.groupControlBackUp.ResumeLayout(false);
            this.groupControlBackUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditGhiDe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControlBackUp;
        public DevExpress.XtraEditors.ButtonEdit btnPath;
        public System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnTroGiup;
        private System.Windows.Forms.TextBox txtTenTapTin;
        private System.Windows.Forms.ProgressBar progressBarCoolDown;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.CheckEdit checkEditGhiDe;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        private DevExpress.XtraEditors.SimpleButton btnDong;
    }
}