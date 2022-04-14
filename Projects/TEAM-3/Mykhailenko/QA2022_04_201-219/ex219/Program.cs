/*
Масиви даних
4. Написати програму, яка знаходить в масиві найменше непарне число і показує його на екран.
*/


using System;

namespace ex219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = '\0';
            int[] arr = new int[10];

            Console.WriteLine("Введіть десять числових елементів масиву");
            for (int i = 0; i < arr.Length; i++) { arr[i] = int.Parse(Console.ReadLine()); }

            Console.WriteLine("Ви ввели такі значення");
            for (int i = 0; i < arr.Length; i++) { Console.Write(arr[i] + " "); }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (x == '\0') x = arr[i];
                    if (x > arr[i]) x = arr[i];
                }
            }
            if (x == '\0') Console.WriteLine("Непарних елементів масиву не знайдено");
            else Console.WriteLine("Найменший непарний елемент масиву {0}", x);
            Console.ReadKey();
        }
    }
}
