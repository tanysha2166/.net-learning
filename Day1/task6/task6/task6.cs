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
            while (!cycle)
            {
                number = Console.ReadLine();
                bool check = Int32.TryParse(number, out int keyboardNumber);
                if (check)
                {
                    if (number.Length == 6)
                    {
                        c6 = keyboardNumber % 10;
                        c5 = ((keyboardNumber % 100) - c6) / 10;
                        c4 = (((keyboardNumber % 1000) - (c5 * 10) - c6) / 100);
                        c3 = (((keyboardNumber % 10000) - (c4 * 100) - (c5 * 10) - c6) / 1000);
                        c2 = (((keyboardNumber % 100000) - (c3 * 1000) - (c4 * 100) - (c5 * 10) - c6) / 10000);
                        c1 = keyboardNumber / 100000;
                        if (c1 + c2 + c3 == c4 + c5 + c6)
                        {
                            Console.WriteLine("Поздравляем с со счастливым билетом!");
                            cycle = true;
                        }
                        else
                        {
                            Console.WriteLine("Лузер");
                            cycle = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Билет должен быть шестизначным");
                    }
                }
                else
                {
                    Console.WriteLine("Номер должен состоять из чисел");
                }

            }
            Console.ReadLine();

        }
    }
}
