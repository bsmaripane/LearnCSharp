using Microsoft.Data.SqlClient;

namespace WorksWithDatabaseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Updated connection string with TrustServerCertificate=True
            string connectionString = "Server=MARIPANEBS\\SQLEXPRESS;Database=shop;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 1. Reading data
                // Ensure "Name" is the correct column name in your "students" table
                using (SqlCommand command = new SqlCommand("SELECT * FROM students", connection))
                { 
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["first_name"]);
                        }
                    }
                } // 'using' block

                // 2. Insert data 
                string insertQuery = "INSERT INTO students(first_name) VALUES ('Belicia')";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.ExecuteNonQuery();

                Console.WriteLine("Insert successful!");
            } // Connection closes automatically here due to 'using' block


            Console.ReadKey();
        }
    }
}
