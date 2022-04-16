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
                        
            string inner_string = "";
            inner_string = $"*{inner_string.PadRight(length-2)}*";

            
            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            
            for (int i = 0; i < height-2; i++)
            {
                Console.WriteLine(inner_string);
            }
                        

            for (int i = 0; i < length; i++) // works correct only if length >= 2
            {
                Console.Write("*");
            }
            
        }
    }
}
