/*
Робота з масивами. Сортування масивів.

Дано масив випадкових чисел в діапазоні від -20 до +20. Необхідно знайти позиції крайніх негативних елементів (самого лівого негативного елементу і
самого правого негативного елементу) і впорядкувати елементи, що знаходяться між ними.
*/

using System;

namespace ex224
{
    internal class Program
    {
        static void init_array(ref int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 40) - 20;
            }
        }

        static void print_array(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static void sort_array(ref int[] a)
        {
            int left_index = -1, right_index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] < 0) && (left_index == -1)) left_index = i;
                if (a[i] < 0) right_index = i;
            }
            //сортування
            int tmp;
            for (int i = left_index; i < right_index; i++)
                for (int j = i + 1; j <= right_index; j++)
                {
                    if (a[i] > a[j])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
        }
        static void Main(string[] args)
        {
            int[] ar = new int[40];
            init_array(ref ar);
            Console.WriteLine("Масив до сортування");
            print_array(ar);
            sort_array(ref ar);
            Console.WriteLine("Масив після сортування");
            print_array(ar);
            Console.ReadKey();
        }
    }
}
