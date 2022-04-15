using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишіть програму, яка обчислює середнє арифметичне двох чисел.

            Console.WriteLine("Please, enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2) / 2;

            Console.WriteLine(average);
        }
    }
}
