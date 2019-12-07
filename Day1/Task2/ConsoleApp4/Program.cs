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
            string a, b, c, e;
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0, z1 = 0, z2=0;
            Console.WriteLine("Введите координаты первой точки через запятую");
            a = Console.ReadLine();
            bool i = false;
            while( i==false)
            {
                int pd = a.IndexOf(",");
                int g = a.Length;
                g = g - pd;
                b= a.Remove(pd, g);
                i = Int32.TryParse(b, out int r);
                if (i == true)
                {
                    x1 = r;
                    break;
                }
               else
                    Console.WriteLine("Первый символ не число");
                a = Console.ReadLine();
            }
            bool k = false;
            while (k == false)
            {
                int cd = a.IndexOf(",");
                b = a.Remove(0, (cd+1));
                i = Int32.TryParse(b, out int result);
                if (i == true)
                {
                    x2 = result;
                    break;
                }
                else
                  Console.WriteLine("Второй символ не число");
                a = Console.ReadLine();

            }
            Console.WriteLine("Введите координаты второй точки через запятую");
            c= Console.ReadLine();
            bool j = false;
            while (j == false)
            {
                int m = c.IndexOf(",");
                int hg = c.Length;
                hg = hg - m;
                b = c.Remove(m,hg);
                i = Int32.TryParse(b, out int r);
                if (i == true)
                {
                    y1 = r;
                    break;
                }
                else
                    Console.WriteLine("Первый символ не число");
                c = Console.ReadLine();
            }
            bool v = false;
            while (v == false)
            {
                int u = c.IndexOf(",");
                b = c.Remove(0, (u + 1));
                i = Int32.TryParse(b, out int result);
                if (i == true)
                {
                    y2 = result;
                    break;
                }
                else
                    Console.WriteLine("Второй символ не число");
                c = Console.ReadLine();
            }
            Console.WriteLine("Введите координаты третьей точки через запятую");
            e = Console.ReadLine();
            bool o = false;
            while (o == false)
            {
                int h = e.IndexOf(",");
                int q = e.Length;
                q = q - h;
                b = e.Remove(h, q);
                i = Int32.TryParse(b, out int r);
                if (i == true)
                {
                    z1 = r;
                    break;
                }
                else
                    Console.WriteLine("Первый символ не число");
                e = Console.ReadLine();
            }
            bool n = false;
            while (n == false)
            {
                int l = e.IndexOf(",");
                b = e.Remove(0, (l + 1));
                i = Int32.TryParse(b, out int result);
                if (i == true)
                {
                    z2 = result;
                    break;
                }
                else
                    Console.WriteLine("Второй символ не число");
                e = Console.ReadLine();
            }
            Console.WriteLine("x1 {0}, x2 {1}, y1 {2}, y2 {3}, z1 {4}, z2 {5}", x1, x2, y1, y2, z1, z2);
            double t1 = Math.Sqrt((y1 - x1)*(y1-x1) + (y2 - x2)*(y2-x2));
            double t2 = Math.Sqrt((z1 - y1)*(z1-y1) + (z2 - y2)*(z2-y2));
            double t3 = Math.Sqrt((x1 - z1)*(x1-z1) + (x2 - z2)*(x2-z2));
            Console.WriteLine("t1 = " + t1,"t2= " +t2, "t3= "+t3);
            double p = (t1 + t2 + t3) / 2;
            double stepen2 = 1 / 2;
            double S1 = (p * (p - t1) * (p - t2) * (p - t3));
            double S = Math.Pow(S1, stepen2);
            Console.WriteLine("Периметр треугольника равен ", +p);
            Console.ReadLine();


        }
    }
}
