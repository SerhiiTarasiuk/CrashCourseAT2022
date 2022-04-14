using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task201
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишіть програму, яка обчислює середнє арифметичне двох чисел.
            float a, b;
            Console.WriteLine("Enter a: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = Convert.ToSingle(Console.ReadLine());
            float s = (a + b) / 2;
            Console.WriteLine($"Mean: {s}");
        }
    }
}
