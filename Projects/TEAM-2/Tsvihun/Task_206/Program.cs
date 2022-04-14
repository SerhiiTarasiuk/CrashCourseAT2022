/*
206. Напишіть програму, яка перевіряє число, введене з клавіатури на парність.
*/
using System;

namespace Task_206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("EVEN");
                }
                else
                {
                    Console.WriteLine("ODD");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
