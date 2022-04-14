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
            float a, b, c, sum, dob;
            Console.WriteLine("Enter a: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            c = Convert.ToSingle(Console.ReadLine());
            sum = a + b + c;
            dob = a * b * c;
            Console.WriteLine($"Sum = {sum}; dob = {dob}");
        }
    }
}
