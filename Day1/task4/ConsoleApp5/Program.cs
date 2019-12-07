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
            string p;
            double P;
            int M = 0;
            bool c = false;
            double Sum = 1000;
            Console.WriteLine("Начальный вклад = " + Sum);
            Console.WriteLine("Введите размер процента");
            while (c == false)
            {
                p = Console.ReadLine();
            bool t = Double.TryParse(p, out double result);
                if (t == true)
                {
                    P = result;
                    P = Sum / 100*P;
                    while (Sum <= 1100)
                    {
                        Sum += P;
                        M++;
                    }
                    break;
                }
                if (t == false)
                {
                    Console.WriteLine("Введите число");
                }

            }
            Console.WriteLine("Сумма превысит 1100 через {0} месяца", M);
            Console.ReadLine();
        }
    }
}
