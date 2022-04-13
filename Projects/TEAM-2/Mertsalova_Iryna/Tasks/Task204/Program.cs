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
            float digit = 0;
            Console.Write(" Enter any digit: ");
            digit = float.Parse(Console.ReadLine());
            Console.WriteLine("\n Your digit --> " + digit + "\n Square your digit --> " + Math.Pow(digit, 2));              
        }
    }
}
