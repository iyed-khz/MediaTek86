using MySql.Data.MySqlClient;
using System.Configuration;

public class Bdd
{
    private MySqlConnection connection;

    public Bdd()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MediaTek86DB"].ConnectionString;
        connection = new MySqlConnection(connectionString);
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }

    public void Open()
    {
        if (connection.State != System.Data.ConnectionState.Open)
            connection.Open();
    }

    public void Close()
    {
        if (connection.State != System.Data.ConnectionState.Closed)
            connection.Close();
    }
}

