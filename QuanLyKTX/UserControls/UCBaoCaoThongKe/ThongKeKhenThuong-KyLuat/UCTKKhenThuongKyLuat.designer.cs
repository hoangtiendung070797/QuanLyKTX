namespace QuanLyKTX.UserControls.UCBaoCaoThongKe.ThongKeKhenThuong
{
    partial class UCTKKhenThuongKyLuat
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
            this.radioButtonKyLuat = new System.Windows.Forms.RadioButton();
            this.radioButtonKhenThuong = new System.Windows.Forms.RadioButton();
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
            this.panel1.Size = new System.Drawing.Size(775, 399);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 114);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(775, 285);
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
            this.panel3.Controls.Add(this.radioButtonKyLuat);
            this.panel3.Controls.Add(this.radioButtonKhenThuong);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 56);
            this.panel3.TabIndex = 1;
            // 
            // radioButtonKyLuat
            // 
            this.radioButtonKyLuat.AutoSize = true;
            this.radioButtonKyLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKyLuat.Location = new System.Drawing.Point(152, 20);
            this.radioButtonKyLuat.Name = "radioButtonKyLuat";
            this.radioButtonKyLuat.Size = new System.Drawing.Size(76, 21);
            this.radioButtonKyLuat.TabIndex = 1;
            this.radioButtonKyLuat.TabStop = true;
            this.radioButtonKyLuat.Text = "Kỷ luật";
            this.radioButtonKyLuat.UseVisualStyleBackColor = true;
            // 
            // radioButtonKhenThuong
            // 
            this.radioButtonKhenThuong.AutoSize = true;
            this.radioButtonKhenThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKhenThuong.Location = new System.Drawing.Point(28, 20);
            this.radioButtonKhenThuong.Name = "radioButtonKhenThuong";
            this.radioButtonKhenThuong.Size = new System.Drawing.Size(118, 21);
            this.radioButtonKhenThuong.TabIndex = 1;
            this.radioButtonKhenThuong.TabStop = true;
            this.radioButtonKhenThuong.Text = "Khen thưởng";
            this.radioButtonKhenThuong.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.simpleButtonLoc);
            this.panel4.Controls.Add(this.simpleButtonHuyLoc);
            this.panel4.Controls.Add(this.simpleButtonIn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(549, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 56);
            this.panel4.TabIndex = 0;
            // 
            // simpleButtonLoc
            // 
            this.simpleButtonLoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonLoc.Location = new System.Drawing.Point(1, 0);
            this.simpleButtonLoc.Name = "simpleButtonLoc";
            this.simpleButtonLoc.Size = new System.Drawing.Size(75, 56);
            this.simpleButtonLoc.TabIndex = 2;
            this.simpleButtonLoc.Text = "Lọc";
            this.simpleButtonLoc.Click += new System.EventHandler(this.simpleButtonLoc_Click);
            // 
            // simpleButtonHuyLoc
            // 
            this.simpleButtonHuyLoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonHuyLoc.Location = new System.Drawing.Point(76, 0);
            this.simpleButtonHuyLoc.Name = "simpleButtonHuyLoc";
            this.simpleButtonHuyLoc.Size = new System.Drawing.Size(75, 56);
            this.simpleButtonHuyLoc.TabIndex = 1;
            this.simpleButtonHuyLoc.Text = "Hủy Lọc";
            this.simpleButtonHuyLoc.Click += new System.EventHandler(this.simpleButtonHuyLoc_Click);
            // 
            // simpleButtonIn
            // 
            this.simpleButtonIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonIn.Location = new System.Drawing.Point(151, 0);
            this.simpleButtonIn.Name = "simpleButtonIn";
            this.simpleButtonIn.Size = new System.Drawing.Size(75, 56);
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
            this.panel2.Size = new System.Drawing.Size(775, 58);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê sinh viên theo khen thưởng - kỷ luật";
            // 
            // UCTKKhenThuongKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCTKKhenThuongKyLuat";
            this.Size = new System.Drawing.Size(775, 399);
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
        private System.Windows.Forms.RadioButton radioButtonKyLuat;
        private System.Windows.Forms.RadioButton radioButtonKhenThuong;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLoc;
        private DevExpress.XtraEditors.SimpleButton simpleButtonHuyLoc;
        private DevExpress.XtraEditors.SimpleButton simpleButtonIn;
        private System.Windows.Forms.Label label1;
    }
}
