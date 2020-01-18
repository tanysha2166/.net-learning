using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;      
            for (num=1; num <= 10000; num++)
            {
                int sum = 0;
                for (int div = num-1; div > 0; div--)
                {
                    if (num % div == 0)
                    {
                        sum += div;
                    }           

                }
                if (sum == num)
                {
                    Console.WriteLine(num);
                }


            }
            

            Console.ReadLine();
        }
    }
}
