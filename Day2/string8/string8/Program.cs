using System;

namespace string8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();
            int sum = 0;
            char[] stroka = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                // оно ломается если гласная является последней т.к. выходит за границы массива. У меня было решеие вставлять пустой символ в конец массива, но не уверена, что эот возможно
                if (stroka[i] == 'а' | stroka[i] == 'у' | stroka[i] == 'е' | stroka[i] == 'ы' | stroka[i] == 'о' | stroka[i] == 'э' | stroka[i] == 'я' | stroka[i] == 'и' | stroka[i] == 'ю' && stroka[i + 1] == ' ' | stroka[i + 1] == ',' | stroka[i + 1] == '.')
                {
                    sum += 1;
                }

            }
            Console.WriteLine("Количество слов, оканчивающихся на гласную = " +sum);
            Console.ReadLine();
        }
    }
}
