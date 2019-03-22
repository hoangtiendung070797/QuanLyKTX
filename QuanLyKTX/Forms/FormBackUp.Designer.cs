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
            this.components = new System.ComponentModel.Container();
            this.btnSaoLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnPath = new DevExpress.XtraEditors.ButtonEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSaoLuu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoLuu.AppearanceHovered.Options.UseFont = true;
            this.btnSaoLuu.AutoWidthInLayoutControl = true;
            this.btnSaoLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSaoLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaoLuu.Location = new System.Drawing.Point(212, 255);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(173, 71);
            this.btnSaoLuu.TabIndex = 1;
            this.btnSaoLuu.Text = "Sao lưu";
            this.btnSaoLuu.ToolTip = "Bấm vào đây để thực hiện sao lưu dữ liệu";
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // btnPath
            // 
            this.btnPath.EditValue = "c:\\SQLBackup\\MinhHieuDatabase.bak";
            this.btnPath.Location = new System.Drawing.Point(169, 120);
            this.btnPath.Name = "btnPath";
            this.btnPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnPath.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_Properties_ButtonClick);
            this.btnPath.Size = new System.Drawing.Size(306, 20);
            this.btnPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đường dẫn thư mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sao lưu";
            // 
            // txtTenSaoLuu
            // 
            this.txtTenSaoLuu.Location = new System.Drawing.Point(169, 65);
            this.txtTenSaoLuu.Name = "txtTenSaoLuu";
            this.txtTenSaoLuu.Size = new System.Drawing.Size(306, 20);
            this.txtTenSaoLuu.TabIndex = 5;
            // 
            // FormBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.txtTenSaoLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaoLuu);
            this.Controls.Add(this.btnPath);
            this.Name = "FormBackUp";
            this.Text = "FormBackUp";
            ((System.ComponentModel.ISupportInitialize)(this.btnPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSaoLuu;
        private DevExpress.XtraEditors.ButtonEdit btnPath;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSaoLuu;
    }
}