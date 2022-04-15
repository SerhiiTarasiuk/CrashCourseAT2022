/*
Арифметичні операції, приведення типів, логічні операції, оператори if, else, switch

2. Дано натуральне число а (a <100). Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр
*/


using System;

namespace ex207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a0, a1;
            Console.Write("Введіть натуральне число менше 100 ");
            int x = int.Parse(Console.ReadLine());
            a0 = x % 10;
            a1 = (x - a0) / 10;
            if (a1 == 0) Console.Write("Кількість цифр якіВи ввели - одна цифра, ");
            else Console.Write("Кількість цифр які Ви ввели - дві цифри, ");
            Console.Write("сума цифр дорівнює {0}", a1 + a0);
            Console.ReadKey();

        }
    }
}
