using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Напишіть програму, яка перевіряє число, введене з клавіатури на парність.
namespace _206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number ");

            double num = Convert.ToDouble(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Number is not even");
            }
        }
    }
}
