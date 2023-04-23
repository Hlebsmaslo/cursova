using System;
using System.Configuration;
using System.Data.SqlClient;
namespace cinema
{
    public class TicketBooking
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["base"].ConnectionString;

        public static void SelectionSeat()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Введіть ID квитка який ви хочете зарезервувати:");
                int id = int.Parse(Console.ReadLine());
                int rowsAffected = ReserveTicket(connection, id);
                if (rowsAffected == 1)
                {
                    int orderCode = GenerateOrderCode();
                    SqlCommand command2 = new SqlCommand($"UPDATE Codes SET code = {orderCode} WHERE ID = @Id AND code = 0", connection);
                    command2.Parameters.AddWithValue("@code", orderCode);
                    command2.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}", reader.GetString(0));
                        }

                    }
                    Console.WriteLine($"Квиток успішно зарезервований!Код для оплати квитка на касi - {orderCode}. Будь-ласка, оплатіть його на касі в кінотеатрі.");
                }
                else
                {
                    Console.WriteLine("Квиток не зарезервований. Можливо він вже зарезервований або ви ввели неправильне число.");
                }
            }
        }
        public static int ReserveTicket(SqlConnection connection, int id)
        {
            SqlCommand command = new SqlCommand("UPDATE TicketReservations SET IsReserved = 1 WHERE Id = @Id AND IsReserved = 0", connection);
            command.Parameters.AddWithValue("@Id", id);
            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected;
        }
        public static int GenerateOrderCode()
        {
            Random random = new Random();
            int orderCode;
            orderCode = random.Next(10000000, 99999999);
            return orderCode;

        }
    }
}