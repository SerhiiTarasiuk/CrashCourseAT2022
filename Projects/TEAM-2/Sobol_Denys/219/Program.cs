using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Enter the numbers: ");

            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int minNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]<minNumber && numbers[i]%2!=0)
                {
                    minNumber = numbers[i];
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
