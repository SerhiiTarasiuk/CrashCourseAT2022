/*
215
* Написати програму, яка виводить на екран - наступну фігуру:
"*********************                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*                           *                                                                                                                                                                                                        
*********************                                                                                                                                                                                                        
ширина і висота фігури встановлюються користувачем з клавіатури.
*/

using System;

namespace Task_215
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length:");
            byte length = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            byte height = Convert.ToByte(Console.ReadLine());

            //Console.WriteLine($"Length = {length}\nHeight = {height}");
        }
    }
}
