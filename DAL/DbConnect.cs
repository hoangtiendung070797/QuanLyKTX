using System.Data.SqlClient;

namespace DAL
{
    public class DbConnect
    {
        protected SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-APH6IS0;Initial Catalog=DBQuanLyKyTucXa;Integrated Security=True");
    }
}
