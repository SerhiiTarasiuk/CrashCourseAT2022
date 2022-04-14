using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = Convert.ToDouble(Console.ReadLine());
            double pow = Math.Pow(num, 2);
            Console.WriteLine(pow);
        }
    }
}
