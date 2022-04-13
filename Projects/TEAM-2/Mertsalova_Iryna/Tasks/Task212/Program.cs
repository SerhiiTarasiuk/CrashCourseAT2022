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
            int num = 0, res = 0;
            var list = new List<int>();
            Console.WriteLine(" Enter a number : ");
            do
            {
                res = num % 10;
                list.Add(res);
                num /= 10;
            } while (num != 0);

            var unique = list.Distinct();
            var length = unique.Count();
            foreach (var i in unique)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"В числe {length} цифр");
        }
    }
}
