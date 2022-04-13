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
            int a, k = 1, b;
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < 100; i += 10)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(a == i + j)
                    {
                        b = i / 10 + j;
                        Console.WriteLine($"Numbers: {k}; sum of numbers: {b}");
                    }
                }
                k = 2;
            }
        }
    }
}
