using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cycle = false;
            string number;
            double sum =0, count=0;
            Console.WriteLine("Введите число");
            while (!cycle)
            {
                number = Console.ReadLine();
                bool check = Double.TryParse(number, out double keyboardNumber);
                if (check)
                {
                    if (keyboardNumber != 0)
                    {
                        sum += keyboardNumber;                 
                    }
                    else
                    {
                        cycle = true;
                    }
                    count++;
                }
                else
                {
                    Console.WriteLine("Введите число");
                }
            }
            double average = CountAverage(sum, count);
            Console.WriteLine("Сумма = {0}, Среднее арифметическое = {1}, Количество чисел = {2}", sum,average, count);
            Console.ReadLine();
        }
        public static double CountAverage(double sum, double count)
        { 
        return sum / count;
        }
    }
}
