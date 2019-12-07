using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1, n2;
            int q;
            bool cycle = false;
            while (cycle == false)
            {
                Console.WriteLine("ВВедите первое число");
                n1 = Console.ReadLine();
                Console.WriteLine("ВВедите второе число");
                n2 = Console.ReadLine();
                bool t1 = Int32.TryParse(n1, out int num1);
                bool t2 = Int32.TryParse(n2, out int num2);
                if (t1 == true && t2 == true)
                {
                    if (num1 < num2)
                    {
                        for (q = num1; q <= num2; q++)
                        {
                            for (int i = 0; i < num1; i++)
                            {
                                Console.Write(num1 + " ");
                            }
                            Console.WriteLine("\n");
                            num1++;
                        }
                        cycle = true;
                    }
                    else
                    {
                        Console.WriteLine("первое число должно быть меньше второго");
                    }
                }
                else
                {
                    Console.WriteLine("Введите числа!");
                }            
            }

            Console.ReadLine();
        } 
    }
}
