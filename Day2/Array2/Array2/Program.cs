using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите размер первого массива");
            string mass1 = Console.ReadLine();
            Int32.TryParse(mass1, out int m);
            Console.WriteLine("Введите размер второго массива");
            string mass2 = Console.ReadLine();
            Int32.TryParse(mass1, out int n);
            int[] Array1 = new int[m];
            int[] Array2 = new int[n];
            int[] Array3 = new int [m+n];
            bool check = false;
            int index = 0;
            Console.WriteLine("Первый массив");
            for (int m1 = 0; m1 < m; m1++)
            {
                Array1[m1] = rnd.Next(0, 20);
                Console.Write(Array1 [m1] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Второй массив");
            for (int m2 = 0; m2 < n; m2++)
            {
                Array2[m2] = rnd.Next(0, 20);
                Console.Write(Array2[m2] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Третий массив");
            for (int m1 = 0; m1 < m; m1++)
            {
                for (int m2 = 0; m2 < n; m2++)
                {

                    for (int i = 0; i < Array3.Length; i++)

                    {
                        if (Array1[m1] == Array2[m2])
                        {
                            if (Array1[m1] == Array3[i])
                            {
                                check = false;
                                break;
                            }
                            else
                            {
                                check = true;
                            }
                        }                   
                    }
                    if (check == true)
                    {
                        Array3[index] = Array1[m1];
                        index++;
                    }
                    check = false;
                }
               
            }
            for (int i = 0; i < index; i++)

            {    
                    Console.Write(Array3[i] + " ");               
            }
                Console.ReadLine();
        }

    }
}