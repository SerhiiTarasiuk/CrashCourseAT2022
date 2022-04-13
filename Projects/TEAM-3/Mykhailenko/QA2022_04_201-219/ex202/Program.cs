/*
Перший консольний додаток, типи даних,  константи та змінні, методи, введення/вивід даних, літерали

2. Напишіть програму, яка переводить гривні в $, Є.
*/

/*
Перший консольний додаток, типи даних, константи та змінні, методи, введення/вивід даних, літерали

2. Напишіть програму, яка переводить гривні в $, Є. 
*/


using System;

namespace ex202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double kurs_grn_in_usd = 29.25;
            const double kurs_grn_in_gbp = 38.42;
            double exch;

            Console.WriteLine("Виберіть на яку валюту грн хочете поміняти?\n1 - usd (курс {0} грн за usd);\n2 - gbp  (курс {1} грн за gbp);", kurs_grn_in_usd, kurs_grn_in_gbp);
            int your_choice = int.Parse(Console.ReadLine());
            if (your_choice == 1)
            {
                Console.Write("Введіть скільки валюти Ви хочете придбати ");
                exch = Double.Parse(Console.ReadLine());
                Console.WriteLine("З Вас {0} грн", Math.Abs(exch) * kurs_grn_in_usd);
            }
            else if (your_choice == 2)
            {
                Console.Write("Введіть скільки валюти Ви хочете придбати ");
                exch = Double.Parse(Console.ReadLine());
                Console.WriteLine("З Вас {0} грн", Math.Abs(exch) * kurs_grn_in_gbp);
            }
            else Console.WriteLine("Помилка вибору напрямку оббміну валюти");
            Console.ReadKey();
        }
    }
}
