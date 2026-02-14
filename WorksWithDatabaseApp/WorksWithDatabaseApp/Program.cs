using Microsoft.Data.SqlClient;

namespace WorksWithDatabaseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Database connection 
            string connectionString = "";

            // Open database communication
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM students", connection);

            // Reading data
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["Name"]);
            }

            // Insert data into database
            SqlCommand insertCommand = new SqlCommand("INSERT INTO students(first_name) VALUES ('Belicia')", connection);
            insertCommand.ExecuteNonQuery();

            // Closing database connection
            connection.Close();

            Console.ReadKey();
        }
    }
}
