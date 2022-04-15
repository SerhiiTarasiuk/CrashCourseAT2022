using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишіть програму, яка обчислює квадрат будь - якого, введеного числа.

            Console.WriteLine("Please enter a number: ");

            double num = Convert.ToDouble(Console.ReadLine());

            double sqr = Math.Pow(num, 2);

            Console.WriteLine("Square of {0} is: {1}", num, sqr);

        }
    }
}
