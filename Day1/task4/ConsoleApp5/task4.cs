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
            string percent;
            int month = 0;
            bool cycle = false;
            double Sum = 1000;
            Console.WriteLine("Начальный вклад = " + Sum);
            Console.WriteLine("Введите размер процента");
            while (cycle == false)
            {
            percent = Console.ReadLine();
            bool check = Double.TryParse(percent, out double percent2);
                if (check == true)
                { 
                    percent2 = Sum / 100*percent2;
                    while (Sum <= 1100)
                    {
                        Sum += percent2;
                        month++;
                    }
                    break;
                }
               else
                {
                    Console.WriteLine("Введите число");
                }

            }
            Console.WriteLine("Сумма превысит 1100 через {0} месяца", month);
            Console.ReadLine();
        }
    }
}
