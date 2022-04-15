/*
Масиви даних
1. Написати програму, яка виводить вміст масиву навпаки.
Приклад: масив 23 11 6 перетворюється в 6 23 11.
*/

using System;

namespace ex216
{
    internal class Program
    {
        static void variant1(int[] a)
        {
            for (int i = a.Length - 1; i >= 0; i--) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        static void variant2(int[] a)
        {
            Array.Reverse(a);
            for (int i = 0; i < a.Length; i++) Console.Write("{0} ", a[i]);
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 21, 14, 10, 27, 45, 80 };
            Console.WriteLine("Первий варіант виконання завдання - for (int i = a.Length-1; i >=0 ; i--) {}");
            variant1(a);
            Console.WriteLine("Другий варіант виконання завдання - Array.Reverse()");
            variant2(a);
            Console.ReadKey();
        }
    }
}
