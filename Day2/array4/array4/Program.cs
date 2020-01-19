using System;

namespace array4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string stroka = Console.ReadLine();
            int number = 0;
            char[] divisors = { ' ', ',', '.', '!' };
            string[] stroki = stroka.Split(divisors);
            for (int i = 0; i < stroki.Length; i++)
            {
                if (stroki[i] != "")
                {
                    number += 1;
                }
            }
            Console.WriteLine("Количество слов = " + number);
            Console.ReadLine();
        }
    }
}
