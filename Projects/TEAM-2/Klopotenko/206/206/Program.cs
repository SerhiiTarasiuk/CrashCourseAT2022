using System;

namespace _206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value: ");
            double a = Convert.ToDouble(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine("The value is even");
            }
            else
            {
                Console.WriteLine("The value is non-even");
            }
        }
    }
}
