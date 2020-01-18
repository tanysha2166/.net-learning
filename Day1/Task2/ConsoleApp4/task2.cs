using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            Console.WriteLine("Введите координаты первой точки через запятую");
            number = Console.ReadLine();
            int[] coordinates1 = GetNumbers(number);
            Console.WriteLine("Введите координаты второй точки через запятую");
            number = Console.ReadLine();
            int[] coordinates2 = GetNumbers(number);
            Console.WriteLine("Введите координаты третьей точки через запятую");
            number = Console.ReadLine();
            int[] coordinates3 = GetNumbers(number);
            double t1 = CountSide(coordinates2[0], coordinates1[0], coordinates2[1], coordinates1[1]);
            double t2 = CountSide(coordinates3[0], coordinates2[0], coordinates3[1], coordinates2[1]);
            double t3 = CountSide(coordinates1[0], coordinates3[0], coordinates1[1], coordinates3[1]);
            double P = (t1 + t2 + t3);
            double S = CountPloshad (t1, t2, t3);
            Console.WriteLine ("Стороны треуголинка " +t1 + " " + t2 + " " + t3);
            Console.WriteLine("Периметр треугольника равен {0}", P);
            Console.WriteLine("Площадь треугольника равна {0}", S);
            Console.ReadLine();
        }

        public static double CountSide(int num1, int num2, int num3, int num4)
        {
            double t1 = Math.Sqrt(Math.Pow((num1 - num2), 2) + Math.Pow((num3 - num4), 2));
            return t1;
        }

        public static double CountPloshad(double t1, double t2, double t3)
        { 
            double p = (t1 + t2 + t3) / 2;
            double S1 = (p * (p - t1) * (p - t2) * (p - t3));
            double S = Math.Sqrt(S1);
            return S;
        }
        public static int [] GetNumbers(string number)
        {
            string [] numbers = number.Split(',');
            int[] numbers2 = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers2[i] = int.Parse(numbers[i]);
            }
            return numbers2;
        }
      
    }
}
