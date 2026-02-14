using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace WorkingWithDatabase_Clean_Async_Using
{
    internal class Program
    {
        public static async Task GetCustomersAsync()
        {
            string connectionString = "Server=MARIPANEBS\\SQLEXPRESS;Database=shop;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM customers ORDER BY last_name ASC", connection))
                {
                    Console.WriteLine("Customer ID\tFirst Name\tLast Name\tEmail Address");
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                            Console.WriteLine($"{reader["customer_id"]}\t\t{reader["first_name"]}\t\t{reader["last_name"]}\t\t{reader["email"]}");
                    }
                }
            }
        }

        static async Task Main(string[] args)
        {
            await GetCustomersAsync();

            Console.ReadKey();
        }
    }
}
