using System.Data.SqlClient;

namespace DAL
{
    public class DbConnect
    {
        public static string cn = @"Data Source=.\SQLEXPRESS;Initial Catalog=DBQuanLyKyTucXa;Integrated Security=True";
        public DbConnect()
        {
            IsServerConnected(cn);
        }
        protected SqlConnection connection;

        private void IsServerConnected(string connectionString)
        {
            using (SqlConnection c = new SqlConnection(connectionString))
            {
                try
                {
                    c.Open();
                    connection = new SqlConnection(cn);
                    return;
                }
                catch (SqlException)
                {
                    cn = @"Data Source=.;Initial Catalog=DBQuanLyKyTucXa;Integrated Security=True";
                    connection = new SqlConnection(cn);
                    return;
                }
            }
        }
    }
}
