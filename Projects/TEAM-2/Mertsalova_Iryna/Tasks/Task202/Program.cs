using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task202
{
    class Program
    {
        // Напишіть програму, яка переводить гривні в $, Є.
        static void Main(string[] args)
        {
            float grn = 0;
            Console.Write("Enter the count of money: ");
            grn = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n You enter " + grn + " UAN \n USD (29.66) --> " +
               + (float)Math.Round(grn / 29.66, 2) + "\n EUR (32.12) --> " +
               + (float)Math.Round(grn / 32.12, 2) + "\n");
        }
    }
}