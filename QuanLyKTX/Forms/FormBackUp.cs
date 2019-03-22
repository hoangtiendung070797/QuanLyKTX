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
        string path = @"c:\SQLBackup\KiTucXaDHHHDatabase.bak";
        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog  folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                btnPath.Text = folderBrowserDialog.SelectedPath;
                path = folderBrowserDialog.SelectedPath;
            }
                
        }

        private void btnSaoLuu_Click(object sender, System.EventArgs e)
        {
            bool bBackUpStatus = true;

            Cursor.Current = Cursors.WaitCursor;

            if (Directory.Exists(@"c:\SQLBackup"))
            {
                if (File.Exists(@"c:\SQLBackup\KiTucXaDHHHDatabase.bak"))
                {
                    if (MessageBox.Show(@"Do you want to replace it?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(@"c:\SQLBackup\KiTucXaDHHHDatabase.bak");
                    }
                    else
                        bBackUpStatus = false;
                }
            }
            else
                Directory.CreateDirectory(@"c:\SQLBackup");

            if (bBackUpStatus)
            {
                //Connect to DB
                using (SqlConnection connection = new SqlConnection())
                {
                  
                    string query = "Data Source = localhost; Initial Catalog=dbWiseCodes ;Integrated Security = True;";
                    
                    connection.Open();
                    //----------------------------------------------------------------------------------------------------

                    //Execute SQL---------------
                    SqlCommand command;
                    command = new SqlCommand(@"backup database dbWiseCodes to disk ='c:\SQLBackup\KiTucXaDHHHDatabase.bak' with init,stats=10", connection);
                    command.ExecuteNonQuery();
                    //-------------------------------------------------------------------------------------------------------------------------------

                    connection.Close();

                    MessageBox.Show("The support of the database was successfully performed", "Back", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
}
