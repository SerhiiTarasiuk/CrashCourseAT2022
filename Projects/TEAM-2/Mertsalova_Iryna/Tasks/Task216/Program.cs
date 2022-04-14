using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task216
{
    class Program
    {
        //Написати програму, яка виводить вміст масиву навпаки.
        //Приклад: масив 23 11 6 перетворюється в 6 11 23
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("  Enter array[" + i + "] : ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n  Before reverse: ");
            printArr(arr);
            Console.WriteLine("  After reverse: ");
            Array.Reverse(arr);
            printArr(arr);
        }

        private static void printArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("   " + item);
            }
            Console.WriteLine("\n");
        }
    }
}
