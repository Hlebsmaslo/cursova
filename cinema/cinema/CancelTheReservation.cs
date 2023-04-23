using System;
using System.Configuration;
using System.Data.SqlClient;

namespace cinema
{
    internal class CancelTheReservation
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["base"].ConnectionString;

        public static void cancelTheTrservation()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Введіть код резервації який вам був наданий:");
                int cancelCode = int.Parse(Console.ReadLine());
                SqlCommand command = new SqlCommand($"UPDATE TicketReservations SET IsReserved = 0 WHERE ID IN (SELECT ID FROM Codes WHERE code = {cancelCode})", connection);
                int rowsAffected = command.ExecuteNonQuery();
                SqlCommand command1 = new SqlCommand($"UPDATE Codes SET code = 0 WHERE code = {cancelCode}", connection);
                command1.ExecuteNonQuery();
                if (cancelCode == 0)
                {
                    Console.WriteLine("Резервацію квитка з таким кодом не знайдено.");
                }
                else if (rowsAffected > 0)
                {
                    Console.WriteLine("Резервація квитка з вашим кодом була відмінена.");
                }
                
                else
                {
                    Console.WriteLine("Резервацію квитка з таким кодом не знайдено.");
                }

            }
        }
    }
}
