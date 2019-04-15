namespace QuanLyKTX.UserControls.UCBaoCaoThongKe
{
    partial class UCTKVatTuTheoPhong
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.simpleButtonLoc = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonHuyLoc = new DevExpress.XtraEditors.SimpleButton();
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
            this.panel1.Size = new System.Drawing.Size(704, 379);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 116);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(704, 263);
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
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbPhong);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 60);
            this.panel3.TabIndex = 1;
            // 
            // cmbDayNha
            // 
            this.cmbDayNha.FormattingEnabled = true;
            this.cmbDayNha.Location = new System.Drawing.Point(313, 18);
            this.cmbDayNha.Name = "cmbDayNha";
            this.cmbDayNha.Size = new System.Drawing.Size(121, 21);
            this.cmbDayNha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dãy nhà :";
            // 
            // cmbPhong
            // 
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Location = new System.Drawing.Point(86, 18);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(121, 21);
            this.cmbPhong.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.simpleButtonLoc);
            this.panel4.Controls.Add(this.simpleButtonHuyLoc);
            this.panel4.Controls.Add(this.simpleButtonIn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(479, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 60);
            this.panel4.TabIndex = 0;
            // 
            // simpleButtonLoc
            // 
            this.simpleButtonLoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonLoc.Location = new System.Drawing.Point(0, 0);
            this.simpleButtonLoc.Name = "simpleButtonLoc";
            this.simpleButtonLoc.Size = new System.Drawing.Size(75, 60);
            this.simpleButtonLoc.TabIndex = 2;
            this.simpleButtonLoc.Text = "Lọc";
            this.simpleButtonLoc.Click += new System.EventHandler(this.SimpleButtonLoc_Click);
            // 
            // simpleButtonHuyLoc
            // 
            this.simpleButtonHuyLoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonHuyLoc.Location = new System.Drawing.Point(75, 0);
            this.simpleButtonHuyLoc.Name = "simpleButtonHuyLoc";
            this.simpleButtonHuyLoc.Size = new System.Drawing.Size(75, 60);
            this.simpleButtonHuyLoc.TabIndex = 1;
            this.simpleButtonHuyLoc.Text = "Hủy Lọc";
            this.simpleButtonHuyLoc.Click += new System.EventHandler(this.SimpleButtonHuyLoc_Click);
            // 
            // simpleButtonIn
            // 
            this.simpleButtonIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonIn.Location = new System.Drawing.Point(150, 0);
            this.simpleButtonIn.Name = "simpleButtonIn";
            this.simpleButtonIn.Size = new System.Drawing.Size(75, 60);
            this.simpleButtonIn.TabIndex = 0;
            this.simpleButtonIn.Text = "In Báo Cáo";
            this.simpleButtonIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 56);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê vật tư theo phòng";
            // 
            // UCTKVatTuTheoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCTKVatTuTheoPhong";
            this.Size = new System.Drawing.Size(704, 379);
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbDayNha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLoc;
        private DevExpress.XtraEditors.SimpleButton simpleButtonHuyLoc;
        private DevExpress.XtraEditors.SimpleButton simpleButtonIn;
        private System.Windows.Forms.Label label1;
    }
}
