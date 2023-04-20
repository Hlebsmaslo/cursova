using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cinema.TicketReservationApp;

namespace cinema
{
    internal class TicketReservationApp
    {
        List<Reservation> reservations = new List<Reservation>();
        private static string connectionString = ConfigurationManager.ConnectionStrings["base"].ConnectionString;

        public void Run()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                while (true)
                {
                    Console.WriteLine("Введіть 1 щоб переглянути доступні наразі сеанси, 2 щоб зарезервувати квиток, або 3 щоб вийти:");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("Доступні наразі сеанси:");
                        SqlCommand command = new SqlCommand("SELECT DISTINCT Movie, ShowDate, Price FROM TicketReservations ", connection);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} - {1} - {2} грн.", reader.GetString(0), reader.GetString(1), reader.GetDecimal(2));
                            }
                        }
                    }
                    else if (choice == "2")
                    {
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

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("Доступні квитки для резервації на обраний сеанс:");
                            while (reader.Read())
                            {
                                Console.WriteLine("ID:{0} місця {1}.", reader.GetInt32(0), reader.GetString(1));
                            }

                        }
                        Console.WriteLine("Введіть ID квитка який ви хочете зарезервувати:");
                        int id = int.Parse(Console.ReadLine());
                        int rowsAffected = ReserveTicket(connection, id);
                        if (rowsAffected == 1)
                        {
                            int orderCode = GenerateOrderCode(reservations);
                            Reservation reservation = new Reservation(orderCode);
                            reservations.Add(reservation);
                            Console.WriteLine($"Квиток успішно зарезервований!Код для оплати квитка на касi - {orderCode}");
                        }
                        else
                        {
                            Console.WriteLine("Квиток не зарезервований. Можливо він вже зарезервований або ви ввели неправильне число.");
                        }
                    }
                   
                    else if (choice == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Будь-ласка, оберіть одну з цих цифр - 1, 2, or 3.");
                    }
                }
            }
        }
        private static int ReserveTicket(SqlConnection connection, int id)
        {
            SqlCommand command = new SqlCommand("UPDATE TicketReservations SET IsReserved = 1 WHERE Id = @Id AND IsReserved = 0", connection);
            command.Parameters.AddWithValue("@Id", id);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected;
        }
        private static int GenerateOrderCode(List<Reservation> reservations)
        {
            Random random = new Random();
            int orderCode;
            do
            {
                orderCode = random.Next(10000000, 99999999);

            } while (reservations.Exists(r => r.OrderCode == orderCode));
            return orderCode;

        }
    }
}
