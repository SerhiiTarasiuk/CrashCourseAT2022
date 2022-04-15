/*
212.
Користувач вводить з клавіатури число - програма повинна показати скільки в даному числі цифр. Число вводиться повністю в одну змінну.
Примітка: Наприклад, користувач ввів число 11123445555. На екрані має з'явитися повідомлення про те, що в числі 5 цифр.
*/
using System;

namespace Task_212
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            string number = Console.ReadLine();
            
            int counter = 1;
            bool unique;

            for (int i = 1; i < number.Length; i++)
            {
                unique = true;
                for (int j = i-1; j >= 0; j--)
                {
                    if (number[j] == number[i])
                    {
                        unique = false;
                    }
                   
                }
                if (unique)
                {
                    counter++;
                }

            }        
                             
            
            // Console.WriteLine($"Total digits: {number.Length}");
            Console.WriteLine($"Unique digits: {counter}");
        }
    }
}
