/*
Арифметичні операції, приведення типів, логічні операції, оператори if, else, switch

Напишіть програму, яка перевіряє число, введене з клавіатури на парність.
*/


using System;

namespace ex206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ціле число ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("Число яке Ви ввели {0} парне", a);
            else Console.WriteLine("Число яке Ви ввели {0} непарне", a);
            Console.ReadKey();
        }
    }
}
