using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] A = new int[5];
            double max2 = 0;
            int sumChetnye = 0;
            double sumNechet = 0;
            int sum1 = 0; double sum2 = 0;
            int pr1 = 1; double pr2 = 1;
            double[,] B = new double[3, 4];
            Console.WriteLine("Введите значения первого массива");
            for (int i = 0; i < 5; i++)
            {
                string a = Console.ReadLine();
                Int32.TryParse(a, out A[i]);
                sum1 += A[i];
                pr1 *= A[i];
            }
            Console.WriteLine("Первый массив");
            Console.Write(A[0] + " " + A[1] + " " + A[2] + " " + A[3] + " " + A[4]);
            Console.WriteLine();
            Console.WriteLine("Второй массив");
            for (int c1 = 0; c1 < 3; c1++)
            {
                for (int c2 = 0; c2 < 4; c2++)
                {
                    B[c1, c2] = random.Next(0, 20);
                    Console.Write(B[c1, c2] + " ");
                    sum2 += B[c1, c2];
                    pr2 *= B[c1, c2];

                }
                Console.WriteLine();
            }
            int max1 = A.Max();
            for (int c1 = 0; c1 < 3; c1++)
            {
                for (int c2 = 0; c2 < 3; c2++)
                {
                    if (B[c1, c2] > B[c1, (c2 + 1)])
                    {
                        max2 = B[c1, c2];
                    }
                    else
                        max2 = B[c1, (c2 + 1)];
                }
            }
            for (int i = 1; i < 5; i += 2)
            {
                sumChetnye += A[i];
            }
            for (int c1 = 0; c1 < 3; c1++)
            {
                for (int c2 = 0; c2 < 4; c2 += 2)
                {
                    sumNechet += B[c1, c2];
                }
            }
           double min = max2;
            for (int c1 = 0; c1 < 3; c1++)
            {
                for (int c2 = 0; c2 < 3; c2++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (B[c1, c2] < B[c1, (c2 + 1)] && B[c1,c2]< min && A[i] == B[c1,c2] )
                        {
                            min= B[c1, c2];
                        }
                       
                    }
                }
            }

            double sum = sum1 + sum2;
            double pr = pr1 * pr2;
            if (max1 > max2)
            {
                Console.WriteLine("Максимальное значение в обоих массивах " + max1);
            }
            else
            {
                Console.WriteLine("Максимальное значение в обоих массивах " + max2);
            }
            Console.WriteLine("Cумма чисел " + sum);
            Console.WriteLine("Произведение чисел " + pr);
            Console.WriteLine("Сумма четных столбцов массива А " + sumChetnye);
            Console.WriteLine("СУмма начетных столбцов массива B " + sumNechet);
            Console.WriteLine("Минимальное общее" + min);
            Console.ReadLine();

        }
    }
}