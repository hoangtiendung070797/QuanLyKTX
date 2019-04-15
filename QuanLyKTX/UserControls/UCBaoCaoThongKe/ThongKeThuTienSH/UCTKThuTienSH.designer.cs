namespace QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeThuTienSH
{
    partial class UCTKThuTienSH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbDayNha = new System.Windows.Forms.ComboBox();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.simpleButtonLoc = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonHuyloc = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonIn = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 359);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 106);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(574, 253);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbDayNha);
            this.panel3.Controls.Add(this.cmbPhong);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 51);
            this.panel3.TabIndex = 1;
            // 
            // cmbDayNha
            // 
            this.cmbDayNha.FormattingEnabled = true;
            this.cmbDayNha.Location = new System.Drawing.Point(237, 18);
            this.cmbDayNha.Name = "cmbDayNha";
            this.cmbDayNha.Size = new System.Drawing.Size(92, 21);
            this.cmbDayNha.TabIndex = 2;
            // 
            // cmbPhong
            // 
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Location = new System.Drawing.Point(65, 18);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(92, 21);
            this.cmbPhong.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dãy nhà";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.simpleButtonLoc);
            this.panel4.Controls.Add(this.simpleButtonHuyloc);
            this.panel4.Controls.Add(this.simpleButtonIn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(350, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 51);
            this.panel4.TabIndex = 0;
            // 
            // simpleButtonLoc
            // 
            this.simpleButtonLoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonLoc.Location = new System.Drawing.Point(0, 0);
            this.simpleButtonLoc.Name = "simpleButtonLoc";
            this.simpleButtonLoc.Size = new System.Drawing.Size(74, 51);
            this.simpleButtonLoc.TabIndex = 2;
            this.simpleButtonLoc.Text = "Lọc";
            this.simpleButtonLoc.Click += new System.EventHandler(this.SimpleButtonLoc_Click);
            // 
            // simpleButtonHuyloc
            // 
            this.simpleButtonHuyloc.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonHuyloc.Location = new System.Drawing.Point(74, 0);
            this.simpleButtonHuyloc.Name = "simpleButtonHuyloc";
            this.simpleButtonHuyloc.Size = new System.Drawing.Size(75, 51);
            this.simpleButtonHuyloc.TabIndex = 1;
            this.simpleButtonHuyloc.Text = "Hủy Lọc";
            this.simpleButtonHuyloc.Click += new System.EventHandler(this.SimpleButtonHuyLoc_Click);
            // 
            // simpleButtonIn
            // 
            this.simpleButtonIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonIn.Location = new System.Drawing.Point(149, 0);
            this.simpleButtonIn.Name = "simpleButtonIn";
            this.simpleButtonIn.Size = new System.Drawing.Size(75, 51);
            this.simpleButtonIn.TabIndex = 0;
            this.simpleButtonIn.Text = "In báo cáo";
            this.simpleButtonIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 55);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê phòng theo thu tiền sinh hoạt";
            // 
            // UCTKThuTienSH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCTKThuTienSH";
            this.Size = new System.Drawing.Size(574, 359);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonIn;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLoc;
        private DevExpress.XtraEditors.SimpleButton simpleButtonHuyloc;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDayNha;
        private System.Windows.Forms.Label label3;
    }
}
