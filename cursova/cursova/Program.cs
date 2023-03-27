using System;
using System.Collections.Generic;
using System.Text;

namespace cursova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            int a = 1;
            List<string> seats = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            List<string> seats1 = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            List<string> seats2 = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            List<string> seats3 = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            List<string> seats4 = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            List<string> seats5 = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            List<string> seats6 = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            List<string> seats7 = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            List<string> seats8 = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            List<string> seats9 = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            List<string> seats10 = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            List<string> seats11 = new List<string> { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "D1", "D2", "D3", "E1", "E2", "E3", "F1", "F2", "F3" };
            do
            {
                List<string> movies = new List<string> { "Черепашки нiндзя: Погром мутантiв 21.08 12:10", "Людина павук 21.08 14:50", "Кiт у чоботях 2 21.08 18:00", "Черепашки нiндзя: Погром мутантiв 22.08 12:10", "Людина павук 22.08 14:50", "Кiт у чоботях 2 22.08 18:00", "Черепашки нiндзя: Погром мутантiв 23.08 12:10", "Людина павук 23.08 14:50", "Кiт у чоботях 2 23.08 18:00", "Черепашки нiндзя: Погром мутантiв 24.08 12:10", "Аватар 2 24.08 14:50", "Кiт у чоботях 2 24.08 18:00" };
                List<double> prices = new List<double> { 150.00, 130.00, 160.00, 150.00, 130.00, 160.00, 150.00, 130.00, 160.00, 150.00, 140.00, 160.00 };
                Console.WriteLine("Доброго дня! Будь-ласка, оберiть пункт який вас цiкавить:");
                for (int i = 0; i < movies.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {movies[i]}");
                }
                int movieIndex = int.Parse(Console.ReadLine()) - 1;
                string selectedMovie = movies[movieIndex];
                double selectedPrice = prices[movieIndex];
                Console.WriteLine($"Ви обрали {selectedMovie}. Цiна одного бiлету {selectedPrice}грн.");
                if (movieIndex == 0 ^ movieIndex == 3 ^ movieIndex == 6 ^ movieIndex == 9)
                {
                    Console.WriteLine("Сюжет фільму: Довгий час вони ховалися від навколишнього світу в міській каналізації. Проте нарешті герої вирішують піднятися нагору, щоб жити життям звичайних підлітків серед жителів Нью-Йорку. Та зовсім скоро їм доведеться зіткнутися з могутньою армією мутантів, що загрожуватиме місту. Тож разом з новою подругою Ейпріл О’Ніл безстрашні черепашки зроблять усе, аби зупинити ворога");
                }
                if (movieIndex == 1 ^ movieIndex == 4 ^ movieIndex == 7)
                {
                    Console.WriteLine("Cюжет фільму: Містеріо відкрив світу таємницю. Тепер кожен знає, що під костюмом Людини-павука знаходиться Пітер Паркер. Найближчі люди підтримують його, ЕмДжей охоче проводить з ним час та втішає як може. Але ворожо налаштований світ тисне дедалі сильніше. Пітер вирішує звернутися по допомогу до Доктора Стрейнджа. Тільки йому під силу повернути час назад та зробити так, щоб усі забули хто ж насправді під костюмом супергероя.");
                }
                if (movieIndex == 2 ^ movieIndex == 5 ^ movieIndex == 8 ^ movieIndex == 11)
                {
                    Console.WriteLine("Сюжет фільму: Найвідоміший пухнастий розбійник, улюбленець мільйонів, неповторний Кіт у чоботях повертається. Його візитна картка — неймовірно милий погляд, найкраща зброя — вбивча харизма, а про чоботи та капелюх ходять легенди! Цього разу, щоб повернути свої 9 життів, які він так вміло розгубив за довгі роки, Кіт у чоботях відправиться у грандіозну подорож, сповнену викликів та пригод.");
                }
                if (movieIndex == 10)
                {
                    Console.WriteLine("Сюжет фільму: Історія фільму «Аватар: Шлях води» розгортається більше ніж через десятиліття після подій першого фільму. Стрічка розповідає про сім’ю Саллі (Джейка, Нейтірі та їхніх дітей), проблеми, які їх переслідують, шлях, який вони долають, щоб захистити одне одного від небезпек, битви, які вони ведуть, щоб залишитися живими, і трагедії, які вони переживають разом.");
                }
                Console.WriteLine("Cкiльки бiлетiв ви бажаєте придбати?");
                int numTickets = int.Parse(Console.ReadLine());
                Console.WriteLine("Будь-ласка, оберiть мiсця:");
                if (movieIndex == 0)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats.Remove(selectedSeat);
                    }
                }
                if (movieIndex == 1)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats1)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats1.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats1.Remove(selectedSeat);
                    }
                }
                if (movieIndex == 2)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats2)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats1.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats2.Remove(selectedSeat);
                    }
                }
                if (movieIndex == 3)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats3)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats3.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats3.Remove(selectedSeat);
                    }
                }
                if (movieIndex == 4)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats4)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats4.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats4.Remove(selectedSeat);
                    }
                }
                if (movieIndex == 5)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats5)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats5.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats5.Remove(selectedSeat);
                    }
                }
                if (movieIndex == 6)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats6)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats6.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats6.Remove(selectedSeat);
                    }
                }
                if (movieIndex == 7)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats7)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats7.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats7.Remove(selectedSeat);
                    }
                }
                if (movieIndex == 8)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats8)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats8.Remove(selectedSeat);
                    }
                }
                if (movieIndex == 9)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats9)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats9.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats9.Remove(selectedSeat);
                    }
                }
                if (movieIndex == 10)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats10)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats9.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats10.Remove(selectedSeat);
                    }
                }
                if (movieIndex == 11)
                {
                    for (int i = 0; i < numTickets; i++)
                    {
                        Console.WriteLine($"Бiлет {i + 1} - Доступнi мiсця: {string.Join(", ", seats11)}");
                        Console.Write($"Оберiть мiсце для Бiлет {i + 1}: ");
                        string selectedSeat = Console.ReadLine().ToUpper();
                        while (!seats9.Contains(selectedSeat))
                        {
                            Console.Write($"Ви помилились. Оберiть доступне мiсце для Бiлет {i + 1}: ");
                            selectedSeat = Console.ReadLine().ToUpper();
                        }
                        seats11.Remove(selectedSeat);
                    }
                }
                Random rnd = new Random();
                int cod = rnd.Next(1000000, 9999999);
                double totalCost = selectedPrice * numTickets;
                Console.WriteLine($"Ви зарезервували {numTickets} бiлета на {selectedMovie}.Остаточна вартiсть - {totalCost}грн. Код для оплати квитка на касi - {cod}.");
                Console.WriteLine($"\nЯкщо ви хочете повернутися на початок, нажмiть на Enter, якщо завершити роботу додатка - ESC");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            } while (a > 0);
        }
    }
}
