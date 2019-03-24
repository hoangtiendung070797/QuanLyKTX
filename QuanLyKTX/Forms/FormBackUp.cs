using DAL;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace QuanLyKTX.Forms
{
    public partial class FormBackUp : Form
    {
        public FormBackUp()
        {
            InitializeComponent();
        }

        string path = @"c:\SQLBackup";  //thư mục
        string file = "DbKiTucXaDHHH.bak";

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog  folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                btnPath.Text = folderBrowserDialog.SelectedPath;
                path = folderBrowserDialog.SelectedPath;
            }
            MessageBox.Show(path);
        }

        private void btnThucHien_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnPath.Text))
            {
                if (MessageBox.Show("Thực hiện sao lưu", "Bạn có đồng ý sao lưu ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool bBackUpStatus = true;

                    Cursor.Current = Cursors.WaitCursor;

                    if (Directory.Exists(path))
                    {
                        if (File.Exists(path + "\\" + file))
                        {
                            if (MessageBox.Show(@"Bạn có muốn thay thế file đã tồn tại?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                File.Delete(path + "\\" + file);
                            }
                            else
                                bBackUpStatus = false;
                        }
                    }

                    if (bBackUpStatus)
                    {
                        //Connect to DB
                        using (SqlConnection connection = new SqlConnection())
                        {
                            connection.Open();
                            //----------------------------------------------------------------------------------------------------
                            MessageBox.Show("Connected!");
                            //Execute SQL---------------
                            SqlCommand command;
                            command = new SqlCommand(@"backup database DBQuanLyKyTucXa to disk ='" + path + "\\" + file + "' with init,stats=10", connection);
                            command.ExecuteNonQuery();
                            //-------------------------------------------------------------------------------------------------------------------------------

                            connection.Close();

                            MessageBox.Show("Dữ liệu đã được sao lưu thành công!", "Back", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
        }

        private void btnDong_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
