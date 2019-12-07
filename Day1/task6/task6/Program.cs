using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int c1, c2, c3, c4, c5, c6, l;
            bool cycle = false;
            Console.WriteLine("Введите номер билета");
            number = Console.ReadLine();
            bool t = Int32.TryParse(number, out int result);
            while (cycle == false)
            {
                if (t == true)
                {
                    l = number.Length;
                    if (l == 6)
                    {
                        c6 = result % 10;
                        c5 = ((result % 100) - c6) / 10;
                        c4 = (((result % 1000) - (c5 * 10) - c6) / 100);
                        c3 = (((result % 10000) - (c4 * 100) - (c5 * 10) - c6) / 1000);
                        c2 = (((result % 100000) - (c3 * 1000) - (c4 * 100) - (c5 * 10) - c6) / 10000);
                        c1 = result / 100000;
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5} ", c1, c2, c3, c4, c5, c6);
                        break;
                    }
                    else
                        Console.WriteLine("Билет должен быть шестизначным");
                }
                else
                {
                    Console.WriteLine("Номер должен состоять из чисел");
                    break;
                }

            }
        }
    }
}
