using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.AspNet.SignalR.Infrastructure;


namespace Zaj1
{
    public class DB
    {
        public void Select(SqlConnection connection)
        {
    
            //open connection to execute code inside
            connection.Open();

            var query = "SELECT * FROM dbo.Customers";
            var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["CompanyName"]);

            }
        }

        public void Insert(SqlConnection connection, int id, string description)
        {
            var query = "INSERT INTO region(regionID, regionDescription)" + "VALUES(@id, @description)";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("description", description);
            command.BeginExecuteNonQuery();
            var affected = command.ExecuteNonQuery();
            Console.WriteLine($"{affected} rows affected");


        }
        public void Delete(SqlConnection connection, int id, string description)
             
        {
            var query = "DELETE FROM @table WHERE id=@id";
            var command = new SqlCommand(query, connection);
            command.Parameters.Add(table);
            command.Parameters.Add(id);
            var aff = command.ExecuteNonQuery();
            Console.WriteLine($"removed {aff} row");
            connection.Close();
        }
        //connection close to close query/code
        

        }



}
}
