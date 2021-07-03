using System.Data.SqlClient;


namespace Warehouse
{
    public class ConnectionClass
    {
        SqlConnection con;
        public SqlConnection Connection { get { return con; } }

        public void OpenCon()
        {
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True";
            con = new SqlConnection(conString);
            con.Open();
        }

        public void CloseCon()
        {
            con.Close();
        }
    }
}
