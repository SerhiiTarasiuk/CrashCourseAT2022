using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] list = new int[n];
            Console.WriteLine("Enter the numbers: ");
            for (int i = 0; i < n; i++)
            {
                list[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Array.Reverse(list);
            Console.Write("Reversed Array: ");
            foreach (int i in list)
            {
                Console.Write(i + " \n");
            }
        }
    }
}
