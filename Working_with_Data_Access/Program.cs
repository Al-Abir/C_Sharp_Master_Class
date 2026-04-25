using System;
using Npgsql;

class Program
{
    static void Main()
    {
        string connString = "Host=localhost;Username=postgres;Password=abir1981;Database=TestDB";

        using var conn = new NpgsqlConnection(connString);
        conn.Open();

        // INSERT
        var insert = new NpgsqlCommand(
            "INSERT INTO users (name, age) VALUES ('Abir', 25)", conn);
        insert.ExecuteNonQuery();


     var update = new NpgsqlCommand(
     "UPDATE users SET age = 30 WHERE name = 'Abir'", conn);
    update.ExecuteNonQuery();
        // READ
        var cmd = new NpgsqlCommand("SELECT * FROM users", conn);
        var reader = cmd.ExecuteReader();


       
        while (reader.Read())
        {
            Console.WriteLine($"{reader["id"]} - {reader["name"]} - {reader["age"]}");
        }
    }
}