using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number below 100 : ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b < 100)
            {
                int digitCount = (int)Math.Log10(b) + 1;
                Console.WriteLine(digitCount);
            }
            else
            {
                Console.WriteLine("Worth number");
            }
        }
    }
}
