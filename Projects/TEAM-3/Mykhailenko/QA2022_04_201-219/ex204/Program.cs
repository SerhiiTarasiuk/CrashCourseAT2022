/*
Перший консольний додаток, типи даних, константи та змінні, методи, введення/вивід даних, літерали
 
4. Напишіть програму, яка обчислює квадрат будь-якого, введеного числа.
*/
using System;

namespace ex204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Квадрат числа якого Ви ввели дорівнює {0}", Math.Pow(a, 2));
            Console.ReadKey();
        }
    }
}
