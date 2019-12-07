using System;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string stroka = Console.ReadLine();
            string str = stroka.Trim();
            char[] strReverse = str.ToCharArray();
            Array.Reverse(strReverse);
            char[] str1 = str.ToCharArray();
           // пыталась сделать через Equals, но не работало. Пошла другим путем. ДА ЗДРАВСТВУЮТ ЦИКЛЫ!!! 
           // bool check = str.Equals(strReverse);
           // if (check == true)
            bool check = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str1[i] != strReverse[i])
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else 
            {
                Console.WriteLine("Строка не палиндром");
            }                 
            Console.ReadLine();
        }
    }
}
