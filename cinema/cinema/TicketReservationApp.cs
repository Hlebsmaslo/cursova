using System;
using System.Configuration;
using System.Data.SqlClient;

namespace cinema
{
    internal class TicketReservationApp
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["base"].ConnectionString;

        public void Run()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                while (true)
                {
                    Console.WriteLine("Введіть 1 щоб переглянути доступні сеанси, 2 для зарезервувння квитка, 3 щоб вімінити резервування квитка або 4 щоб завершити роботу додатка:");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        AvailableSessions.ShowSeansses();
                    }
                    else if (choice == "2")
                    {
                        SessionSelection.SelectionSession();
                        TicketBooking.SelectionSeat();
                    }
                    else if (choice == "3")
                    {
                        CancelTheReservation.cancelTheTrservation();    
                    }
                    else if (choice == "4")
                    {
                        connection.Close();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Будь-ласка, оберіть одну з цих цифр - 1, 2, або 3.");
                    }
                }
            }
        }
        
       
        
    }
}
