using System;
using System.Collections.Generic;

//6. Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.
//Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися повідомлення про те, що сума цифр числа 15.

namespace Lesson1
{
    class Syntax
    {
        public static void Main(string[] args)
        {
            int n = 0, sum = 0;

            Console.WriteLine("Please, enter your number ");
            Console.Beep();

            sum = 0;

            try
            {
                n = Convert.ToInt16(Console.ReadLine());
                while (n>0)
                {
                    sum += n % 10;
                    n /= 10;
                }

                Console.WriteLine($"The sum of digests of your number is {sum}");
            }
            catch
            { Console.WriteLine("You have entered not a number!"); }

        }

        

    }
}
