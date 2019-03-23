namespace QuanLyKTX
{
    partial class Backup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThuMuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuongDan = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuongDan1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThuMucAuto = new System.Windows.Forms.TextBox();
            this.ckAuto = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeSaoLuu = new DevExpress.XtraEditors.TimeEdit();
            this.ckThu2 = new System.Windows.Forms.CheckBox();
            this.ckThu3 = new System.Windows.Forms.CheckBox();
            this.ckThu4 = new System.Windows.Forms.CheckBox();
            this.ckThu5 = new System.Windows.Forms.CheckBox();
            this.ckThu6 = new System.Windows.Forms.CheckBox();
            this.ckThu7 = new System.Windows.Forms.CheckBox();
            this.ckChuNhat = new System.Windows.Forms.CheckBox();
            this.folderBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSaoLuu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDuongDan);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtThuMuc);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao lưu dữ liệu";
            // 
            // txtThuMuc
            // 
            this.txtThuMuc.Location = new System.Drawing.Point(91, 41);
            this.txtThuMuc.Name = "txtThuMuc";
            this.txtThuMuc.Size = new System.Drawing.Size(401, 21);
            this.txtThuMuc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lưu vào :";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(91, 69);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(95, 23);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Sao lưu";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnDuongDan
            // 
            this.btnDuongDan.Location = new System.Drawing.Point(498, 41);
            this.btnDuongDan.Name = "btnDuongDan";
            this.btnDuongDan.Size = new System.Drawing.Size(46, 21);
            this.btnDuongDan.TabIndex = 3;
            this.btnDuongDan.Text = "...";
            this.btnDuongDan.Click += new System.EventHandler(this.btnDuongDan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.ckAuto);
            this.groupBox2.Controls.Add(this.btnDuongDan1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtThuMucAuto);
            this.groupBox2.Location = new System.Drawing.Point(33, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 217);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tự động sao lưu";
            // 
            // btnDuongDan1
            // 
            this.btnDuongDan1.Location = new System.Drawing.Point(498, 57);
            this.btnDuongDan1.Name = "btnDuongDan1";
            this.btnDuongDan1.Size = new System.Drawing.Size(46, 21);
            this.btnDuongDan1.TabIndex = 3;
            this.btnDuongDan1.Text = "...";
            this.btnDuongDan1.Click += new System.EventHandler(this.btnDuongDan1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thư mục :";
            // 
            // txtThuMucAuto
            // 
            this.txtThuMucAuto.Location = new System.Drawing.Point(91, 57);
            this.txtThuMucAuto.Name = "txtThuMucAuto";
            this.txtThuMucAuto.Size = new System.Drawing.Size(401, 21);
            this.txtThuMucAuto.TabIndex = 0;
            // 
            // ckAuto
            // 
            this.ckAuto.AutoSize = true;
            this.ckAuto.Location = new System.Drawing.Point(91, 34);
            this.ckAuto.Name = "ckAuto";
            this.ckAuto.Size = new System.Drawing.Size(104, 17);
            this.ckAuto.TabIndex = 4;
            this.ckAuto.Text = "Tự động sao lưu";
            this.ckAuto.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckChuNhat);
            this.groupBox3.Controls.Add(this.ckThu7);
            this.groupBox3.Controls.Add(this.ckThu6);
            this.groupBox3.Controls.Add(this.ckThu5);
            this.groupBox3.Controls.Add(this.ckThu4);
            this.groupBox3.Controls.Add(this.ckThu3);
            this.groupBox3.Controls.Add(this.ckThu2);
            this.groupBox3.Controls.Add(this.timeSaoLuu);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(18, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thời gian sao lưu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sao lưu vào lúc :";
            // 
            // timeSaoLuu
            // 
            this.timeSaoLuu.EditValue = new System.DateTime(2019, 3, 23, 0, 0, 0, 0);
            this.timeSaoLuu.Location = new System.Drawing.Point(115, 25);
            this.timeSaoLuu.Name = "timeSaoLuu";
            this.timeSaoLuu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeSaoLuu.Size = new System.Drawing.Size(100, 20);
            this.timeSaoLuu.TabIndex = 2;
            // 
            // ckThu2
            // 
            this.ckThu2.AutoSize = true;
            this.ckThu2.Location = new System.Drawing.Point(25, 61);
            this.ckThu2.Name = "ckThu2";
            this.ckThu2.Size = new System.Drawing.Size(54, 17);
            this.ckThu2.TabIndex = 3;
            this.ckThu2.Text = "Thứ 2";
            this.ckThu2.UseVisualStyleBackColor = true;
            // 
            // ckThu3
            // 
            this.ckThu3.AutoSize = true;
            this.ckThu3.Location = new System.Drawing.Point(98, 61);
            this.ckThu3.Name = "ckThu3";
            this.ckThu3.Size = new System.Drawing.Size(54, 17);
            this.ckThu3.TabIndex = 4;
            this.ckThu3.Text = "Thứ 3";
            this.ckThu3.UseVisualStyleBackColor = true;
            // 
            // ckThu4
            // 
            this.ckThu4.AutoSize = true;
            this.ckThu4.Location = new System.Drawing.Point(161, 61);
            this.ckThu4.Name = "ckThu4";
            this.ckThu4.Size = new System.Drawing.Size(54, 17);
            this.ckThu4.TabIndex = 5;
            this.ckThu4.Text = "Thứ 4";
            this.ckThu4.UseVisualStyleBackColor = true;
            // 
            // ckThu5
            // 
            this.ckThu5.AutoSize = true;
            this.ckThu5.Location = new System.Drawing.Point(236, 61);
            this.ckThu5.Name = "ckThu5";
            this.ckThu5.Size = new System.Drawing.Size(54, 17);
            this.ckThu5.TabIndex = 6;
            this.ckThu5.Text = "Thứ 5";
            this.ckThu5.UseVisualStyleBackColor = true;
            // 
            // ckThu6
            // 
            this.ckThu6.AutoSize = true;
            this.ckThu6.Location = new System.Drawing.Point(310, 61);
            this.ckThu6.Name = "ckThu6";
            this.ckThu6.Size = new System.Drawing.Size(54, 17);
            this.ckThu6.TabIndex = 7;
            this.ckThu6.Text = "Thứ 6";
            this.ckThu6.UseVisualStyleBackColor = true;
            // 
            // ckThu7
            // 
            this.ckThu7.AutoSize = true;
            this.ckThu7.Location = new System.Drawing.Point(379, 61);
            this.ckThu7.Name = "ckThu7";
            this.ckThu7.Size = new System.Drawing.Size(54, 17);
            this.ckThu7.TabIndex = 8;
            this.ckThu7.Text = "Thứ 7";
            this.ckThu7.UseVisualStyleBackColor = true;
            // 
            // ckChuNhat
            // 
            this.ckChuNhat.AutoSize = true;
            this.ckChuNhat.Location = new System.Drawing.Point(451, 61);
            this.ckChuNhat.Name = "ckChuNhat";
            this.ckChuNhat.Size = new System.Drawing.Size(70, 17);
            this.ckChuNhat.TabIndex = 9;
            this.ckChuNhat.Text = "Chủ nhật";
            this.ckChuNhat.UseVisualStyleBackColor = true;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu dữ liệu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSaoLuu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThuMuc;
        private DevExpress.XtraEditors.SimpleButton btnDuongDan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckAuto;
        private DevExpress.XtraEditors.SimpleButton btnDuongDan1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThuMucAuto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckChuNhat;
        private System.Windows.Forms.CheckBox ckThu7;
        private System.Windows.Forms.CheckBox ckThu6;
        private System.Windows.Forms.CheckBox ckThu5;
        private System.Windows.Forms.CheckBox ckThu4;
        private System.Windows.Forms.CheckBox ckThu3;
        private System.Windows.Forms.CheckBox ckThu2;
        private DevExpress.XtraEditors.TimeEdit timeSaoLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBackup;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}