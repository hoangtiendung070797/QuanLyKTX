using BUS;
using DAL;
using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class UCQuocTich : UserControl
    {
        public UCQuocTich()
        {
            InitializeComponent();
        }
        BUS_QuocTich bUS_QuocTich = new BUS_QuocTich();
        private void UCQuocTich_Load(object sender, EventArgs e)
        {
            //QuocTich quocTich = new QuocTich(int.Parse(txtMaQuocTich.Text),txtTenQuocTich.Text);
            //using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DBQuanLyKyTucXa;Integrated Security=True"))
            //{
            //    connection.Open();
            //    string query = "SELECT * FROM QuocTich";
            //    SqlCommand command = new SqlCommand(query, connection);

            //    command.ExecuteNonQuery();
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //    DataTable table = new DataTable();
            //    dataAdapter.Fill(table);
            //    gridControlQuocTich.DataSource = table;
            //}



            gridControlQuocTich.DataSource = bUS_QuocTich.GetData();


        }
    }
}
