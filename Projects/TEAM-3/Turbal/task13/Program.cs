using System;
using System.Collections.Generic;

//7. Написати програму, яка виводить на екран - наступну фігуру:
//"*********************                                                                                                                                                                                                        
// *                   *
// *                   *
// *                   *
// *                   *
// *********************
//ширина і висота фігури встановлюються користувачем з клавіатури.

namespace Lesson1
{
    class Syntax
    {
        public static void Main(string[] args)
        {
            int w = 0, h = 0;

            Console.WriteLine("Please, enter width: ");
            Console.Beep();  

            try
            {
                w = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Please, enter height: ");
                Console.Beep();
                try
                {
                    h = Convert.ToInt16(Console.ReadLine());
                    string s1 = "", s2 = "";
                    
                    for (int i = 0; i < w; i++) s1 += '*';
                    s2 = "*";
                    for (int i = 0; i < w-2; i++) s2 += ' ';
                    s2 += '*';



                    Console.WriteLine(s1);
                    for (int i = 0; i < h - 2; i++)
                    {
                        Console.WriteLine(s2);
                    }
                    Console.WriteLine(s1);
                }
                catch
                {
                    Console.WriteLine("You have entered not a number!");
                }
            }
            catch
            { 
                Console.WriteLine("You have entered not a number!"); 
            }

        }

        

    }
}
