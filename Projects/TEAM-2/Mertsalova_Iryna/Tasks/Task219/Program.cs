using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task219
{
    class Program
    {
        //Написати програму, яка знаходить в масиві найменше непарне число
        //і показує його на екран.
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            List<int> nopair_arr = new List<int>();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("  Enter array[" + i + "] : ");
                arr[i] = Int32.Parse(Console.ReadLine());
                if (arr[i] % 2 != 0)
                {
                    nopair_arr.Add(arr[i]);
                    count++;
                }
            }
            printArr(arr);
            Console.WriteLine("  No pair elements: ");
            foreach (var item in nopair_arr)
            {
                Console.Write("    " + item);
            }
            int min_elem = nopair_arr[0];
            for (int i = 0; i < nopair_arr.Count; i++)
            {
                if (nopair_arr[i] < min_elem)
                {
                    min_elem = nopair_arr[i];
                }
            }
            Console.WriteLine("\n\n  Min elem --> " + min_elem + "\n");

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
