/*
 Дано натуральне число а (a <100). Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр 
 */
using System;

namespace Task_207
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1 - to 99:");
            byte number = Convert.ToByte(Console.ReadLine());
            byte digits = 0;
            int summ = 0;

            while (number > 0)
            {
                summ = summ + (number % 10);
                number /= 10;
                digits++;
                
            }
            Console.WriteLine($"Number of digits = {digits}");
            Console.WriteLine($"Summ of digits = {summ}");
        }
    }
}
