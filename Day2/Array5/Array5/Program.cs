using System;

namespace Array5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[5, 5];
            Random rnd = new Random();
            for (int c1 = 0; c1 < 5; c1++)
            {
                for (int c2 = 0; c2 < 5; c2++)
                {
                    array1[c1, c2] = rnd.Next(-100, 100);
                    Console.Write(array1[c1, c2] + " ");
                }
                Console.WriteLine();
            }
            int max = -100;
            int indMax1 = 0;
            int indMax2 = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array1[i, j] > max)
                    {
                        max = array1[i, j];
                        indMax1 = i;
                        indMax2 = j;
                    }
                }
            }
            int min = max;
            int indexMin1 = 0;
            int indexMin2 = 0;
            for (int c1 = 0; c1 < 5; c1++)
            {
                for (int c2 = 0; c2 < 4; c2++)
                {
                    if (array1[c1, c2] < min)
                    {
                        min = array1[c1, c2];
                        indexMin1 = c1;
                        indexMin2 = c2;
                    }
                }
            }
            int sum;
            if (indexMin1 < indMax1)
            {
                sum = CountSum(indexMin1, indexMin2, indMax1, indMax2, array1);
            }
            else
            {
                sum = CountSum(indMax1, indMax2, indexMin1, indexMin2, array1);
            }
            Console.WriteLine("Максимальное значение " + max);
            Console.WriteLine("Минимальное значение " + min);
            Console.WriteLine("Индекс максимального " + indMax1 + " " + indMax2);
            Console.WriteLine("индех минимального " + indexMin1 + " " + indexMin2);
            Console.WriteLine("сумма " + sum);
            Console.ReadLine();
        }
        public static int CountSum(int ind1Num1, int ind2Num1, int ind1Num2, int ind2Num2, int[,] array)
        {
            int sum = 0;
            for (int line1 = (ind2Num1+1); line1 < 5; line1++)
            {
                sum += array[ind1Num1, line1];
            }
            for (int c1 = (ind1Num1 + 1); c1 < ind1Num2; c1++)
            {
                for (int c2 = 0; c2 < 5; c2++)
                {
                    sum += array[c1, c2];
                }
            }
            for (int c3 = 0; c3 < ind2Num2; c3++)
            {
                sum += array[ind1Num2, c3];           
            }
            return sum;
        }
    }
}
