using System;

namespace _205
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first value: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second value: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third value: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {a}, {b} and {c} is {a + b +c }. " +
                $"The product of {a}, {b} and {c} is {a * b * c}.");
        }
    }
}
