using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task214
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, m;
            Console.Write("Enter a number: ");
            num = Int32.Parse(Console.ReadLine());
            while (num > 0)
            {
                m = num % 10;
                sum = sum + m;
                num = num / 10;
            }
            Console.WriteLine("Sum is = " + sum);
        }
    }
}
 