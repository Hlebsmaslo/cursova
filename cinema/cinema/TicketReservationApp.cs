using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
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
                    Console.WriteLine("1Введіть 1 щоб переглянути доступні сеанси, 2 щоб зарезервувати квиток або 3 щоб завершити роботу додатку:");
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
