/* 215. Написати програму, яка виводить на екран - наступну фігуру:
"*********************                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*********************                                                                                                                                                                                                        
ширина і висота фігури встановлюються користувачем з клавіатури. */


using System;
using System.Linq;

namespace _215
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());
            string empty = " ";
            for(int i = 1; i <= length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat(empty, length))); // multiplication of strings, using System.Linq;
            for (int i = 1; i <= width; i++)
            {
                Console.Write("*");
                Console.Write(string.Concat(Enumerable.Repeat(empty, length - 2)));
                Console.WriteLine("*");
                Console.WriteLine(string.Concat(Enumerable.Repeat(empty, length)));
            }
            for (int i = 1; i <= length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
