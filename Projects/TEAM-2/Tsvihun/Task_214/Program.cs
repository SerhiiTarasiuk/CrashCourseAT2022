/*
214.
Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.
Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися повідомлення про те, що сума цифр числа 15.
*/
using System;

namespace Task_214
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int summ = 0;

            while (number > 0)
            {
                summ += (number % 10);
                number /= 10;
            }
            Console.WriteLine($"Summ of digits = {summ}");
        }
    }
}
