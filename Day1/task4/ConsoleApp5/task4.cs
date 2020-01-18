using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string percentEntered;
            int month = 0;
            bool cycle = false;
            double sum = 1000;
            Console.WriteLine("Начальный вклад = " + sum);
            Console.WriteLine("Введите размер процента");
            while (!cycle)
            {
                percentEntered = Console.ReadLine();
                bool check = Double.TryParse(percentEntered, out double percent);
                if (check)
                {
                    percent = PercentCount(percent, sum);
                    month = CountMonts(sum, percent, month);
                    cycle = true;
                }
                else
                {
                    Console.WriteLine("Введите число");
                }
            }
            Console.WriteLine("Сумма превысит 1100 через {0} месяца", month);
            Console.ReadLine();
        }
        public static double PercentCount(double percent, double sum)
        {
            return sum / 100 * percent;
        }

        public static int CountMonts(double sum, double percent, int month)
        {
            while (sum <= 1100)
            {
                sum += percent;
                month++;
            }
            return month;

        }
    }
}


