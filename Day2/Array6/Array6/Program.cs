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
            int max1 = FindMax(0, massiv);
            Console.WriteLine("Максимальное значение первого столбца = "+ max1);
            int max2 = FindMax(1, massiv);
            Console.WriteLine("Максимальное значение второго столбца = " + max2);
            int max3 = FindMax(2, massiv);
            Console.WriteLine("Максимальное значение третьего столбца = " + max3);
            int max4 = FindMax(3, massiv);
            Console.WriteLine("Максимальное значение четвертого столбца = " + max4);
            int max5 = FindMax(4, massiv);
            Console.WriteLine("Максимальное значение пятого столбца = " + max5);
            Console.ReadLine();
        }

        public static int FindMax (int column, int[,] massiv)
        {
            int max = 0;
            
            for (int c1 = 0; c1 < 5; c1++)
            {
                    if (massiv[c1, column] > max)
                    {
                        max = massiv[c1, column];
                    }
            }
            return max;
        }  
    }
}
