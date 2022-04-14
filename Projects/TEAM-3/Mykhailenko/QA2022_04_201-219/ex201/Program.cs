/*
Перший консольний додаток, типи даних,  константи та змінні, методи, введення/вивід даних, літерали

1. Напишіть програму, яка обчислює середнє арифметичне двох чисел.
*/
using System;

namespace ex201
{
    internal class Program
    {
        static double avg_2(double x, double y) { return (x + y) / 2; }
        static void Main(string[] args)
        {
            Console.Write("Введіть перше число ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Введіть друге число ");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Середне арифметичне двох введених чисел дорівнює {0}", avg_2(a, b));
            Console.ReadKey();
        }
    }
}
