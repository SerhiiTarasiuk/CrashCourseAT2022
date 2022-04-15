using System;
using System.Collections.Generic;

//5. Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.
//Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися число навпаки - 54321.

namespace Lesson1
{
    class Syntax
    {
        public static void Main(string[] args)
        {
            string s = "";

            Console.WriteLine("Please, enter your number ");
            Console.Beep();
            s = Console.ReadLine();

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string s2 = new string(charArray);
            try
            {
                int n = Convert.ToInt32(s2);
                Console.WriteLine($"Revert number - {n}");
            }
            catch
            {
                Console.WriteLine($"You have entered not a number! But we can also revert that string: {s2}");
            }


        }

        

    }
}
