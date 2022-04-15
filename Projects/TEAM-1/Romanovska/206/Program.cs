using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишіть програму, яка перевіряє число, введене з клавіатури на парність.

            Console.WriteLine("Please enter a number to check if it's equal: ");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is equal");
            }
            else
            {
                Console.WriteLine("The number isn't equal");
            }
        }
    }
}
