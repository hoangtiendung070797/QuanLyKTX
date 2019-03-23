using System.Data.SqlClient;

namespace DAL
{
    public class DbConnect
    {
        protected SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DBQuanLyKyTucXa;Integrated Security=True");
    }
}
