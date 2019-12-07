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
            EnterNumber();
            while (cycle==false)
            {
                number = Console.ReadLine();
                bool check = Double.TryParse(number, out double keyboardNumber);
                if (check == true)
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
                    EnterNumber();
                }
            }
            double average = CountAverage(sum, count);
            Console.WriteLine("Сумма = {0}, Среднее арифметическое = {1}, Количество чисел = {2}", sum,average, count);
            Console.ReadLine();
        }
        public static void EnterNumber()
        {
            Console.WriteLine("Введите число");
        }
        public static double CountAverage(double sum, double count)
        { 
        return sum / count;
        }
    }
}
