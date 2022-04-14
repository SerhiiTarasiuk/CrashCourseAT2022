/* 214. Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.
Примітка: Наприклад, користувач ввів число 12345.
На екрані має з'явитися повідомлення про те, що сума цифр числа 15. */



using System;

namespace _214
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = a.ToString(); // convert int 'a' to a string
            int length = b.Length;
            int result = 0;
            for(int i = --length; i >= 0; i--)
            {
                char digit = b[i]; // convert 1st digit to a char
                int c = int.Parse(digit.ToString()); // convert char to int
                result += c; // add to result
            }
            Console.WriteLine($"The sum of digits of the number {a} is {result}");
        }
    }
}
