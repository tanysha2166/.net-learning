﻿using System;

namespace Array5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[5, 5];
            Random rnd = new Random();
            for (int c1 = 0; c1<5; c1++)
            {
                for (int c2 = 0; c2 < 5; c2++)
                {
                    array1[c1, c2] = rnd.Next(-100, 100);
                    Console.Write(array1[c1, c2] + " ");
                }
                Console.WriteLine();
            }
            int max = -100;
            int indMax1 =0;
            int indMax2=0;
            for ( int i = 0; i < 5; i++)
            {
                for ( int j = 0; j < 5; j++)
                {
                    if (array1[i,j] > max)
                    {
                        max = array1[i, j];
                        indMax1 = i;
                        indMax2 = j;
                    }               
                }             
            }
            int min = max;
            int indexMin1 = 0;
            int indexMin2=0;
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
            int sum = 0;
            if (indexMin1 < indMax1)
            {
                for (int line1=indexMin2; line1<5; line1++)
                {
                    sum += array1[indexMin1, line1];
                }
                for (int c1 = (indexMin1+1); c1 < indMax1; c1++)
                {
                    for (int c2 = 0; c2 < 5; c2++)
                    {
                        sum += array1[c1, c2];
                    }
                }
                for (int c3 = 0; c3 <= indMax2; c3++)
                {
                    sum += array1[indMax1, c3];
                }
            }
            else
            {
                for (int line1 = indMax2; line1 < 5; line1++)
                {
                    sum += array1[indMax1, line1];
                }
                for (int c1 = (indMax1+1); c1 <= indexMin2; c1++)
                {
                    for (int c2 = 0; c2 < 5; c2++)
                    {
                        sum += array1[c1, c2];
                    }
                }
                for (int c3 = 0; c3 <= indexMin2; c3++)
                {
                    sum += array1[indexMin1, c3];
                }
            }
            Console.WriteLine("Максимальное значение " +max);
            Console.WriteLine("Минимальное значение " + min);
            Console.WriteLine("Индекс максимального " +indMax1 + " " + indMax2);
            Console.WriteLine("индех минимального "+ indexMin1 + " " + indexMin2);
            Console.WriteLine("сумма " +sum);
            Console.ReadLine();
        }
    }
}
