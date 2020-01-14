using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cycle = false;
            while (!cycle)
            {
                Console.WriteLine("Введите длинну прямоугольника");
                string lengthStr = Console.ReadLine();
                bool checkLength = Int32.TryParse(lengthStr, out int length);
                Console.WriteLine("Введите ширину прямоугольника");
                string widthStr = Console.ReadLine();
                bool checkWidth = Int32.TryParse(widthStr, out int width);
                Console.WriteLine("Введите первый символ");
                string symbol1 = Console.ReadLine();
                Console.WriteLine("Введите второй символ");
                string symbol2 = Console.ReadLine();
                if (checkLength && checkWidth)
                {
                    for (int firstLine = 0; firstLine < length; firstLine++)
                    {
                        Console.Write(symbol1);

                    }
                    Console.Write("\n");
                    for (int middle = 0; middle < (width - 2); middle++)
                    {
                        Console.Write(symbol1);
                        for (int inside = 2; inside < length; inside++)
                        {
                            Console.Write(symbol2);
                        }
                        Console.Write(symbol1);
                        Console.Write("\n");
                    }
                    for (int lastLine = 0; lastLine < length; lastLine++)
                    {
                        Console.Write(symbol1);
                    }
                    Console.Write("\n");
                    cycle = true;
                }
                else
                {
                    Console.WriteLine("Длинна и ширина должны быть числами");
                }
            }
            Console.ReadLine();
        }
    }
}

                    