using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                int rowsAffected = SessionSelection.ReserveTicket(connection, id);
                if (rowsAffected == 1)
                {
                    int orderCode = SessionSelection.GenerateOrderCode();
                    Reservation reservation = new Reservation(orderCode);
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
                    Console.WriteLine($"Квиток успішно зарезервований!Код для оплати квитка на касi - {orderCode}. Будь-ласка, оплатіть його на касі кінотеатрі.");
                }
                else
                {
                    Console.WriteLine("Квиток не зарезервований. Можливо він вже зарезервований або ви ввели неправильне число.");
                }
            }
        }
    }
}