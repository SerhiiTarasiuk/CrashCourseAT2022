using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task218
{
    class Program
    {
        //Написати програму, яка знаходить в масиві значення,
        //що повторюються два і більше разів, і показує їх на екран
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("  Enter array[" + i + "] : ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            printArr(arr);
            printRepeating(arr);
            Console.WriteLine();
        }
        static void printRepeating(int[] arr)
        {
            Console.Write("  Repeated Elements are : ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i] + "  ");
                    }
                }
            }
        }
        private static void printArr(int[] arr)
        {
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write("   " + item);
            }
            Console.WriteLine("\n");
        }
    }
}
