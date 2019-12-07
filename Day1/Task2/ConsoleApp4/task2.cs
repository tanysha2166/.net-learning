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
            int x1, x2, y1, y2, z1, z2;
            Console.WriteLine("Введите координаты первой точки через запятую");
            number = Console.ReadLine();
            x1 = GetLeftNumber(number);
            x2 = GetRightNumber(number);
            Console.WriteLine("Введите координаты второй точки через запятую");
            number = Console.ReadLine();
            y1 = GetLeftNumber(number);
            y2 = GetRightNumber(number);
            Console.WriteLine("Введите координаты третьей точки через запятую");
            number = Console.ReadLine();
            z1 = GetLeftNumber(number);
            z2 = GetRightNumber(number);
            Console.WriteLine("x1 {0}, x2 {1}, y1 {2}, y2 {3}, z1 {4}, z2 {5}", x1, x2, y1, y2, z1, z2);
            double S = CountPerimetr(x1, x2, y1, y2, z1, z2);
            Console.WriteLine("Периметр треугольника равен {0}", S);
            Console.ReadLine();
        }
        public static double CountPerimetr(int x1, int x2, int y1, int y2, int z1, int z2)
        {
            double t1 = Math.Sqrt(Math.Pow((y1 - x1), 2) + Math.Pow((y2 - x2), 2));
            double t2 = Math.Sqrt(Math.Pow((z1 - y1), 2) + Math.Pow((z2 - y2), 2));
            double t3 = Math.Sqrt(Math.Pow((x1 - z1), 2) + Math.Pow((x2 - z2), 2));
            double p = (t1 + t2 + t3) / 2;
            double S1 = (p * (p - t1) * (p - t2) * (p - t3));
            double S = Math.Sqrt(S1);
            return S;
        }
        public static int GetRightNumber(string number)
        {
            int i = number.IndexOf(",");
            int l = number.Length;
            l -= i;    
            string rightSide = number.Remove(0, (i + 1));           
            Int32.TryParse(rightSide, out int y2);
            return y2;
        }
        public static int GetLeftNumber(string number)
        {
            int i = number.IndexOf(",");
            int l = number.Length;
            l -= i;
            string leftSide = number.Remove(i, l);           
            Int32.TryParse(leftSide, out int y1);
            return y1;

        }
    }
}
