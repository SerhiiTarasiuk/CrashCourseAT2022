/*
Перший консольний додаток, типи даних, константи та змінні, методи, введення/вивід даних, літерали
 
5. Введіть три числа і виведіть на екран значення суми і добуток цих чисел.
*/

using System;

namespace ex205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3;
            Console.Write("Введіть перше число ");
            x1 = Double.Parse(Console.ReadLine());
            Console.Write("Введіть друге число ");
            x2 = Double.Parse(Console.ReadLine());
            Console.Write("Введіть трете число ");
            x3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Сума ціх трьох чисел дорівнює {0}", x1 + x2 + x3);
            Console.WriteLine("Добуток ціх трьох чисел дорівнює {0}", x1 * x2 * x3);
            Console.ReadKey();
        }
    }
}
