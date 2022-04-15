using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишіть програму, яка переводить гривні в $, Є.

            Console.WriteLine("Please, enter quantity of hryvnyas to convert: ");

            double hrn = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("In $ = " + hrn * 29.34);
            Console.WriteLine("In Є = " + hrn * 31.78);
        }
    }
}
