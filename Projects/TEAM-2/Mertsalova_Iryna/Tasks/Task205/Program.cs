using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task205
{
    class Program
    {
        //Введіть три числа і виведіть на екран значення суми і добуток цих чисел.
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0;
            Console.Write(" Enter the first digit: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write(" Enter the second digit: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.Write(" Enter the third digit: ");
            num3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n Sum of these digits --> " + (num1 + num2 + num3) +
                "\n Mult of these digits --> " + (num1 * num2 * num3));
        }
    }
}
