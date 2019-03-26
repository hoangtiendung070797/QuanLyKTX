using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace QuanLyKTX.Forms
{
    public partial class FormRestore : Form
    {
        public FormRestore()
        {
            InitializeComponent();
        }

        string path = @"c:\SQLBackup";  //thư mục
        string file = "";

        private void btnPath_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "bak files (*.bak)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btnPath.Text = openFileDialog.FileName;
                path = openFileDialog.FileName;
            }
            string[] words = path.Split('\\');
            txtTenTapTin.Text = words[words.Length - 1];
            
        }

        private void btnThucHien_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (File.Exists(path))
                {
                    if (MessageBox.Show("Bạn có chắc muốn khôi phục?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(Const.ConnectionString))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(@"restore database DBQuanLyKyTucXa from disk = '" + path + "'", connection);
                            connection.Close();
                        }
                        MessageBox.Show("Has been restored database", "Restoration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show(@"Do not make any endorsement above (or is not in the correct path)", "Restoration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
