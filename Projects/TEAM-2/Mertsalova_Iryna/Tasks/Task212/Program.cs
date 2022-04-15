using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task212
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, res = 0, numTest = 0; ;
            var list = new List<int>();
            Console.Write(" Enter any number : ");
            num = Int32.Parse(Console.ReadLine());
            numTest = num;
            do
            {
                res = numTest % 10;
                list.Add(res);
                numTest /= 10;
            } while (numTest != 0);

            var uniqueDigit = list.Distinct();
            Console.WriteLine();
            foreach (var i in uniqueDigit)
            {
                Console.Write("   " + i);
            }
            int length = uniqueDigit.Count();
            Console.WriteLine("\n In number " + num + " --> " + length + " digits");
        }
    }
}
