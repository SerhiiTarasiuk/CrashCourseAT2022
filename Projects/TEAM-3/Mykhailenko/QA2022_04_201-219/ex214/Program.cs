/*
Циклічність. Оператори While, do while. Цикл for, ключові слова break & continue

6. Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.
Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися повідомлення про те, що сума цифр числа 15.
*/


using System;

namespace ex214
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit, result = 0;
            Console.Write("Введіть число ");
            decimal x = decimal.Parse(Console.ReadLine());
            decimal tmp = x;
            while (tmp > 0)
            {
                digit = Convert.ToInt32(tmp % 10);
                result += digit;
                tmp = Math.Floor(tmp / 10);
            }
            Console.WriteLine("У введеному Вами числі {0} сума цифр дорівнює {1}", x, result);
            Console.ReadKey();
        }
    }
}
