using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Напишіть програму, яка переводить гривні в $, Є.
namespace _202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number of hryvnias for conversion in $ and Є : ");
           
            double a = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("In $ = " + a * 31.50);
            Console.WriteLine("In Є = " + a * 33.45);


        }
    }
}
