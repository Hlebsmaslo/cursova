using System;
using System.Text;


namespace cinema 
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            TicketReservationApp app = new TicketReservationApp();
            app.Run();
        } 
    }
}
