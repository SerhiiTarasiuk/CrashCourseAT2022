using System;

namespace _207
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            short a = Convert.ToInt16(Console.ReadLine());
            if(a / 10 == 0)
            {
                Console.WriteLine("The number consists of one digit");
                Console.WriteLine($"The sum of digits is {a}");
            }
            else
            {
                Console.WriteLine("The number consists of two digits");
                Console.WriteLine($"The sum of digits is {(a / 10) + (a % 10)}");
            }
        }
    }
}
