/*
Циклічність. Оператори While, do while. Цикл for, ключові слова break & continue

5. Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.
Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися число навпаки - 54321.
*/

using System;

namespace ex213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit;
            decimal tmp, result = 0;
            Console.Write("Введіть число ");
            decimal x = decimal.Parse(Console.ReadLine());
            tmp = x;
            while (tmp > 0)
            {
                digit = Convert.ToInt32(tmp % 10);
                result += Convert.ToInt64(digit);
                result *= 10;
                tmp = Math.Floor(tmp / 10);
            }
            result /= 10;
            Console.WriteLine("Ви ввели число {0} перевернуте число буде {1}", x, result);
            Console.ReadKey();
        }
    }
}
