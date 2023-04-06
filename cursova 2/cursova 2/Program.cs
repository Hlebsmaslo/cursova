using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;


namespace cursova_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            List<Reservation> reservations = new List<Reservation>();
            List<Session> sessions = new List<Session>();
            sessions.Add(new Session("Черепашки нiндзя: Погром мутантiв 21.08 12:10", new List<Seat> { new Seat(" A1"), new Seat(" A2"), new Seat(" A3"), new Seat(" A4"), new Seat(" A5"), new Seat(" B1"), new Seat(" B2"), new Seat(" B3"), new Seat(" B4"), new Seat("B5"), new Seat("C1"), new Seat("C2"), new Seat("C3"), new Seat("C4"), new Seat("C5") }));
            sessions.Add(new Session("Людина павук 21.08 14:50", new List<Seat> { new Seat(" A1"), new Seat(" A2"), new Seat(" A3"), new Seat(" A4"), new Seat(" A5"), new Seat(" B1"), new Seat(" B2"), new Seat(" B3"), new Seat(" B4"), new Seat("B5"), new Seat("C1"), new Seat("C2"), new Seat("C3"), new Seat("C4"), new Seat("C5") }));
            sessions.Add(new Session("Кiт у чоботях 2 21.08 18:00", new List<Seat> { new Seat(" A1"), new Seat(" A2"), new Seat(" A3"), new Seat(" A4"), new Seat(" A5"), new Seat(" B1"), new Seat(" B2"), new Seat(" B3"), new Seat(" B4"), new Seat("B5"), new Seat("C1"), new Seat("C2"), new Seat("C3"), new Seat("C4"), new Seat("C5") }));
            sessions.Add(new Session("Черепашки нiндзя: Погром мутантiв 22.08 12:20", new List<Seat> { new Seat(" A1"), new Seat(" A2"), new Seat(" A3"), new Seat(" A4"), new Seat(" A5"), new Seat(" B1"), new Seat(" B2"), new Seat(" B3"), new Seat(" B4"), new Seat("B5"), new Seat("C1"), new Seat("C2"), new Seat("C3"), new Seat("C4"), new Seat("C5") }));
            sessions.Add(new Session("Людина павук 22.08 14:50", new List<Seat> { new Seat(" A1"), new Seat(" A2"), new Seat(" A3"), new Seat(" A4"), new Seat(" A5"), new Seat(" B1"), new Seat(" B2"), new Seat(" B3"), new Seat(" B4"), new Seat("B5"), new Seat("C1"), new Seat("C2"), new Seat("C3"), new Seat("C4"), new Seat("C5") }));
            sessions.Add(new Session("Кiт у чоботях 2 22.08 18:00", new List<Seat> { new Seat(" A1"), new Seat(" A2"), new Seat(" A3"), new Seat(" A4"), new Seat(" A5"), new Seat(" B1"), new Seat(" B2"), new Seat(" B3"), new Seat(" B4"), new Seat("B5"), new Seat("C1"), new Seat("C2"), new Seat("C3"), new Seat("C4"), new Seat("C5") }));
            sessions.Add(new Session("Черепашки нiндзя: Погром мутантiв 23.08 12:10", new List<Seat> { new Seat(" A1"), new Seat(" A2"), new Seat(" A3"), new Seat(" A4"), new Seat(" A5"), new Seat(" B1"), new Seat(" B2"), new Seat(" B3"), new Seat(" B4"), new Seat("B5"), new Seat("C1"), new Seat("C2"), new Seat("C3"), new Seat("C4"), new Seat("C5") }));
            sessions.Add(new Session("Людина павук 23.08 14:50", new List<Seat> { new Seat(" A1"), new Seat(" A2"), new Seat(" A3"), new Seat(" A4"), new Seat(" A5"), new Seat(" B1"), new Seat(" B2"), new Seat(" B3"), new Seat(" B4"), new Seat("B5"), new Seat("C1"), new Seat("C2"), new Seat("C3"), new Seat("C4"), new Seat("C5") }));
            sessions.Add(new Session("Аватар 2 23.08 19:30", new List<Seat> { new Seat(" A1"), new Seat(" A2"), new Seat(" A3"), new Seat(" A4"), new Seat(" A5"), new Seat(" B1"), new Seat(" B2"), new Seat(" B3"), new Seat(" B4"), new Seat("B5"), new Seat("C1"), new Seat("C2"), new Seat("C3"), new Seat("C4"), new Seat("C5") }));
            List<double> prices = new List<double> { 150.00, 130.00, 160.00, 150.00, 130.00, 160.00, 150.00, 130.00, 160.00 };
            while (true)
            {
                Console.WriteLine("Введіть 1 для резервації квитків,2 для виходу із програми або 3 щоб прочитати інформацію про фільми.");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Введіть своє ім'я:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Введіть номер сеансу на який ви хочете забронювати квитки:");
                    for (int i = 0; i < sessions.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {sessions[i].Name} - {prices[i]} грн.");

                    }
                    int sessionNum = Convert.ToInt32(Console.ReadLine());
                    Session session = sessions[sessionNum - 1];
                    Console.WriteLine($"Доступні місця для {session.Name}:");
                    for (int i = 0; i < session.Seats.Count; i++)
                    {
                        if (session.Seats[i].IsAvailable)
                        {
                            Console.WriteLine($"{i + 1}. {session.Seats[i].Name}");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Введіть номер місця або 0 для повернення на початок");
                        int seatNum = Convert.ToInt32(Console.ReadLine());

                        if (seatNum == 0)
                        {
                            break;
                        }

                        Seat seat = session.Seats[seatNum - 1];

                        if (!seat.IsAvailable)
                        {
                            Console.WriteLine($"Місце{seat.Name} вже зарезервовано. Будь-ласка, оберіть інше.");
                            continue;
                        }

                        seat.IsAvailable = false;
                        int orderCode = GenerateOrderCode(reservations);
                        Reservation reservation = new Reservation(orderCode);
                        reservations.Add(reservation);
                        Ticket ticket = new Ticket(name, session.Name, seat.Name);


                        Console.WriteLine($"Квиток успішно зарезервований для {name} на {session.Name}, місце {seat.Name}.Ціна квитка - {prices[sessionNum]}. Код для оплати квитка на касi - {orderCode}.");
                    }
                }
                if (choice == 2)
                {
                    break;
                }
                if (choice == 3)
                {
                    Console.WriteLine("Сюжет фільму Черепашки нiндзя: Погром мутантiв - Довгий час вони ховалися від навколишнього світу в міській каналізації. Проте нарешті герої вирішують піднятися нагору, щоб жити життям звичайних підлітків серед жителів Нью-Йорку. Та зовсім скоро їм доведеться зіткнутися з могутньою армією мутантів, що загрожуватиме місту. Тож разом з новою подругою Ейпріл О’Ніл безстрашні черепашки зроблять усе, аби зупинити ворога.\n");
                    Console.WriteLine("Cюжет фільму Людина павук: Містеріо відкрив світу таємницю. Тепер кожен знає, що під костюмом Людини-павука знаходиться Пітер Паркер. Найближчі люди підтримують його, ЕмДжей охоче проводить з ним час та втішає як може. Але ворожо налаштований світ тисне дедалі сильніше. Пітер вирішує звернутися по допомогу до Доктора Стрейнджа. Тільки йому під силу повернути час назад та зробити так, щоб усі забули хто ж насправді під костюмом супергероя.\n");
                    Console.WriteLine("Сюжет фільму Кіт у чоботях 2: Найвідоміший пухнастий розбійник, улюбленець мільйонів, неповторний Кіт у чоботях повертається. Його візитна картка — неймовірно милий погляд, найкраща зброя — вбивча харизма, а про чоботи та капелюх ходять легенди! Цього разу, щоб повернути свої 9 життів, які він так вміло розгубив за довгі роки, Кіт у чоботях відправиться у грандіозну подорож, сповнену викликів та пригод.\n");
                    Console.WriteLine("Сюжет фільму Аватар 2: Історія фільму «Аватар: Шлях води» розгортається більше ніж через десятиліття після подій першого фільму. Стрічка розповідає про сім’ю Саллі (Джейка, Нейтірі та їхніх дітей), проблеми, які їх переслідують, шлях, який вони долають, щоб захистити одне одного від небезпек, битви, які вони ведуть, щоб залишитися живими, і трагедії, які вони переживають разом.\n");
                }
            }
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

    class Reservation
    {
        public int OrderCode { get; set; }
        public Reservation(int orderCode)
        {
            OrderCode = orderCode;
        }
    }
    class Ticket
    {
        public string Name { get; set; }
        public string SessionName { get; set; }
        public string SeatName { get; set; }

        public Ticket(string name, string sessionName, string seatName)
        {
            Name = name;
            SessionName = sessionName;
            SeatName = seatName;
        }
    }

    class Session
    {
        public string Name { get; set; }
        public List<Seat> Seats { get; set; }
        public Session(string name, List<Seat> seats)
        {
            Name = name;
            Seats = seats;
        }
    }

    class Seat
    {
        public string Name { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Seat(string name)
        {
            Name = name;
        }
    }
}