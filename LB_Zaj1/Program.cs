using System;
using System.Data.SqlClient;

namespace Zaj1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Connection to database
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using var connection = new SqlConnection(connectionString);
            var db = new DB();
            connection.Open();

            db.Select(connection);
            db.Insert(connection, 15, "Bielsko");
            db.Delete(connection, 15);

            connection.Close();
        
        
        
        }
    }
}
