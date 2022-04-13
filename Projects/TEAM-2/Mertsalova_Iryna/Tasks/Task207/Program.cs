using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task207
{
    class Program
    {
        //Дано натуральне число а(a<100). Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр
        static void Main(string[] args)
        {
            int digit;
            Console.Write(" Enter any digit ( < 100 ): ");
            digit = Int32.Parse(Console.ReadLine());
            if (digit < 100)
            {
                if (digit > 9)
                {
                    Console.WriteLine(" Two number");
                    Console.WriteLine(" Sum: " + digit / 10 + " + " + digit % 10 + " = "
                        + ((digit / 10) + (digit % 10)) + "\n");
                }
                else
                {
                    Console.WriteLine(" One number");
                    Console.WriteLine(" Sum = " + digit + "\n");
                }
            }
        }
    }
}
