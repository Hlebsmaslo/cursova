﻿using System;
using System.Configuration;
using System.Data.SqlClient;

namespace cinema
{
    public class AvailableSessions

    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["base"].ConnectionString;

        public static void ShowSeansses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
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
        }
        

    }
}