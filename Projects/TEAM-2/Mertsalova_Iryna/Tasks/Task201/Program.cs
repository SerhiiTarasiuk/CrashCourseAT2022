using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task201
{
    class Program
    {
        // Напишіть програму, яка обчислює середнє арифметичне двох чисел.
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            Console.Write("Enter the first number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Avarage --> " + (num1 + num2) / 2);
        }
    }
}
