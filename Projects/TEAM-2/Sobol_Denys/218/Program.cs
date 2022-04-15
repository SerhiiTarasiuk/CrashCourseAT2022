using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Написати програму, яка знаходить в масиві значення, що повторюються два і більше разів, і показує їх на екран.
namespace _218
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] list = new int[n];
            var newList = new List<int>();
            Console.WriteLine("Enter the numbers: ");

            for (int i = 0; i < n; i++)
            {
                list[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (list[i] == list[j])
                    {
                       newList.Add(list[j]);

                    }
                }
            }

            var unique = newList.Distinct();
            foreach (var i in unique)
            {
                Console.WriteLine(i);
            }
        }
    }
}
