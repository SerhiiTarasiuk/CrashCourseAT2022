using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task202
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишіть програму, яка переводить гривні в $, Є.
            float sum, dol, euro;
            Console.WriteLine("Enter amount of hryvnia: ");
            sum = Convert.ToSingle(Console.ReadLine());
            dol = sum * 29.39f;
            euro = sum * 32f;
            Console.WriteLine($"Dollar: {dol}; euro: {euro}");
        }
    }
}
