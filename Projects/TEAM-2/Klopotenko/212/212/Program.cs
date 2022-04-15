/* 212. Користувач вводить з клавіатури число - програма повинна  показати скільки в даному числі цифр. 
Число вводиться повністю в одну змінну.
Примітка:
Наприклад, користувач ввів число 11123445555. На екрані має з'явитися повідомлення про те, що в числі 5 цифр. */


using System;

namespace _212
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            long a = Convert.ToInt64(Console.ReadLine());
            int numbers = 0;
            for(int i = 0; i <= 9; i++)
            {
                bool b = a.ToString().Contains(i.ToString());
                if (b)
                {
                    numbers++;
                }
            }
            Console.WriteLine($"The number {a} contains {numbers} digits");
        }
    }
}
