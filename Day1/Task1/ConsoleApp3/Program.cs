using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру");
            int number = GetNumber();
            double celcia = CountCelcia(number);
            Console.WriteLine("Температура в Цельсия " + celcia);
            Console.ReadLine();

        }
        public static int GetNumber()
        {
            string i = Console.ReadLine();
            int.TryParse(i, out int a);
            return a;

        }
        public static double CountCelcia(int a)
        {
            return (a - 32) * 5 / 9;
        }

    }
}
