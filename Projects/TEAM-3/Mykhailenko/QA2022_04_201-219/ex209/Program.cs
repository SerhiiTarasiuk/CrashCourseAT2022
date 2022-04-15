/*
Циклічність. Оператори While, do while. Цикл for, ключові слова break & continue

1. Розробити програму, яка виводить на екран горизонтальну лінію з символів. Кількість символів, який використовувати символ, і яка буде лінія - вертикальна, або горизонтальна - вказує користувач.
*/

using System;

namespace ex209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть символ, яким буде малюватись лінія ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.Write("Введіть довжину лінії в символах ");
            int len_line = int.Parse(Console.ReadLine());
            for (int i = 0; i < len_line; i++) { Console.Write(c); }
            Console.ReadKey();
        }
    }
}
