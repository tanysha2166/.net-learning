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
            string stroka2 = stroka.Trim();
            char[] str = stroka2.ToCharArray();
            for (int i = 0; i < stroka2.Length; i++)
            {
                if (str[i] == ' ')
                {
                    number += 1;
                }
            }
            number += 1;
            Console.WriteLine("Количество слов = " +number);
            Console.ReadLine();
        }
    }
}
