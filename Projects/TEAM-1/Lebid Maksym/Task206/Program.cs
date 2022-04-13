using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task206
{
    class Program
    {
        //Напишіть програму, яка перевіряє число, введене з клавіатури на парність.
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("A is even");
            }
            else
            {
                Console.WriteLine("A isn`t even");
            }
        }
    }
}
