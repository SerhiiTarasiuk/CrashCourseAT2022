using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task204
{
    class Program
    {
        //Напишіть програму, яка обчислює квадрат будь-якого, введеного числа.
        static void Main(string[] args)
        {
            float a;
            Console.WriteLine("Enter a: ");
            a = Convert.ToSingle(Console.ReadLine());
            a = a * a;
            Console.WriteLine($"a^2 = {a}");
        }
    }
}
