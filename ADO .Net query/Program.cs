using System.Data.SqlClient;

Console.WriteLine("Enter a user ID: ");
string? userId = Console.ReadLine();

string connectionString = "your_connection_string_here";
using (SqlConnection connection = new(connectionString))
{
    connection.Open();

    string query = "SELECT * FROM Users WHERE UserId = '" + userId + "'";
    SqlCommand command = new(query, connection);

    using SqlDataReader reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"User ID: {reader["UserId"]}, Username: {reader["Username"]}");
    }
}