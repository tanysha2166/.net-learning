using System;

namespace Array6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] massiv = new int[5, 5];
            Random rnd = new Random();
            for (int c1 = 0; c1 < 5; c1++)
            {
                for (int c2 = 0; c2 < 5; c2++)
                {
                    massiv[c1, c2] = rnd.Next(0, 100);
                    Console.Write(massiv[c1, c2] + " ");
                }
                Console.WriteLine();
            }
            int max1 = 0;
            for (int c1 = 1; c1 < 5; c1++)
            {
                for (int c2 = 0; c2 < 1; c2++)//здезь же всегда обязательно тройное условие?
                {
                    if (massiv[c1, c2] > massiv[(c1 - 1), c2]&& massiv[c1,c2]>max1)
                    {
                        max1 = massiv[c1, c2];
                    }
                    if (massiv[c1, c2] < massiv[(c1 - 1), c2] && massiv[c1, c2] > max1)
                    {
                        max1 = massiv[(c1-1), c2];
                    }
                }
            }
            Console.WriteLine("Максимальное значение первого столбца = "+max1);
            int max2 = 0;
            for (int c1 = 1; c1 < 5; c1++)
            {
                for (int c2 = 1; c2 < 2; c2++)
                {
                    if (massiv[c1, c2] > massiv[(c1 - 1), c2] && massiv[c1, c2] > max2)
                    {
                        max2 = massiv[c1, c2];
                    }
                    if (massiv[c1, c2] < massiv[(c1 - 1), c2] && massiv[c1, c2] > max2)
                    {
                        max2 = massiv[(c1 - 1), c2];
                    }
                }
            }
            Console.WriteLine("Максимальное значение второго столбца = " + max2);
            int max3 = 0;
            for (int c1 = 1; c1 < 5; c1++)
            {
                for (int c2 = 2; c2 < 3; c2++)
                {
                    if (massiv[c1, c2] > massiv[(c1 - 1), c2] && massiv[c1, c2] > max3)
                    {
                        max3 = massiv[c1, c2];
                    }
                    if (massiv[c1, c2] < massiv[(c1 - 1), c2] && massiv[c1, c2] > max3)
                    {
                        max3 = massiv[(c1 - 1), c2];
                    }
                }
            }
            Console.WriteLine("Максимальное значение третьего столбца = " + max3);
            int max4 = 0;
            for (int c1 = 1; c1 < 5; c1++)
            {
                for (int c2 = 3; c2 < 4; c2++)
                {
                    if (massiv[c1, c2] > massiv[(c1 - 1), c2] && massiv[c1, c2] > max4)
                    {
                        max4 = massiv[c1, c2];
                    }
                    if (massiv[c1, c2] < massiv[(c1 - 1), c2] && massiv[c1, c2] > max4)
                    {
                        max4 = massiv[(c1 - 1), c2];
                    }
                }
            }
            Console.WriteLine("Максимальное значение четвертого столбца = " + max4);
            int max5 = 0;
            for (int c1 = 1; c1 < 5; c1++)
            {
                for (int c2 = 4; c2 < 5; c2++)
                {
                    if (massiv[c1, c2] > massiv[(c1 - 1), c2] && massiv[c1, c2] > max5)
                    {
                        max5 = massiv[c1, c2];
                    }
                    if (massiv[c1, c2] < massiv[(c1 - 1), c2] && massiv[c1, c2] > max5)
                    {
                        max5 = massiv[(c1 - 1), c2];
                    }
                }
            }
            Console.WriteLine("Максимальное значение пятого столбца = " + max5);
            Console.ReadLine();
        }
    }
}
