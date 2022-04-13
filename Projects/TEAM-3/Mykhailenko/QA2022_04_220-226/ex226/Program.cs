/*
Робота з масивами. Сортування масивів.

Написати функцію, яка сортує масив  розмірністю 10 елементів за зростанням або за спаданням, в залежності від третього параметра функції. Якщо він дорівнює 1,
сортування йде за спаданням, якщо 0, то по зростанню. Перші 2 параметра функції - це масив і його розмір, третій параметр за замовчуванням дорівнює 1.
*/

using System;

namespace ex226
{
    internal class Program
    {

        static void init_array(ref int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 40);
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
        static void sort_array(ref int[] a, int len, int way = 1)
        {
            //сортування
            int tmp;
            for (int i = 0; i < len - 1; i++)
                for (int j = i + 1; j < len; j++)
                {
                    if (way == 1)
                    {
                        if (a[i] > a[j])
                        {
                            tmp = a[i];
                            a[i] = a[j];
                            a[j] = tmp;
                        }
                    }
                    else if (way == 0)
                    {
                        if (a[i] < a[j])
                        {
                            tmp = a[i];
                            a[i] = a[j];
                            a[j] = tmp;
                        }
                    }
                }
        }

        static void Main(string[] args)
        {
            int[] ar = new int[10];
            init_array(ref ar);
            Console.WriteLine("Масив до сортування");
            print_array(ar);
            sort_array(ref ar, 10);
            Console.WriteLine("Масив після сортування по зростанню");
            print_array(ar);
            sort_array(ref ar, 10, 0);
            Console.WriteLine("Масив після сортування за зменшенням");
            print_array(ar);
            Console.ReadKey();
        }
    }
}
