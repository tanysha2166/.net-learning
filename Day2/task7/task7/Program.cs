using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            // мне не нравится большое количество циклов и не гибкость, если хочешь изменить число, но я решила хоть как-то сделать
            int[,] arr = new int[5, 5];
            for (int l1 = 0; l1 < 1; l1++)
            {
             int  num = 25; 
                    for (int st1 = 0; st1 < 5; st1++)
                    {

                        arr[l1, st1] = num-st1;
                    }
                
            }
            for (int l2 = 1; l2 < 5; l2++)
            {
                int num = 21;
                for (int st2 = 4; st2 < 5; st2++)
                {                  
                        arr[l2, st2] = num-l2;
                }
            }
            for (int l3 = 4; l3 < 5; l3++)
            {
                int num = 13;
                for (int st3 = 0; st3 < 4; st3++)
                {
                        arr[l3, st3] = num++;
                }
            }
            for (int l5 = 1; l5 < 4; l5++)
            {
                int num = 9;
                for (int st5 = 0; st5 < 1; st5++)
                {
                        arr[l5, st5] = num+l5;
                }
            }
            for (int l6 = 1; l6 < 2; l6++)
            {
                int num= 10;
                for (int st6 = 1; st6 < 4; st6++)
                {
                        arr[l6, st6] = num-st6;
                }
            }
            for (int l7 = 2; l7 < 4; l7++)
            {
                int num = 8;
                for (int st7 = 3; st7 < 4; st7++)
                {
                        arr[l7, st7] = num-l7;
                }
            }
            for (int l8 = 3; l8 < 4; l8++)
            {
                int num = 2;
                for (int st8 = 1; st8 < 3; st8++)
                {
                        arr[l8, st8] = num+st8;
                }
            }
            for (int l9 = 2; l9 < 3; l9++)
            {
                int num = 2;
                for (int st9 = 1; st9 < 3; st9++)
                { 
                        arr[l9, st9] = num--;
                }
            }
            for (int c1 = 0; c1 < 5; c1++)
            {
                for (int c2 = 0; c2 < 5; c2++)
                {
                    Console.Write(arr[c1, c2] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
