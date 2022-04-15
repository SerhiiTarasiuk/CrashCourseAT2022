using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введіть три числа і виведіть на екран значення суми і добуток цих чисел.

            Console.WriteLine("Please, enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter the third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The sum of the numbers is: "+(num1+num2+num3));
            Console.WriteLine("The result of multiplication of the numbers is: "+(num1*num2*num3));
        }
    }
}
