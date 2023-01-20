namespace prak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите опции(1-3):");
                Console.WriteLine("\n1. Игра Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3.Вывод делителей числа");
                Console.WriteLine("Нажмите ESC чтобы выйти из программы");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        GuessANumber();
                        break;
                    case ConsoleKey.D2:
                        MultiplicationTable();
                        break;
                    case ConsoleKey.D3:
                        NumberDivisors();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неправильный ввод!Попробуйте еще раз\n");
                        continue;
                }
            }
        }
        private static void GuessANumber()
        {
            Random randomizer = new Random();
            int randomNumber = randomizer.Next(0, 100);
            Console.Clear();
            Console.WriteLine("Введите число от 1 до 100!\n");
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == randomNumber)
                {
                    Console.Clear();
                    Console.WriteLine("Ты угадал!\n");
                    break;
                }
                else if (input < randomNumber)
                {
                    Console.WriteLine("\nБольше!\n");
                }
                else if (input > randomNumber)
                {
                    Console.WriteLine("\nМеньше!\n");
                }
            }
        }
        private static void MultiplicationTable()
        {
            int[,] multTable = new int[9, 10];
            for (int i = 0; i <= 8; i++)
            {
                for (int n = 0; n <= 9; n++)
                {
                    multTable[i, n] = (i + 1) * (n + 1);
                }
            }
            Console.Clear();
            for (int i = 0; i <= 8; i++)
            {
                for (int n = 0; n <= 9; n++)
                {
                    Console.Write("{0, 3}", multTable[i, n]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private static void NumberDivisors()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("Введите число или нажмите 'q' для выхода в главное меню: ");
                string? input = Console.ReadLine();
                int number = 0;
                if (input == "q")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    number = Convert.ToInt32(input);
                }
                Console.WriteLine();
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.Write($"{i}   ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}