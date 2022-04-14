using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double data1 = Convert.ToDouble(Console.ReadLine());

            double data2 = Convert.ToDouble(Console.ReadLine());

            double result = (data1 + data2) / 2;
            Console.WriteLine(result);
        }
    }
}
