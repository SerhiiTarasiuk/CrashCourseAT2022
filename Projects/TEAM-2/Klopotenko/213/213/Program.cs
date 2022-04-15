/* 213. Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.
Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися число навпаки - 54321. */


using System;

namespace _213
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = a.ToString();
            int length = b.Length;
            Console.Write($"The number {a} after reversing is ");
            for(int i = --length; i >= 0; i--)
            {
                Console.Write(b[i]);
            }
        }
    }
}
