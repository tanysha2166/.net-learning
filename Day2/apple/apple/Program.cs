using System;

namespace apple
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[5];
            Random rnd = new Random();
            int pr1 = -10;
            int pr2 = -10;
            int pr = -10;
            for (int i = 0; i < 5; i++)
            {
                arr[i] = rnd.Next(-10, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int n1 = 1;
            int n2 = 2;
            for (int c1 = 0; c1 < 3; c1++)
            {
                for (int c2 = n1; c2 < 4; c2++)
                {
                    if (n2 != 4)
                    {
                        for (int c3 = n2; c3 < 4; c3++)
                        {
                            pr1 = arr[c1] * arr[c2] * arr[c3];
                            pr2 = arr[c2] * arr[c2] * arr[c3 + 1];
                            if (pr1 > pr2 && pr1 > pr)
                            {
                                pr = pr1;
                            }
                            if (pr1 < pr2 && pr2 > pr)
                            {
                                pr = pr2;
                            }
                        }
                    }
                    else
                    {
                        for (int c3 = n2; c3 < 5; c3++)
                        {
                            pr1 = arr[c1] * arr[c2] * arr[c3];
                            if (pr1 > pr)
                            {
                                pr = pr1;
                            }
                        }
                    }
                    n2++;
                }
                n1++;
                n2 = n1+1;
               
            }
            Console.WriteLine(pr);
        }
    }
}
