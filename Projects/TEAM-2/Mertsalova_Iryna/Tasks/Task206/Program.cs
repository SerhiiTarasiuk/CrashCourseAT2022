using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task206
{
    class Program
    {
        //Напишіть програму, яка перевіряє число, введене з клавіатури на парність
        static void Main(string[] args)
        {
            int number = 0;
            Console.Write("Enter any number: ");
            number = Int32.Parse(Console.ReadLine());
            Console.WriteLine((number % 2 == 0) ? " This digit is pair." : " This digit is no pair.");
        }
    }
}
