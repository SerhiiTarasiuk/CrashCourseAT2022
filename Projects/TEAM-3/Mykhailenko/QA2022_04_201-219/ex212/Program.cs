/*
Циклічність. Оператори While, do while. Цикл for, ключові слова break & continue

4. Користувач вводить з клавіатури число - програма повинна показати скільки в даному числі цифр. Число вводиться повністю в одну змінну.
Примітка: Наприклад, користувач ввів число 11123445555. На екрані має з'явитися повідомлення про те, що в числі 5 цифр.
*/

using System;

namespace ex212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit, result, a0 = 0, a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0;
            Console.Write("Введіть число ");
            decimal x = decimal.Parse(Console.ReadLine());
            decimal tmp = x;
            while (tmp > 0)
            {
                digit = Convert.ToInt32(tmp % 10);
                switch (digit)
                {
                    case 0: a0 = 1; break;
                    case 1: a1 = 1; break;
                    case 2: a2 = 1; break;
                    case 3: a3 = 1; break;
                    case 4: a4 = 1; break;
                    case 5: a5 = 1; break;
                    case 6: a6 = 1; break;
                    case 7: a7 = 1; break;
                    case 8: a8 = 1; break;
                    case 9: a9 = 1; break;
                    default: break;
                }
                tmp = Math.Floor(tmp / 10);
            }
            result = a0 + a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9;
            Console.WriteLine("У введеному Вами числі {0} використовується {1} неповторних цифр", x, result);
            Console.ReadKey();
        }
    }
}
