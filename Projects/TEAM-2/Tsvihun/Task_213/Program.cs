/*
213.
Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.
Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися число навпаки - 54321.
*/

using System;

namespace Task_213
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            string number = Console.ReadLine();
            
            for (int i = number.Length-1; i >= 0; i--)
            {
                Console.Write($"{number[i]} ");                
            }
        }
    }
}
