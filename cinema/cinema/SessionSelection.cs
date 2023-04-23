using System;
using System.Configuration;
using System.Data.SqlClient;


namespace cinema
{
    public class SessionSelection
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["base"].ConnectionString;

        public static void SelectionSession()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                Console.WriteLine("Введіть назву фільму:");
                string movieName = Console.ReadLine();
                Console.WriteLine("Введіть час:");
                string showDate = Console.ReadLine();
                SqlCommand command1 = new SqlCommand("SELECT TOP 1 Description, Movie FROM TicketReservations WHERE Movie = @movie AND ShowDate = @date", connection);
                command1.Parameters.AddWithValue("@movie", movieName);
                command1.Parameters.AddWithValue("@date", showDate);
                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}", reader.GetString(0));
                    }
                }
                SqlCommand command = new SqlCommand("SELECT ID, SeatNumber, IsReserved, Price FROM TicketReservations WHERE Movie = @movie AND ShowDate = @date AND IsReserved = 0", connection);
                command.Parameters.AddWithValue("@movie", movieName);
                command.Parameters.AddWithValue("@date", showDate);
                Console.WriteLine(" ");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Доступні квитки для резервації на обраний сеанс:");
                    while (reader.Read())
                    {
                        Console.WriteLine("ID:{0} місця {1}.", reader.GetInt32(0), reader.GetString(1));
                    }

                }
                
            }
        }
        
    }
}
